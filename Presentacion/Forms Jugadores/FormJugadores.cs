using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Presentacion.Forms_Contratos;
using Domain.Composite;
using Common.Cache;


namespace Presentacion
{
    public partial class FormJugadores : Form
    {
        UserModel objeto = new UserModel();
        private string idJugador = null; //Creamos una variable para almacenar d manera nula.
        private bool Editar = false;
        private Permiso permisosUsuario;

        public FormJugadores()
        {
            InitializeComponent();
        }

        private void FormJugadores_Load(object sender, EventArgs e)
        {
            permisosUsuario = FabricaPermisos.ObtenerPermisosPorCargo(UserCache.Position);

            MostrarJugadores();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            AplicarPermisos();

        }
        private void AplicarPermisos()
        {
            // Deshabilita los botones si NO tiene el permiso de Gestión de Partidos
            if (!permisosUsuario.TienePermiso("GestionUsuarios"))
            {
                btnAddContrato.Visible = false;
                btnVerContrato.Visible = false;
                btnAdd.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

            }
        }
        private void MostrarJugadores()
        {
            UserModel objetoCD = new UserModel();
            dataGridView1.DataSource = objetoCD.MostrarJugadores();

            dataGridView1.Columns["Salario (USD)"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["Salario (USD)"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");

            dataGridView1.Columns["Cláusula (USD)"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["Cláusula (USD)"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var FormJugadoresAdd = new FormJugadoresAdd();
            FormJugadoresAdd.FormClosed += (s, args) => {
                MostrarJugadores(); // Llamar a MostrarJugadores() cuando se cierre el formulario de edición
            };
            FormJugadoresAdd.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                string fechaNacimiento = dataGridView1.CurrentRow.Cells["Fecha de Nacimiento"].Value.ToString();
                string nacionalidad = dataGridView1.CurrentRow.Cells["Nacionalidad"].Value.ToString();
                string posicion = dataGridView1.CurrentRow.Cells["Posición"].Value.ToString();
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();

                // Crear una instancia del formulario FormJugadoresEdit
                var FormJugadoresEdit = new FormJugadoresEdit(nombre, apellido, fechaNacimiento, nacionalidad, posicion, idJugador);
                FormJugadoresEdit.FormClosed += (s, args) => {
                    MostrarJugadores();
                };
                FormJugadoresEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este jugador?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                    objeto.EliminarJugador(idJugador);

                    MessageBox.Show("Eliminado correctamente",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    MostrarJugadores();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool jugadorSeleccionado = dataGridView1.SelectedRows.Count > 0;

            // Solo mostrar los botones si hay un jugador seleccionado Y tiene permisos
            bool puedeGestionarContratos = jugadorSeleccionado && permisosUsuario.TienePermiso("GestionUsuarios");

            btnAddContrato.Visible = puedeGestionarContratos;
            btnVerContrato.Visible = puedeGestionarContratos;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();

                // Consultar si el jugador ya tiene un contrato
                DataTable contrato = objeto.ObtenerContratoPorJugador(idJugador);

                if (contrato.Rows.Count > 0)
                {
                    MessageBox.Show("Este jugador ya tiene un contrato registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    string monto = contrato.Rows[0]["Monto"].ToString();
                    string fechaInicio = contrato.Rows[0]["FechaInicio"].ToString();
                    string fechaFin = contrato.Rows[0]["FechaFin"].ToString();
                    string clausula = contrato.Rows[0]["Clausula"].ToString();
                    string salario = contrato.Rows[0]["Salario"].ToString();
                    string bonificacion = contrato.Rows[0]["Bonificacion"].ToString();
                    string obligacion = contrato.Rows[0]["Obligacion"].ToString();

                    FormContratoActual formContratoActual = new FormContratoActual(idJugador, nombre, apellido, monto, fechaInicio, fechaFin, clausula, salario, bonificacion, obligacion);
                    formContratoActual.ShowDialog();
                }
                else
                {
                    FormContratoAdd formContratoAdd = new FormContratoAdd(idJugador);
                    formContratoAdd.ContratoAgregado += () => MostrarJugadores(); // Suscripción al evento
                    formContratoAdd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un jugador antes de agregar un contrato.");
            }
        }
        private void btnVerContrato_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();

                // Llamamos a UserModel en lugar de acceder directamente a la BD
                DataTable contrato = objeto.ObtenerContratoPorJugador(idJugador);

                if (contrato.Rows.Count > 0)
                {
                    string monto = contrato.Rows[0]["Monto"].ToString();
                    string fechaInicio = contrato.Rows[0]["FechaInicio"].ToString();
                    string fechaFin = contrato.Rows[0]["FechaFin"].ToString();
                    string clausula = contrato.Rows[0]["Clausula"].ToString();
                    string salario = contrato.Rows[0]["Salario"].ToString();
                    string bonificacion = contrato.Rows[0]["Bonificacion"].ToString();
                    string obligacion = contrato.Rows[0]["Obligacion"].ToString();

                    FormContratoActual formContratoActual = new FormContratoActual(idJugador, nombre, apellido, monto, fechaInicio, fechaFin, clausula, salario, bonificacion, obligacion);

                    // Suscribirse al evento para actualizar la lista de jugadores cuando se elimine un contrato
                    formContratoActual.ContratoEliminado += MostrarJugadores;

                    formContratoActual.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El jugador seleccionado no tiene un contrato registrado.");
                }
            }
        }


        private void btnGenerarInforme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGenerarInforme formGenerarInforme = new FormGenerarInforme();
            formGenerarInforme.ShowDialog();
        }
    }
}
