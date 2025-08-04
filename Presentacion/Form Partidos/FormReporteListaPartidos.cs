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
using System.Data.SqlClient;

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
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;Database=MyCompany;Integrated Security=true"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Partidos", conn);
                da.Fill(dt);
            }

            var ds = new ReportDataSource("DataSetPartidos", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();

        }
    }
}
