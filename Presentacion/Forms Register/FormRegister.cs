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
            btnRegister.Enabled = true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay errores en los campos de texto
                if (!validFields())
                {
                    MessageBox.Show("Hay errores en los campos de texto. Por favor, corrígelos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Verificar si el LoginName ya existe en la base de datos
                else if (objetoCN.ConsultLoginName(txtLoginName.Text))
                {

                    MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (objetoCN.ConsultEmail(txtEmail.Text))
                {
                    MessageBox.Show("El correo electrónico ya está en uso. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text != txtPasswordRepeat.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // El Email no existe, proceder con el registro del usuario
                    objetoCN.AddUsuario(txtLoginName.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, txtPosition.Text);
                    MessageBox.Show("Se insertó correctamente", "Éxito", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir el usuario debido a: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordLogic_TextChanged(object sender, EventArgs e)
        {
            GunaTextBox textBox = sender as GunaTextBox; // Convertir el sender a GunaTextBox

            if (textBox != null)
            {
                string password = textBox.Text; // Obtener el texto del GunaTextBox

                // Llamar a la función passwordSafe para validar la contraseña
                bool isPasswordSafe = Validations.passwordSafe(password); // Llama a passwordSafe desde Validations

                if (isPasswordSafe)
                {
                    // La contraseña es segura, limpiar cualquier mensaje de error
                    errorPo.SetError(textBox, ""); // Limpiar mensaje de error si es seguro
                    textBox.BorderColor = Color.FromArgb(232, 233, 234); // Restaurar color de borde
                    textBox.FocusedBorderColor = Color.Blue; // Restaurar color de borde enfocado
                }
                else
                {
                    // La contraseña no es segura, mostrar mensaje de error usando errorPo
                    errorPo.SetError(textBox, "La contraseña no es segura");
                    textBox.BorderColor = Color.Red; // Cambiar color de borde a rojo
                    textBox.FocusedBorderColor = Color.Red; // Cambiar color de borde enfocado a rojo
                }
            }
            else
            {
                // El sender no es un GunaTextBox, manejar esta situación según sea necesario
                Console.WriteLine("Error: El sender no es un GunaTextBox.");
            }
        }





        #region Validaciones de los TextBox

        //VALIDACIONES

        // btn escondido, hasta que se completen todos los espacios vacios.
        //private void fullTxt()
        //{
        //    var vr =
        //           !string.IsNullOrEmpty(txtFirstName.Text) &&
        //           !string.IsNullOrEmpty(txtLastName.Text) &&
        //           !string.IsNullOrEmpty(txtLoginName.Text) &&
        //           !string.IsNullOrEmpty(txtEmail.Text) &&
        //           !string.IsNullOrEmpty(txtPassword.Text) &&
        //           txtPosition.SelectedItem != null;
        //    btnRegister.Enabled = vr;
        //}

        ErrorProvider errorPo = new ErrorProvider();

        // Evento TextChanged para todos los GunaTextBox
        private void txtFull_TextChanged(object sender, EventArgs e)
        {
            //fullTxt();
        }

        //Validar todos los campos al presionar el btn.
        private bool validFields()
        {
            bool isValid = true;

            // Validar cada campo individualmente
            isValid &= !Validations.TxtEmpty(txtFirstName);
            isValid &= !Validations.TxtEmpty(txtLastName);
            isValid &= !Validations.TxtEmpty(txtLoginName);
            isValid &= Validations.validMail(txtEmail.Text);
            isValid &= !string.IsNullOrEmpty(txtPassword.Text); // Verificar que la contraseña no esté vacía
            isValid &= Validations.passwordSafe(txtPassword.Text); // Verificar que la contraseña sea segura

            isValid &= !Validations.ComboBoxEmpty(txtPosition);

            // Si alguno de los campos no es válido, establecer el estado de error en true
            error = !isValid;

            return isValid;
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

            }
            else
            {
                txtEmail.BorderColor = Color.FromArgb(232, 233, 234);
                txtEmail.FocusedBorderColor = Color.Blue;
                errorPo.Clear();

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
            }
            else
            {
                textBox.BorderColor = Color.FromArgb(232, 233, 234);
                errorPo.Clear();
            }
        }

        private void ComboBoxEmpty_Leave(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaComboBox comboBox = (Guna.UI.WinForms.GunaComboBox)sender; // Convertir el control a GunaComboBox

            if (Validations.ComboBoxEmpty(comboBox))
            {
                errorPo.SetError(comboBox, "No se puede dejar vacio");
                comboBox.BorderColor = Color.Red;
            }
            else
            {
                comboBox.BorderColor = Color.FromArgb(232, 233, 234);
                errorPo.Clear();
            }
        }

        //Contrañas distintas
        private void txtPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            GunaTextBox textBox = (GunaTextBox)sender; // Convertir el control a GunaTextBox

            // Obtener los textos de los campos de contraseña principal y repetida
            string password = txtPassword.Text;
            string repeatPassword = txtPasswordRepeat.Text;

            // Verificar si los textos de las contraseñas no coinciden
            if (password != repeatPassword)
            {
                // Mostrar un mensaje de error usando errorPo en el campo repetido
                errorPo.SetError(textBox, "Las contraseñas no coinciden");
                textBox.BorderColor = Color.Red; // Cambiar color de borde a rojo
                textBox.FocusedBorderColor = Color.Red; // Cambiar color de borde enfocado a rojo
            }
            else
            {
                // Las contraseñas coinciden, limpiar cualquier mensaje de error
                errorPo.SetError(textBox, ""); // Limpiar mensaje de error si coinciden
                textBox.BorderColor = Color.FromArgb(232, 233, 234); // Restaurar color de borde
                textBox.FocusedBorderColor = Color.Blue; // Restaurar color de borde enfocado
            }
        }
        #endregion


    }
}
