
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
            this.VistaJugadoresSinModificarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetContratos = new Presentacion.Forms_Contratos.DataSetContratos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbContratosVencimiento = new Guna.UI.WinForms.GunaComboBox();
            this.btnFiltrar = new Guna.UI.WinForms.GunaButton();
            this.numSalarioMin = new Guna.UI.WinForms.GunaNumeric();
            this.numSalarioMax = new Guna.UI.WinForms.GunaNumeric();
            this.dtpDesde = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpHasta = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cmbPosicion = new Guna.UI.WinForms.GunaComboBox();
            this.VistaJugadoresSinModificarTableAdapter = new Presentacion.Forms_Contratos.DataSetContratosTableAdapters.VistaJugadoresSinModificarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VistaJugadoresSinModificarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContratos)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VistaJugadoresSinModificarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Forms Contratos.ReportContratos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(386, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(817, 526);
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
            this.cmbContratosVencimiento.Location = new System.Drawing.Point(51, 86);
            this.cmbContratosVencimiento.Name = "cmbContratosVencimiento";
            this.cmbContratosVencimiento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.cmbContratosVencimiento.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbContratosVencimiento.Size = new System.Drawing.Size(302, 26);
            this.cmbContratosVencimiento.TabIndex = 1;
            this.cmbContratosVencimiento.SelectedIndexChanged += new System.EventHandler(this.cmbContratosVencimiento_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrar.AnimationHoverSpeed = 0.07F;
            this.btnFiltrar.AnimationSpeed = 0.03F;
            this.btnFiltrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltrar.Location = new System.Drawing.Point(118, 469);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
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
            this.numSalarioMin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.numSalarioMin.ButtonForeColor = System.Drawing.Color.White;
            this.numSalarioMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSalarioMin.ForeColor = System.Drawing.Color.Black;
            this.numSalarioMin.Location = new System.Drawing.Point(49, 308);
            this.numSalarioMin.Maximum = ((long)(9999999));
            this.numSalarioMin.Minimum = ((long)(0));
            this.numSalarioMin.Name = "numSalarioMin";
            this.numSalarioMin.Size = new System.Drawing.Size(121, 30);
            this.numSalarioMin.TabIndex = 3;
            this.numSalarioMin.Text = "gunaNumeric1";
            this.numSalarioMin.Value = ((long)(0));
            // 
            // numSalarioMax
            // 
            this.numSalarioMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numSalarioMax.BaseColor = System.Drawing.Color.White;
            this.numSalarioMax.BorderColor = System.Drawing.Color.Silver;
            this.numSalarioMax.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.numSalarioMax.ButtonForeColor = System.Drawing.Color.White;
            this.numSalarioMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSalarioMax.ForeColor = System.Drawing.Color.Black;
            this.numSalarioMax.Location = new System.Drawing.Point(223, 308);
            this.numSalarioMax.Maximum = ((long)(999999999));
            this.numSalarioMax.Minimum = ((long)(0));
            this.numSalarioMax.Name = "numSalarioMax";
            this.numSalarioMax.Size = new System.Drawing.Size(130, 30);
            this.numSalarioMax.TabIndex = 4;
            this.numSalarioMax.Text = "gunaNumeric2";
            this.numSalarioMax.Value = ((long)(1000000));
            // 
            // dtpDesde
            // 
            this.dtpDesde.BaseColor = System.Drawing.Color.White;
            this.dtpDesde.BorderColor = System.Drawing.Color.Silver;
            this.dtpDesde.CustomFormat = null;
            this.dtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDesde.ForeColor = System.Drawing.Color.Black;
            this.dtpDesde.Location = new System.Drawing.Point(51, 166);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDesde.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDesde.Size = new System.Drawing.Size(302, 30);
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
            this.dtpHasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHasta.ForeColor = System.Drawing.Color.Black;
            this.dtpHasta.Location = new System.Drawing.Point(51, 202);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpHasta.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.OnPressedColor = System.Drawing.Color.Black;
            this.dtpHasta.Size = new System.Drawing.Size(302, 30);
            this.dtpHasta.TabIndex = 6;
            this.dtpHasta.Text = "jueves, 6 de marzo de 2025";
            this.dtpHasta.Value = new System.DateTime(2025, 3, 6, 18, 28, 54, 678);
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
            this.cmbPosicion.Location = new System.Drawing.Point(49, 400);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.cmbPosicion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPosicion.Size = new System.Drawing.Size(304, 26);
            this.cmbPosicion.TabIndex = 9;
            // 
            // VistaJugadoresSinModificarTableAdapter
            // 
            this.VistaJugadoresSinModificarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione el período para filtrar contratos próximos a vencer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seleccione un rango de fechas para filtrar contratos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Filtrar por rango de salario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione la posición del jugador para filtrar contratos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Filtrar y visualizar contratos de jugadores";
            // 
            // FormGenerarInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.numSalarioMax);
            this.Controls.Add(this.numSalarioMin);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbContratosVencimiento);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormGenerarInforme";
            this.Text = "Crear informe";
            this.Load += new System.EventHandler(this.FormGenerarInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaJugadoresSinModificarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI.WinForms.GunaComboBox cmbPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label5;
    }
}