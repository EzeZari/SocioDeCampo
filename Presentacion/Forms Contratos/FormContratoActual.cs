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
        public event Action ContratoEliminado;

        public FormContratoActual(string idJugador, string nombre, string apellido, string monto, string fechaInicio, string fechaFin, string clausula, string salario, string bonificacion, string obligacion)
        {
            InitializeComponent();

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
            FormContratoAdd formContratoAdd = new FormContratoAdd(lblIdJugador.Text);
            formContratoAdd.ContratoAgregado += () => this.Close();
            formContratoAdd.Show();
        }

        private void CargarUltimoContrato(string idJugador)
        {
            DataTable contrato = userModel.ObtenerUltimoContrato(idJugador);

            if (contrato.Rows.Count > 0)
            {
                DataRow row = contrato.Rows[0];

                lblMonto.Text = FormatearEnDolares(row["Monto"].ToString());
                lblSalario.Text = FormatearEnDolares(row["Salario"].ToString());
                lblClausula.Text = FormatearEnDolares(row["Clausula"].ToString());
                lblFechaInicio.Text = Convert.ToDateTime(row["FechaInicio"]).ToShortDateString();
                lblFechaFin.Text = Convert.ToDateTime(row["FechaFin"]).ToShortDateString();
                lblBonificacion.Text = row["Bonificacion"].ToString();
                lblObligacion.Text = row["Obligacion"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró un contrato previo para este jugador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string FormatearEnDolares(string valor)
        {
            if (decimal.TryParse(valor, out decimal valorDecimal))
            {
                return valorDecimal.ToString("C0", new System.Globalization.CultureInfo("en-US"));
            }
            else
            {
                return "Formato inválido";
            }
        }
        private void btnEliminarContrato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar el último contrato?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    userModel.EliminarUltimoContrato(Convert.ToInt32(lblIdJugador.Text));
                    MessageBox.Show("Último contrato eliminado correctamente.");

                    ContratoEliminado?.Invoke(); // Dispara el evento para actualizar el DataGridView
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el contrato: " + ex.Message);
            }
        }
    }
}
