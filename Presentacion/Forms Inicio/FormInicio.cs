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


namespace Presentacion
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            MostrarJugadores();
            MostrarUltimosMovimientos();
        }
        private void MostrarJugadores()
        {
            UserModel objetoCD = new UserModel();
            dataGridView1.DataSource = objetoCD.MostrarJugadores();

            // Ocultar las últimas dos columnas
            if (dataGridView1.Columns.Count >= 2)
            {
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false; 
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false; 
            }
        }

        private void MostrarUltimosMovimientos()
        {
            GastosModel objetoGastos = new GastosModel();
            dataGridView2.DataSource = objetoGastos.MostrarUltimosMovimientos();
        }
    }
}
