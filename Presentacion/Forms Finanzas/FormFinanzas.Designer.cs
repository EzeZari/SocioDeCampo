
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinanzas));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvDatos = new Guna.UI.WinForms.GunaDataGridView();
            this.DTPFcheDesde = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.DTPFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(576, 10);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(200, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Form Finanzas";
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatos.Location = new System.Drawing.Point(4, 138);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(789, 356);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDatos.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDatos.ThemeStyle.ReadOnly = true;
            this.dgvDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDatos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // DTPFcheDesde
            // 
            this.DTPFcheDesde.Location = new System.Drawing.Point(110, 99);
            this.DTPFcheDesde.Name = "DTPFcheDesde";
            this.DTPFcheDesde.Size = new System.Drawing.Size(200, 22);
            this.DTPFcheDesde.TabIndex = 2;
            this.DTPFcheDesde.ValueChanged += new System.EventHandler(this.DTPFcheDesde_ValueChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(12, 99);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(91, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Fecha inicio ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(396, 99);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(84, 20);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Fecha final ";
            // 
            // DTPFechaHasta
            // 
            this.DTPFechaHasta.Location = new System.Drawing.Point(499, 97);
            this.DTPFechaHasta.Name = "DTPFechaHasta";
            this.DTPFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.DTPFechaHasta.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(4, 500);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Size = new System.Drawing.Size(160, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Gasto";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AnimationHoverSpeed = 0.07F;
            this.BtnEliminar.AnimationSpeed = 0.03F;
            this.BtnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnEliminar.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEliminar.Location = new System.Drawing.Point(630, 500);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Size = new System.Drawing.Size(160, 42);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar Gasto";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(9, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(250, 38);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Control de Gastos";
            // 
            // FormFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 590);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.DTPFechaHasta);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.DTPFcheDesde);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFinanzas";
            this.Text = "FormFinanzas";
            this.Load += new System.EventHandler(this.FormFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvDatos;
        private System.Windows.Forms.DateTimePicker DTPFcheDesde;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DateTimePicker DTPFechaHasta;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}