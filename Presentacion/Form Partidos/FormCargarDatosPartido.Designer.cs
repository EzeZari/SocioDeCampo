
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarDatosPartido));
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
            this.dgvGoles = new System.Windows.Forms.DataGridView();
            this.cmbJugadoresTarjeta = new System.Windows.Forms.ComboBox();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.txtMinutoTarjeta = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregarTarjeta = new Guna.UI.WinForms.GunaButton();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(21, 25);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(35, 13);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "label1";
            // 
            // lblVisitante
            // 
            this.lblVisitante.AutoSize = true;
            this.lblVisitante.Location = new System.Drawing.Point(149, 25);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(35, 13);
            this.lblVisitante.TabIndex = 1;
            this.lblVisitante.Text = "label1";
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
            this.txtResultadoLocal.Location = new System.Drawing.Point(24, 149);
            this.txtResultadoLocal.Name = "txtResultadoLocal";
            this.txtResultadoLocal.PasswordChar = '\0';
            this.txtResultadoLocal.Size = new System.Drawing.Size(160, 30);
            this.txtResultadoLocal.TabIndex = 2;
            this.txtResultadoLocal.Text = "gunaTextBox1";
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
            this.txtResultadoVisitante.Location = new System.Drawing.Point(24, 215);
            this.txtResultadoVisitante.Name = "txtResultadoVisitante";
            this.txtResultadoVisitante.PasswordChar = '\0';
            this.txtResultadoVisitante.Size = new System.Drawing.Size(160, 30);
            this.txtResultadoVisitante.TabIndex = 3;
            this.txtResultadoVisitante.Text = "gunaTextBox1";
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
            this.txtObservaciones.Location = new System.Drawing.Point(24, 278);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.Size = new System.Drawing.Size(160, 30);
            this.txtObservaciones.TabIndex = 4;
            this.txtObservaciones.Text = "gunaTextBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado Visitante:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(24, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(160, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbJugadoresGol
            // 
            this.cmbJugadoresGol.FormattingEnabled = true;
            this.cmbJugadoresGol.Location = new System.Drawing.Point(301, 61);
            this.cmbJugadoresGol.Name = "cmbJugadoresGol";
            this.cmbJugadoresGol.Size = new System.Drawing.Size(162, 21);
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
            this.txtMinutoGol.Location = new System.Drawing.Point(301, 116);
            this.txtMinutoGol.Name = "txtMinutoGol";
            this.txtMinutoGol.PasswordChar = '\0';
            this.txtMinutoGol.Size = new System.Drawing.Size(160, 30);
            this.txtMinutoGol.TabIndex = 10;
            this.txtMinutoGol.Text = "gunaTextBox1";
            // 
            // btnAgregarGol
            // 
            this.btnAgregarGol.AnimationHoverSpeed = 0.07F;
            this.btnAgregarGol.AnimationSpeed = 0.03F;
            this.btnAgregarGol.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAgregarGol.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarGol.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarGol.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarGol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarGol.ForeColor = System.Drawing.Color.White;
            this.btnAgregarGol.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGol.Image")));
            this.btnAgregarGol.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarGol.Location = new System.Drawing.Point(303, 184);
            this.btnAgregarGol.Name = "btnAgregarGol";
            this.btnAgregarGol.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarGol.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarGol.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarGol.OnHoverImage = null;
            this.btnAgregarGol.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarGol.Size = new System.Drawing.Size(160, 42);
            this.btnAgregarGol.TabIndex = 11;
            this.btnAgregarGol.Text = "gunaButton1";
            this.btnAgregarGol.Click += new System.EventHandler(this.btnAgregarGol_Click);
            // 
            // dgvGoles
            // 
            this.dgvGoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoles.Location = new System.Drawing.Point(303, 276);
            this.dgvGoles.Name = "dgvGoles";
            this.dgvGoles.Size = new System.Drawing.Size(160, 150);
            this.dgvGoles.TabIndex = 12;
            // 
            // cmbJugadoresTarjeta
            // 
            this.cmbJugadoresTarjeta.FormattingEnabled = true;
            this.cmbJugadoresTarjeta.Location = new System.Drawing.Point(557, 61);
            this.cmbJugadoresTarjeta.Name = "cmbJugadoresTarjeta";
            this.cmbJugadoresTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbJugadoresTarjeta.TabIndex = 13;
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(557, 116);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(121, 21);
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
            this.txtMinutoTarjeta.Location = new System.Drawing.Point(557, 182);
            this.txtMinutoTarjeta.Name = "txtMinutoTarjeta";
            this.txtMinutoTarjeta.PasswordChar = '\0';
            this.txtMinutoTarjeta.Size = new System.Drawing.Size(160, 30);
            this.txtMinutoTarjeta.TabIndex = 15;
            this.txtMinutoTarjeta.Text = "gunaTextBox1";
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.AnimationHoverSpeed = 0.07F;
            this.btnAgregarTarjeta.AnimationSpeed = 0.03F;
            this.btnAgregarTarjeta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAgregarTarjeta.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTarjeta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarTarjeta.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTarjeta.Image")));
            this.btnAgregarTarjeta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(557, 248);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarTarjeta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarTarjeta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarTarjeta.OnHoverImage = null;
            this.btnAgregarTarjeta.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(160, 42);
            this.btnAgregarTarjeta.TabIndex = 16;
            this.btnAgregarTarjeta.Text = "gunaButton1";
            this.btnAgregarTarjeta.Click += new System.EventHandler(this.btnAgregarTarjeta_Click);
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(557, 296);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.Size = new System.Drawing.Size(160, 150);
            this.dgvTarjetas.TabIndex = 17;
            // 
            // FormCargarDatosPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.btnAgregarTarjeta);
            this.Controls.Add(this.txtMinutoTarjeta);
            this.Controls.Add(this.cmbTipoTarjeta);
            this.Controls.Add(this.cmbJugadoresTarjeta);
            this.Controls.Add(this.dgvGoles);
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
        private System.Windows.Forms.DataGridView dgvGoles;
        private System.Windows.Forms.ComboBox cmbJugadoresTarjeta;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private Guna.UI.WinForms.GunaTextBox txtMinutoTarjeta;
        private Guna.UI.WinForms.GunaButton btnAgregarTarjeta;
        private System.Windows.Forms.DataGridView dgvTarjetas;
    }
}