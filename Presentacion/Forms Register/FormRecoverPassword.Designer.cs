
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
            this.SuspendLayout();
            // 
            // lblUserOrEmail
            // 
            this.lblUserOrEmail.AutoSize = true;
            this.lblUserOrEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserOrEmail.Location = new System.Drawing.Point(76, 60);
            this.lblUserOrEmail.Name = "lblUserOrEmail";
            this.lblUserOrEmail.Size = new System.Drawing.Size(144, 15);
            this.lblUserOrEmail.TabIndex = 0;
            this.lblUserOrEmail.Text = "Ingresa tu Usuario o Email";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.BaseColor = System.Drawing.Color.White;
            this.txtUserRequest.BorderColor = System.Drawing.Color.Silver;
            this.txtUserRequest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserRequest.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserRequest.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserRequest.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserRequest.Location = new System.Drawing.Point(53, 189);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.PasswordChar = '\0';
            this.txtUserRequest.Size = new System.Drawing.Size(160, 30);
            this.txtUserRequest.TabIndex = 1;
            this.txtUserRequest.Text = "gunaTextBox1";
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.Location = new System.Drawing.Point(272, 306);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Size = new System.Drawing.Size(160, 42);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResult.Location = new System.Drawing.Point(76, 333);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";
            // 
            // FormRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserRequest);
            this.Controls.Add(this.lblUserOrEmail);
            this.Name = "FormRecoverPassword";
            this.Text = "FormRecoverPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblUserOrEmail;
        private Guna.UI.WinForms.GunaTextBox txtUserRequest;
        private Guna.UI.WinForms.GunaButton btnSend;
        private Guna.UI.WinForms.GunaLabel lblResult;
    }
}