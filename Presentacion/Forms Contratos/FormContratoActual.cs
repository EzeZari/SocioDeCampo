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

namespace Presentacion.Forms_Contratos
{
    public partial class FormContratoActual : Form
    {
        private UserModel userModel = new UserModel(); // Instancia de UserModel

        public FormContratoActual(string idJugador, string nombre, string apellido, string monto, string fechaInicio, string fechaFin, string clausula, string salario, string bonificacion, string obligacion)
        {
            InitializeComponent();

            // Asignar los valores a los controles antes de cargar el contrato
            lblIdJugador.Text = idJugador;
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblMonto.Text = monto;
            lblFechaInicio.Text = fechaInicio;
            lblFechaFin.Text = fechaFin;
            lblClausula.Text = clausula;
            lblSalario.Text = salario;
            lblBonificacion.Text = bonificacion;
            lblObligacion.Text = obligacion;

            // Llamar a la función después de asignar el ID del jugador
            CargarUltimoContrato(idJugador);
        }

        private void btnEntendido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenovarContrato_Click(object sender, EventArgs e)
        {
            // Crear y abrir el formulario de renovación con el idJugador
            FormContratoAdd formContratoAdd = new FormContratoAdd(lblIdJugador.Text);
            // Suscribirse al evento para cerrar este formulario cuando se agregue un contrato
            formContratoAdd.ContratoAgregado += () => this.Close();
            formContratoAdd.Show();
        }

        private void CargarUltimoContrato(string idJugador)
        {
            DataTable contrato = userModel.ObtenerUltimoContrato(idJugador);

            if (contrato.Rows.Count > 0)
            {
                DataRow row = contrato.Rows[0];

                // Formatear Monto, Salario y Clausula en dólares
                lblMonto.Text = FormatearEnDolares(row["Monto"].ToString());
                lblSalario.Text = FormatearEnDolares(row["Salario"].ToString());
                lblClausula.Text = FormatearEnDolares(row["Clausula"].ToString());

                // Asignar otros valores sin formato específico
                lblFechaInicio.Text = Convert.ToDateTime(row["FechaInicio"]).ToShortDateString();
                lblFechaFin.Text = Convert.ToDateTime(row["FechaFin"]).ToShortDateString();
                lblBonificacion.Text = row["Bonificacion"].ToString();
                lblObligacion.Text = row["Obligacion"].ToString();
            }
            else
            {
                // En caso de que no haya contratos, puedes mostrar un mensaje o dejar los valores iniciales
                MessageBox.Show("No se encontró un contrato previo para este jugador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método auxiliar para formatear en dólares
        private string FormatearEnDolares(string valor)
        {
            if (decimal.TryParse(valor, out decimal valorDecimal))
            {
                // Formatear como dólares (USD)
                return valorDecimal.ToString("C0", new System.Globalization.CultureInfo("en-US"));
            }
            else
            {
                return "Formato inválido";
            }
        }


        private void btnEliminarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar el último contrato?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    userModel.EliminarUltimoContrato(Convert.ToInt32(lblIdJugador.Text));
                    MessageBox.Show("Último contrato eliminado correctamente.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el contrato: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
