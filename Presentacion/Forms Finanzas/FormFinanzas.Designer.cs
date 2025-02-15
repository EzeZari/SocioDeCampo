
namespace Presentacion
{
    partial class FormFinanzas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.DTPFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnReporte = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarIngresos = new Guna.UI.WinForms.GunaButton();
            this.btnAgregarIngreso = new Guna.UI.WinForms.GunaButton();
            this.dtpFechaHastaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdeIngreso = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dvgIngresos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(592, 25);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 37);
            this.gunaLabel1.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 172);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(764, 431);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(7, 114);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Fecha Desde";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(446, 115);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Fecha Hasta";
            // 
            // DTPFechaDesde
            // 
            this.DTPFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaDesde.Location = new System.Drawing.Point(12, 144);
            this.DTPFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFechaDesde.Name = "DTPFechaDesde";
            this.DTPFechaDesde.Size = new System.Drawing.Size(200, 26);
            this.DTPFechaDesde.TabIndex = 4;
            this.DTPFechaDesde.ValueChanged += new System.EventHandler(this.DTPFechaDesde_ValueChanged);
            // 
            // DTPFechaHasta
            // 
            this.DTPFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaHasta.Location = new System.Drawing.Point(451, 142);
            this.DTPFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFechaHasta.Name = "DTPFechaHasta";
            this.DTPFechaHasta.Size = new System.Drawing.Size(200, 26);
            this.DTPFechaHasta.TabIndex = 5;
            this.DTPFechaHasta.ValueChanged += new System.EventHandler(this.DTPFechaHasta_ValueChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1509, 2);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gestion de Finanzas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.BaseColor = System.Drawing.Color.Green;
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = null;
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(20, 623);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Size = new System.Drawing.Size(160, 49);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEliminar.AnimationHoverSpeed = 0.07F;
            this.BtnEliminar.AnimationSpeed = 0.03F;
            this.BtnEliminar.BaseColor = System.Drawing.Color.Red;
            this.BtnEliminar.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = null;
            this.BtnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEliminar.Location = new System.Drawing.Point(225, 623);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Size = new System.Drawing.Size(160, 49);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AnimationHoverSpeed = 0.07F;
            this.btnReporte.AnimationSpeed = 0.03F;
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.BaseColor = System.Drawing.Color.Transparent;
            this.btnReporte.BorderColor = System.Drawing.Color.Black;
            this.btnReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReporte.FocusedColor = System.Drawing.Color.Empty;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Image = null;
            this.btnReporte.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReporte.Location = new System.Drawing.Point(1372, 25);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReporte.OnHoverImage = null;
            this.btnReporte.OnPressedColor = System.Drawing.Color.Black;
            this.btnReporte.Size = new System.Drawing.Size(135, 21);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "Generar informe";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnEliminarIngresos
            // 
            this.btnEliminarIngresos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarIngresos.AnimationHoverSpeed = 0.07F;
            this.btnEliminarIngresos.AnimationSpeed = 0.03F;
            this.btnEliminarIngresos.BaseColor = System.Drawing.Color.Red;
            this.btnEliminarIngresos.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarIngresos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarIngresos.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarIngresos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnEliminarIngresos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarIngresos.Image = null;
            this.btnEliminarIngresos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarIngresos.Location = new System.Drawing.Point(995, 623);
            this.btnEliminarIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarIngresos.Name = "btnEliminarIngresos";
            this.btnEliminarIngresos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarIngresos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarIngresos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarIngresos.OnHoverImage = null;
            this.btnEliminarIngresos.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarIngresos.Size = new System.Drawing.Size(160, 49);
            this.btnEliminarIngresos.TabIndex = 26;
            this.btnEliminarIngresos.Text = "Eliminar";
            this.btnEliminarIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarIngresos.Click += new System.EventHandler(this.btnEliminarIngresos_Click);
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarIngreso.AnimationHoverSpeed = 0.07F;
            this.btnAgregarIngreso.AnimationSpeed = 0.03F;
            this.btnAgregarIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarIngreso.BaseColor = System.Drawing.Color.Green;
            this.btnAgregarIngreso.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarIngreso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarIngreso.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.Image = null;
            this.btnAgregarIngreso.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarIngreso.Location = new System.Drawing.Point(790, 623);
            this.btnAgregarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarIngreso.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarIngreso.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.OnHoverImage = null;
            this.btnAgregarIngreso.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarIngreso.Size = new System.Drawing.Size(160, 49);
            this.btnAgregarIngreso.TabIndex = 25;
            this.btnAgregarIngreso.Text = "Agregar";
            this.btnAgregarIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // dtpFechaHastaIngreso
            // 
            this.dtpFechaHastaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaIngreso.Location = new System.Drawing.Point(1221, 142);
            this.dtpFechaHastaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHastaIngreso.Name = "dtpFechaHastaIngreso";
            this.dtpFechaHastaIngreso.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaHastaIngreso.TabIndex = 24;
            this.dtpFechaHastaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaHastaIngreso_ValueChanged);
            // 
            // dtpFechaDesdeIngreso
            // 
            this.dtpFechaDesdeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesdeIngreso.Location = new System.Drawing.Point(782, 144);
            this.dtpFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesdeIngreso.Name = "dtpFechaDesdeIngreso";
            this.dtpFechaDesdeIngreso.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaDesdeIngreso.TabIndex = 23;
            this.dtpFechaDesdeIngreso.ValueChanged += new System.EventHandler(this.dtpFechaDesdeIngreso_ValueChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(1216, 115);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel4.TabIndex = 22;
            this.gunaLabel4.Text = "Fecha Hasta";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(777, 114);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel5.TabIndex = 21;
            this.gunaLabel5.Text = "Fecha Desde";
            // 
            // dvgIngresos
            // 
            this.dvgIngresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dvgIngresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIngresos.Location = new System.Drawing.Point(782, 172);
            this.dvgIngresos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgIngresos.Name = "dvgIngresos";
            this.dvgIngresos.RowHeadersWidth = 51;
            this.dvgIngresos.RowTemplate.Height = 24;
            this.dvgIngresos.Size = new System.Drawing.Size(764, 431);
            this.dvgIngresos.TabIndex = 20;
            this.dvgIngresos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgIngresos_CellClick);
            // 
            // FormFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1539, 849);
            this.Controls.Add(this.btnEliminarIngresos);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.dtpFechaHastaIngreso);
            this.Controls.Add(this.dtpFechaDesdeIngreso);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.dvgIngresos);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPFechaHasta);
            this.Controls.Add(this.DTPFechaDesde);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFinanzas";
            this.Text = "Finanzas";
            this.Load += new System.EventHandler(this.FormFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DateTimePicker DTPFechaDesde;
        private System.Windows.Forms.DateTimePicker DTPFechaHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private Guna.UI.WinForms.GunaButton btnReporte;
        private Guna.UI.WinForms.GunaButton btnEliminarIngresos;
        private Guna.UI.WinForms.GunaButton btnAgregarIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeIngreso;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridView dvgIngresos;
    }
}