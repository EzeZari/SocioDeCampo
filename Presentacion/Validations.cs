using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Guna.UI.WinForms;

namespace Presentacion
{
    class Validations
    {
        public static bool onlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public static bool onlyLetters(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }


        public bool VerificarTextoNoVacio(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return false; // El texto está vacío o contiene solo espacios en blanco
            }
            else
            {
                return true; // El texto no está vacío
            }
        }
        



        public static bool IsEmpty(GunaTextBox currentTextBox, GunaTextBox nextTextBox)
        {
            if (string.IsNullOrWhiteSpace(currentTextBox.Text))
            {
                currentTextBox.Focus();
                return true;
            }
            else
            {
                // Si se proporciona un siguiente TextBox, establecer el foco en él
                nextTextBox?.Focus();
                return false;
            }
        }

        public static bool validMail(string pMail)
        {
            return pMail != null && Regex.IsMatch(pMail,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public static bool passwordSafe(string password)
        {
            bool mayuscula = false, minuscula = false, number = false;
            for(int i =0; i<password.Length; i++)
            if (char.IsUpper(password, i))
            {
                    mayuscula = true;
            }
            else if (char.IsLower(password, i))
            {
                    minuscula = true;
            }
            else if (char.IsDigit(password, i))
            {
                    number = true;
            }
            if(mayuscula && minuscula && number && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        private void txtFull_TextChanged(object sender, EventArgs e)
        {
            //if(passwordSafe(txtF.texts))
            //{
            //    btn.enables = true;
            //    else btn.enabled = false;
            //}
        }
    }
}
