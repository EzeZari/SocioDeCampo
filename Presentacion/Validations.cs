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
        //Solos Numeros
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

        //Solo Letras
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

        //Texto Vacio
        public static bool TxtEmpty(GunaTextBox pTxt)
        {
            if (pTxt.Text == string.Empty)
            {
                return true; // Si el texto está vacío, devolver true
            }
            else
            {
                return false; 
            }
        }

        //Combobox
        public static bool ComboBoxEmpty(Guna.UI.WinForms.GunaComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Mails
        public static bool validMail(string pMail)
        {
            return pMail != null && Regex.IsMatch(pMail,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        //Contraseña
        public static bool passwordSafe(string password)
{
    // Verificar si la contraseña contiene espacios en blanco
    if (password.Contains(" "))
    {
        return false; // La contraseña contiene espacios en blanco, no es segura
    }

    // Variables para verificar la presencia de mayúsculas, minúsculas y dígitos
    bool mayuscula = false, minuscula = false, number = false;

    // Verificar cada carácter de la contraseña
    for (int i = 0; i < password.Length; i++)
    {
        char currentChar = password[i];

        if (char.IsUpper(currentChar))
        {
            mayuscula = true;
        }
        else if (char.IsLower(currentChar))
        {
            minuscula = true;
        }
        else if (char.IsDigit(currentChar))
        {
            number = true;
        }
    }

    // Verificar todas las condiciones para determinar si la contraseña es segura
    if (mayuscula && minuscula && number && password.Length >= 8)
    {
        return true; // La contraseña cumple con todos los criterios de seguridad
    }

    return false; // La contraseña no es segura
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
