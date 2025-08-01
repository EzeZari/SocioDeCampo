
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditarResultado = new Guna.UI.WinForms.GunaButton();
            this.btnCargarDatos = new Guna.UI.WinForms.GunaButton();
            this.btnVerDetalles = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarPartido = new Guna.UI.WinForms.GunaButton();
            this.txtBuscarEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.btnLimpiarFiltro = new Guna.UI.WinForms.GunaButton();
            this.txtUbicacion = new Guna.UI.WinForms.GunaTextBox();
            this.btnFiltrar = new Guna.UI.WinForms.GunaButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadirPartido = new Guna.UI.WinForms.GunaButton();
            this.btnGenerarInforme = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoEquipo = new Guna.UI.WinForms.GunaComboBox();
            this.dtpDesde = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHasta = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarResultado
            // 
            this.btnEditarResultado.AnimationHoverSpeed = 0.07F;
            this.btnEditarResultado.AnimationSpeed = 0.03F;
            this.btnEditarResultado.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnEditarResultado.BorderColor = System.Drawing.Color.Black;
            this.btnEditarResultado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditarResultado.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditarResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditarResultado.ForeColor = System.Drawing.Color.White;
            this.btnEditarResultado.Image = null;
            this.btnEditarResultado.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditarResultado.Location = new System.Drawing.Point(325, 55);
            this.btnEditarResultado.Name = "btnEditarResultado";
            this.btnEditarResultado.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnEditarResultado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditarResultado.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditarResultado.OnHoverImage = null;
            this.btnEditarResultado.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditarResultado.Size = new System.Drawing.Size(112, 42);
            this.btnEditarResultado.TabIndex = 2;
            this.btnEditarResultado.Text = "Editar resultado";
            this.btnEditarResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditarResultado.Click += new System.EventHandler(this.btnEditarResultado_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.AnimationHoverSpeed = 0.07F;
            this.btnCargarDatos.AnimationSpeed = 0.03F;
            this.btnCargarDatos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnCargarDatos.BorderColor = System.Drawing.Color.Black;
            this.btnCargarDatos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCargarDatos.FocusedColor = System.Drawing.Color.Empty;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.Image = null;
            this.btnCargarDatos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCargarDatos.Location = new System.Drawing.Point(154, 55);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCargarDatos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarDatos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.OnHoverImage = null;
            this.btnCargarDatos.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarDatos.Size = new System.Drawing.Size(165, 42);
            this.btnCargarDatos.TabIndex = 3;
            this.btnCargarDatos.Text = "Cargar datos del partido";
            this.btnCargarDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.AnimationHoverSpeed = 0.07F;
            this.btnVerDetalles.AnimationSpeed = 0.03F;
            this.btnVerDetalles.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnVerDetalles.BorderColor = System.Drawing.Color.Black;
            this.btnVerDetalles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerDetalles.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerDetalles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVerDetalles.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.Image = null;
            this.btnVerDetalles.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerDetalles.Location = new System.Drawing.Point(443, 55);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVerDetalles.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerDetalles.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.OnHoverImage = null;
            this.btnVerDetalles.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerDetalles.Size = new System.Drawing.Size(117, 42);
            this.btnVerDetalles.TabIndex = 4;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.AnimationHoverSpeed = 0.07F;
            this.btnEliminarPartido.AnimationSpeed = 0.03F;
            this.btnEliminarPartido.BaseColor = System.Drawing.Color.Red;
            this.btnEliminarPartido.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarPartido.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarPartido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEliminarPartido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPartido.Image = null;
            this.btnEliminarPartido.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarPartido.Location = new System.Drawing.Point(566, 55);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarPartido.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarPartido.OnHoverImage = null;
            this.btnEliminarPartido.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.Size = new System.Drawing.Size(160, 42);
            this.btnEliminarPartido.TabIndex = 6;
            this.btnEliminarPartido.Text = "Eliminar Partido";
            this.btnEliminarPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtBuscarEquipo.Location = new System.Drawing.Point(869, 173);
            this.txtBuscarEquipo.Name = "txtBuscarEquipo";
            this.txtBuscarEquipo.PasswordChar = '\0';
            this.txtBuscarEquipo.Size = new System.Drawing.Size(254, 26);
            this.txtBuscarEquipo.TabIndex = 7;
            this.txtBuscarEquipo.TextChanged += new System.EventHandler(this.txtBuscarEquipo_TextChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(868, 521);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(99, 17);
            this.chkFecha.TabIndex = 8;
            this.chkFecha.Text = "Filtrar por fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarFiltro.AnimationSpeed = 0.03F;
            this.btnLimpiarFiltro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnLimpiarFiltro.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarFiltro.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.Image = null;
            this.btnLimpiarFiltro.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(1014, 636);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiarFiltro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.OnHoverImage = null;
            this.btnLimpiarFiltro.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(109, 42);
            this.btnLimpiarFiltro.TabIndex = 12;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
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
            this.txtUbicacion.Location = new System.Drawing.Point(869, 363);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.PasswordChar = '\0';
            this.txtUbicacion.Size = new System.Drawing.Size(254, 26);
            this.txtUbicacion.TabIndex = 14;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AnimationHoverSpeed = 0.07F;
            this.btnFiltrar.AnimationSpeed = 0.03F;
            this.btnFiltrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = null;
            this.btnFiltrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltrar.Location = new System.Drawing.Point(870, 636);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFiltrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnHoverImage = null;
            this.btnFiltrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFiltrar.Size = new System.Drawing.Size(121, 42);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Aplicar Filtro";
            this.btnFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 2);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gestion de Partidos";
            // 
            // btnAñadirPartido
            // 
            this.btnAñadirPartido.AnimationHoverSpeed = 0.07F;
            this.btnAñadirPartido.AnimationSpeed = 0.03F;
            this.btnAñadirPartido.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnAñadirPartido.BorderColor = System.Drawing.Color.Black;
            this.btnAñadirPartido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAñadirPartido.FocusedColor = System.Drawing.Color.Empty;
            this.btnAñadirPartido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAñadirPartido.ForeColor = System.Drawing.Color.White;
            this.btnAñadirPartido.Image = null;
            this.btnAñadirPartido.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAñadirPartido.Location = new System.Drawing.Point(16, 55);
            this.btnAñadirPartido.Name = "btnAñadirPartido";
            this.btnAñadirPartido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAñadirPartido.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAñadirPartido.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAñadirPartido.OnHoverImage = null;
            this.btnAñadirPartido.OnPressedColor = System.Drawing.Color.Black;
            this.btnAñadirPartido.Size = new System.Drawing.Size(118, 42);
            this.btnAñadirPartido.TabIndex = 23;
            this.btnAñadirPartido.Text = "Añadir Partido";
            this.btnAñadirPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAñadirPartido.Click += new System.EventHandler(this.btnAñadirPartido_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSize = true;
            this.btnGenerarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnGenerarInforme.Location = new System.Drawing.Point(1038, 15);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(104, 16);
            this.btnGenerarInforme.TabIndex = 24;
            this.btnGenerarInforme.TabStop = true;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnGenerarInforme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGenerarInforme_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(866, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seleccioná el equipo...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(866, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo de equipo (Local / Visitante)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(867, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estado del partido";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BaseColor = System.Drawing.Color.White;
            this.cmbEstado.BorderColor = System.Drawing.Color.Silver;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Jugados",
            "No Jugados"});
            this.cmbEstado.Location = new System.Drawing.Point(869, 299);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEstado.Size = new System.Drawing.Size(254, 26);
            this.cmbEstado.TabIndex = 29;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(866, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(867, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ubicación";
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoEquipo.BaseColor = System.Drawing.Color.White;
            this.cmbTipoEquipo.BorderColor = System.Drawing.Color.Silver;
            this.cmbTipoEquipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEquipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoEquipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoEquipo.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Items.AddRange(new object[] {
            "Local",
            "Visitante"});
            this.cmbTipoEquipo.Location = new System.Drawing.Point(870, 237);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTipoEquipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTipoEquipo.Size = new System.Drawing.Size(253, 26);
            this.cmbTipoEquipo.TabIndex = 32;
            this.cmbTipoEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEquipo_SelectedIndexChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.BaseColor = System.Drawing.Color.White;
            this.dtpDesde.BorderColor = System.Drawing.Color.Silver;
            this.dtpDesde.CustomFormat = null;
            this.dtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDesde.Enabled = false;
            this.dtpDesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDesde.ForeColor = System.Drawing.Color.Black;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(869, 435);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDesde.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDesde.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDesde.Size = new System.Drawing.Size(253, 30);
            this.dtpDesde.TabIndex = 33;
            this.dtpDesde.Text = "1/8/2025";
            this.dtpDesde.Value = new System.DateTime(2025, 8, 1, 13, 27, 20, 956);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(866, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rango de fechas";
            // 
            // dtpHasta
            // 
            this.dtpHasta.BaseColor = System.Drawing.Color.White;
            this.dtpHasta.BorderColor = System.Drawing.Color.Silver;
            this.dtpHasta.CustomFormat = null;
            this.dtpHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpHasta.Enabled = false;
            this.dtpHasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHasta.ForeColor = System.Drawing.Color.Black;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(868, 471);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpHasta.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpHasta.OnPressedColor = System.Drawing.Color.Black;
            this.dtpHasta.Size = new System.Drawing.Size(254, 30);
            this.dtpHasta.TabIndex = 35;
            this.dtpHasta.Text = "1/8/2025";
            this.dtpHasta.Value = new System.DateTime(2025, 8, 1, 13, 27, 20, 956);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPartidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPartidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPartidos.ColumnHeadersHeight = 30;
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPartidos.EnableHeadersVisualStyles = false;
            this.dgvPartidos.Location = new System.Drawing.Point(16, 123);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPartidos.RowHeadersWidth = 50;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dgvPartidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPartidos.RowTemplate.Height = 50;
            this.dgvPartidos.Size = new System.Drawing.Size(793, 555);
            this.dgvPartidos.TabIndex = 36;
            this.dgvPartidos.SelectionChanged += new System.EventHandler(this.dgvPartidos_SelectionChanged);
            // 
            // FormPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 690);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.cmbTipoEquipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnAñadirPartido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.txtBuscarEquipo);
            this.Controls.Add(this.btnEliminarPartido);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnEditarResultado);
            this.Name = "FormPartidos";
            this.Text = "FormPatidos";
            this.Load += new System.EventHandler(this.FormPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnEditarResultado;
        private Guna.UI.WinForms.GunaButton btnCargarDatos;
        private Guna.UI.WinForms.GunaButton btnVerDetalles;
        private Guna.UI.WinForms.GunaButton btnEliminarPartido;
        private Guna.UI.WinForms.GunaTextBox txtBuscarEquipo;
        private System.Windows.Forms.CheckBox chkFecha;
        private Guna.UI.WinForms.GunaButton btnLimpiarFiltro;
        private Guna.UI.WinForms.GunaTextBox txtUbicacion;
        private Guna.UI.WinForms.GunaButton btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnAñadirPartido;
        private System.Windows.Forms.LinkLabel btnGenerarInforme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cmbTipoEquipo;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDesde;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDateTimePicker dtpHasta;
        private System.Windows.Forms.DataGridView dgvPartidos;
    }
}