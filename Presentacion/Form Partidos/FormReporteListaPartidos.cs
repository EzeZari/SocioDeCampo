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
using Common.Cache;
using Microsoft.Reporting.WinForms;


namespace Presentacion
{
    public partial class FormReporteListaPartidos : Form
    {
        private List<Partido> _partidos;

        public FormReporteListaPartidos(List<Partido> partidos)
        {
            InitializeComponent();
            _partidos = partidos;
        }

        private void FormReporteListaPartidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSetPartidos.Partidos' Puede moverla o quitarla según sea necesario.
            this.PartidosTableAdapter.Fill(this.MyCompanyDataSetPartidos.Partidos);
            var ds = new ReportDataSource("DataSetPartidos", _partidos);
           // reportViewer1.LocalReport.ReportPath = "ReporteListaPartidos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}
