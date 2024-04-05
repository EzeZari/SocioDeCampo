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
        static bool error;

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
                // Verificar si el LoginName ya existe en la base de datos
                if (error == true)
                {
                    MessageBox.Show("Hay errores en los campos de texto. Por favor, corrígelos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (objetoCN.ConsultLoginName(txtLoginName.Text))
                {
                    // El LoginName ya existe, mostrar un mensaje de error
                    MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (objetoCN.ConsultEmail(txtEmail.Text))
                {
                    MessageBox.Show("El correo electronico ya está en uso. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // El Email no existe, proceder con el registro del usuario
                    objetoCN.AddUsuario(txtLoginName.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, txtPosition.Text);
                    MessageBox.Show("Se insertó correctamente", "Exito", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir el usuario debido a:  " + ex);
            }
        }


        #region Validaciones de los TextBox

        //VALIDACIONES
        ErrorProvider errorPo = new ErrorProvider();

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
        
        //Validacion solo LETRAS
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
        //Validaciion Mail
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            GunaTextBox txtEmail = (GunaTextBox)sender; // Convertir el sender a GunaTextBox
            if (!Validations.validMail(txtEmail.Text))
            {
                errorPo.SetError(txtEmail, "Correo no válido");
                txtEmail.BorderColor = Color.Red;
                txtEmail.FocusedBorderColor = Color.Red;
                error = true;
            }
            else
            {
                txtEmail.BorderColor = Color.FromArgb(232, 233, 234);
                txtEmail.FocusedBorderColor = Color.Blue;
                errorPo.Clear();
                error = false;
            }
        }
        //Validacion txt Vacios
       private void TextEmpty_Leave(object sender, EventArgs e)
        {
            GunaTextBox textBox = (GunaTextBox)sender; // Convertir el control a GunaTextBox
            
            if (Validations.TxtEmpty(textBox))
            {
                errorPo.SetError(textBox, "No se puede dejar vacio");
                textBox.BorderColor = Color.Red;
                textBox.FocusedBorderColor = Color.Red;
                error = true;
            }
            else
            {
                textBox.BorderColor = Color.FromArgb(232, 233, 234);
                errorPo.Clear();
                error = false;

            }
        }

        private void ComboBoxEmpty_Leave(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaComboBox comboBox = (Guna.UI.WinForms.GunaComboBox)sender; // Convertir el control a GunaComboBox

            if (Validations.ComboBoxEmpty(comboBox))
            {
                errorPo.SetError(comboBox, "No se puede dejar vacio");
                comboBox.BorderColor = Color.Red;
                error = true;
            }
            else
            {
                comboBox.BorderColor = Color.FromArgb(232, 233, 234);
                errorPo.Clear();
                error = false;
            }
        }

        #endregion
    }
}
