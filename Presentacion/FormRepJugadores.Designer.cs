
namespace Presentacion
{
    partial class FormRepJugadores
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
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosTableAdapter = new Presentacion.MyCompanyDataSetTableAdapters.gastosTableAdapter();
            this.MyCompanyDataSet1 = new Presentacion.MyCompanyDataSet1();
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JugadoresTableAdapter = new Presentacion.MyCompanyDataSet1TableAdapters.JugadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.JugadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.reportJugadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // MyCompanyDataSet
            // 
            this.MyCompanyDataSet.DataSetName = "MyCompanyDataSet";
            this.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "gastos";
            this.gastosBindingSource.DataSource = this.MyCompanyDataSet;
            // 
            // gastosTableAdapter
            // 
            this.gastosTableAdapter.ClearBeforeFill = true;
            // 
            // MyCompanyDataSet1
            // 
            this.MyCompanyDataSet1.DataSetName = "MyCompanyDataSet1";
            this.MyCompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataMember = "Jugadores";
            this.JugadoresBindingSource.DataSource = this.MyCompanyDataSet1;
            // 
            // JugadoresTableAdapter
            // 
            this.JugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormRepJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRepJugadores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private MyCompanyDataSet MyCompanyDataSet;
        private MyCompanyDataSetTableAdapters.gastosTableAdapter gastosTableAdapter;
        private System.Windows.Forms.BindingSource JugadoresBindingSource;
        private MyCompanyDataSet1 MyCompanyDataSet1;
        private MyCompanyDataSet1TableAdapters.JugadoresTableAdapter JugadoresTableAdapter;
    }
}