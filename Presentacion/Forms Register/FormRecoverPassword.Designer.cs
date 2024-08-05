
namespace Presentacion
{
    partial class FormRecoverPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecoverPassword));
            this.lblUserOrEmail = new Guna.UI.WinForms.GunaLabel();
            this.txtUserRequest = new Guna.UI.WinForms.GunaTextBox();
            this.btnSend = new Guna.UI.WinForms.GunaButton();
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserOrEmail
            // 
            this.lblUserOrEmail.AutoSize = true;
            this.lblUserOrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOrEmail.ForeColor = System.Drawing.Color.White;
            this.lblUserOrEmail.Location = new System.Drawing.Point(19, 168);
            this.lblUserOrEmail.Name = "lblUserOrEmail";
            this.lblUserOrEmail.Size = new System.Drawing.Size(182, 18);
            this.lblUserOrEmail.TabIndex = 0;
            this.lblUserOrEmail.Text = "Ingresa tu Usuario o Email";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.BaseColor = System.Drawing.Color.White;
            this.txtUserRequest.BorderColor = System.Drawing.Color.Silver;
            this.txtUserRequest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserRequest.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserRequest.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(176)))));
            this.txtUserRequest.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserRequest.ForeColor = System.Drawing.Color.Black;
            this.txtUserRequest.Location = new System.Drawing.Point(22, 200);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.PasswordChar = '\0';
            this.txtUserRequest.Size = new System.Drawing.Size(272, 30);
            this.txtUserRequest.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(176)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = null;
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.Location = new System.Drawing.Point(75, 265);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Size = new System.Drawing.Size(172, 42);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Restablecer Contraseña";
            this.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(19, 320);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserRequest);
            this.Controls.Add(this.lblUserOrEmail);
            this.Name = "FormRecoverPassword";
            this.Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblUserOrEmail;
        private Guna.UI.WinForms.GunaTextBox txtUserRequest;
        private Guna.UI.WinForms.GunaButton btnSend;
        private Guna.UI.WinForms.GunaLabel lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}