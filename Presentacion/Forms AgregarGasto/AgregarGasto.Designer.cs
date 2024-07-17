
namespace Presentacion
{
    partial class AgregarGasto
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.CbTipoGasto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.TBnota = new System.Windows.Forms.TextBox();
            this.Lbnota = new Guna.UI.WinForms.GunaLabel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dateTimePickerGasto = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(8, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tipo de Gasto ";
            // 
            // CbTipoGasto
            // 
            this.CbTipoGasto.FormattingEnabled = true;
            this.CbTipoGasto.Items.AddRange(new object[] {
            "Sueldos de jugadores ",
            "",
            "Alquiler de instalaciones",
            "",
            "Compra de uniformes",
            "",
            "Transporte para partidos",
            "",
            "Costos administrativos",
            "",
            "Publicidad",
            " ",
            "Inscripciones a torneos",
            "",
            "Atención médica",
            "",
            "Multas y sanciones",
            "",
            "Mantenimiento de instalaciones",
            "Compra de balones",
            "",
            "Alojamiento para jugadores y staff",
            "",
            "Renovaciones y mejoras"});
            this.CbTipoGasto.Location = new System.Drawing.Point(127, 25);
            this.CbTipoGasto.Name = "CbTipoGasto";
            this.CbTipoGasto.Size = new System.Drawing.Size(174, 24);
            this.CbTipoGasto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(318, 27);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBnota
            // 
            this.TBnota.Location = new System.Drawing.Point(12, 116);
            this.TBnota.Multiline = true;
            this.TBnota.Name = "TBnota";
            this.TBnota.Size = new System.Drawing.Size(406, 145);
            this.TBnota.TabIndex = 3;
            // 
            // Lbnota
            // 
            this.Lbnota.AutoSize = true;
            this.Lbnota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbnota.Location = new System.Drawing.Point(12, 93);
            this.Lbnota.Name = "Lbnota";
            this.Lbnota.Size = new System.Drawing.Size(42, 20);
            this.Lbnota.TabIndex = 4;
            this.Lbnota.Text = "Nota";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(340, 267);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 37);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // dateTimePickerGasto
            // 
            this.dateTimePickerGasto.Location = new System.Drawing.Point(127, 56);
            this.dateTimePickerGasto.Name = "dateTimePickerGasto";
            this.dateTimePickerGasto.Size = new System.Drawing.Size(291, 22);
            this.dateTimePickerGasto.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(12, 58);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 20);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Fecha Gasto ";
            // 
            // AgregarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 330);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dateTimePickerGasto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Lbnota);
            this.Controls.Add(this.TBnota);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.CbTipoGasto);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "AgregarGasto";
            this.Text = "AgregarGasto";
            this.Load += new System.EventHandler(this.AgregarGasto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ComboBox CbTipoGasto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox TBnota;
        private Guna.UI.WinForms.GunaLabel Lbnota;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePickerGasto;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}