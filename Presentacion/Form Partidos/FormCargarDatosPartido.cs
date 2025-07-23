using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormCargarDatosPartido : Form
    {
        private Partido partido;

        public FormCargarDatosPartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los resultados sean números
            if (!int.TryParse(txtResultadoLocal.Text, out int resultadoLocal) ||
                !int.TryParse(txtResultadoVisitante.Text, out int resultadoVisitante))
            {
                MessageBox.Show("Los resultados deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            partido.ResultadoLocal = resultadoLocal;
            partido.ResultadoVisitante = resultadoVisitante;
            partido.Observaciones = txtObservaciones.Text;
            partido.PartidoJugado = true;

            try
            {
                PartidoModel model = new PartidoModel();
                model.ActualizarPartidoResultado(partido); // Este método debe hacer el UPDATE
                MessageBox.Show("Datos del partido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el partido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCargarDatosPartido_Load(object sender, EventArgs e)
        {
            lblLocal.Text = partido.EquipoLocal;
            lblVisitante.Text = partido.EquipoVisitante;
        }
    }
}

