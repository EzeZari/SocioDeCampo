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

namespace Presentacion
{
    public partial class FormJugadores : Form
    {
        UserModel objeto = new UserModel();
        private string idJugador = null; //Creamos una variable para almacenar d manera nula.
        private bool Editar = false;
        public FormJugadores()
        {
            InitializeComponent();
        }

        private void FormJugadores_Load(object sender, EventArgs e)
        {
            MostrarJugadores();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void MostrarJugadores()
        {
            UserModel objetoCD = new UserModel();
            dataGridView1.DataSource = objetoCD.MostrarJugadores();
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
                // Obtener los datos de la fila seleccionada en el DataGridView
                string nombre = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                string fechaNacimiento = dataGridView1.CurrentRow.Cells["Birthdate"].Value.ToString();
                string nacionalidad = dataGridView1.CurrentRow.Cells["Nationality"].Value.ToString();
                string posicion = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();

                // Crear una instancia del formulario FormJugadoresEdit
                var FormJugadoresEdit = new FormJugadoresEdit(nombre, apellido, fechaNacimiento, nacionalidad, posicion, idJugador);
                FormJugadoresEdit.FormClosed += (s, args) => {
                    MostrarJugadores(); // Llamar a MostrarJugadores() cuando se cierre el formulario de edición
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
                // Mostrar el mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este jugador?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                // Si el usuario selecciona "Sí", proceder con la eliminación
                if (result == DialogResult.Yes)
                {
                    idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                    objeto.EliminarJugador(idJugador);

                    // Mensaje de éxito con ícono de información
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
            // Muestra el botón solo si hay una fila seleccionada
            bool jugadorSeleccionado = dataGridView1.SelectedRows.Count > 0;
            gunaButton1.Visible = jugadorSeleccionado;
            btnVerContrato.Visible = jugadorSeleccionado;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                FormContratoAdd formContratoAdd = new FormContratoAdd(idJugador);
                formContratoAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un jugador antes de agregar un contrato.");
            }
        }

        //private void btnVerContrato_Click_1(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
        //        FormContratoActual formContratoActual = new FormContratoActual( );
        //        formContratoActual.ShowDialog(); // Cambié ShowDialog por Show
        //    }
        //    else
        //    {
        //        // Aquí no se muestra el mensaje
        //    }
        //}
        private void btnVerContrato_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                string nombre = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();

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

                    FormContratoActual formContratoActual = new FormContratoActual(idJugador, nombre, apellido, monto, fechaInicio, fechaFin, clausula ,salario, bonificacion,obligacion);
                    formContratoActual.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El jugador seleccionado no tiene un contrato registrado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un jugador antes de ver su contrato.");
            }
        }


    }
}
