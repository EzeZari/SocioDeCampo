using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using System.Data;

namespace Presentacion
{
    public partial class FormVerDetallePartido : Form
    {
        private Partido partido;

        public FormVerDetallePartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        private void FormVerDetallePartido_Load(object sender, EventArgs e)
        {
            lblFecha.Text = partido.Fecha.ToShortDateString();
            lblHora.Text = partido.Hora.ToString(@"hh\:mm");
            lblLocal.Text = partido.EquipoLocal;
            lblVisitante.Text = partido.EquipoVisitante;

            lblResultadoLocal.Text = partido.ResultadoLocal.ToString();
            lblResultadoVisitante.Text = partido.ResultadoVisitante.ToString();
            lblObservaciones.Text = partido.Observaciones;

            MostrarGoles();
            MostrarTarjetas();
        }

        private void MostrarGoles()
        {
            PartidoModel model = new PartidoModel();
            DataTable goles = model.ObtenerGolesPorPartido(partido.IdPartido);

            panelGoles.Controls.Clear();

            if (goles.Rows.Count == 0)
            {
                panelGoles.Controls.Add(new Label { Text = "Sin goles.", AutoSize = true });
                return;
            }

            int y = 0;
            foreach (DataRow row in goles.Select("", "Minuto ASC")) // 👈 ordena por minuto
            {
                string nombre = row["NombreJugador"].ToString();
                int minuto = Convert.ToInt32(row["Minuto"]);

                var label = new Label
                {
                    Text = $"• {nombre} ({minuto}')",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(0, y)
                };

                panelGoles.Controls.Add(label);
                y += 20;
            }
        }




        private void MostrarTarjetas()
        {
            PartidoModel model = new PartidoModel();
            DataTable tarjetas = model.ObtenerTarjetasPorPartido(partido.IdPartido);

            panelTarjetas.Controls.Clear();

            if (tarjetas.Rows.Count == 0)
            {
                panelTarjetas.Controls.Add(new Label { Text = "Sin tarjetas.", AutoSize = true });
                return;
            }

            int y = 0;
            foreach (DataRow row in tarjetas.Select("", "Minuto ASC")) // 👈 ordena por minuto
            {
                string nombre = row["NombreJugador"].ToString();
                string tipo = row["Tipo"].ToString();
                int minuto = Convert.ToInt32(row["Minuto"]);

                var label = new Label
                {
                    Text = $"• {nombre} - {tipo} ({minuto}')",
                    AutoSize = true,
                    ForeColor = tipo == "Roja" ? Color.Red : Color.DarkGoldenrod,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(0, y)
                };

                panelTarjetas.Controls.Add(label);
                y += 20;
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}