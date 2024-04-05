
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
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.BaseColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(95, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.Size = new System.Drawing.Size(160, 30);
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
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.Location = new System.Drawing.Point(289, 36);
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
            this.txtLoginName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLoginName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginName.Location = new System.Drawing.Point(95, 114);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.Size = new System.Drawing.Size(160, 30);
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
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(95, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Size = new System.Drawing.Size(160, 30);
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
            this.txtPosition.Location = new System.Drawing.Point(95, 260);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPosition.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtPosition.Size = new System.Drawing.Size(160, 26);
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
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(289, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Size = new System.Drawing.Size(160, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // txtPasswordRepeat
            // 
            this.txtPasswordRepeat.BaseColor = System.Drawing.Color.White;
            this.txtPasswordRepeat.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordRepeat.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasswordRepeat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPasswordRepeat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordRepeat.Location = new System.Drawing.Point(289, 260);
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";
            this.txtPasswordRepeat.PasswordChar = '\0';
            this.txtPasswordRepeat.Size = new System.Drawing.Size(160, 30);
            this.txtPasswordRepeat.TabIndex = 6;
            this.txtPasswordRepeat.TextChanged += new System.EventHandler(this.txtFull_TextChanged);
            this.txtPasswordRepeat.Leave += new System.EventHandler(this.TextEmpty_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.AnimationHoverSpeed = 0.07F;
            this.btnRegister.AnimationSpeed = 0.03F;
            this.btnRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegister.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegister.Location = new System.Drawing.Point(250, 389);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegister.OnHoverImage = null;
            this.btnRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegister.Size = new System.Drawing.Size(149, 37);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(92, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(286, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Apellido";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(92, 98);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(98, 13);
            this.lblLoginName.TabIndex = 11;
            this.lblLoginName.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Puesto de trabajo";
            // 
            // lblCorreoelectronico
            // 
            this.lblCorreoelectronico.AutoSize = true;
            this.lblCorreoelectronico.Location = new System.Drawing.Point(98, 165);
            this.lblCorreoelectronico.Name = "lblCorreoelectronico";
            this.lblCorreoelectronico.Size = new System.Drawing.Size(93, 13);
            this.lblCorreoelectronico.TabIndex = 13;
            this.lblCorreoelectronico.Text = "Correo electronico";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(286, 165);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 14;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Location = new System.Drawing.Point(286, 244);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(97, 13);
            this.lblRepeatPass.TabIndex = 15;
            this.lblRepeatPass.Text = "Repetir contraseña";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreoelectronico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPasswordRepeat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
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
    }
}