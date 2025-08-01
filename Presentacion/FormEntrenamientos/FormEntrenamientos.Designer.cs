
namespace Presentacion.FormEntrenamientos
{
    partial class FormEntrenamientos
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
            this.dataGridViewEntrenamientos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewJugadores = new System.Windows.Forms.DataGridView();
            this.btnAsignarJugadores = new System.Windows.Forms.Button();
            this.dataGridViewAuditoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAsignados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExportarAuditoria = new System.Windows.Forms.Button();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEntrenamientos
            // 
            this.dataGridViewEntrenamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrenamientos.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewEntrenamientos.Name = "dataGridViewEntrenamientos";
            this.dataGridViewEntrenamientos.RowHeadersWidth = 51;
            this.dataGridViewEntrenamientos.RowTemplate.Height = 24;
            this.dataGridViewEntrenamientos.Size = new System.Drawing.Size(550, 136);
            this.dataGridViewEntrenamientos.TabIndex = 0;
            this.dataGridViewEntrenamientos.SelectionChanged += new System.EventHandler(this.dataGridViewEntrenamientos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(178, 310);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(15, 276);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(144, 22);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 195);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(550, 58);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(129, 167);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(273, 22);
            this.dateTimePickerFecha.TabIndex = 6;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(404, 276);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(149, 22);
            this.txtDuracion.TabIndex = 7;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(204, 276);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(144, 22);
            this.txtLugar.TabIndex = 8;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(12, 339);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(273, 22);
            this.dateTimePickerInicio.TabIndex = 10;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(298, 339);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerFin.TabIndex = 11;
            // 
            // dataGridViewJugadores
            // 
            this.dataGridViewJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugadores.Location = new System.Drawing.Point(12, 405);
            this.dataGridViewJugadores.Name = "dataGridViewJugadores";
            this.dataGridViewJugadores.RowHeadersWidth = 51;
            this.dataGridViewJugadores.RowTemplate.Height = 24;
            this.dataGridViewJugadores.Size = new System.Drawing.Size(550, 274);
            this.dataGridViewJugadores.TabIndex = 12;
            // 
            // btnAsignarJugadores
            // 
            this.btnAsignarJugadores.Location = new System.Drawing.Point(162, 685);
            this.btnAsignarJugadores.Name = "btnAsignarJugadores";
            this.btnAsignarJugadores.Size = new System.Drawing.Size(193, 38);
            this.btnAsignarJugadores.TabIndex = 13;
            this.btnAsignarJugadores.Text = "AsignarJugadores";
            this.btnAsignarJugadores.UseVisualStyleBackColor = true;
            this.btnAsignarJugadores.Click += new System.EventHandler(this.btnAsignarJugadores_Click);
            // 
            // dataGridViewAuditoria
            // 
            this.dataGridViewAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuditoria.Location = new System.Drawing.Point(578, 23);
            this.dataGridViewAuditoria.Name = "dataGridViewAuditoria";
            this.dataGridViewAuditoria.RowHeadersWidth = 51;
            this.dataGridViewAuditoria.RowTemplate.Height = 24;
            this.dataGridViewAuditoria.Size = new System.Drawing.Size(510, 301);
            this.dataGridViewAuditoria.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lugar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Duracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filtrar entrenamientos ";
            // 
            // dataGridViewAsignados
            // 
            this.dataGridViewAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignados.Location = new System.Drawing.Point(578, 405);
            this.dataGridViewAsignados.Name = "dataGridViewAsignados";
            this.dataGridViewAsignados.RowHeadersWidth = 51;
            this.dataGridViewAsignados.RowTemplate.Height = 24;
            this.dataGridViewAsignados.Size = new System.Drawing.Size(510, 274);
            this.dataGridViewAsignados.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Auditorias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Futbolistas Asignados";
            // 
            // btnExportarAuditoria
            // 
            this.btnExportarAuditoria.Location = new System.Drawing.Point(578, 333);
            this.btnExportarAuditoria.Name = "btnExportarAuditoria";
            this.btnExportarAuditoria.Size = new System.Drawing.Size(510, 23);
            this.btnExportarAuditoria.TabIndex = 22;
            this.btnExportarAuditoria.Text = "Exportar";
            this.btnExportarAuditoria.UseVisualStyleBackColor = true;
            this.btnExportarAuditoria.Click += new System.EventHandler(this.btnExportarAuditoria_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(12, 685);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(144, 38);
            this.btnVerHistorial.TabIndex = 23;
            this.btnVerHistorial.Text = "Historial Jugadores";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Asignar Jugadores ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Entrenamientos";
            // 
            // FormEntrenamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnExportarAuditoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewAsignados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAuditoria);
            this.Controls.Add(this.btnAsignarJugadores);
            this.Controls.Add(this.dataGridViewJugadores);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewEntrenamientos);
            this.Name = "FormEntrenamientos";
            this.Text = "FormEntrenamientos";
            this.Load += new System.EventHandler(this.FormEntrenamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEntrenamientos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DataGridView dataGridViewJugadores;
        private System.Windows.Forms.Button btnAsignarJugadores;
        private System.Windows.Forms.DataGridView dataGridViewAuditoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAsignados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExportarAuditoria;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}