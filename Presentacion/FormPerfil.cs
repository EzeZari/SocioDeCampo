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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }
        private void LoadUserData()
        {
            txtFirstName.Text = UserCache.FirstName;   //+", "+UserLoginCache.LastName
            txtLastName.Text = UserCache.LastName;
            txtLoginName.Text = UserCache.LoginName;
            txtEmail.Text = UserCache.Email; //Mostrarlos en pantalla
            txtPosition.Text = UserCache.Position;
            txtPassword.Text = UserCache.Password; 
        }
        private void TextBoxOn() //Funcion para que se puedan editar los txt.
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtLoginName.Enabled = true;
            txtEmail.Enabled = true;
            txtPosition.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword.PasswordChar = '\0';
        }
        private void FormPerfil_Load(object sender, EventArgs e)
        {
            LoadUserData();
            
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            TextBoxOn();
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            btnEditProfile.Visible = false; 
            
        }
    }
}
