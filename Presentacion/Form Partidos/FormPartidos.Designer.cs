
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
            this.dgvPartidos.Size = new System.Drawing.Size(965, 251);
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
            // FormPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
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

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirPartido;
        private Guna.UI.WinForms.GunaButton btnEditarResultado;
        private Guna.UI.WinForms.GunaButton btnCargarDatos;
        private Guna.UI.WinForms.GunaButton btnVerDetalles;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private Guna.UI.WinForms.GunaButton btnEliminarPartido;
    }
}