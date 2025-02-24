using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain; // Importa UserModel

namespace Presentacion.Forms_Contratos
{
    public partial class FormContratoAdd : Form
    {
        private UserModel userModel = new UserModel(); // Instancia de UserModel
        private string idJugador; // Variable para almacenar el ID del jugador

        public FormContratoAdd(string idJugador)
        {
            InitializeComponent();
            this.idJugador = idJugador; // Almacena el ID recibido
            txtIdJugador.Text = idJugador; // Muestra el ID en el TextBox (opcional)
            CargarContratos();

        }

        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los datos antes de proceder
                if (!ValidarDatos())
                {
                    return; // Detener la ejecución si la validación falla
                }

                // Usar el ID del jugador ya almacenado
                int idJugadorInt = Convert.ToInt32(idJugador);

                // Mantener las fechas en DateTime
                DateTime fechaInicio = dtFechaInicio.Value;
                DateTime fechaFin = dtFechaFinal.Value;

                decimal monto = Convert.ToDecimal(txtMonto.Text);
                string clausula = txtClausula.Text;
                decimal salario = Convert.ToDecimal(txtSalario.Text);
                string bonificacion = txtBonificacion.Text;
                string obligacion = txtObligacion.Text;

                // Pasamos los valores correctamente
                userModel.AgregarContrato(idJugadorInt, fechaInicio, fechaFin, monto, clausula, salario, bonificacion, obligacion);

                MessageBox.Show("Contrato agregado correctamente.");
                CargarContratos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private bool ValidarDatos()
        {
            // Verificar si el monto es un número válido
            if (string.IsNullOrWhiteSpace(txtMonto.Text) || !decimal.TryParse(txtMonto.Text, out _))
            {
                MessageBox.Show("El campo 'Monto' debe ser un número válido.");
                txtMonto.Focus();
                return false;
            }

            // Verificar si el campo cláusula no está vacío
            if (string.IsNullOrWhiteSpace(txtClausula.Text))
            {
                MessageBox.Show("El campo 'Cláusula' no puede estar vacío.");
                txtClausula.Focus();
                return false;
            }

            // Validar que se haya seleccionado una fecha de inicio
            if (dtFechaInicio.Value == null || dtFechaInicio.Value == DateTime.MinValue)
            {
                MessageBox.Show("Debe seleccionar una fecha de inicio.");
                dtFechaInicio.Focus();
                return false;
            }

            // Validar que se haya seleccionado una fecha de fin
            if (dtFechaFinal.Value == null || dtFechaFinal.Value == DateTime.MinValue)
            {
                MessageBox.Show("Debe seleccionar una fecha de fin.");
                dtFechaFinal.Focus();
                return false;
            }

            // Verificar que la fecha de fin no sea anterior a la fecha de inicio
            if (dtFechaFinal.Value < dtFechaInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                dtFechaFinal.Focus();
                return false;
            }

            // Si todos los campos están completos y correctos, devolver verdadero
            return true;
        }

        private void CargarContratos()
        {
            // dgvContratos.DataSource = userModel.ObtenerContratos();
        }
    }
}
