using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar Sesion?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName;   //+", "+UserLoginCache.LastName
            lblLastName.Text = UserLoginCache.LastName;
            lblEmail.Text = UserLoginCache.Email; //Mostrarlos en pantalla
            lblPosition.Text = UserLoginCache.Position;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
