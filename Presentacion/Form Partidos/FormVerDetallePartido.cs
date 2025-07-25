using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using System.Data;
using System.Linq;


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

            // Agrupar por jugador
            var resumenPorJugador = new Dictionary<string, List<(string tipo, int minuto)>>();

            foreach (DataRow row in tarjetas.Rows)
            {
                string nombre = row["NombreJugador"].ToString();
                string tipo = row["Tipo"].ToString();
                int minuto = Convert.ToInt32(row["Minuto"]);

                if (!resumenPorJugador.ContainsKey(nombre))
                    resumenPorJugador[nombre] = new List<(string tipo, int minuto)>();

                resumenPorJugador[nombre].Add((tipo, minuto));
            }

            int y = 0;

            foreach (var jugador in resumenPorJugador)
            {
                string nombre = jugador.Key;
                var eventos = jugador.Value.OrderBy(e => e.minuto).ToList();

                int amarillas = eventos.Count(e => e.tipo == "Amarilla");
                int rojas = eventos.Count(e => e.tipo == "Roja");
                string texto;
                Color color;

                if (amarillas >= 2)
                {
                    var minutos = string.Join(", ", eventos.Where(e => e.tipo == "Amarilla").Select(e => $"{e.minuto}'"));
                    texto = $"• {nombre} - Doble Amarilla (min. {minutos})";
                    color = Color.Red;
                }
                else if (rojas >= 1)
                {
                    var minuto = eventos.First(e => e.tipo == "Roja").minuto;
                    texto = $"• {nombre} - Roja directa (min. {minuto}')";
                    color = Color.Red;
                }
                else if (amarillas == 1)
                {
                    var minuto = eventos.First(e => e.tipo == "Amarilla").minuto;
                    texto = $"• {nombre} - Amarilla (min. {minuto}')";
                    color = Color.DarkGoldenrod;
                }
                else
                {
                    continue;
                }

                var label = new Label
                {
                    Text = texto,
                    AutoSize = true,
                    ForeColor = color,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(0, y)
                };

                panelTarjetas.Controls.Add(label);
                y += 22;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}