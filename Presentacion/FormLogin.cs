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
            
                if (txtuser.Text != "Username")
                {
                    if (txtpassword.Text != "Password") 
                    {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpassword.Text);
                    if(validLogin == true)//Si el inicio de sesion es verdadero mostramos el form principal
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        MessageBox.Show("Bienvenido "+UserCache.FirstName + ", "+ UserCache.LastName); //Alerta de bienvenida al iniciar sesion.
                        mainMenu.Show();  //Mostramos el form principal
                        mainMenu.FormClosed += Logout;
                        this.Hide();     //Ocultamos el Login
                    }
                    else {
                        msgError("El usuario o contraseña no son correctos");
                        txtuser.Text = ""; //Limpiamos el txt user. 
                        txtpassword.Text = "Password";
                        txtpassword.Focus(); //Te lleva el cursos a txtPassword.
                    }
                
                }
                    else msgError("Por favot ingresa tu contraseña");
                }
                else msgError(" Por favor ingresa tu Usuario");
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

        private void lblOlvidastePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FormRecoverPassword();
            recoverPassword.ShowDialog();
        }
    }
}
