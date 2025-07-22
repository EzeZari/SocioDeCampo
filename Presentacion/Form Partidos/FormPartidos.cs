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
    public partial class FormPartidos : Form
    {
        public FormPartidos()
        {
            InitializeComponent();
        }

        private void btnAñadirPartido_Click(object sender, EventArgs e)
        {
            var formAddPartido = new FormAddPartido();
            formAddPartido.ShowDialog();

        }
    }
}
