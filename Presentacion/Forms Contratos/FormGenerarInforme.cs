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
            // TODO: esta línea de código carga datos en la tabla 'DataSetContratos.VistaJugadoresSinModificar' Puede moverla o quitarla según sea necesario.
            this.VistaJugadoresSinModificarTableAdapter.Fill(this.DataSetContratos.VistaJugadoresSinModificar);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportContratos.rdlc";

            this.reportViewer1.RefreshReport();
        }
    }
}
