
namespace Presentacion
{
    partial class FormPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartidos));
            this.btnAñadirPartido = new System.Windows.Forms.Button();
            this.btnEditarResultado = new Guna.UI.WinForms.GunaButton();
            this.btnCargarDatos = new Guna.UI.WinForms.GunaButton();
            this.btnVerDetalles = new Guna.UI.WinForms.GunaButton();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.btnEliminarPartido = new Guna.UI.WinForms.GunaButton();
            this.txtBuscarEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiarFiltro = new Guna.UI.WinForms.GunaButton();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtUbicacion = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new Guna.UI.WinForms.GunaButton();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.btnReporteLista = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadirPartido
            // 
            this.btnAñadirPartido.Location = new System.Drawing.Point(46, 25);
            this.btnAñadirPartido.Name = "btnAñadirPartido";
            this.btnAñadirPartido.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirPartido.TabIndex = 0;
            this.btnAñadirPartido.Text = "Añadir partido";
            this.btnAñadirPartido.UseVisualStyleBackColor = true;
            this.btnAñadirPartido.Click += new System.EventHandler(this.btnAñadirPartido_Click);
            // 
            // btnEditarResultado
            // 
            this.btnEditarResultado.AnimationHoverSpeed = 0.07F;
            this.btnEditarResultado.AnimationSpeed = 0.03F;
            this.btnEditarResultado.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEditarResultado.BorderColor = System.Drawing.Color.Black;
            this.btnEditarResultado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditarResultado.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditarResultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarResultado.ForeColor = System.Drawing.Color.White;
            this.btnEditarResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarResultado.Image")));
            this.btnEditarResultado.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditarResultado.Location = new System.Drawing.Point(258, 51);
            this.btnEditarResultado.Name = "btnEditarResultado";
            this.btnEditarResultado.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEditarResultado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditarResultado.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditarResultado.OnHoverImage = null;
            this.btnEditarResultado.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditarResultado.Size = new System.Drawing.Size(160, 42);
            this.btnEditarResultado.TabIndex = 2;
            this.btnEditarResultado.Text = "Editar resultado";
            this.btnEditarResultado.Click += new System.EventHandler(this.btnEditarResultado_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.AnimationHoverSpeed = 0.07F;
            this.btnCargarDatos.AnimationSpeed = 0.03F;
            this.btnCargarDatos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCargarDatos.BorderColor = System.Drawing.Color.Black;
            this.btnCargarDatos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCargarDatos.FocusedColor = System.Drawing.Color.Empty;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarDatos.Image")));
            this.btnCargarDatos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCargarDatos.Location = new System.Drawing.Point(87, 103);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCargarDatos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarDatos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.OnHoverImage = null;
            this.btnCargarDatos.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarDatos.Size = new System.Drawing.Size(160, 42);
            this.btnCargarDatos.TabIndex = 3;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.AnimationHoverSpeed = 0.07F;
            this.btnVerDetalles.AnimationSpeed = 0.03F;
            this.btnVerDetalles.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnVerDetalles.BorderColor = System.Drawing.Color.Black;
            this.btnVerDetalles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerDetalles.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerDetalles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerDetalles.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.Image = ((System.Drawing.Image)(resources.GetObject("btnVerDetalles.Image")));
            this.btnVerDetalles.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerDetalles.Location = new System.Drawing.Point(284, 103);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVerDetalles.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerDetalles.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.OnHoverImage = null;
            this.btnVerDetalles.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerDetalles.Size = new System.Drawing.Size(160, 42);
            this.btnVerDetalles.TabIndex = 4;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(5, 201);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.Size = new System.Drawing.Size(792, 251);
            this.dgvPartidos.TabIndex = 5;
            this.dgvPartidos.SelectionChanged += new System.EventHandler(this.dgvPartidos_SelectionChanged);
            // 
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.AnimationHoverSpeed = 0.07F;
            this.btnEliminarPartido.AnimationSpeed = 0.03F;
            this.btnEliminarPartido.BaseColor = System.Drawing.Color.Red;
            this.btnEliminarPartido.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarPartido.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarPartido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarPartido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPartido.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPartido.Image")));
            this.btnEliminarPartido.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarPartido.Location = new System.Drawing.Point(487, 103);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarPartido.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarPartido.OnHoverImage = null;
            this.btnEliminarPartido.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.Size = new System.Drawing.Size(160, 42);
            this.btnEliminarPartido.TabIndex = 6;
            this.btnEliminarPartido.Text = "Editar resultado";
            this.btnEliminarPartido.Click += new System.EventHandler(this.btnEliminarPartido_Click);
            // 
            // txtBuscarEquipo
            // 
            this.txtBuscarEquipo.BaseColor = System.Drawing.Color.White;
            this.txtBuscarEquipo.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscarEquipo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarEquipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarEquipo.Location = new System.Drawing.Point(816, 39);
            this.txtBuscarEquipo.Name = "txtBuscarEquipo";
            this.txtBuscarEquipo.PasswordChar = '\0';
            this.txtBuscarEquipo.Size = new System.Drawing.Size(133, 26);
            this.txtBuscarEquipo.TabIndex = 7;
            this.txtBuscarEquipo.TextChanged += new System.EventHandler(this.txtBuscarEquipo_TextChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(912, 127);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(99, 17);
            this.chkFecha.TabIndex = 8;
            this.chkFecha.Text = "Filtrar por fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(816, 103);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(82, 20);
            this.dtpDesde.TabIndex = 9;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(816, 151);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(82, 20);
            this.dtpHasta.TabIndex = 10;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarFiltro.AnimationSpeed = 0.03F;
            this.btnLimpiarFiltro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLimpiarFiltro.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarFiltro.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltro.Image")));
            this.btnLimpiarFiltro.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(816, 391);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiarFiltro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.OnHoverImage = null;
            this.btnLimpiarFiltro.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(101, 42);
            this.btnLimpiarFiltro.TabIndex = 12;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Todos",
            "Jugados",
            "No Jugados"});
            this.cmbEstado.Location = new System.Drawing.Point(816, 220);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 13;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BaseColor = System.Drawing.Color.White;
            this.txtUbicacion.BorderColor = System.Drawing.Color.Silver;
            this.txtUbicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUbicacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUbicacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUbicacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUbicacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUbicacion.Location = new System.Drawing.Point(816, 263);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.PasswordChar = '\0';
            this.txtUbicacion.Size = new System.Drawing.Size(133, 26);
            this.txtUbicacion.TabIndex = 14;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(970, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "txtBuscarEquipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "txtUbicacion";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AnimationHoverSpeed = 0.07F;
            this.btnFiltrar.AnimationSpeed = 0.03F;
            this.btnFiltrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltrar.Location = new System.Drawing.Point(921, 151);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFiltrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnHoverImage = null;
            this.btnFiltrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFiltrar.Size = new System.Drawing.Size(81, 31);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Aplicar Filtro";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Items.AddRange(new object[] {
            "Ambos ",
            "Local",
            "Visitante"});
            this.cmbTipoEquipo.Location = new System.Drawing.Point(816, 330);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEquipo.TabIndex = 19;
            this.cmbTipoEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEquipo_SelectedIndexChanged);
            // 
            // btnReporteLista
            // 
            this.btnReporteLista.AnimationHoverSpeed = 0.07F;
            this.btnReporteLista.AnimationSpeed = 0.03F;
            this.btnReporteLista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReporteLista.BorderColor = System.Drawing.Color.Black;
            this.btnReporteLista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReporteLista.FocusedColor = System.Drawing.Color.Empty;
            this.btnReporteLista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReporteLista.ForeColor = System.Drawing.Color.White;
            this.btnReporteLista.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteLista.Image")));
            this.btnReporteLista.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReporteLista.Location = new System.Drawing.Point(513, 25);
            this.btnReporteLista.Name = "btnReporteLista";
            this.btnReporteLista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReporteLista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReporteLista.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReporteLista.OnHoverImage = null;
            this.btnReporteLista.OnPressedColor = System.Drawing.Color.Black;
            this.btnReporteLista.Size = new System.Drawing.Size(160, 42);
            this.btnReporteLista.TabIndex = 20;
            this.btnReporteLista.Text = "REPORTE";
            this.btnReporteLista.Click += new System.EventHandler(this.btnReporteLista_Click);
            // 
            // FormPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.btnReporteLista);
            this.Controls.Add(this.cmbTipoEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.txtBuscarEquipo);
            this.Controls.Add(this.btnEliminarPartido);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnEditarResultado);
            this.Controls.Add(this.btnAñadirPartido);
            this.Name = "FormPartidos";
            this.Text = "FormPatidos";
            this.Load += new System.EventHandler(this.FormPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirPartido;
        private Guna.UI.WinForms.GunaButton btnEditarResultado;
        private Guna.UI.WinForms.GunaButton btnCargarDatos;
        private Guna.UI.WinForms.GunaButton btnVerDetalles;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private Guna.UI.WinForms.GunaButton btnEliminarPartido;
        private Guna.UI.WinForms.GunaTextBox txtBuscarEquipo;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private Guna.UI.WinForms.GunaButton btnLimpiarFiltro;
        private System.Windows.Forms.ComboBox cmbEstado;
        private Guna.UI.WinForms.GunaTextBox txtUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnFiltrar;
        private System.Windows.Forms.ComboBox cmbTipoEquipo;
        private Guna.UI.WinForms.GunaButton btnReporteLista;
    }
}