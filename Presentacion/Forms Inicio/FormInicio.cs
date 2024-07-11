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
        }
        private void MostrarJugadores()
        {
            UserModel objetoCD = new UserModel();
            dataGridView1.DataSource = objetoCD.MostrarJugadores();
           // dataGridView1.Columns["idJugador"].Width = 50;
        }
    }
}
