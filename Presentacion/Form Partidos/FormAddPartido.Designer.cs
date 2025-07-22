
namespace Presentacion
{
    partial class FormAddPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPartido));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtUbicacion = new Guna.UI.WinForms.GunaTextBox();
            this.txtEquipoLocal = new Guna.UI.WinForms.GunaTextBox();
            this.txtEquipoVisitante = new Guna.UI.WinForms.GunaTextBox();
            this.txtObservaciones = new Guna.UI.WinForms.GunaTextBox();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(67, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(73, 161);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(94, 20);
            this.dtpHora.TabIndex = 2;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BaseColor = System.Drawing.Color.White;
            this.txtUbicacion.BorderColor = System.Drawing.Color.Silver;
            this.txtUbicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUbicacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUbicacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUbicacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUbicacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUbicacion.Location = new System.Drawing.Point(73, 228);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.PasswordChar = '\0';
            this.txtUbicacion.Size = new System.Drawing.Size(144, 26);
            this.txtUbicacion.TabIndex = 3;
            this.txtUbicacion.Text = "Ubicacion";
            // 
            // txtEquipoLocal
            // 
            this.txtEquipoLocal.BaseColor = System.Drawing.Color.White;
            this.txtEquipoLocal.BorderColor = System.Drawing.Color.Silver;
            this.txtEquipoLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEquipoLocal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEquipoLocal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEquipoLocal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEquipoLocal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEquipoLocal.Location = new System.Drawing.Point(73, 271);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.PasswordChar = '\0';
            this.txtEquipoLocal.Size = new System.Drawing.Size(144, 26);
            this.txtEquipoLocal.TabIndex = 4;
            this.txtEquipoLocal.Text = "Local";
            // 
            // txtEquipoVisitante
            // 
            this.txtEquipoVisitante.BaseColor = System.Drawing.Color.White;
            this.txtEquipoVisitante.BorderColor = System.Drawing.Color.Silver;
            this.txtEquipoVisitante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEquipoVisitante.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEquipoVisitante.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEquipoVisitante.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEquipoVisitante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEquipoVisitante.Location = new System.Drawing.Point(73, 319);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.PasswordChar = '\0';
            this.txtEquipoVisitante.Size = new System.Drawing.Size(144, 26);
            this.txtEquipoVisitante.TabIndex = 5;
            this.txtEquipoVisitante.Text = "Visitante";
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
            this.txtObservaciones.Location = new System.Drawing.Point(73, 366);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.Size = new System.Drawing.Size(144, 26);
            this.txtObservaciones.TabIndex = 6;
            this.txtObservaciones.Text = "Observaciones";
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
            this.btnGuardar.Location = new System.Drawing.Point(250, 396);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(160, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(528, 269);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // FormAddPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtEquipoVisitante);
            this.Controls.Add(this.txtEquipoLocal);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FormAddPartido";
            this.Text = "FormAddPartido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private Guna.UI.WinForms.GunaTextBox txtUbicacion;
        private Guna.UI.WinForms.GunaTextBox txtEquipoLocal;
        private Guna.UI.WinForms.GunaTextBox txtEquipoVisitante;
        private Guna.UI.WinForms.GunaTextBox txtObservaciones;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}