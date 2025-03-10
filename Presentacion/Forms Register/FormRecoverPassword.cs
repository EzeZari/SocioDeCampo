﻿using System;
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
    public partial class FormRecoverPassword : Form
    {
        public FormRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel(); //Instanciamos al modelo de Usuario
            var result = user.recoverPassword(txtUserRequest.Text); //Llamamos el metodo de recuperar contraseña de la capa de dominio.
            lblResult.Text = result;
        }
    }
}
