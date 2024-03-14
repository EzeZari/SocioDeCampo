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
            lblName.Text = UserCache.FirstName;   //+", "+UserLoginCache.LastName
            lblLastName.Text = UserCache.LastName;
            lblEmail.Text = UserCache.Email; //Mostrarlos en pantalla
            lblPosition.Text = UserCache.Position;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();

            //Permisos Admin
            if(UserCache.Position == Position.AyudanteDeCampo)
            {
                btnLogout.Visible = false; //Le desactivamos el acceso a tal boton
            }
            if (UserCache.Position == Position.Entrenador)
            {
                // btnLogout.Enabled = false; Le desactivamos el acceso a tal boton
            } //EN EL FORM QUE YO QUIERA OCULTAR UN BOTON, LO HAGO DE LA MISMA MANERA. //Lo puedo hacer asi, o hacer una funcion y desp llamarla en "FormPrincipal_Load"
        }
    }
}
