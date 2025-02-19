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
                // Usar el ID del jugador ya almacenado
                int idJugadorInt = Convert.ToInt32(idJugador);

                // Mantener las fechas en DateTime
                DateTime fechaInicio = dtFechaInicio.Value;
                DateTime fechaFin = dtFechaFinal.Value;

                decimal monto = Convert.ToDecimal(txtMonto.Text);
                string clausula = txtClausula.Text;

                // Pasamos los valores correctamente
                userModel.AgregarContrato(idJugadorInt, fechaInicio, fechaFin, monto, clausula);

                MessageBox.Show("Contrato agregado correctamente.");
                CargarContratos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarContratos()
        {
            // dgvContratos.DataSource = userModel.ObtenerContratos();
        }
    }
}
