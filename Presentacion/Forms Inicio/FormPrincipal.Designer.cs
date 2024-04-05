
namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.PanelMenu = new Guna.UI.WinForms.GunaPanel();
            this.btnPerfil = new Guna.UI.WinForms.GunaButton();
            this.btnPartidos = new Guna.UI.WinForms.GunaButton();
            this.btnEntrenadores = new Guna.UI.WinForms.GunaButton();
            this.btnFinanzas = new Guna.UI.WinForms.GunaButton();
            this.btnJugadores = new Guna.UI.WinForms.GunaButton();
            this.btnInicio = new Guna.UI.WinForms.GunaButton();
            this.PanelLogo = new Guna.UI.WinForms.GunaPanel();
            this.panelChildFrom = new System.Windows.Forms.Panel();
            this.lblLastName = new Guna.UI.WinForms.GunaLabel();
            this.lblPosition = new Guna.UI.WinForms.GunaLabel();
            this.lblEmail = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.PanelMenu.SuspendLayout();
            this.panelChildFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(0, 687);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(180, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Salir";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.PanelMenu.Controls.Add(this.btnPerfil);
            this.PanelMenu.Controls.Add(this.btnPartidos);
            this.PanelMenu.Controls.Add(this.btnEntrenadores);
            this.PanelMenu.Controls.Add(this.btnFinanzas);
            this.PanelMenu.Controls.Add(this.btnJugadores);
            this.PanelMenu.Controls.Add(this.btnInicio);
            this.PanelMenu.Controls.Add(this.btnLogout);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(180, 729);
            this.PanelMenu.TabIndex = 6;
            // 
            // btnPerfil
            // 
            this.btnPerfil.AnimationHoverSpeed = 0.07F;
            this.btnPerfil.AnimationSpeed = 0.03F;
            this.btnPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerfil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnPerfil.BorderColor = System.Drawing.Color.Black;
            this.btnPerfil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPerfil.FocusedColor = System.Drawing.Color.Empty;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPerfil.Location = new System.Drawing.Point(0, 370);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnPerfil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPerfil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPerfil.OnHoverImage = null;
            this.btnPerfil.OnPressedColor = System.Drawing.Color.Black;
            this.btnPerfil.Size = new System.Drawing.Size(180, 42);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "Mi perfil";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.AnimationHoverSpeed = 0.07F;
            this.btnPartidos.AnimationSpeed = 0.03F;
            this.btnPartidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPartidos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnPartidos.BorderColor = System.Drawing.Color.Black;
            this.btnPartidos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPartidos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPartidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPartidos.Image")));
            this.btnPartidos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPartidos.Location = new System.Drawing.Point(3, 305);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnPartidos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPartidos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPartidos.OnHoverImage = null;
            this.btnPartidos.OnPressedColor = System.Drawing.Color.Black;
            this.btnPartidos.Size = new System.Drawing.Size(180, 42);
            this.btnPartidos.TabIndex = 5;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnEntrenadores
            // 
            this.btnEntrenadores.AnimationHoverSpeed = 0.07F;
            this.btnEntrenadores.AnimationSpeed = 0.03F;
            this.btnEntrenadores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntrenadores.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnEntrenadores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnEntrenadores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntrenadores.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntrenadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenadores.ForeColor = System.Drawing.Color.White;
            this.btnEntrenadores.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrenadores.Image")));
            this.btnEntrenadores.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntrenadores.Location = new System.Drawing.Point(0, 257);
            this.btnEntrenadores.Name = "btnEntrenadores";
            this.btnEntrenadores.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnEntrenadores.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntrenadores.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntrenadores.OnHoverImage = null;
            this.btnEntrenadores.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntrenadores.Size = new System.Drawing.Size(180, 42);
            this.btnEntrenadores.TabIndex = 4;
            this.btnEntrenadores.Text = "Entrenadores";
            this.btnEntrenadores.Click += new System.EventHandler(this.btnEntrenadores_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.AnimationHoverSpeed = 0.07F;
            this.btnFinanzas.AnimationSpeed = 0.03F;
            this.btnFinanzas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinanzas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnFinanzas.BorderColor = System.Drawing.Color.Black;
            this.btnFinanzas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinanzas.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinanzas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.ForeColor = System.Drawing.Color.White;
            this.btnFinanzas.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanzas.Image")));
            this.btnFinanzas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFinanzas.Location = new System.Drawing.Point(0, 205);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnFinanzas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinanzas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFinanzas.OnHoverImage = null;
            this.btnFinanzas.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinanzas.Size = new System.Drawing.Size(180, 42);
            this.btnFinanzas.TabIndex = 3;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.AnimationHoverSpeed = 0.07F;
            this.btnJugadores.AnimationSpeed = 0.03F;
            this.btnJugadores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnJugadores.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnJugadores.BorderColor = System.Drawing.Color.Black;
            this.btnJugadores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnJugadores.FocusedColor = System.Drawing.Color.Empty;
            this.btnJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.Color.White;
            this.btnJugadores.Image = ((System.Drawing.Image)(resources.GetObject("btnJugadores.Image")));
            this.btnJugadores.ImageSize = new System.Drawing.Size(20, 20);
            this.btnJugadores.Location = new System.Drawing.Point(0, 153);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnJugadores.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnJugadores.OnHoverForeColor = System.Drawing.Color.White;
            this.btnJugadores.OnHoverImage = null;
            this.btnJugadores.OnPressedColor = System.Drawing.Color.Black;
            this.btnJugadores.Size = new System.Drawing.Size(180, 42);
            this.btnJugadores.TabIndex = 2;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.AnimationHoverSpeed = 0.07F;
            this.btnInicio.AnimationSpeed = 0.03F;
            this.btnInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInicio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnInicio.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInicio.FocusedColor = System.Drawing.Color.Empty;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInicio.Location = new System.Drawing.Point(0, 105);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnInicio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInicio.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInicio.OnHoverImage = null;
            this.btnInicio.OnPressedColor = System.Drawing.Color.Black;
            this.btnInicio.Size = new System.Drawing.Size(180, 42);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(180, 80);
            this.PanelLogo.TabIndex = 0;
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.BackColor = System.Drawing.Color.Transparent;
            this.panelChildFrom.Controls.Add(this.lblLastName);
            this.panelChildFrom.Controls.Add(this.lblPosition);
            this.panelChildFrom.Controls.Add(this.lblEmail);
            this.panelChildFrom.Controls.Add(this.lblName);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(180, 0);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(1170, 729);
            this.panelChildFrom.TabIndex = 7;
            this.panelChildFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFrom_Paint);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastName.Location = new System.Drawing.Point(253, 141);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(51, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellido";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPosition.Location = new System.Drawing.Point(251, 205);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(43, 15);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Puesto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(251, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(253, 241);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelChildFrom);
            this.Controls.Add(this.PanelMenu);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panelChildFrom.ResumeLayout(false);
            this.panelChildFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaPanel PanelMenu;
        private Guna.UI.WinForms.GunaButton btnInicio;
        private Guna.UI.WinForms.GunaPanel PanelLogo;
        private Guna.UI.WinForms.GunaButton btnPartidos;
        private Guna.UI.WinForms.GunaButton btnEntrenadores;
        private Guna.UI.WinForms.GunaButton btnFinanzas;
        private Guna.UI.WinForms.GunaButton btnJugadores;
        private System.Windows.Forms.Panel panelChildFrom;
        private Guna.UI.WinForms.GunaLabel lblLastName;
        private Guna.UI.WinForms.GunaLabel lblPosition;
        private Guna.UI.WinForms.GunaLabel lblEmail;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaButton btnPerfil;
    }
}