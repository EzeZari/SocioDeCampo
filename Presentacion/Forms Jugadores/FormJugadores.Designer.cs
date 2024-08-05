
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJugadores));
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtLastNameJug = new Guna.UI.WinForms.GunaTextBox();
            this.txtBirthdate = new Guna.UI.WinForms.GunaTextBox();
            this.txtPositionJug = new Guna.UI.WinForms.GunaTextBox();
            this.btnSaveJugador = new Guna.UI.WinForms.GunaButton();
            this.txtNationality = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnInforme = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(549, 89);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nombre";
            // 
            // txtLastNameJug
            // 
            this.txtLastNameJug.BaseColor = System.Drawing.Color.White;
            this.txtLastNameJug.BorderColor = System.Drawing.Color.Silver;
            this.txtLastNameJug.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameJug.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastNameJug.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLastNameJug.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLastNameJug.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastNameJug.Location = new System.Drawing.Point(549, 139);
            this.txtLastNameJug.Name = "txtLastNameJug";
            this.txtLastNameJug.PasswordChar = '\0';
            this.txtLastNameJug.Size = new System.Drawing.Size(160, 30);
            this.txtLastNameJug.TabIndex = 3;
            this.txtLastNameJug.Text = "Apellido";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.BaseColor = System.Drawing.Color.White;
            this.txtBirthdate.BorderColor = System.Drawing.Color.Silver;
            this.txtBirthdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthdate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBirthdate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBirthdate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBirthdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBirthdate.Location = new System.Drawing.Point(549, 195);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.PasswordChar = '\0';
            this.txtBirthdate.Size = new System.Drawing.Size(160, 30);
            this.txtBirthdate.TabIndex = 4;
            this.txtBirthdate.Text = "Fecha de Nacimiento";
            // 
            // txtPositionJug
            // 
            this.txtPositionJug.BaseColor = System.Drawing.Color.White;
            this.txtPositionJug.BorderColor = System.Drawing.Color.Silver;
            this.txtPositionJug.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPositionJug.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPositionJug.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPositionJug.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPositionJug.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPositionJug.Location = new System.Drawing.Point(549, 297);
            this.txtPositionJug.Name = "txtPositionJug";
            this.txtPositionJug.PasswordChar = '\0';
            this.txtPositionJug.Size = new System.Drawing.Size(160, 30);
            this.txtPositionJug.TabIndex = 5;
            this.txtPositionJug.Text = "Posicion";
            // 
            // btnSaveJugador
            // 
            this.btnSaveJugador.AnimationHoverSpeed = 0.07F;
            this.btnSaveJugador.AnimationSpeed = 0.03F;
            this.btnSaveJugador.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSaveJugador.BorderColor = System.Drawing.Color.Black;
            this.btnSaveJugador.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveJugador.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveJugador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveJugador.ForeColor = System.Drawing.Color.White;
            this.btnSaveJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveJugador.Image")));
            this.btnSaveJugador.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveJugador.Location = new System.Drawing.Point(549, 349);
            this.btnSaveJugador.Name = "btnSaveJugador";
            this.btnSaveJugador.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSaveJugador.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveJugador.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveJugador.OnHoverImage = null;
            this.btnSaveJugador.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveJugador.Size = new System.Drawing.Size(160, 42);
            this.btnSaveJugador.TabIndex = 6;
            this.btnSaveJugador.Text = "Guardar ";
            // 
            // txtNationality
            // 
            this.txtNationality.BaseColor = System.Drawing.Color.White;
            this.txtNationality.BorderColor = System.Drawing.Color.Silver;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNationality.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNationality.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNationality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationality.Location = new System.Drawing.Point(549, 249);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.Size = new System.Drawing.Size(160, 30);
            this.txtNationality.TabIndex = 7;
            this.txtNationality.Text = "Nacionalidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 291);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(104, 349);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Size = new System.Drawing.Size(160, 42);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(287, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Size = new System.Drawing.Size(160, 42);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(104, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(160, 42);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.AnimationHoverSpeed = 0.07F;
            this.btnInforme.AnimationSpeed = 0.03F;
            this.btnInforme.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnInforme.BorderColor = System.Drawing.Color.Black;
            this.btnInforme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInforme.FocusedColor = System.Drawing.Color.Empty;
            this.btnInforme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInforme.ForeColor = System.Drawing.Color.White;
            this.btnInforme.Image = ((System.Drawing.Image)(resources.GetObject("btnInforme.Image")));
            this.btnInforme.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInforme.Location = new System.Drawing.Point(446, 464);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnInforme.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInforme.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInforme.OnHoverImage = null;
            this.btnInforme.OnPressedColor = System.Drawing.Color.Black;
            this.btnInforme.Size = new System.Drawing.Size(160, 42);
            this.btnInforme.TabIndex = 12;
            this.btnInforme.Text = "Informe";
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // FormJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(876, 543);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.btnSaveJugador);
            this.Controls.Add(this.txtPositionJug);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtLastNameJug);
            this.Controls.Add(this.txtName);
            this.Name = "FormJugadores";
            this.Text = "FormJugadores";
            this.Load += new System.EventHandler(this.FormJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaTextBox txtLastNameJug;
        private Guna.UI.WinForms.GunaTextBox txtBirthdate;
        private Guna.UI.WinForms.GunaTextBox txtPositionJug;
        private Guna.UI.WinForms.GunaButton btnSaveJugador;
        private Guna.UI.WinForms.GunaTextBox txtNationality;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnInforme;
    }
}