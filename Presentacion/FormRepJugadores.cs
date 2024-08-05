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
    public partial class FormRepJugadores : Form
    {
        public FormRepJugadores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet1.Jugadores' Puede moverla o quitarla según sea necesario.
            this.JugadoresTableAdapter.Fill(this.MyCompanyDataSet1.Jugadores);
            // TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet.gastos' Puede moverla o quitarla según sea necesario.
            this.gastosTableAdapter.Fill(this.MyCompanyDataSet.gastos);

            this.reportViewer1.RefreshReport();
        }



    }


}
