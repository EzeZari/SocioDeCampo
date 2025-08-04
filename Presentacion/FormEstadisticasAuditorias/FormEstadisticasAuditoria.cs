using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Presentacion.FormEstadisticasAuditoria;

namespace Presentacion.FormEstadisticasAuditoria
{
    public partial class FormEstadisticasAuditoria : Form
    {
        public FormEstadisticasAuditoria()
        {
            InitializeComponent();
        }

        private void FormEstadisticasAuditoria_Load(object sender, EventArgs e)
        {
            CargarGraficoAcciones();
        }

        private void CargarGraficoAcciones()
        {
            chartAccionesAuditoria.Series.Clear();
            chartAccionesAuditoria.Titles.Clear();
            chartAccionesAuditoria.ChartAreas[0].AxisX.Title = "Acción";
            chartAccionesAuditoria.ChartAreas[0].AxisY.Title = "Cantidad";

            Series serie = new Series("Acciones");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;

            try
            {
                using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security=true"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT accion, COUNT(*) AS cantidad
                        FROM AuditoriaEntrenamientos
                        GROUP BY accion
                    ", conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string accion = reader.GetString(0);
                            int cantidad = reader.GetInt32(1);
                            serie.Points.AddXY(accion, cantidad);
                        }
                    }
                }

                chartAccionesAuditoria.Series.Add(serie);
                chartAccionesAuditoria.Titles.Add("Estadísticas de Auditoría de Entrenamientos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico:\n" + ex.Message);
            }
        }
    }
}

