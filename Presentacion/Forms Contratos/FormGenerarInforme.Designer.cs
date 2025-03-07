
namespace Presentacion.Forms_Contratos
{
    partial class FormGenerarInforme
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarInforme));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbContratosVencimiento = new Guna.UI.WinForms.GunaComboBox();
            this.btnFiltrar = new Guna.UI.WinForms.GunaButton();
            this.numSalarioMin = new Guna.UI.WinForms.GunaNumeric();
            this.numSalarioMax = new Guna.UI.WinForms.GunaNumeric();
            this.dtpDesde = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpHasta = new Guna.UI.WinForms.GunaDateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbPosicion = new Guna.UI.WinForms.GunaComboBox();
            this.VistaJugadoresSinModificarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetContratos = new Presentacion.Forms_Contratos.DataSetContratos();
            this.VistaJugadoresSinModificarTableAdapter = new Presentacion.Forms_Contratos.DataSetContratosTableAdapters.VistaJugadoresSinModificarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaJugadoresSinModificarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VistaJugadoresSinModificarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Forms Contratos.ReportContratos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(413, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(790, 516);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbContratosVencimiento
            // 
            this.cmbContratosVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.cmbContratosVencimiento.BaseColor = System.Drawing.Color.White;
            this.cmbContratosVencimiento.BorderColor = System.Drawing.Color.Silver;
            this.cmbContratosVencimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbContratosVencimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContratosVencimiento.FocusedColor = System.Drawing.Color.Empty;
            this.cmbContratosVencimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbContratosVencimiento.ForeColor = System.Drawing.Color.Black;
            this.cmbContratosVencimiento.FormattingEnabled = true;
            this.cmbContratosVencimiento.Location = new System.Drawing.Point(40, 48);
            this.cmbContratosVencimiento.Name = "cmbContratosVencimiento";
            this.cmbContratosVencimiento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbContratosVencimiento.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbContratosVencimiento.Size = new System.Drawing.Size(179, 26);
            this.cmbContratosVencimiento.TabIndex = 1;
            this.cmbContratosVencimiento.SelectedIndexChanged += new System.EventHandler(this.cmbContratosVencimiento_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AnimationHoverSpeed = 0.07F;
            this.btnFiltrar.AnimationSpeed = 0.03F;
            this.btnFiltrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltrar.Location = new System.Drawing.Point(103, 486);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFiltrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnHoverImage = null;
            this.btnFiltrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFiltrar.Size = new System.Drawing.Size(160, 42);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Aplicar Filtros";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // numSalarioMin
            // 
            this.numSalarioMin.BaseColor = System.Drawing.Color.White;
            this.numSalarioMin.BorderColor = System.Drawing.Color.Silver;
            this.numSalarioMin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numSalarioMin.ButtonForeColor = System.Drawing.Color.White;
            this.numSalarioMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSalarioMin.ForeColor = System.Drawing.Color.Black;
            this.numSalarioMin.Location = new System.Drawing.Point(49, 247);
            this.numSalarioMin.Maximum = ((long)(9999999));
            this.numSalarioMin.Minimum = ((long)(0));
            this.numSalarioMin.Name = "numSalarioMin";
            this.numSalarioMin.Size = new System.Drawing.Size(98, 30);
            this.numSalarioMin.TabIndex = 3;
            this.numSalarioMin.Text = "gunaNumeric1";
            this.numSalarioMin.Value = ((long)(0));
            // 
            // numSalarioMax
            // 
            this.numSalarioMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numSalarioMax.BaseColor = System.Drawing.Color.White;
            this.numSalarioMax.BorderColor = System.Drawing.Color.Silver;
            this.numSalarioMax.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numSalarioMax.ButtonForeColor = System.Drawing.Color.White;
            this.numSalarioMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSalarioMax.ForeColor = System.Drawing.Color.Black;
            this.numSalarioMax.Location = new System.Drawing.Point(188, 247);
            this.numSalarioMax.Maximum = ((long)(999999999));
            this.numSalarioMax.Minimum = ((long)(0));
            this.numSalarioMax.Name = "numSalarioMax";
            this.numSalarioMax.Size = new System.Drawing.Size(100, 30);
            this.numSalarioMax.TabIndex = 4;
            this.numSalarioMax.Text = "gunaNumeric2";
            this.numSalarioMax.Value = ((long)(100000));
            // 
            // dtpDesde
            // 
            this.dtpDesde.BaseColor = System.Drawing.Color.White;
            this.dtpDesde.BorderColor = System.Drawing.Color.Silver;
            this.dtpDesde.CustomFormat = null;
            this.dtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDesde.ForeColor = System.Drawing.Color.Black;
            this.dtpDesde.Location = new System.Drawing.Point(40, 118);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDesde.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDesde.Size = new System.Drawing.Size(223, 30);
            this.dtpDesde.TabIndex = 5;
            this.dtpDesde.Text = "jueves, 6 de marzo de 2025";
            this.dtpDesde.Value = new System.DateTime(2025, 3, 6, 18, 28, 54, 678);
            // 
            // dtpHasta
            // 
            this.dtpHasta.BaseColor = System.Drawing.Color.White;
            this.dtpHasta.BorderColor = System.Drawing.Color.Silver;
            this.dtpHasta.CustomFormat = null;
            this.dtpHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpHasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHasta.ForeColor = System.Drawing.Color.Black;
            this.dtpHasta.Location = new System.Drawing.Point(40, 170);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpHasta.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.OnPressedColor = System.Drawing.Color.Black;
            this.dtpHasta.Size = new System.Drawing.Size(223, 30);
            this.dtpHasta.TabIndex = 6;
            this.dtpHasta.Text = "jueves, 6 de marzo de 2025";
            this.dtpHasta.Value = new System.DateTime(2025, 3, 6, 18, 28, 54, 678);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(50, 283);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.BackColor = System.Drawing.Color.Transparent;
            this.cmbPosicion.BaseColor = System.Drawing.Color.White;
            this.cmbPosicion.BorderColor = System.Drawing.Color.Silver;
            this.cmbPosicion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosicion.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPosicion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPosicion.ForeColor = System.Drawing.Color.Black;
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(50, 372);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbPosicion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPosicion.Size = new System.Drawing.Size(202, 26);
            this.cmbPosicion.TabIndex = 9;
            // 
            // VistaJugadoresSinModificarBindingSource
            // 
            this.VistaJugadoresSinModificarBindingSource.DataMember = "VistaJugadoresSinModificar";
            this.VistaJugadoresSinModificarBindingSource.DataSource = this.DataSetContratos;
            // 
            // DataSetContratos
            // 
            this.DataSetContratos.DataSetName = "DataSetContratos";
            this.DataSetContratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VistaJugadoresSinModificarTableAdapter
            // 
            this.VistaJugadoresSinModificarTableAdapter.ClearBeforeFill = true;
            // 
            // FormGenerarInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 540);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.numSalarioMax);
            this.Controls.Add(this.numSalarioMin);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbContratosVencimiento);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormGenerarInforme";
            this.Text = "Crear informe";
            this.Load += new System.EventHandler(this.FormGenerarInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaJugadoresSinModificarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VistaJugadoresSinModificarBindingSource;
        private DataSetContratos DataSetContratos;
        private DataSetContratosTableAdapters.VistaJugadoresSinModificarTableAdapter VistaJugadoresSinModificarTableAdapter;
        private Guna.UI.WinForms.GunaComboBox cmbContratosVencimiento;
        private Guna.UI.WinForms.GunaButton btnFiltrar;
        private Guna.UI.WinForms.GunaNumeric numSalarioMin;
        private Guna.UI.WinForms.GunaNumeric numSalarioMax;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDesde;
        private Guna.UI.WinForms.GunaDateTimePicker dtpHasta;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Guna.UI.WinForms.GunaComboBox cmbPosicion;
    }
}