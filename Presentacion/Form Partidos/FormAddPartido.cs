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

namespace Presentacion
{
    public partial class FormAddPartido : Form
    {
        public FormAddPartido()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dtpFecha.Value.Date;
                TimeSpan hora = dtpHora.Value.TimeOfDay;
                string ubicacion = txtUbicacion.Text.Trim();
                string equipoLocal = txtEquipoLocal.Text.Trim();
                string equipoVisitante = txtEquipoVisitante.Text.Trim();
                string observaciones = txtObservaciones.Text.Trim();

                if (string.IsNullOrWhiteSpace(equipoLocal) || string.IsNullOrWhiteSpace(equipoVisitante))
                {
                    MessageBox.Show("Debes ingresar ambos equipos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PartidoModel modelo = new PartidoModel();
                modelo.AgregarPartido(fecha, hora, ubicacion, equipoLocal, equipoVisitante, observaciones);

                MessageBox.Show("Partido guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el partido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

