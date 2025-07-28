using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormReportePartido : Form
    {
        private Partido partido;

        public FormReportePartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        private void FormReportePartido_Load(object sender, EventArgs e)
        {
            PartidoModel model = new PartidoModel();

            // Parámetros básicos
            var parametros = new ReportParameterCollection
            {
                new ReportParameter("Fecha", partido.Fecha.ToShortDateString()),
                new ReportParameter("Hora", partido.Hora.ToString(@"hh\:mm")),
                new ReportParameter("Local", partido.EquipoLocal),
                new ReportParameter("Visitante", partido.EquipoVisitante),
                new ReportParameter("Resultado", $"{partido.ResultadoLocal} - {partido.ResultadoVisitante}"),
                new ReportParameter("Observaciones", partido.Observaciones ?? ""),
                new ReportParameter("Ubicacion", partido.Ubicacion ?? "")
            };

            // Obtener los datos de goles y tarjetas
            DataTable dtGoles = model.ObtenerGolesPorPartido(partido.IdPartido);
            DataTable dtTarjetas = model.ObtenerTarjetasPorPartido(partido.IdPartido);

            // Crear los ReportDataSource
            ReportDataSource rdsGoles = new ReportDataSource("DataSetGoles", dtGoles);
            ReportDataSource rdsTarjetas = new ReportDataSource("DataSetTarjetas", dtTarjetas);

            // Limpiar y agregar orígenes de datos
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdsGoles);
            reportViewer1.LocalReport.DataSources.Add(rdsTarjetas);

            // Establecer parámetros y refrescar
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.RefreshReport();
        }
    }
}