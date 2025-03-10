
namespace Presentacion
{
    partial class Reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyCompanyDataSet = new Presentacion.MyCompanyDataSet();
            this.ingresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyCompanyDataSet2 = new Presentacion.MyCompanyDataSet2();
            this.gastosTableAdapter = new Presentacion.MyCompanyDataSetTableAdapters.gastosTableAdapter();
            this.ingresosTableAdapter = new Presentacion.MyCompanyDataSet2TableAdapters.ingresosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "gastos";
            this.gastosBindingSource.DataSource = this.MyCompanyDataSet;
            // 
            // MyCompanyDataSet
            // 
            this.MyCompanyDataSet.DataSetName = "MyCompanyDataSet";
            this.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingresosBindingSource
            // 
            this.ingresosBindingSource.DataMember = "ingresos";
            this.ingresosBindingSource.DataSource = this.MyCompanyDataSet2;
            // 
            // MyCompanyDataSet2
            // 
            this.MyCompanyDataSet2.DataSetName = "MyCompanyDataSet2";
            this.MyCompanyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosTableAdapter
            // 
            this.gastosTableAdapter.ClearBeforeFill = true;
            // 
            // ingresosTableAdapter
            // 
            this.ingresosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gastosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ingresosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reporte1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1068, 538);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 538);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private MyCompanyDataSet MyCompanyDataSet;
        private System.Windows.Forms.BindingSource ingresosBindingSource;
        private MyCompanyDataSet2 MyCompanyDataSet2;
        private MyCompanyDataSetTableAdapters.gastosTableAdapter gastosTableAdapter;
        private MyCompanyDataSet2TableAdapters.ingresosTableAdapter ingresosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}