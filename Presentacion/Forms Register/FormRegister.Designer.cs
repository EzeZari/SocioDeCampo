
namespace Presentacion
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.txtLoginName = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtPosition = new Guna.UI.WinForms.GunaComboBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtPasswordRepeat = new Guna.UI.WinForms.GunaTextBox();
            this.btnRegister = new Guna.UI.WinForms.GunaButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorreoelectronico = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.gBoxTxt = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.BaseColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.txtFirstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(23, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.Size = new System.Drawing.Size(140, 30);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            this.txtFirstName.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.BaseColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.txtLastName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(217, 23);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.Size = new System.Drawing.Size(160, 30);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            this.txtLastName.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // txtLoginName
            // 
            this.txtLoginName.BaseColor = System.Drawing.Color.White;
            this.txtLoginName.BorderColor = System.Drawing.Color.Silver;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLoginName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.txtLoginName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginName.ForeColor = System.Drawing.Color.Black;
            this.txtLoginName.Location = new System.Drawing.Point(23, 101);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.Size = new System.Drawing.Size(354, 30);
            this.txtLoginName.TabIndex = 2;
            this.txtLoginName.TextChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtLoginName.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(23, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Size = new System.Drawing.Size(354, 30);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.Transparent;
            this.txtPosition.BaseColor = System.Drawing.Color.White;
            this.txtPosition.BorderColor = System.Drawing.Color.Silver;
            this.txtPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPosition.FocusedColor = System.Drawing.Color.Empty;
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.FormattingEnabled = true;
            this.txtPosition.Items.AddRange(new object[] {
            "Entrenador",
            "Ayudante de campo"});
            this.txtPosition.Location = new System.Drawing.Point(23, 247);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPosition.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtPosition.Size = new System.Drawing.Size(354, 26);
            this.txtPosition.TabIndex = 4;
            this.txtPosition.SelectedIndexChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtPosition.Leave += new System.EventHandler(this.ComboBoxEmpty_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(23, 322);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Size = new System.Drawing.Size(354, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.passwordLogic_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // txtPasswordRepeat
            // 
            this.txtPasswordRepeat.BaseColor = System.Drawing.Color.White;
            this.txtPasswordRepeat.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordRepeat.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasswordRepeat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.txtPasswordRepeat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordRepeat.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordRepeat.Location = new System.Drawing.Point(23, 394);
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";
            this.txtPasswordRepeat.PasswordChar = '\0';
            this.txtPasswordRepeat.Size = new System.Drawing.Size(354, 30);
            this.txtPasswordRepeat.TabIndex = 6;
            this.txtPasswordRepeat.TextChanged += new System.EventHandler(this.txtPasswordRepeat_TextChanged);
            this.txtPasswordRepeat.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegister.AnimationHoverSpeed = 0.07F;
            this.btnRegister.AnimationSpeed = 0.03F;
            this.btnRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(176)))));
            this.btnRegister.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = null;
            this.btnRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegister.Location = new System.Drawing.Point(25, 500);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegister.OnHoverImage = null;
            this.btnRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegister.Size = new System.Drawing.Size(354, 37);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(214, 7);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Apellido";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Location = new System.Drawing.Point(20, 85);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(98, 13);
            this.lblLoginName.TabIndex = 11;
            this.lblLoginName.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Puesto de trabajo";
            // 
            // lblCorreoelectronico
            // 
            this.lblCorreoelectronico.AutoSize = true;
            this.lblCorreoelectronico.ForeColor = System.Drawing.Color.White;
            this.lblCorreoelectronico.Location = new System.Drawing.Point(26, 152);
            this.lblCorreoelectronico.Name = "lblCorreoelectronico";
            this.lblCorreoelectronico.Size = new System.Drawing.Size(93, 13);
            this.lblCorreoelectronico.TabIndex = 13;
            this.lblCorreoelectronico.Text = "Correo electronico";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(20, 308);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 14;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.ForeColor = System.Drawing.Color.White;
            this.lblRepeatPass.Location = new System.Drawing.Point(20, 378);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(97, 13);
            this.lblRepeatPass.TabIndex = 15;
            this.lblRepeatPass.Text = "Repetir contraseña";
            // 
            // gBoxTxt
            // 
            this.gBoxTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBoxTxt.Controls.Add(this.lblRepeatPass);
            this.gBoxTxt.Controls.Add(this.lblContraseña);
            this.gBoxTxt.Controls.Add(this.lblCorreoelectronico);
            this.gBoxTxt.Controls.Add(this.label2);
            this.gBoxTxt.Controls.Add(this.lblLoginName);
            this.gBoxTxt.Controls.Add(this.lblLastName);
            this.gBoxTxt.Controls.Add(this.lblName);
            this.gBoxTxt.Controls.Add(this.txtPasswordRepeat);
            this.gBoxTxt.Controls.Add(this.txtPassword);
            this.gBoxTxt.Controls.Add(this.txtPosition);
            this.gBoxTxt.Controls.Add(this.txtEmail);
            this.gBoxTxt.Controls.Add(this.txtLoginName);
            this.gBoxTxt.Controls.Add(this.txtLastName);
            this.gBoxTxt.Controls.Add(this.txtFirstName);
            this.gBoxTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxTxt.ForeColor = System.Drawing.Color.Transparent;
            this.gBoxTxt.Location = new System.Drawing.Point(7, 37);
            this.gBoxTxt.Name = "gBoxTxt";
            this.gBoxTxt.Size = new System.Drawing.Size(385, 457);
            this.gBoxTxt.TabIndex = 16;
            this.gBoxTxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrarse";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(404, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxTxt);
            this.Controls.Add(this.btnRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.gBoxTxt.ResumeLayout(false);
            this.gBoxTxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private Guna.UI.WinForms.GunaTextBox txtLoginName;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaComboBox txtPosition;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtPasswordRepeat;
        private Guna.UI.WinForms.GunaButton btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorreoelectronico;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.GroupBox gBoxTxt;
        private System.Windows.Forms.Label label1;
    }
}