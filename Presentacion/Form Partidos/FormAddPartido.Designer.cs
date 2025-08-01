
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtUbicacion = new Guna.UI.WinForms.GunaTextBox();
            this.txtEquipoLocal = new Guna.UI.WinForms.GunaTextBox();
            this.txtEquipoVisitante = new Guna.UI.WinForms.GunaTextBox();
            this.txtObservaciones = new Guna.UI.WinForms.GunaTextBox();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.txtEstadio = new Guna.UI.WinForms.GunaTextBox();
            this.nudNumeroFecha = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(30, 76);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(144, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(214, 72);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(144, 20);
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
            this.txtUbicacion.Location = new System.Drawing.Point(31, 131);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.PasswordChar = '\0';
            this.txtUbicacion.Size = new System.Drawing.Size(144, 26);
            this.txtUbicacion.TabIndex = 3;
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
            this.txtEquipoLocal.Location = new System.Drawing.Point(31, 200);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.PasswordChar = '\0';
            this.txtEquipoLocal.Size = new System.Drawing.Size(144, 26);
            this.txtEquipoLocal.TabIndex = 4;
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
            this.txtEquipoVisitante.Location = new System.Drawing.Point(214, 200);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.PasswordChar = '\0';
            this.txtEquipoVisitante.Size = new System.Drawing.Size(144, 26);
            this.txtEquipoVisitante.TabIndex = 5;
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
            this.txtObservaciones.Location = new System.Drawing.Point(214, 252);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.Size = new System.Drawing.Size(143, 65);
            this.txtObservaciones.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(133, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(126, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEstadio
            // 
            this.txtEstadio.BaseColor = System.Drawing.Color.White;
            this.txtEstadio.BorderColor = System.Drawing.Color.Silver;
            this.txtEstadio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstadio.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstadio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEstadio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstadio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstadio.Location = new System.Drawing.Point(214, 127);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.PasswordChar = '\0';
            this.txtEstadio.Size = new System.Drawing.Size(144, 30);
            this.txtEstadio.TabIndex = 11;
            // 
            // nudNumeroFecha
            // 
            this.nudNumeroFecha.Location = new System.Drawing.Point(31, 271);
            this.nudNumeroFecha.Name = "nudNumeroFecha";
            this.nudNumeroFecha.Size = new System.Drawing.Size(143, 20);
            this.nudNumeroFecha.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 2);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Agregar Partido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha del partido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hora del partido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ubicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Equipo local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Equipo visitante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(212, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Estadio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Número de Fecha (jornada)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Observaciones (opcional)";
            // 
            // FormAddPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 416);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNumeroFecha);
            this.Controls.Add(this.txtEstadio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtEquipoVisitante);
            this.Controls.Add(this.txtEquipoLocal);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FormAddPartido";
            this.Text = "FormAddPartido";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFecha)).EndInit();
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
        private Guna.UI.WinForms.GunaTextBox txtEstadio;
        private System.Windows.Forms.NumericUpDown nudNumeroFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}