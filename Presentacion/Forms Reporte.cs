using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Forms_Reporte : Form
    {
        public Forms_Reporte()
        {
            InitializeComponent();
        }

        private void Forms_Reporte_Load(object sender, EventArgs e)
        {
            DisablePdfExport();
        }
        public void SetData(DataTable dataTable)
        {

            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void DisablePdfExport()
        {
            foreach (RenderingExtension extension in this.reportViewer1.LocalReport.ListRenderingExtensions())
            {
                if (extension.Name == "PDF")
                {
                    var fieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                    if (fieldInfo != null)
                    {
                        fieldInfo.SetValue(extension, false);
                    }
                }
            }
        }
    }
}
