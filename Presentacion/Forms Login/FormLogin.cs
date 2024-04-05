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
using Common.Cache;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar si se ha ingresado un nombre de usuario
            if (txtuser.Text != "Usuario")
            {
                // Verificar si se ha ingresado una contraseña
                if (txtpassword.Text != "Contraseña")
                {
                    // Crear una instancia del modelo de usuario
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpassword.Text);
                    // Si el inicio de sesión es exitoso, mostrar el formulario principal
                    if (validLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        MessageBox.Show("Hola de nuevo " + UserCache.FirstName + ", " + UserCache.LastName, "Bienvenido");
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else if (txtuser.Text == "")
                    {
                        msgError("Por favor ingresa tu Usuario");
                    }
                    else if (txtpassword.Text == "")
                    {
                        msgError("Por favor ingresa tu Contraseña");
                    }
                    else
                    {
                        msgError("El usuario o contraseña no son correctos");
                        //txtuser.Text = ""; // Limpiamos el txt user. 
                        txtpassword.Text = ""; // Limpiamos el txt user.
                        txtpassword.Text = "Password";
                        txtpassword.Focus(); // Te lleva el cursor a txtPassword.
                    }
                }
            }
        }

        private void msgError(string msg)
            {
                lblErrorMessagge.Text = " " + msg;
                lblErrorMessagge.Visible = true;
            }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpassword.Text = "Password";
            txtpassword.UseSystemPasswordChar = false;//Borramos los inputs
            txtuser.Text = "Username";
            lblErrorMessagge.Visible = false; //Escondemos el mensaje de error.
            this.Show(); //Al cerrar sesion volvemos a mostrar el Form Login.
            //txtuser.Focus();
        }


        #region Botones
        //Boton ¿Olvidaste tu contraseña?
        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FormRecoverPassword();
            recoverPassword.ShowDialog();
        }
        //Boton Registrarse
        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Register = new FormRegister();
            Register.ShowDialog();
        }

        //Boton Ver y Ocultar contraseña
        private void passShow_Click(object sender, EventArgs e)
        {
            passShow.BringToFront();
            txtpassword.PasswordChar = '\0';
            passShow.Visible = false;
            passHide.Visible = true;
        }

        private void passHide_Click(object sender, EventArgs e)
        {
            passHide.BringToFront();
            passHide.Visible = false;
            passShow.Visible = true;
            txtpassword.PasswordChar = '*';
        }
        #endregion

    }
}
