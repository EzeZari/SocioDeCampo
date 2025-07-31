
namespace Presentacion
{
    partial class FormReporteListaPartidos
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
            this.MyCompanyDataSetPartidos = new Presentacion.MyCompanyDataSetPartidos();
            this.PartidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PartidosTableAdapter = new Presentacion.MyCompanyDataSetPartidosTableAdapters.PartidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSetPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPartidos";
            reportDataSource1.Value = this.PartidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteListaPartidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // MyCompanyDataSetPartidos
            // 
            this.MyCompanyDataSetPartidos.DataSetName = "MyCompanyDataSetPartidos";
            this.MyCompanyDataSetPartidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PartidosBindingSource
            // 
            this.PartidosBindingSource.DataMember = "Partidos";
            this.PartidosBindingSource.DataSource = this.MyCompanyDataSetPartidos;
            // 
            // PartidosTableAdapter
            // 
            this.PartidosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteListaPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteListaPartidos";
            this.Text = "FormReporteListaPartidos";
            this.Load += new System.EventHandler(this.FormReporteListaPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSetPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PartidosBindingSource;
        private MyCompanyDataSetPartidos MyCompanyDataSetPartidos;
        private MyCompanyDataSetPartidosTableAdapters.PartidosTableAdapter PartidosTableAdapter;
    }
}