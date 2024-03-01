using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    if (txtpassword.Text != "Password") { }
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
