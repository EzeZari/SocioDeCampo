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
                lblMonto.Text = row["Monto"].ToString();
                lblFechaInicio.Text = Convert.ToDateTime(row["FechaInicio"]).ToShortDateString();
                lblFechaFin.Text = Convert.ToDateTime(row["FechaFin"]).ToShortDateString();
                lblClausula.Text = row["Clausula"].ToString();
                lblSalario.Text = row["Salario"].ToString();
                lblBonificacion.Text = row["Bonificacion"].ToString();
                lblObligacion.Text = row["Obligacion"].ToString();
            }
            else
            {
                // En caso de que no haya contratos, puedes mostrar un mensaje o dejar los valores iniciales
                MessageBox.Show("No se encontró un contrato previo para este jugador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
