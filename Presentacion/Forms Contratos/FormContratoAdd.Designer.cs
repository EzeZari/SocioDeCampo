
namespace Presentacion.Forms_Contratos
{
    partial class FormContratoAdd
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
            this.txtMonto = new Guna.UI.WinForms.GunaTextBox();
            this.txtClausula = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregarContrato = new Guna.UI.WinForms.GunaButton();
            this.dtFechaInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtIdJugador = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombre = new Guna.UI.WinForms.GunaLabel();
            this.txtSalario = new Guna.UI.WinForms.GunaTextBox();
            this.txtBonificacion = new Guna.UI.WinForms.GunaTextBox();
            this.txtObligacion = new Guna.UI.WinForms.GunaTextBox();
            this.dtFechaFinal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.BaseColor = System.Drawing.Color.White;
            this.txtMonto.BorderColor = System.Drawing.Color.Silver;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMonto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.txtMonto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonto.Location = new System.Drawing.Point(50, 143);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.Size = new System.Drawing.Size(223, 30);
            this.txtMonto.TabIndex = 2;
            // 
            // txtClausula
            // 
            this.txtClausula.BaseColor = System.Drawing.Color.White;
            this.txtClausula.BorderColor = System.Drawing.Color.Silver;
            this.txtClausula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClausula.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClausula.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.txtClausula.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClausula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClausula.Location = new System.Drawing.Point(50, 340);
            this.txtClausula.Name = "txtClausula";
            this.txtClausula.PasswordChar = '\0';
            this.txtClausula.Size = new System.Drawing.Size(223, 30);
            this.txtClausula.TabIndex = 5;
            // 
            // btnAgregarContrato
            // 
            this.btnAgregarContrato.AnimationHoverSpeed = 0.07F;
            this.btnAgregarContrato.AnimationSpeed = 0.03F;
            this.btnAgregarContrato.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnAgregarContrato.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarContrato.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarContrato.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarContrato.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarContrato.ForeColor = System.Drawing.Color.White;
            this.btnAgregarContrato.Image = null;
            this.btnAgregarContrato.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarContrato.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarContrato.Location = new System.Drawing.Point(226, 407);
            this.btnAgregarContrato.Name = "btnAgregarContrato";
            this.btnAgregarContrato.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnAgregarContrato.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarContrato.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarContrato.OnHoverImage = null;
            this.btnAgregarContrato.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarContrato.Size = new System.Drawing.Size(160, 42);
            this.btnAgregarContrato.TabIndex = 4;
            this.btnAgregarContrato.Text = "Agregar Contrato";
            this.btnAgregarContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarContrato.Click += new System.EventHandler(this.btnAgregarContrato_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.BaseColor = System.Drawing.Color.White;
            this.dtFechaInicio.BorderColor = System.Drawing.Color.Silver;
            this.dtFechaInicio.Checked = false;
            this.dtFechaInicio.CustomFormat = null;
            this.dtFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFechaInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dtFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.dtFechaInicio.Location = new System.Drawing.Point(50, 204);
            this.dtFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtFechaInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaInicio.OnPressedColor = System.Drawing.Color.Black;
            this.dtFechaInicio.ShowCheckBox = true;
            this.dtFechaInicio.Size = new System.Drawing.Size(223, 30);
            this.dtFechaInicio.TabIndex = 3;
            this.dtFechaInicio.Text = "sábado, 8 de marzo de 2025";
            this.dtFechaInicio.Value = new System.DateTime(2025, 2, 19, 16, 34, 31, 864);
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.BaseColor = System.Drawing.Color.White;
            this.txtIdJugador.BorderColor = System.Drawing.Color.Silver;
            this.txtIdJugador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdJugador.Enabled = false;
            this.txtIdJugador.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdJugador.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.txtIdJugador.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdJugador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdJugador.Location = new System.Drawing.Point(50, 87);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.PasswordChar = '\0';
            this.txtIdJugador.Size = new System.Drawing.Size(223, 30);
            this.txtIdJugador.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(191, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(78, 21);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "[Nombre]";
            // 
            // txtSalario
            // 
            this.txtSalario.BaseColor = System.Drawing.Color.White;
            this.txtSalario.BorderColor = System.Drawing.Color.Silver;
            this.txtSalario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSalario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.txtSalario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalario.Location = new System.Drawing.Point(325, 89);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.PasswordChar = '\0';
            this.txtSalario.Size = new System.Drawing.Size(223, 30);
            this.txtSalario.TabIndex = 6;
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.BaseColor = System.Drawing.Color.White;
            this.txtBonificacion.BorderColor = System.Drawing.Color.Silver;
            this.txtBonificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBonificacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBonificacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.txtBonificacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBonificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBonificacion.Location = new System.Drawing.Point(325, 143);
            this.txtBonificacion.MultiLine = true;
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.PasswordChar = '\0';
            this.txtBonificacion.Size = new System.Drawing.Size(223, 95);
            this.txtBonificacion.TabIndex = 7;
            // 
            // txtObligacion
            // 
            this.txtObligacion.BaseColor = System.Drawing.Color.White;
            this.txtObligacion.BorderColor = System.Drawing.Color.Silver;
            this.txtObligacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObligacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtObligacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.txtObligacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObligacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObligacion.Location = new System.Drawing.Point(325, 267);
            this.txtObligacion.MultiLine = true;
            this.txtObligacion.Name = "txtObligacion";
            this.txtObligacion.PasswordChar = '\0';
            this.txtObligacion.Size = new System.Drawing.Size(223, 103);
            this.txtObligacion.TabIndex = 8;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.BaseColor = System.Drawing.Color.White;
            this.dtFechaFinal.BorderColor = System.Drawing.Color.Silver;
            this.dtFechaFinal.Checked = false;
            this.dtFechaFinal.CustomFormat = null;
            this.dtFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFechaFinal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dtFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.dtFechaFinal.Location = new System.Drawing.Point(50, 267);
            this.dtFechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaFinal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtFechaFinal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaFinal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaFinal.OnPressedColor = System.Drawing.Color.Black;
            this.dtFechaFinal.ShowCheckBox = true;
            this.dtFechaFinal.Size = new System.Drawing.Size(223, 30);
            this.dtFechaFinal.TabIndex = 4;
            this.dtFechaFinal.Text = "sábado, 8 de marzo de 2025";
            this.dtFechaFinal.Value = new System.DateTime(2025, 2, 19, 16, 34, 31, 864);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 2);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Añadir Contrato  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id Jugador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Monto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Inicio de Contrato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fin de Contrato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Clausula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Salario por Mes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Bonificaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Obligaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "-";
            // 
            // FormContratoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 476);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.txtObligacion);
            this.Controls.Add(this.txtBonificacion);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdJugador);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.btnAgregarContrato);
            this.Controls.Add(this.txtClausula);
            this.Controls.Add(this.txtMonto);
            this.Name = "FormContratoAdd";
            this.Text = "Añadir Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtMonto;
        private Guna.UI.WinForms.GunaTextBox txtClausula;
        private Guna.UI.WinForms.GunaButton btnAgregarContrato;
        private Guna.UI.WinForms.GunaDateTimePicker dtFechaInicio;
        private Guna.UI.WinForms.GunaTextBox txtIdJugador;
        private Guna.UI.WinForms.GunaLabel txtNombre;
        private Guna.UI.WinForms.GunaTextBox txtSalario;
        private Guna.UI.WinForms.GunaTextBox txtBonificacion;
        private Guna.UI.WinForms.GunaTextBox txtObligacion;
        private Guna.UI.WinForms.GunaDateTimePicker dtFechaFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}