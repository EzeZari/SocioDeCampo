
namespace Presentacion
{
    partial class FormCargarDatosPartido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblVisitante = new System.Windows.Forms.Label();
            this.txtResultadoLocal = new Guna.UI.WinForms.GunaTextBox();
            this.txtResultadoVisitante = new Guna.UI.WinForms.GunaTextBox();
            this.txtObservaciones = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.cmbJugadoresGol = new System.Windows.Forms.ComboBox();
            this.txtMinutoGol = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregarGol = new Guna.UI.WinForms.GunaButton();
            this.cmbJugadoresTarjeta = new System.Windows.Forms.ComboBox();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.txtMinutoTarjeta = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregarTarjeta = new Guna.UI.WinForms.GunaButton();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.lblNumeroFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarGol = new System.Windows.Forms.LinkLabel();
            this.btnEliminarTarjeta = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvGoles = new System.Windows.Forms.DataGridView();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblLocal.Location = new System.Drawing.Point(107, 55);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(44, 20);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Local";
            // 
            // lblVisitante
            // 
            this.lblVisitante.AutoSize = true;
            this.lblVisitante.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblVisitante.Location = new System.Drawing.Point(128, 75);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(68, 20);
            this.lblVisitante.TabIndex = 1;
            this.lblVisitante.Text = "Visitante";
            // 
            // txtResultadoLocal
            // 
            this.txtResultadoLocal.BaseColor = System.Drawing.Color.White;
            this.txtResultadoLocal.BorderColor = System.Drawing.Color.Silver;
            this.txtResultadoLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultadoLocal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResultadoLocal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtResultadoLocal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultadoLocal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultadoLocal.Location = new System.Drawing.Point(19, 191);
            this.txtResultadoLocal.Name = "txtResultadoLocal";
            this.txtResultadoLocal.PasswordChar = '\0';
            this.txtResultadoLocal.Size = new System.Drawing.Size(160, 30);
            this.txtResultadoLocal.TabIndex = 2;
            // 
            // txtResultadoVisitante
            // 
            this.txtResultadoVisitante.BaseColor = System.Drawing.Color.White;
            this.txtResultadoVisitante.BorderColor = System.Drawing.Color.Silver;
            this.txtResultadoVisitante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultadoVisitante.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResultadoVisitante.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtResultadoVisitante.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultadoVisitante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResultadoVisitante.Location = new System.Drawing.Point(19, 257);
            this.txtResultadoVisitante.Name = "txtResultadoVisitante";
            this.txtResultadoVisitante.PasswordChar = '\0';
            this.txtResultadoVisitante.Size = new System.Drawing.Size(160, 30);
            this.txtResultadoVisitante.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BaseColor = System.Drawing.Color.White;
            this.txtObservaciones.BorderColor = System.Drawing.Color.Silver;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.FocusedBaseColor = System.Drawing.Color.White;
            this.txtObservaciones.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtObservaciones.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.Location = new System.Drawing.Point(19, 320);
            this.txtObservaciones.MultiLine = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.Size = new System.Drawing.Size(160, 82);
            this.txtObservaciones.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Goles Equipo Local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Goles Equipo Visitante:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(19, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(160, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbJugadoresGol
            // 
            this.cmbJugadoresGol.FormattingEnabled = true;
            this.cmbJugadoresGol.Location = new System.Drawing.Point(259, 121);
            this.cmbJugadoresGol.Name = "cmbJugadoresGol";
            this.cmbJugadoresGol.Size = new System.Drawing.Size(229, 21);
            this.cmbJugadoresGol.TabIndex = 9;
            // 
            // txtMinutoGol
            // 
            this.txtMinutoGol.BaseColor = System.Drawing.Color.White;
            this.txtMinutoGol.BorderColor = System.Drawing.Color.Silver;
            this.txtMinutoGol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinutoGol.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMinutoGol.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMinutoGol.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMinutoGol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinutoGol.Location = new System.Drawing.Point(259, 175);
            this.txtMinutoGol.Name = "txtMinutoGol";
            this.txtMinutoGol.PasswordChar = '\0';
            this.txtMinutoGol.Size = new System.Drawing.Size(229, 30);
            this.txtMinutoGol.TabIndex = 10;
            // 
            // btnAgregarGol
            // 
            this.btnAgregarGol.AnimationHoverSpeed = 0.07F;
            this.btnAgregarGol.AnimationSpeed = 0.03F;
            this.btnAgregarGol.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnAgregarGol.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarGol.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarGol.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarGol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGol.ForeColor = System.Drawing.Color.White;
            this.btnAgregarGol.Image = null;
            this.btnAgregarGol.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarGol.Location = new System.Drawing.Point(263, 219);
            this.btnAgregarGol.Name = "btnAgregarGol";
            this.btnAgregarGol.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarGol.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarGol.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarGol.OnHoverImage = null;
            this.btnAgregarGol.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarGol.Size = new System.Drawing.Size(225, 35);
            this.btnAgregarGol.TabIndex = 11;
            this.btnAgregarGol.Text = "Añadir gol";
            this.btnAgregarGol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarGol.Click += new System.EventHandler(this.btnAgregarGol_Click);
            // 
            // cmbJugadoresTarjeta
            // 
            this.cmbJugadoresTarjeta.FormattingEnabled = true;
            this.cmbJugadoresTarjeta.Location = new System.Drawing.Point(549, 88);
            this.cmbJugadoresTarjeta.Name = "cmbJugadoresTarjeta";
            this.cmbJugadoresTarjeta.Size = new System.Drawing.Size(266, 21);
            this.cmbJugadoresTarjeta.TabIndex = 13;
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(549, 134);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(266, 21);
            this.cmbTipoTarjeta.TabIndex = 14;
            // 
            // txtMinutoTarjeta
            // 
            this.txtMinutoTarjeta.BaseColor = System.Drawing.Color.White;
            this.txtMinutoTarjeta.BorderColor = System.Drawing.Color.Silver;
            this.txtMinutoTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinutoTarjeta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMinutoTarjeta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMinutoTarjeta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMinutoTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinutoTarjeta.Location = new System.Drawing.Point(549, 176);
            this.txtMinutoTarjeta.Name = "txtMinutoTarjeta";
            this.txtMinutoTarjeta.PasswordChar = '\0';
            this.txtMinutoTarjeta.Size = new System.Drawing.Size(266, 29);
            this.txtMinutoTarjeta.TabIndex = 15;
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.AnimationHoverSpeed = 0.07F;
            this.btnAgregarTarjeta.AnimationSpeed = 0.03F;
            this.btnAgregarTarjeta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnAgregarTarjeta.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTarjeta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarTarjeta.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarjeta.Image = null;
            this.btnAgregarTarjeta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(549, 219);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarTarjeta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarTarjeta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarTarjeta.OnHoverImage = null;
            this.btnAgregarTarjeta.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(266, 35);
            this.btnAgregarTarjeta.TabIndex = 16;
            this.btnAgregarTarjeta.Text = "Añadir tarjeta";
            this.btnAgregarTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarTarjeta.Click += new System.EventHandler(this.btnAgregarTarjeta_Click);
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadio.Location = new System.Drawing.Point(78, 105);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(60, 20);
            this.lblEstadio.TabIndex = 20;
            this.lblEstadio.Text = "Estadio";
            // 
            // lblNumeroFecha
            // 
            this.lblNumeroFecha.AutoSize = true;
            this.lblNumeroFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNumeroFecha.Location = new System.Drawing.Point(89, 134);
            this.lblNumeroFecha.Name = "lblNumeroFecha";
            this.lblNumeroFecha.Size = new System.Drawing.Size(71, 20);
            this.lblNumeroFecha.TabIndex = 21;
            this.lblNumeroFecha.Text = "N° Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 2);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cargar datos de Partido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Minuto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Jugador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(258, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Goles:";
            // 
            // btnEliminarGol
            // 
            this.btnEliminarGol.AutoSize = true;
            this.btnEliminarGol.LinkColor = System.Drawing.Color.Red;
            this.btnEliminarGol.Location = new System.Drawing.Point(461, 475);
            this.btnEliminarGol.Name = "btnEliminarGol";
            this.btnEliminarGol.Size = new System.Drawing.Size(62, 13);
            this.btnEliminarGol.TabIndex = 28;
            this.btnEliminarGol.TabStop = true;
            this.btnEliminarGol.Text = "Eliminar Gol";
            this.btnEliminarGol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnEliminarGol_LinkClicked);
            // 
            // btnEliminarTarjeta
            // 
            this.btnEliminarTarjeta.AutoSize = true;
            this.btnEliminarTarjeta.LinkColor = System.Drawing.Color.Red;
            this.btnEliminarTarjeta.Location = new System.Drawing.Point(740, 475);
            this.btnEliminarTarjeta.Name = "btnEliminarTarjeta";
            this.btnEliminarTarjeta.Size = new System.Drawing.Size(75, 13);
            this.btnEliminarTarjeta.TabIndex = 29;
            this.btnEliminarTarjeta.TabStop = true;
            this.btnEliminarTarjeta.Text = "Eliminar tarjeta";
            this.btnEliminarTarjeta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnEliminarTarjeta_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Jugador:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Minuto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tipo de tarjeta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(546, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tarjetas:";
            // 
            // dgvGoles
            // 
            this.dgvGoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGoles.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvGoles.ColumnHeadersHeight = 30;
            this.dgvGoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGoles.EnableHeadersVisualStyles = false;
            this.dgvGoles.Location = new System.Drawing.Point(259, 279);
            this.dgvGoles.Name = "dgvGoles";
            this.dgvGoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoles.RowHeadersWidth = 50;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dgvGoles.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvGoles.RowTemplate.Height = 50;
            this.dgvGoles.Size = new System.Drawing.Size(264, 189);
            this.dgvGoles.TabIndex = 34;
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTarjetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTarjetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarjetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarjetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarjetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTarjetas.ColumnHeadersHeight = 30;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTarjetas.EnableHeadersVisualStyles = false;
            this.dgvTarjetas.Location = new System.Drawing.Point(551, 279);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTarjetas.RowHeadersWidth = 50;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dgvTarjetas.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTarjetas.RowTemplate.Height = 50;
            this.dgvTarjetas.Size = new System.Drawing.Size(264, 189);
            this.dgvTarjetas.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(21, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Equipo local:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(21, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Equipo visitante:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(21, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Estadio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(21, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "N° Fecha:";
            // 
            // FormCargarDatosPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 497);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.dgvGoles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarTarjeta);
            this.Controls.Add(this.btnEliminarGol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumeroFecha);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.btnAgregarTarjeta);
            this.Controls.Add(this.txtMinutoTarjeta);
            this.Controls.Add(this.cmbTipoTarjeta);
            this.Controls.Add(this.cmbJugadoresTarjeta);
            this.Controls.Add(this.btnAgregarGol);
            this.Controls.Add(this.txtMinutoGol);
            this.Controls.Add(this.cmbJugadoresGol);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtResultadoVisitante);
            this.Controls.Add(this.txtResultadoLocal);
            this.Controls.Add(this.lblVisitante);
            this.Controls.Add(this.lblLocal);
            this.Name = "FormCargarDatosPartido";
            this.Text = "FormCargarDatosPartido";
            this.Load += new System.EventHandler(this.FormCargarDatosPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblVisitante;
        private Guna.UI.WinForms.GunaTextBox txtResultadoLocal;
        private Guna.UI.WinForms.GunaTextBox txtResultadoVisitante;
        private Guna.UI.WinForms.GunaTextBox txtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private System.Windows.Forms.ComboBox cmbJugadoresGol;
        private Guna.UI.WinForms.GunaTextBox txtMinutoGol;
        private Guna.UI.WinForms.GunaButton btnAgregarGol;
        private System.Windows.Forms.ComboBox cmbJugadoresTarjeta;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private Guna.UI.WinForms.GunaTextBox txtMinutoTarjeta;
        private Guna.UI.WinForms.GunaButton btnAgregarTarjeta;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.Label lblNumeroFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel btnEliminarGol;
        private System.Windows.Forms.LinkLabel btnEliminarTarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvGoles;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}