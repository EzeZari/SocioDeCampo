
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(311, 190);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(211, 50);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "PRINCIPAL";
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(54, 379);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(160, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Salir";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnLogout;
    }
}