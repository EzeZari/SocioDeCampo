﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Presentacion;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {

        private Guna.UI.WinForms.GunaButton currentButton;  //Variable para Almacenar btn actual.
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar Sesion?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void LoadUserData()
        {
            lblName.Text = UserCache.FirstName;   
            lblLastName.Text = UserCache.LastName;
            lblEmail.Text = UserCache.Email; //Mostrarlos en pantalla
            lblPosition.Text = UserCache.Position;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();

            //Permisos Admin
            if(UserCache.Position == Position.AyudanteDeCampo)
            {
                btnLogout.Visible = false; //Le desactivamos el acceso a tal boton
            }
            if (UserCache.Position == Position.Entrenador)
            {
                
            } //EN EL FORM QUE YO QUIERA OCULTAR UN BOTON, LO HAGO DE LA MISMA MANERA. //Lo puedo hacer asi, o hacer una funcion y desp llamarla en "FormPrincipal_Load"
        }

        
        private void ActivateButton (Object btnSender) 
        {
            if (btnSender != null) // Comprobar si el objeto enviado es un botón
            {
                if (currentButton != (Guna.UI.WinForms.GunaButton)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(70,130,180) ;
                    currentButton = (Guna.UI.WinForms.GunaButton)btnSender;
                    currentButton.BaseColor = color;       
                    currentButton.ForeColor = Color.White; 
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI.WinForms.GunaButton)) // Verifica si el botón es de tipo GunaButton
                {
                    Guna.UI.WinForms.GunaButton gunaButton = (Guna.UI.WinForms.GunaButton)previousBtn;
                    gunaButton.BaseColor = Color.FromArgb(38, 84, 124); 
                    gunaButton.ForeColor = Color.White; 

                }
            }
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm) //Metodo para abrir los formularios hijos en el metodo contenedor. (ONLY FORM)
        {
            if (activeForm != null) 
                activeForm.Close(); 

                activeForm = childForm; //Almacenamos el form activo.
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None; 
                childForm.Dock = DockStyle.Fill; //Establecemos que rellene todo el panel.
                panelChildFrom.Controls.Add(childForm);
                panelChildFrom.Tag = childForm;//Asociamos el form con el panel contenedor.
                childForm.BringToFront();
                childForm.Show();

            
        }
        #region Botones
        private void btnInicio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInicio()); // Abrir el formulario hijo primero
            ActivateButton(sender); // Llamamos a ActivateButton y pasamos el botón actual (sender)
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormJugadores()); 
            ActivateButton(sender); 
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormFinanzas());
        }

        private void btnEntrenadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentacion.FormEntrenamientos.FormEntrenamientos());
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPartidos());
            ActivateButton(sender);
            
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormProfile());
        }
        #endregion

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
