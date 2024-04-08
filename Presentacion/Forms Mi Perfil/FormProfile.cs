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
using Domain;

namespace Presentacion
{
    public partial class FormProfile : Form
    {
        UserModel objeto = new UserModel();
        private int UserID;

        public FormProfile()
        {
            InitializeComponent();
        }

        // Método para cargar los datos del usuario desde UserCache
        private void LoadUserData()
        {
            txtFirstName.Text = UserCache.FirstName;
            txtLastName.Text = UserCache.LastName;
            txtLoginName.Text = UserCache.LoginName;
            txtEmail.Text = UserCache.Email;
            txtPosition.Text = UserCache.Position;
            txtPassword.Text = UserCache.Password;
            UserID = UserCache.UserID;
        }
        #region Txt ON/OFF
        // Método para habilitar la edición de los campos de texto
        private void TextBoxOn()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtLoginName.Enabled = true;
            txtEmail.Enabled = true;
            txtPosition.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword.PasswordChar = '\0'; // Mostrar texto en campo de contraseña
        }

        // Método para deshabilitar la edición de los campos de texto
        private void TextBoxOff()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtLoginName.Enabled = false;
            txtEmail.Enabled = false;
            txtPosition.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.PasswordChar = '*'; // Mostrar asteriscos en campo de contraseña
        }
        #endregion

        #region btn Profile ON/OFF
        private void btnProfileOn()
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnEditProfile.Visible = true;
        }
        private void btnProfileOff()
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            btnEditProfile.Visible = false;
        }
        #endregion

        // Método para editar el usuario en la base de datos
        private void EditUser()
        {
            try
            {
                // Llamar al método para editar el usuario en UserModel 
                DialogResult result = MessageBox.Show("¿Está seguro de que desea editar sus datos?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    objeto.EditarUser(txtLoginName.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, txtPosition.Text, UserID);
                    MessageBox.Show("Se Editó correctamente tu perfil","Exito");
                    btnProfileOn(); // Habilitar perfil
                }
                else
                {
                    LoadUserData(); // Cargar datos del usuario
                    btnProfileOn(); // Habilitar perfil
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar el Usuario debido a:  " + ex);
            }
        }


        private void FormPerfil_Load(object sender, EventArgs e)
        {
            LoadUserData(); // Cargar datos del usuario
            TextBoxOff(); // Deshabilitar edición de campos de texto
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            TextBoxOn(); // Habilitar edición de campos de texto al hacer clic en el botón "Editar perfil"
            btnProfileOff();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EditUser(); // Editar usuario en la base de datos al hacer clic en el botón "Confirmar"
            TextBoxOff(); // Deshabilitar edición de campos de texto después de editar
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TextBoxOff();
            btnProfileOn();
            LoadUserData();
        }
    }

}
