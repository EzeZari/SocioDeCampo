
namespace Presentacion
{
    partial class FormSeguimientoPresupuestario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTemporada = new System.Windows.Forms.ComboBox();
            this.dgvSeguimiento = new System.Windows.Forms.DataGridView();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MyCompanyDataSet3 = new Presentacion.MyCompanyDataSet3();
            this.PresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PresupuestosTableAdapter = new Presentacion.MyCompanyDataSet3TableAdapters.PresupuestosTableAdapter();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(736, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Temporada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seguimiento de Presupuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(778, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comparativo de Presupuesto vs Gasto";
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Location = new System.Drawing.Point(922, 8);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(156, 24);
            this.cmbTemporada.TabIndex = 3;
            this.cmbTemporada.SelectedIndexChanged += new System.EventHandler(this.cmbTemporada_SelectedIndexChanged);
            // 
            // dgvSeguimiento
            // 
            this.dgvSeguimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguimiento.Location = new System.Drawing.Point(12, 38);
            this.dgvSeguimiento.Name = "dgvSeguimiento";
            this.dgvSeguimiento.RowHeadersWidth = 51;
            this.dgvSeguimiento.RowTemplate.Height = 24;
            this.dgvSeguimiento.Size = new System.Drawing.Size(1066, 319);
            this.dgvSeguimiento.TabIndex = 4;
            // 
            // chartPie
            // 
            chartArea7.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea7);
            legend5.Name = "Legend1";
            this.chartPie.Legends.Add(legend5);
            this.chartPie.Location = new System.Drawing.Point(631, 406);
            this.chartPie.Name = "chartPie";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartPie.Series.Add(series5);
            this.chartPie.Size = new System.Drawing.Size(447, 558);
            this.chartPie.TabIndex = 6;
            this.chartPie.Text = "chart1";
            // 
            // MyCompanyDataSet3
            // 
            this.MyCompanyDataSet3.DataSetName = "MyCompanyDataSet3";
            this.MyCompanyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PresupuestosBindingSource
            // 
            this.PresupuestosBindingSource.DataMember = "Presupuestos";
            this.PresupuestosBindingSource.DataSource = this.MyCompanyDataSet3;
            // 
            // PresupuestosTableAdapter
            // 
            this.PresupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // chartBarras
            // 
            chartArea8.Name = "ChartArea1";
            chartArea9.Name = "ChartArea2";
            this.chartBarras.ChartAreas.Add(chartArea8);
            this.chartBarras.ChartAreas.Add(chartArea9);
            legend6.Name = "Legend1";
            this.chartBarras.Legends.Add(legend6);
            this.chartBarras.Location = new System.Drawing.Point(12, 363);
            this.chartBarras.Name = "chartBarras";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartBarras.Series.Add(series6);
            this.chartBarras.Size = new System.Drawing.Size(599, 601);
            this.chartBarras.TabIndex = 5;
            this.chartBarras.Text = "chart1";
            // 
            // FormSeguimientoPresupuestario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 976);
            this.Controls.Add(this.chartBarras);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.dgvSeguimiento);
            this.Controls.Add(this.cmbTemporada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSeguimientoPresupuestario";
            this.Text = "FormSeguimientoPresupuestario";
            this.Load += new System.EventHandler(this.FormSeguimientoPresupuestario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTemporada;
        private System.Windows.Forms.DataGridView dgvSeguimiento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.BindingSource PresupuestosBindingSource;
        private MyCompanyDataSet3 MyCompanyDataSet3;
        private MyCompanyDataSet3TableAdapters.PresupuestosTableAdapter PresupuestosTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
    }
}