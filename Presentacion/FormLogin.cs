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
                    if (txtpassword.Text != "Password") {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpassword.Text);
                    if(validLogin == true)//Si el inicio de sesion es verdadero mostramos el form principal
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();  //Mostramos el form principal
                        this.Hide();     //Ocultamos el Login
                    }
                    else
                    {
                        msgError("El usuario o contraseña no son correctos");
                        txtuser.Text = ""; //Limpiamos el txt user 
                        txtpassword.Focus();
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
    }
}
