using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FormSeguimientoPresupuestario : Form
    {
        private PresupuestoModel _presupuestoModel = new PresupuestoModel();



        public FormSeguimientoPresupuestario()
        {
            InitializeComponent();
        }

        private void FormSeguimientoPresupuestario_Load(object sender, EventArgs e)
        {
                CargarTemporadas();

            // Si hay temporadas, seleccionar la primera por defecto
            if (cmbTemporada.Items.Count > 0)
            {
                cmbTemporada.SelectedIndex = 0;
            }

        }


        private void CargarTemporadas()
        {
            DataTable presupuestos = _presupuestoModel.MostrarPresupuestos();
            cmbTemporada.Items.Clear();

            // Usar HashSet para obtener temporadas únicas
            HashSet<string> temporadasUnicas = new HashSet<string>();

            foreach (DataRow row in presupuestos.Rows)
            {
                string temporada = row["temporada"].ToString();
                if (!temporadasUnicas.Contains(temporada))
                {
                    temporadasUnicas.Add(temporada);
                    cmbTemporada.Items.Add(temporada);
                }
            }
        }

        private void cmbTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemporada.SelectedIndex >= 0)
            {
                CargarDatosSeguimiento(cmbTemporada.SelectedItem.ToString());
            }
        }

        private void CargarDatosSeguimiento(string temporada)
        {
            DataTable comparativo = _presupuestoModel.ObtenerComparativoPresupuestoVsGasto(temporada);
            dgvSeguimiento.DataSource = comparativo;

            dgvSeguimiento.Columns["categoria"].HeaderText = "Categoría";
            dgvSeguimiento.Columns["monto_presupuestado"].HeaderText = "Presupuestado";
            dgvSeguimiento.Columns["gasto_actual"].HeaderText = "Gasto Actual";
            dgvSeguimiento.Columns["diferencia"].HeaderText = "Diferencia";
            dgvSeguimiento.Columns["porcentaje_usado"].HeaderText = "% Usado";

            dgvSeguimiento.Columns["monto_presupuestado"].DefaultCellStyle.Format = "C2";
            dgvSeguimiento.Columns["gasto_actual"].DefaultCellStyle.Format = "C2";
            dgvSeguimiento.Columns["diferencia"].DefaultCellStyle.Format = "C2";
            dgvSeguimiento.Columns["porcentaje_usado"].DefaultCellStyle.Format = "0.00 %";

            dgvSeguimiento.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == dgvSeguimiento.Columns["porcentaje_usado"].Index && e.RowIndex >= 0)
                {
                    double porcentaje = Convert.ToDouble(e.Value);
                    e.CellStyle.BackColor = porcentaje >= 100 ? Color.Red : porcentaje >= 80 ? Color.Orange : porcentaje >= 50 ? Color.Yellow : Color.LightGreen;
                    e.CellStyle.ForeColor = porcentaje >= 100 ? Color.White : Color.Black;
                }

                if (e.ColumnIndex == dgvSeguimiento.Columns["diferencia"].Index && e.RowIndex >= 0 && Convert.ToDecimal(e.Value) < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dgvSeguimiento.Font, FontStyle.Bold);
                }
            };

            ActualizarGraficoBarras(comparativo);
            ActualizarGraficoPie(comparativo);
        }


        private void ActualizarGraficoBarras(DataTable datos)
        {
            chartBarras.Series.Clear();
            chartBarras.ChartAreas[0].AxisX.Interval = 1;
            chartBarras.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartBarras.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            Series seriePresupuesto = new Series("Presupuestado") { ChartType = SeriesChartType.Column, Color = Color.Blue };
            Series serieGastos = new Series("Gasto Actual") { ChartType = SeriesChartType.Column, Color = Color.Green };

            foreach (DataRow row in datos.Rows)
            {
                string categoria = row["categoria"].ToString();
                double presupuestado = Convert.ToDouble(row["monto_presupuestado"]);
                double gastoActual = row["gasto_actual"] != DBNull.Value ? Convert.ToDouble(row["gasto_actual"]) : 0;

                seriePresupuesto.Points.AddXY(categoria, presupuestado);
                serieGastos.Points.AddXY(categoria, gastoActual);
            }

            chartBarras.Series.Add(seriePresupuesto);
            chartBarras.Series.Add(serieGastos);
            chartBarras.Legends[0].Enabled = true;
            chartBarras.Update();
        }


        private void ActualizarGraficoPie(DataTable datos)
        {
            chartPie.Series.Clear();
            Series serie = new Series("Porcentaje de Presupuesto") { ChartType = SeriesChartType.Pie };
            decimal totalPresupuestado = datos.AsEnumerable().Sum(row => row.Field<decimal>("monto_presupuestado"));

            foreach (DataRow row in datos.Rows)
            {
                string categoria = row["categoria"].ToString();
                decimal presupuestado = Convert.ToDecimal(row["monto_presupuestado"]);
                if (presupuestado > 0)
                {
                    double porcentaje = (double)((presupuestado / totalPresupuestado) * 100);
                    int indice = serie.Points.AddXY(categoria, porcentaje);
                    // Modified label to show only the category name
                    serie.Points[indice].Label = categoria;
                }
            }

            chartPie.Series.Add(serie);
            chartPie.Legends[0].Enabled = true;
        }
    }
}
