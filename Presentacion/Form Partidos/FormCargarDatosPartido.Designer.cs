
namespace Presentacion
{
    partial class FormCargarDatosPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarDatosPartido));
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblVisitante = new System.Windows.Forms.Label();
            this.txtResultadoLocal = new Guna.UI.WinForms.GunaTextBox();
            this.txtResultadoVisitante = new Guna.UI.WinForms.GunaTextBox();
            this.txtObservaciones = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(102, 102);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(35, 13);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "label1";
            // 
            // lblVisitante
            // 
            this.lblVisitante.AutoSize = true;
            this.lblVisitante.Location = new System.Drawing.Point(292, 102);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(35, 13);
            this.lblVisitante.TabIndex = 1;
            this.lblVisitante.Text = "label1";
            // 
            // txtResultadoLocal
            // 
            this.txtResultadoLocal.BaseColor = System.Drawing.Color.White;
            this.txtResultadoLocal.BorderColor = System.Drawing.Color.Silver;
            this.txtResultadoLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultadoLocal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResultadoLocal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtResultadoLocal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultadoLocal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultadoLocal.Location = new System.Drawing.Point(108, 226);
            this.txtResultadoLocal.Name = "txtResultadoLocal";
            this.txtResultadoLocal.PasswordChar = '\0';
            this.txtResultadoLocal.Size = new System.Drawing.Size(160, 30);
            this.txtResultadoLocal.TabIndex = 2;
            this.txtResultadoLocal.Text = "gunaTextBox1";
            // 
            // txtResultadoVisitante
            // 
            this.txtResultadoVisitante.BaseColor = System.Drawing.Color.White;
            this.txtResultadoVisitante.BorderColor = System.Drawing.Color.Silver;
            this.txtResultadoVisitante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultadoVisitante.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResultadoVisitante.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtResultadoVisitante.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultadoVisitante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultadoVisitante.Location = new System.Drawing.Point(108, 292);
            this.txtResultadoVisitante.Name = "txtResultadoVisitante";
            this.txtResultadoVisitante.PasswordChar = '\0';
            this.txtResultadoVisitante.Size = new System.Drawing.Size(160, 30);
            this.txtResultadoVisitante.TabIndex = 3;
            this.txtResultadoVisitante.Text = "gunaTextBox1";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BaseColor = System.Drawing.Color.White;
            this.txtObservaciones.BorderColor = System.Drawing.Color.Silver;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.FocusedBaseColor = System.Drawing.Color.White;
            this.txtObservaciones.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtObservaciones.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.Location = new System.Drawing.Point(108, 355);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.Size = new System.Drawing.Size(160, 30);
            this.txtObservaciones.TabIndex = 4;
            this.txtObservaciones.Text = "gunaTextBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado Visitante:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(397, 396);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(160, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormCargarDatosPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtResultadoVisitante);
            this.Controls.Add(this.txtResultadoLocal);
            this.Controls.Add(this.lblVisitante);
            this.Controls.Add(this.lblLocal);
            this.Name = "FormCargarDatosPartido";
            this.Text = "FormCargarDatosPartido";
            this.Load += new System.EventHandler(this.FormCargarDatosPartido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblVisitante;
        private Guna.UI.WinForms.GunaTextBox txtResultadoLocal;
        private Guna.UI.WinForms.GunaTextBox txtResultadoVisitante;
        private Guna.UI.WinForms.GunaTextBox txtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnGuardar;
    }
}