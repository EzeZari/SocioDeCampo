
namespace SocioDeCampo1
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnEntrar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtContraseña = new Guna.UI.WinForms.GunaTextBox();
            this.txtusuario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnCerrar = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMin = new Guna.UI.WinForms.GunaPictureBox();
            this.g = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(212, 161);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(226, 42);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Iniciar Sesion ";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnEntrar);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txtContraseña);
            this.gunaGroupBox1.Controls.Add(this.txtusuario);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.White;
            this.gunaGroupBox1.Location = new System.Drawing.Point(75, 200);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 2;
            this.gunaGroupBox1.Size = new System.Drawing.Size(500, 368);
            this.gunaGroupBox1.TabIndex = 3;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Animated = true;
            this.btnEntrar.AnimationHoverSpeed = 0.07F;
            this.btnEntrar.AnimationSpeed = 0.03F;
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.Black;
            this.btnEntrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntrar.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = null;
            this.btnEntrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntrar.Location = new System.Drawing.Point(50, 284);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.btnEntrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntrar.OnHoverImage = null;
            this.btnEntrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntrar.Radius = 4;
            this.btnEntrar.Size = new System.Drawing.Size(400, 42);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(46, 79);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 23);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Usuario";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(46, 164);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 23);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BaseColor = System.Drawing.Color.White;
            this.txtContraseña.BorderColor = System.Drawing.Color.Silver;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtContraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContraseña.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.Location = new System.Drawing.Point(50, 190);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.Radius = 4;
            this.txtContraseña.Size = new System.Drawing.Size(400, 30);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.Transparent;
            this.txtusuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtusuario.BackgroundImage")));
            this.txtusuario.BaseColor = System.Drawing.Color.White;
            this.txtusuario.BorderColor = System.Drawing.Color.Silver;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusuario.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtusuario.Location = new System.Drawing.Point(50, 105);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.Radius = 4;
            this.txtusuario.Size = new System.Drawing.Size(400, 30);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.Text = "Usuario";
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(158, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(315, 131);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(80, 16);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(180, 18);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "¿Nuevo en Socio de Campo?";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.White;
            this.btnRegistrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRegistrar.BorderSize = 1;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(270, 10);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 4;
            this.btnRegistrar.Size = new System.Drawing.Size(130, 30);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.btnRegistrar);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.Location = new System.Drawing.Point(75, 614);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 2;
            this.gunaGroupBox2.Size = new System.Drawing.Size(500, 50);
            this.gunaGroupBox2.TabIndex = 7;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BaseColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(632, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // btnMin
            // 
            this.btnMin.BaseColor = System.Drawing.Color.White;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(611, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(15, 15);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 9;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // g
            // 
            this.g.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.LinkColor = System.Drawing.Color.Transparent;
            this.g.Location = new System.Drawing.Point(12, 677);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(14, 13);
            this.g.TabIndex = 0;
            this.g.TabStop = true;
            this.g.Text = "g";
            this.g.VisitedLinkColor = System.Drawing.Color.Transparent;
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 700);
            this.Controls.Add(this.g);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btnEntrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtContraseña;
        private Guna.UI.WinForms.GunaTextBox txtusuario;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaPictureBox btnCerrar;
        private Guna.UI.WinForms.GunaPictureBox btnMin;
        private Guna.UI.WinForms.GunaLinkLabel g;
    }
}

