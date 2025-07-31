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
    public partial class FormEditarPartidoJugado : Form
    {
        private Partido partido; // 👈 Declaración de la variable

        public FormEditarPartidoJugado(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        private void FormEditarPartidoJugado_Load(object sender, EventArgs e)
        {
            lblLocal.Text = partido.EquipoLocal;
            lblVisitante.Text = partido.EquipoVisitante;
            txtResultadoLocal.Text = partido.ResultadoLocal.ToString();
            txtResultadoVisitante.Text = partido.ResultadoVisitante.ToString();
            txtObservaciones.Text = partido.Observaciones;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtResultadoLocal.Text, out int resLocal) ||
                !int.TryParse(txtResultadoVisitante.Text, out int resVisitante))
            {
                MessageBox.Show("Los resultados deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Estás seguro que querés modificar el resultado del partido?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes)
                return;

            partido.ResultadoLocal = resLocal;
            partido.ResultadoVisitante = resVisitante;
            partido.Observaciones = txtObservaciones.Text;

            try
            {
                PartidoModel model = new PartidoModel();
                model.ActualizarPartidoResultado(partido);

                MessageBox.Show("Partido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el partido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
