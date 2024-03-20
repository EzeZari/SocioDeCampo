using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common.Cache;
using Domain;



namespace Presentacion
{
    public partial class FormRegister : Form
    {
        UserModel objetoCN = new UserModel();
        public FormRegister()
        {
            InitializeComponent();
        }

        
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.AddUsuario(txtLoginName.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, txtPosition.Text); //Los ponemos sin convertirlos pq la capa dominio se encarga de hacer eso.
                MessageBox.Show("Se inserto correctamente");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir el usuario debido a:  " + ex);
            }
        }
    }
}
