
namespace Presentacion
{
    partial class FormReport
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
            this.MyCompanyDataSet = new Presentacion.MyCompanyDataSet();
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JugadoresTableAdapter = new Presentacion.MyCompanyDataSetTableAdapters.JugadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Jugadores";
            reportDataSource1.Value = this.JugadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportJugadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 1063);
            this.reportViewer1.TabIndex = 0;
            // 
            // MyCompanyDataSet
            // 
            this.MyCompanyDataSet.DataSetName = "MyCompanyDataSet";
            this.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataMember = "Jugadores";
            this.JugadoresBindingSource.DataSource = this.MyCompanyDataSet;
            // 
            // JugadoresTableAdapter
            // 
            this.JugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 1061);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInforme";
            this.Text = "FormInforme";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JugadoresBindingSource;
        private MyCompanyDataSet MyCompanyDataSet;
        private MyCompanyDataSetTableAdapters.JugadoresTableAdapter JugadoresTableAdapter;
    }
}