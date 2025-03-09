
namespace Presentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.txtuser = new Guna.UI.WinForms.GunaTextBox();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.lblErrorMessagge = new Guna.UI.WinForms.GunaLabel();
            this.lblOlvidastePassword = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.passShow = new System.Windows.Forms.PictureBox();
            this.passHide = new System.Windows.Forms.PictureBox();
            this.lblNoTienesCuenta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineaMedio = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(176)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(481, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(207, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtuser
            // 
            this.txtuser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtuser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.txtuser.BorderColor = System.Drawing.Color.Silver;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtuser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(154)))));
            this.txtuser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtuser.ForeColor = System.Drawing.Color.Transparent;
            this.txtuser.Location = new System.Drawing.Point(481, 157);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.Size = new System.Drawing.Size(207, 30);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "admin";
            this.txtuser.Enter += new System.EventHandler(this.clearTxt_Enter);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtpassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(154)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpassword.ForeColor = System.Drawing.Color.Transparent;
            this.txtpassword.Location = new System.Drawing.Point(481, 222);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(207, 30);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "admin";
            this.txtpassword.Enter += new System.EventHandler(this.clearTxt_Enter);
            // 
            // lblErrorMessagge
            // 
            this.lblErrorMessagge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblErrorMessagge.AutoSize = true;
            this.lblErrorMessagge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorMessagge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessagge.Location = new System.Drawing.Point(478, 282);
            this.lblErrorMessagge.Name = "lblErrorMessagge";
            this.lblErrorMessagge.Size = new System.Drawing.Size(32, 15);
            this.lblErrorMessagge.TabIndex = 3;
            this.lblErrorMessagge.Text = "Error";
            this.lblErrorMessagge.Visible = false;
            // 
            // lblOlvidastePassword
            // 
            this.lblOlvidastePassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(154)))));
            this.lblOlvidastePassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOlvidastePassword.AutoSize = true;
            this.lblOlvidastePassword.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOlvidastePassword.ForeColor = System.Drawing.Color.White;
            this.lblOlvidastePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblOlvidastePassword.LinkColor = System.Drawing.Color.White;
            this.lblOlvidastePassword.Location = new System.Drawing.Point(557, 257);
            this.lblOlvidastePassword.Name = "lblOlvidastePassword";
            this.lblOlvidastePassword.Size = new System.Drawing.Size(131, 13);
            this.lblOlvidastePassword.TabIndex = 6;
            this.lblOlvidastePassword.TabStop = true;
            this.lblOlvidastePassword.Text = "¿Olvidaste tu contraseña?";
            this.lblOlvidastePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgetPassword_LinkClicked);
            // 
            // lblRegister
            // 
            this.lblRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(154)))));
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblRegister.LinkColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(606, 382);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(71, 13);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Registrarse";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // passShow
            // 
            this.passShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passShow.Image = ((System.Drawing.Image)(resources.GetObject("passShow.Image")));
            this.passShow.Location = new System.Drawing.Point(713, 222);
            this.passShow.Name = "passShow";
            this.passShow.Size = new System.Drawing.Size(35, 30);
            this.passShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passShow.TabIndex = 8;
            this.passShow.TabStop = false;
            this.passShow.Click += new System.EventHandler(this.passShow_Click);
            // 
            // passHide
            // 
            this.passHide.Image = ((System.Drawing.Image)(resources.GetObject("passHide.Image")));
            this.passHide.Location = new System.Drawing.Point(713, 222);
            this.passHide.Name = "passHide";
            this.passHide.Size = new System.Drawing.Size(35, 30);
            this.passHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passHide.TabIndex = 9;
            this.passHide.TabStop = false;
            this.passHide.Visible = false;
            this.passHide.Click += new System.EventHandler(this.passHide_Click);
            // 
            // lblNoTienesCuenta
            // 
            this.lblNoTienesCuenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoTienesCuenta.AutoSize = true;
            this.lblNoTienesCuenta.ForeColor = System.Drawing.Color.White;
            this.lblNoTienesCuenta.Location = new System.Drawing.Point(500, 382);
            this.lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            this.lblNoTienesCuenta.Size = new System.Drawing.Size(100, 13);
            this.lblNoTienesCuenta.TabIndex = 10;
            this.lblNoTienesCuenta.Text = "¿No tienes cuenta?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "SOCIO DE CAMPO";
            // 
            // lineaMedio
            // 
            this.lineaMedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineaMedio.BackColor = System.Drawing.Color.White;
            this.lineaMedio.ForeColor = System.Drawing.Color.White;
            this.lineaMedio.Location = new System.Drawing.Point(436, 95);
            this.lineaMedio.Name = "lineaMedio";
            this.lineaMedio.Size = new System.Drawing.Size(1, 300);
            this.lineaMedio.TabIndex = 14;
            this.lineaMedio.TabStop = false;
            this.lineaMedio.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(536, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lineaMedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNoTienesCuenta);
            this.Controls.Add(this.passShow);
            this.Controls.Add(this.passHide);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblOlvidastePassword);
            this.Controls.Add(this.lblErrorMessagge);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormLogin";
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaTextBox txtuser;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaLabel lblErrorMessagge;
        private System.Windows.Forms.LinkLabel lblOlvidastePassword;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.PictureBox passShow;
        private System.Windows.Forms.PictureBox passHide;
        private System.Windows.Forms.Label lblNoTienesCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox lineaMedio;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

