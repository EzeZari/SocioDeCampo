
namespace Presentacion
{
    partial class FormJugadores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddContrato = new Guna.UI.WinForms.GunaButton();
            this.btnVerContrato = new Guna.UI.WinForms.GunaButton();
            this.btnGenerarInforme = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 555);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = null;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(862, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Size = new System.Drawing.Size(120, 40);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BaseColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(1006, 55);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.BaseColor = System.Drawing.Color.Green;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(718, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestion de Jugadores";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 2);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnAddContrato
            // 
            this.btnAddContrato.AnimationHoverSpeed = 0.07F;
            this.btnAddContrato.AnimationSpeed = 0.03F;
            this.btnAddContrato.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btnAddContrato.BorderColor = System.Drawing.Color.Black;
            this.btnAddContrato.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddContrato.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddContrato.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddContrato.ForeColor = System.Drawing.Color.White;
            this.btnAddContrato.Image = null;
            this.btnAddContrato.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddContrato.Location = new System.Drawing.Point(16, 55);
            this.btnAddContrato.Name = "btnAddContrato";
            this.btnAddContrato.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnAddContrato.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddContrato.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddContrato.OnHoverImage = null;
            this.btnAddContrato.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddContrato.Size = new System.Drawing.Size(120, 42);
            this.btnAddContrato.TabIndex = 16;
            this.btnAddContrato.Text = "Agregar Contrato";
            this.btnAddContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddContrato.Visible = false;
            this.btnAddContrato.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnVerContrato
            // 
            this.btnVerContrato.AnimationHoverSpeed = 0.07F;
            this.btnVerContrato.AnimationSpeed = 0.03F;
            this.btnVerContrato.BackColor = System.Drawing.Color.White;
            this.btnVerContrato.BaseColor = System.Drawing.Color.Transparent;
            this.btnVerContrato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnVerContrato.BorderSize = 2;
            this.btnVerContrato.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerContrato.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerContrato.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVerContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnVerContrato.Image = null;
            this.btnVerContrato.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerContrato.Location = new System.Drawing.Point(175, 55);
            this.btnVerContrato.Name = "btnVerContrato";
            this.btnVerContrato.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnVerContrato.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnVerContrato.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerContrato.OnHoverImage = null;
            this.btnVerContrato.OnPressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnVerContrato.Size = new System.Drawing.Size(120, 42);
            this.btnVerContrato.TabIndex = 17;
            this.btnVerContrato.Text = "Ver contrato";
            this.btnVerContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerContrato.Visible = false;
            this.btnVerContrato.Click += new System.EventHandler(this.btnVerContrato_Click_1);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSize = true;
            this.btnGenerarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnGenerarInforme.Location = new System.Drawing.Point(1012, 15);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(104, 16);
            this.btnGenerarInforme.TabIndex = 18;
            this.btnGenerarInforme.TabStop = true;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnGenerarInforme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGenerarInforme_LinkClicked);
            // 
            // FormJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 690);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnVerContrato);
            this.Controls.Add(this.btnAddContrato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormJugadores";
            this.Text = "FormJugadores";
            this.Load += new System.EventHandler(this.FormJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btnAddContrato;
        private Guna.UI.WinForms.GunaButton btnVerContrato;
        private System.Windows.Forms.LinkLabel btnGenerarInforme;
    }
}