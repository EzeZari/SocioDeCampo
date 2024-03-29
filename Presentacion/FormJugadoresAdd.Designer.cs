
namespace Presentacion
{
    partial class FormJugadoresAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJugadoresAdd));
            this.txtNationality = new Guna.UI.WinForms.GunaTextBox();
            this.btnSaveJugador = new Guna.UI.WinForms.GunaButton();
            this.txtPositionJug = new Guna.UI.WinForms.GunaTextBox();
            this.txtBirthdate = new Guna.UI.WinForms.GunaTextBox();
            this.txtLastNameJug = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
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
            this.txtNationality.Location = new System.Drawing.Point(80, 231);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.Size = new System.Drawing.Size(160, 30);
            this.txtNationality.TabIndex = 13;
            this.txtNationality.Text = "Nacionalidad";
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
            this.btnSaveJugador.Location = new System.Drawing.Point(237, 373);
            this.btnSaveJugador.Name = "btnSaveJugador";
            this.btnSaveJugador.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSaveJugador.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveJugador.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveJugador.OnHoverImage = null;
            this.btnSaveJugador.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveJugador.Size = new System.Drawing.Size(160, 42);
            this.btnSaveJugador.TabIndex = 12;
            this.btnSaveJugador.Text = "Guardar ";
            this.btnSaveJugador.Click += new System.EventHandler(this.btnSaveJugador_Click);
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
            this.txtPositionJug.Location = new System.Drawing.Point(80, 279);
            this.txtPositionJug.Name = "txtPositionJug";
            this.txtPositionJug.PasswordChar = '\0';
            this.txtPositionJug.Size = new System.Drawing.Size(160, 30);
            this.txtPositionJug.TabIndex = 11;
            this.txtPositionJug.Text = "Posicion";
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
            this.txtBirthdate.Location = new System.Drawing.Point(80, 177);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.PasswordChar = '\0';
            this.txtBirthdate.Size = new System.Drawing.Size(160, 30);
            this.txtBirthdate.TabIndex = 10;
            this.txtBirthdate.Text = "Fecha de Nacimiento";
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
            this.txtLastNameJug.Location = new System.Drawing.Point(80, 121);
            this.txtLastNameJug.Name = "txtLastNameJug";
            this.txtLastNameJug.PasswordChar = '\0';
            this.txtLastNameJug.Size = new System.Drawing.Size(160, 30);
            this.txtLastNameJug.TabIndex = 9;
            this.txtLastNameJug.Text = "Apellido";
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
            this.txtName.Location = new System.Drawing.Point(80, 71);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(502, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(499, 202);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // FormJugadoresAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.btnSaveJugador);
            this.Controls.Add(this.txtPositionJug);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtLastNameJug);
            this.Controls.Add(this.txtName);
            this.Name = "FormJugadoresAdd";
            this.Text = "Agregar Jugador";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtNationality;
        private Guna.UI.WinForms.GunaButton btnSaveJugador;
        private Guna.UI.WinForms.GunaTextBox txtPositionJug;
        private Guna.UI.WinForms.GunaTextBox txtBirthdate;
        private Guna.UI.WinForms.GunaTextBox txtLastNameJug;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}