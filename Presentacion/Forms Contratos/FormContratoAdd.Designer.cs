﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContratoAdd));
            this.txtMonto = new Guna.UI.WinForms.GunaTextBox();
            this.txtClausula = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregarContrato = new Guna.UI.WinForms.GunaButton();
            this.dtFechaInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtFechaFinal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtIdJugador = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.NombreJugContrato = new Guna.UI.WinForms.GunaLabel();
            this.txtSalario = new Guna.UI.WinForms.GunaTextBox();
            this.txtBonificacion = new Guna.UI.WinForms.GunaTextBox();
            this.txtObligacion = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.BaseColor = System.Drawing.Color.White;
            this.txtMonto.BorderColor = System.Drawing.Color.Silver;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMonto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMonto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonto.Location = new System.Drawing.Point(117, 236);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.Size = new System.Drawing.Size(160, 30);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.Text = "Monto";
            // 
            // txtClausula
            // 
            this.txtClausula.BaseColor = System.Drawing.Color.White;
            this.txtClausula.BorderColor = System.Drawing.Color.Silver;
            this.txtClausula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClausula.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClausula.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtClausula.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClausula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClausula.Location = new System.Drawing.Point(117, 288);
            this.txtClausula.Name = "txtClausula";
            this.txtClausula.PasswordChar = '\0';
            this.txtClausula.Size = new System.Drawing.Size(160, 30);
            this.txtClausula.TabIndex = 3;
            this.txtClausula.Text = "Clausula";
            // 
            // btnAgregarContrato
            // 
            this.btnAgregarContrato.AnimationHoverSpeed = 0.07F;
            this.btnAgregarContrato.AnimationSpeed = 0.03F;
            this.btnAgregarContrato.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAgregarContrato.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarContrato.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarContrato.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarContrato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarContrato.ForeColor = System.Drawing.Color.White;
            this.btnAgregarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarContrato.Image")));
            this.btnAgregarContrato.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarContrato.Location = new System.Drawing.Point(117, 357);
            this.btnAgregarContrato.Name = "btnAgregarContrato";
            this.btnAgregarContrato.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarContrato.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarContrato.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarContrato.OnHoverImage = null;
            this.btnAgregarContrato.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarContrato.Size = new System.Drawing.Size(160, 42);
            this.btnAgregarContrato.TabIndex = 4;
            this.btnAgregarContrato.Text = "Agregar Contrato";
            this.btnAgregarContrato.Click += new System.EventHandler(this.btnAgregarContrato_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.BaseColor = System.Drawing.Color.White;
            this.dtFechaInicio.BorderColor = System.Drawing.Color.Silver;
            this.dtFechaInicio.Checked = false;
            this.dtFechaInicio.CustomFormat = null;
            this.dtFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFechaInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.dtFechaInicio.Location = new System.Drawing.Point(117, 129);
            this.dtFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtFechaInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaInicio.OnPressedColor = System.Drawing.Color.Black;
            this.dtFechaInicio.Size = new System.Drawing.Size(223, 30);
            this.dtFechaInicio.TabIndex = 5;
            this.dtFechaInicio.Text = "lunes, 24 de febrero de 2025";
            this.dtFechaInicio.Value = new System.DateTime(2025, 2, 19, 16, 34, 31, 864);
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.BaseColor = System.Drawing.Color.White;
            this.dtFechaFinal.BorderColor = System.Drawing.Color.Silver;
            this.dtFechaFinal.CustomFormat = null;
            this.dtFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFechaFinal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.dtFechaFinal.Location = new System.Drawing.Point(117, 182);
            this.dtFechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtFechaFinal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaFinal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtFechaFinal.OnPressedColor = System.Drawing.Color.Black;
            this.dtFechaFinal.Size = new System.Drawing.Size(223, 30);
            this.dtFechaFinal.TabIndex = 6;
            this.dtFechaFinal.Text = "miércoles, 19 de febrero de 2025";
            this.dtFechaFinal.Value = new System.DateTime(2025, 2, 19, 16, 34, 31, 864);
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.BaseColor = System.Drawing.Color.White;
            this.txtIdJugador.BorderColor = System.Drawing.Color.Silver;
            this.txtIdJugador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdJugador.Enabled = false;
            this.txtIdJugador.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdJugador.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdJugador.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdJugador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdJugador.Location = new System.Drawing.Point(117, 73);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.PasswordChar = '\0';
            this.txtIdJugador.Size = new System.Drawing.Size(160, 30);
            this.txtIdJugador.TabIndex = 7;
            this.txtIdJugador.Text = "Id jugdaor";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 15);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Añadir contrato a";
            // 
            // NombreJugContrato
            // 
            this.NombreJugContrato.AutoSize = true;
            this.NombreJugContrato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NombreJugContrato.Location = new System.Drawing.Point(117, 9);
            this.NombreJugContrato.Name = "NombreJugContrato";
            this.NombreJugContrato.Size = new System.Drawing.Size(59, 15);
            this.NombreJugContrato.TabIndex = 9;
            this.NombreJugContrato.Text = "[Nombre]";
            this.NombreJugContrato.Visible = false;
            // 
            // txtSalario
            // 
            this.txtSalario.BaseColor = System.Drawing.Color.White;
            this.txtSalario.BorderColor = System.Drawing.Color.Silver;
            this.txtSalario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSalario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSalario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalario.Location = new System.Drawing.Point(342, 236);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.PasswordChar = '\0';
            this.txtSalario.Size = new System.Drawing.Size(160, 30);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.Text = "Salario";
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.BaseColor = System.Drawing.Color.White;
            this.txtBonificacion.BorderColor = System.Drawing.Color.Silver;
            this.txtBonificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBonificacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBonificacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBonificacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBonificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBonificacion.Location = new System.Drawing.Point(342, 288);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.PasswordChar = '\0';
            this.txtBonificacion.Size = new System.Drawing.Size(160, 30);
            this.txtBonificacion.TabIndex = 11;
            this.txtBonificacion.Text = "Bonificacion";
            // 
            // txtObligacion
            // 
            this.txtObligacion.BaseColor = System.Drawing.Color.White;
            this.txtObligacion.BorderColor = System.Drawing.Color.Silver;
            this.txtObligacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObligacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtObligacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtObligacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObligacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObligacion.Location = new System.Drawing.Point(342, 334);
            this.txtObligacion.Name = "txtObligacion";
            this.txtObligacion.PasswordChar = '\0';
            this.txtObligacion.Size = new System.Drawing.Size(160, 30);
            this.txtObligacion.TabIndex = 12;
            this.txtObligacion.Text = "Obligacion";
            // 
            // FormContratoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.txtObligacion);
            this.Controls.Add(this.txtBonificacion);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.NombreJugContrato);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtIdJugador);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.btnAgregarContrato);
            this.Controls.Add(this.txtClausula);
            this.Controls.Add(this.txtMonto);
            this.Name = "FormContratoAdd";
            this.Text = "FormContratoAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtMonto;
        private Guna.UI.WinForms.GunaTextBox txtClausula;
        private Guna.UI.WinForms.GunaButton btnAgregarContrato;
        private Guna.UI.WinForms.GunaDateTimePicker dtFechaInicio;
        private Guna.UI.WinForms.GunaDateTimePicker dtFechaFinal;
        private Guna.UI.WinForms.GunaTextBox txtIdJugador;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel NombreJugContrato;
        private Guna.UI.WinForms.GunaTextBox txtSalario;
        private Guna.UI.WinForms.GunaTextBox txtBonificacion;
        private Guna.UI.WinForms.GunaTextBox txtObligacion;
    }
}