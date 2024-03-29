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
using Guna.UI.WinForms;



namespace Presentacion
{
    public partial class FormRegister : Form
    {
        UserModel objetoCN = new UserModel();
        public FormRegister()
        {
            InitializeComponent();
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
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
        private void fullTxt()
        {
            var vr = 
                   !string.IsNullOrEmpty(txtFirstName.Text) &&
                   !string.IsNullOrEmpty(txtLastName.Text) &&
                   !string.IsNullOrEmpty(txtLoginName.Text) &&
                   !string.IsNullOrEmpty(txtEmail.Text) &&
                   !string.IsNullOrEmpty(txtPassword.Text) &&
                   txtPosition.SelectedItem != null;
                   btnRegister.Enabled = vr;
        }
        // Evento TextChanged para todos los GunaTextBox
        private void txtFull_TextChanged(object sender, EventArgs e)
        {
            fullTxt();
        }

        #region Validaciones de los TextBox
        //VALIDACIONES


        ErrorProvider errorPo = new ErrorProvider();

        //SOLO LETRAS
        private void OnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            GunaTextBox gunaTextBox = (GunaTextBox)sender; // Convertir el sender a GunaTextBox
            bool valida = Validations.onlyLetters(e);
            if (!valida)
            {
                errorPo.SetError(gunaTextBox, "Solo letras");
                gunaTextBox.BorderColor = Color.Red;
                gunaTextBox.FocusedBorderColor = Color.Red;
            }
            else
            {
                gunaTextBox.BorderColor = Color.FromArgb(232, 233, 234); // Restaurar color del borde
                errorPo.Clear();
            }
        }

        public void TextEmpty_(GunaTextBox ptxt, ErrorProvider errorProvider, EventArgs e)
        {
            if (ptxt.Text == string.Empty)
            {
                errorProvider.SetError(ptxt, "Este campo no puede estar vacío");
                ptxt.Focus();
            }
            else
            {
                errorProvider.SetError(ptxt, ""); // Limpiar el error si el campo no está vacío
            }
        }
        #endregion

        // Evento Leave para validar si el correo electrónico es válido
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            GunaTextBox txtEmail = (GunaTextBox)sender; // Convertir el sender a GunaTextBox
            if (!Validations.validMail(txtEmail.Text))
            {
                errorPo.SetError(txtEmail, "Correo no válido");
            }
            else
            {
                errorPo.Clear();
            }
        }
        //private void gunaTextBox_Leave(object sender, EventArgs e)
        //{
        //    GunaTextBox gunaTextBox = (GunaTextBox)sender; // Convertir el sender a GunaTextBox
        //    if (Validations.textEmpty(gunaTextBox))
        //    {
        //        errorPo.SetError(gunaTextBox, "No puede estar vacío");
        //        gunaTextBox.Focus();
        //    }
        //    else
        //    {
        //        errorPo.Clear();
        //    }
        //}
        // Método para verificar si todos los campos están llenos
        
        //public void TextVacio()
        //{
        //    Validations verificador = new Validations();
        //    if (verificador.VerificarTextoNoVacio(textBox1.Text))
        //    {
        //        // El texto no está vacío, realiza alguna acción aquí
        //    }
        //    else
        //    {
        //        MessageBox.Show("El texto está vacío. Por favor ingresa algún valor.");
        //    }
        //}
        
    }
}
