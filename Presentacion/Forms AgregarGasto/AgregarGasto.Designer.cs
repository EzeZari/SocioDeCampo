
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarGasto));
            this.CbTipoGasto = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.TBnota = new System.Windows.Forms.TextBox();
            this.Lbnota = new Guna.UI.WinForms.GunaLabel();
            this.btnAceptar = new Guna.UI.WinForms.GunaButton();
            this.dateTimePickerGasto = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // CbTipoGasto
            // 
            this.CbTipoGasto.BackColor = System.Drawing.Color.Transparent;
            this.CbTipoGasto.BaseColor = System.Drawing.Color.White;
            this.CbTipoGasto.BorderColor = System.Drawing.Color.Silver;
            this.CbTipoGasto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoGasto.FocusedColor = System.Drawing.Color.Empty;
            this.CbTipoGasto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbTipoGasto.ForeColor = System.Drawing.Color.Black;
            this.CbTipoGasto.FormattingEnabled = true;
            this.CbTipoGasto.Items.AddRange(new object[] {
            "Patrocionios ",
            "Sueldos de jugadores ",
            "Sueldos de personal ",
            "Mantenimientos ",
            "Servicios publicos ",
            "Alquileres ",
            "Trasportes",
            "Seguros de jugadores ",
            "Gastos de arbitrajes "});
            this.CbTipoGasto.Location = new System.Drawing.Point(95, 29);
            this.CbTipoGasto.Name = "CbTipoGasto";
            this.CbTipoGasto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbTipoGasto.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbTipoGasto.Size = new System.Drawing.Size(205, 31);
            this.CbTipoGasto.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(8, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Tipo Gasto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(306, 38);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBnota
            // 
            this.TBnota.Location = new System.Drawing.Point(12, 167);
            this.TBnota.Multiline = true;
            this.TBnota.Name = "TBnota";
            this.TBnota.Size = new System.Drawing.Size(414, 97);
            this.TBnota.TabIndex = 3;
            // 
            // Lbnota
            // 
            this.Lbnota.AutoSize = true;
            this.Lbnota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbnota.Location = new System.Drawing.Point(12, 144);
            this.Lbnota.Name = "Lbnota";
            this.Lbnota.Size = new System.Drawing.Size(42, 20);
            this.Lbnota.TabIndex = 4;
            this.Lbnota.Text = "Nota";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AnimationHoverSpeed = 0.07F;
            this.btnAceptar.AnimationSpeed = 0.03F;
            this.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAceptar.Location = new System.Drawing.Point(266, 270);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnHoverImage = null;
            this.btnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAceptar.Size = new System.Drawing.Size(160, 42);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dateTimePickerGasto
            // 
            this.dateTimePickerGasto.Location = new System.Drawing.Point(119, 91);
            this.dateTimePickerGasto.Name = "dateTimePickerGasto";
            this.dateTimePickerGasto.Size = new System.Drawing.Size(293, 22);
            this.dateTimePickerGasto.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(8, 93);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(89, 20);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Fecha Gasto";
            // 
            // AgregarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 355);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dateTimePickerGasto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Lbnota);
            this.Controls.Add(this.TBnota);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.CbTipoGasto);
            this.Name = "AgregarGasto";
            this.Text = "AgregarGasto";
            this.Load += new System.EventHandler(this.AgregarGasto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox CbTipoGasto;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox TBnota;
        private Guna.UI.WinForms.GunaLabel Lbnota;
        private Guna.UI.WinForms.GunaButton btnAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePickerGasto;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}