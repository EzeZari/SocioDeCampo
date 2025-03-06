
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetContratos = new Presentacion.Forms_Contratos.DataSetContratos();
            this.VistaJugadoresSinModificarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VistaJugadoresSinModificarTableAdapter = new Presentacion.Forms_Contratos.DataSetContratosTableAdapters.VistaJugadoresSinModificarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaJugadoresSinModificarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VistaJugadoresSinModificarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Forms Contratos.ReportContratos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetContratos
            // 
            this.DataSetContratos.DataSetName = "DataSetContratos";
            this.DataSetContratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VistaJugadoresSinModificarBindingSource
            // 
            this.VistaJugadoresSinModificarBindingSource.DataMember = "VistaJugadoresSinModificar";
            this.VistaJugadoresSinModificarBindingSource.DataSource = this.DataSetContratos;
            // 
            // VistaJugadoresSinModificarTableAdapter
            // 
            this.VistaJugadoresSinModificarTableAdapter.ClearBeforeFill = true;
            // 
            // FormGenerarInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormGenerarInforme";
            this.Text = "FormGenerarInforme";
            this.Load += new System.EventHandler(this.FormGenerarInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaJugadoresSinModificarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VistaJugadoresSinModificarBindingSource;
        private DataSetContratos DataSetContratos;
        private DataSetContratosTableAdapters.VistaJugadoresSinModificarTableAdapter VistaJugadoresSinModificarTableAdapter;
    }
}