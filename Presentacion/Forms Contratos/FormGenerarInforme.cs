using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms_Contratos
{
    public partial class FormGenerarInforme : Form
    {
        public FormGenerarInforme()
        {
            InitializeComponent();
        }

        private void FormGenerarInforme_Load(object sender, EventArgs e)
        {
            this.VistaJugadoresSinModificarTableAdapter.Fill(this.DataSetContratos.VistaJugadoresSinModificar);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportContratos.rdlc";
            this.reportViewer1.RefreshReport();

            // Opciones del ComboBox de vencimiento
            cmbContratosVencimiento.Items.AddRange(new string[] { "Todos", "6 meses", "1 año", "2 años", "Fecha personalizada" });
            cmbContratosVencimiento.SelectedIndex = 0;

            // Opciones del ComboBox de posición
            cmbPosicion.Items.AddRange(new string[] { "Todos", "Arquero", "Defensor", "Mediocampista", "Delantero" });
            cmbPosicion.SelectedIndex = 0;

            // Fechas por defecto
            dtpDesde.Value = DateTime.Today.AddYears(-1);
            dtpHasta.Value = DateTime.Today;

            // Eventos
            cmbContratosVencimiento.SelectedIndexChanged += cmbContratosVencimiento_SelectedIndexChanged;

            CargarInforme();
        }

        private void cmbContratosVencimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool habilitarFechas = cmbContratosVencimiento.SelectedItem.ToString() == "Fecha personalizada";
            dtpDesde.Enabled = habilitarFechas;
            dtpHasta.Enabled = habilitarFechas;
        }

        private void CargarInforme()
        {
            DateTime fechaDesde = DateTime.MinValue;
            DateTime fechaHasta = DateTime.MaxValue;

            if (cmbContratosVencimiento.SelectedItem.ToString() == "Fecha personalizada")
            {
                fechaDesde = dtpDesde.Value;
                fechaHasta = dtpHasta.Value;
            }

            decimal salarioMin = numSalarioMin.Value;
            decimal salarioMax = numSalarioMax.Value;
            DateTime fechaVencimiento = DateTime.MaxValue;

            switch (cmbContratosVencimiento.SelectedItem.ToString())
            {
                case "6 meses":
                    fechaVencimiento = DateTime.Today.AddMonths(6);
                    break;
                case "1 año":
                    fechaVencimiento = DateTime.Today.AddYears(1);
                    break;
                case "2 años":
                    fechaVencimiento = DateTime.Today.AddYears(2);
                    break;
            }

            string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd");
            string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd");
            int salarioMinInt = Convert.ToInt32(salarioMin);
            int salarioMaxInt = Convert.ToInt32(salarioMax);
            string fechaVencimientoStr = fechaVencimiento.ToString("yyyy-MM-dd");

            // Filtro de posición
            string posicionSeleccionada = cmbPosicion.SelectedItem.ToString();
            if (posicionSeleccionada == "Todos") posicionSeleccionada = null;

            this.VistaJugadoresSinModificarTableAdapter.FillByFiltros(
                this.DataSetContratos.VistaJugadoresSinModificar,
                fechaDesdeStr, fechaHastaStr, salarioMinInt, salarioMaxInt, fechaVencimientoStr, posicionSeleccionada
            );

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarInforme();
        }
    }
}