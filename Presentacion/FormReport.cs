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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet.Jugadores' Puede moverla o quitarla según sea necesario.
            this.JugadoresTableAdapter.Fill(this.MyCompanyDataSet.Jugadores);

            this.reportViewer1.RefreshReport();
        }
    }
}
