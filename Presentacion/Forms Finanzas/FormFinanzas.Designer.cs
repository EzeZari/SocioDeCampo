﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.DTPFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarIngresos = new Guna.UI.WinForms.GunaButton();
            this.btnAgregarIngreso = new Guna.UI.WinForms.GunaButton();
            this.dtpFechaDesdeIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHastaIngreso = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.chartBalance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnImportar = new Guna.UI.WinForms.GunaButton();
            this.txtBuscarGasto = new System.Windows.Forms.TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarIngreso = new System.Windows.Forms.TextBox();
            this.btnPresupuestos = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dvgIngresos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartBalance)).BeginInit();
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
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 78);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Fecha Desde";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(567, 78);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Fecha Hasta";
            // 
            // DTPFechaDesde
            // 
            this.DTPFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaDesde.Location = new System.Drawing.Point(16, 105);
            this.DTPFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFechaDesde.Name = "DTPFechaDesde";
            this.DTPFechaDesde.Size = new System.Drawing.Size(200, 26);
            this.DTPFechaDesde.TabIndex = 4;
            this.DTPFechaDesde.ValueChanged += new System.EventHandler(this.DTPFechaDesde_ValueChanged);
            // 
            // DTPFechaHasta
            // 
            this.DTPFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaHasta.Location = new System.Drawing.Point(512, 105);
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 656);
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
            this.BtnEliminar.Location = new System.Drawing.Point(184, 656);
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
            this.btnEliminarIngresos.Location = new System.Drawing.Point(1366, 656);
            this.btnEliminarIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarIngresos.Name = "btnEliminarIngresos";
            this.btnEliminarIngresos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarIngresos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarIngresos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarIngresos.OnHoverImage = null;
            this.btnEliminarIngresos.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarIngresos.Size = new System.Drawing.Size(160, 49);
            this.btnEliminarIngresos.TabIndex = 21;
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
            this.btnAgregarIngreso.Location = new System.Drawing.Point(1186, 656);
            this.btnAgregarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarIngreso.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarIngreso.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarIngreso.OnHoverImage = null;
            this.btnAgregarIngreso.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarIngreso.Size = new System.Drawing.Size(160, 49);
            this.btnAgregarIngreso.TabIndex = 22;
            this.btnAgregarIngreso.Text = "Agregar";
            this.btnAgregarIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // dtpFechaDesdeIngreso
            // 
            this.dtpFechaDesdeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesdeIngreso.Location = new System.Drawing.Point(756, 105);
            this.dtpFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesdeIngreso.Name = "dtpFechaDesdeIngreso";
            this.dtpFechaDesdeIngreso.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaDesdeIngreso.TabIndex = 23;
            this.dtpFechaDesdeIngreso.ValueChanged += new System.EventHandler(this.dtpFechaDesdeIngreso_ValueChanged);
            // 
            // dtpFechaHastaIngreso
            // 
            this.dtpFechaHastaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaIngreso.Location = new System.Drawing.Point(1307, 107);
            this.dtpFechaHastaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHastaIngreso.Name = "dtpFechaHastaIngreso";
            this.dtpFechaHastaIngreso.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaHastaIngreso.TabIndex = 24;
            this.dtpFechaHastaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaHastaIngreso_ValueChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(751, 78);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "Fecha Desde";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(1384, 78);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel5.TabIndex = 26;
            this.gunaLabel5.Text = "Fecha Hasta";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(593, 656);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(242, 32);
            this.lblBalance.TabIndex = 29;
            this.lblBalance.Text = "\"Balance: $0.00\"";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // chartBalance
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBalance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBalance.Legends.Add(legend1);
            this.chartBalance.Location = new System.Drawing.Point(488, 691);
            this.chartBalance.Name = "chartBalance";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBalance.Series.Add(series1);
            this.chartBalance.Size = new System.Drawing.Size(554, 146);
            this.chartBalance.TabIndex = 30;
            this.chartBalance.Text = "chart1";
            this.chartBalance.Click += new System.EventHandler(this.chartBalance_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImportar.AnimationHoverSpeed = 0.07F;
            this.btnImportar.AnimationSpeed = 0.03F;
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportar.BaseColor = System.Drawing.Color.Green;
            this.btnImportar.BorderColor = System.Drawing.Color.Black;
            this.btnImportar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImportar.FocusedColor = System.Drawing.Color.Empty;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Image = null;
            this.btnImportar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImportar.Location = new System.Drawing.Point(1350, 3);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImportar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImportar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImportar.OnHoverImage = null;
            this.btnImportar.OnPressedColor = System.Drawing.Color.Black;
            this.btnImportar.Size = new System.Drawing.Size(176, 25);
            this.btnImportar.TabIndex = 31;
            this.btnImportar.Text = "Exportar";
            this.btnImportar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtBuscarGasto
            // 
            this.txtBuscarGasto.Location = new System.Drawing.Point(279, 103);
            this.txtBuscarGasto.Name = "txtBuscarGasto";
            this.txtBuscarGasto.Size = new System.Drawing.Size(134, 22);
            this.txtBuscarGasto.TabIndex = 32;
            this.txtBuscarGasto.Text = "Buscar";
            this.txtBuscarGasto.TextChanged += new System.EventHandler(this.txtBuscarGasto_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(309, 78);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(73, 25);
            this.gunaLabel6.TabIndex = 33;
            this.gunaLabel6.Text = "Buscar";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(1074, 78);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(73, 25);
            this.gunaLabel7.TabIndex = 35;
            this.gunaLabel7.Text = "Buscar";
            // 
            // txtBuscarIngreso
            // 
            this.txtBuscarIngreso.Location = new System.Drawing.Point(1048, 107);
            this.txtBuscarIngreso.Name = "txtBuscarIngreso";
            this.txtBuscarIngreso.Size = new System.Drawing.Size(134, 22);
            this.txtBuscarIngreso.TabIndex = 34;
            this.txtBuscarIngreso.Text = "Buscar";
            this.txtBuscarIngreso.TextChanged += new System.EventHandler(this.txtBuscarIngreso_TextChanged);
            // 
            // btnPresupuestos
            // 
            this.btnPresupuestos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPresupuestos.AnimationHoverSpeed = 0.07F;
            this.btnPresupuestos.AnimationSpeed = 0.03F;
            this.btnPresupuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPresupuestos.BaseColor = System.Drawing.Color.Green;
            this.btnPresupuestos.BorderColor = System.Drawing.Color.Black;
            this.btnPresupuestos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPresupuestos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPresupuestos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuestos.ForeColor = System.Drawing.Color.White;
            this.btnPresupuestos.Image = null;
            this.btnPresupuestos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPresupuestos.Location = new System.Drawing.Point(1186, 752);
            this.btnPresupuestos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPresupuestos.Name = "btnPresupuestos";
            this.btnPresupuestos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPresupuestos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPresupuestos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPresupuestos.OnHoverImage = null;
            this.btnPresupuestos.OnPressedColor = System.Drawing.Color.Black;
            this.btnPresupuestos.Size = new System.Drawing.Size(282, 40);
            this.btnPresupuestos.TabIndex = 36;
            this.btnPresupuestos.Text = "Presupuestos";
            this.btnPresupuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPresupuestos.Click += new System.EventHandler(this.btnPresupuestos_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaButton1.BaseColor = System.Drawing.Color.Green;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1186, 800);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(300, 37);
            this.gunaButton1.TabIndex = 37;
            this.gunaButton1.Text = "SeguimientoPresupuestario";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(284, 147);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(74, 25);
            this.gunaLabel8.TabIndex = 38;
            this.gunaLabel8.Text = "Gastos";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(1074, 147);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(87, 25);
            this.gunaLabel9.TabIndex = 39;
            this.gunaLabel9.Text = "Ingresos";
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeight = 30;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(12, 147);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDatos.RowHeadersWidth = 50;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.RowTemplate.Height = 50;
            this.dgvDatos.Size = new System.Drawing.Size(678, 428);
            this.dgvDatos.TabIndex = 40;
            // 
            // dvgIngresos
            // 
            this.dvgIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgIngresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgIngresos.BackgroundColor = System.Drawing.Color.White;
            this.dvgIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgIngresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgIngresos.ColumnHeadersHeight = 30;
            this.dvgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgIngresos.EnableHeadersVisualStyles = false;
            this.dvgIngresos.Location = new System.Drawing.Point(848, 147);
            this.dvgIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.dvgIngresos.Name = "dvgIngresos";
            this.dvgIngresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgIngresos.RowHeadersWidth = 50;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dvgIngresos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgIngresos.RowTemplate.Height = 50;
            this.dvgIngresos.Size = new System.Drawing.Size(678, 428);
            this.dvgIngresos.TabIndex = 41;
            // 
            // FormFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1539, 849);
            this.Controls.Add(this.dvgIngresos);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnPresupuestos);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtBuscarIngreso);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtBuscarGasto);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.chartBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.dtpFechaHastaIngreso);
            this.Controls.Add(this.dtpFechaDesdeIngreso);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.btnEliminarIngresos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPFechaHasta);
            this.Controls.Add(this.DTPFechaDesde);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFinanzas";
            this.Text = "Finanzas";
            this.Load += new System.EventHandler(this.FormFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DateTimePicker DTPFechaDesde;
        private System.Windows.Forms.DateTimePicker DTPFechaHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private Guna.UI.WinForms.GunaButton btnEliminarIngresos;
        private Guna.UI.WinForms.GunaButton btnAgregarIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaIngreso;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBalance;
        private Guna.UI.WinForms.GunaButton btnImportar;
        private System.Windows.Forms.TextBox txtBuscarGasto;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.TextBox txtBuscarIngreso;
        private Guna.UI.WinForms.GunaButton btnPresupuestos;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridView dvgIngresos;
    }
}