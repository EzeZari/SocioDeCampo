
namespace Presentacion.FormEstadisticasAuditoria
{
    partial class FormEstadisticasAuditoria
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAccionesAuditoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccionesAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAccionesAuditoria
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAccionesAuditoria.ChartAreas.Add(chartArea1);
            this.chartAccionesAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartAccionesAuditoria.Legends.Add(legend1);
            this.chartAccionesAuditoria.Location = new System.Drawing.Point(0, 0);
            this.chartAccionesAuditoria.Name = "chartAccionesAuditoria";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAccionesAuditoria.Series.Add(series1);
            this.chartAccionesAuditoria.Size = new System.Drawing.Size(800, 450);
            this.chartAccionesAuditoria.TabIndex = 0;
            this.chartAccionesAuditoria.Text = "chart1";
            // 
            // FormEstadisticasAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartAccionesAuditoria);
            this.Name = "FormEstadisticasAuditoria";
            this.Text = "FormEstadisticasAuditoria";
            this.Load += new System.EventHandler(this.FormEstadisticasAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAccionesAuditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccionesAuditoria;
    }
}