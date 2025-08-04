using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.IO;



namespace Presentacion.FormEntrenamientos
{
    public partial class FormEntrenamientos : Form
    {


        private EntrenamientoModel entrenamientoModel = new EntrenamientoModel();

        public FormEntrenamientos()
        {
            InitializeComponent();
            this.dataGridViewEntrenamientos.SelectionChanged += new System.EventHandler(this.dataGridViewEntrenamientos_SelectionChanged);

        }

        private void FormEntrenamientos_Load(object sender, EventArgs e)
        {
            CargarEntrenamientos();
            CargarJugadores();
            CargarAuditoria();
        }

        private void CargarAuditoria()
        {
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                ae.id,
                ae.entrenamiento_id,
                ISNULL(e.titulo, '(Entrenamiento eliminado)') AS entrenamiento,
                ae.jugador_id,
                ISNULL(j.Name + ' ' + j.LastName, '(Jugador eliminado)') AS jugador,
                ae.entrenador_id,
                ISNULL(u.FirstName + ' ' + u.LastName, '(Entrenador eliminado)') AS entrenador,
                ae.fecha_asignacion,
                ae.accion
            FROM AuditoriaEntrenamientos ae
            LEFT JOIN Entrenamientos e ON ae.entrenamiento_id = e.id
            LEFT JOIN Jugadores j ON ae.jugador_id = j.idJugador
            LEFT JOIN Users u ON ae.entrenador_id = u.UserID
            ORDER BY ae.fecha_asignacion DESC", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewAuditoria.DataSource = dt;
            }
        }



        private void CargarEntrenamientos()
        {
            dataGridViewEntrenamientos.DataSource = entrenamientoModel.MostrarEntrenamientos();
        }

        private void CargarJugadores()
        {
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT idJugador, Name, LastName FROM Jugadores", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Agregar columna "Seleccionado" e inicializar en false para todas las filas
                dt.Columns.Add("Seleccionado", typeof(bool));
                foreach (DataRow row in dt.Rows)
                {
                    row["Seleccionado"] = false;
                }

                // Asignar al DataGridView
                dataGridViewJugadores.DataSource = dt;

                // Ajustar encabezados (opcional)
                dataGridViewJugadores.Columns["idJugador"].HeaderText = "ID";
                dataGridViewJugadores.Columns["Name"].HeaderText = "Nombre";
                dataGridViewJugadores.Columns["LastName"].HeaderText = "Apellido";
                dataGridViewJugadores.Columns["Seleccionado"].HeaderText = "✔ Seleccionar";
            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtLugar.Text) || string.IsNullOrWhiteSpace(txtDuracion.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.");
                return;
            }

            if (!int.TryParse(txtDuracion.Text, out int duracion))
            {
                MessageBox.Show("La duración debe ser un número entero (en minutos).");
                return;
            }

            var entrenamiento = new EntrenamientoCache
            {
                Titulo = txtTitulo.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dateTimePickerFecha.Value,
                Duracion = duracion,
                Lugar = txtLugar.Text,
                EntrenadorId = UserCache.UserID
            };

            entrenamientoModel.CrearEntrenamiento(entrenamiento);
            MessageBox.Show("Entrenamiento agregado con éxito.");
            CargarEntrenamientos();

            // ✅ Seleccionar el último entrenamiento recién agregado
            if (dataGridViewEntrenamientos.Rows.Count > 0)
            {
                int lastRowIndex = dataGridViewEntrenamientos.Rows.Count - 1;
                dataGridViewEntrenamientos.ClearSelection();
                dataGridViewEntrenamientos.Rows[lastRowIndex].Selected = true;
                dataGridViewEntrenamientos.CurrentCell = dataGridViewEntrenamientos.Rows[lastRowIndex].Cells[0];

                // ✅ Obtener el ID del nuevo entrenamiento
                int nuevoId = Convert.ToInt32(dataGridViewEntrenamientos.Rows[lastRowIndex].Cells["id"].Value);

                // ✅ Registrar en la auditoría la creación del entrenamiento
                using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security=true"))
                {
                    conn.Open();

                    SqlCommand auditCmd = new SqlCommand(@"
                INSERT INTO AuditoriaEntrenamientos 
                (entrenamiento_id, jugador_id, entrenador_id, fecha_asignacion, accion) 
                VALUES 
                (@entrenamiento_id, NULL, @entrenador_id, @fecha_asignacion, @accion)", conn);

                    auditCmd.Parameters.AddWithValue("@entrenamiento_id", nuevoId);
                    auditCmd.Parameters.AddWithValue("@entrenador_id", UserCache.UserID);
                    auditCmd.Parameters.AddWithValue("@fecha_asignacion", DateTime.Now);
                    auditCmd.Parameters.AddWithValue("@accion", "Entrenamiento creado");
                    auditCmd.ExecuteNonQuery();
                }

                // ✅ Llamar manualmente al evento para actualizar jugadores asignados
                dataGridViewEntrenamientos_SelectionChanged(null, null);
                CargarAuditoria(); // Refrescar la grilla de auditoría
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntrenamientos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un entrenamiento para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro que querés eliminar este entrenamiento? Se borrarán también sus asignaciones y auditoría.", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            int entrenamientoId = Convert.ToInt32(dataGridViewEntrenamientos.CurrentRow.Cells["id"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true"))
                {
                    conn.Open();

                    // ✅ Registrar en auditoría antes de eliminar el entrenamiento
                    SqlCommand auditCmd = new SqlCommand(@"
                INSERT INTO AuditoriaEntrenamientos 
                (entrenamiento_id, jugador_id, entrenador_id, fecha_asignacion, accion) 
                VALUES 
                (@entrenamiento_id, NULL, @entrenador_id, @fecha_asignacion, @accion)", conn);

                    auditCmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                    auditCmd.Parameters.AddWithValue("@entrenador_id", UserCache.UserID);
                    auditCmd.Parameters.AddWithValue("@fecha_asignacion", DateTime.Now);
                    auditCmd.Parameters.AddWithValue("@accion", "Entrenamiento eliminado");
                    auditCmd.ExecuteNonQuery();
                }

                // ✅ Eliminar el entrenamiento y luego refrescar
                entrenamientoModel.EliminarEntrenamiento(entrenamientoId);

                CargarEntrenamientos();
                CargarAuditoria();

                MessageBox.Show("Entrenamiento eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar entrenamiento:\n" + ex.Message);
            }
        }









        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value.Date;
            DateTime fechaFin = dateTimePickerFin.Value.Date.AddDays(1); // Incluye todo el día final

            dataGridViewEntrenamientos.DataSource = entrenamientoModel.FiltrarEntrenamientos(fechaInicio, fechaFin);
        }


        private void btnAsignarJugadores_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntrenamientos.CurrentRow == null)
            {
                MessageBox.Show("Debés seleccionar un entrenamiento antes de asignar jugadores.");
                return;
            }

            int entrenamientoId = Convert.ToInt32(dataGridViewEntrenamientos.CurrentRow.Cells["id"].Value);

            if (UserCache.UserID <= 0)
            {
                MessageBox.Show("Usuario no válido. No se puede registrar la auditoría.");
                return;
            }

            // ✅ Verificar si hay al menos un jugador tildado
            bool haySeleccionados = dataGridViewJugadores.Rows
                .Cast<DataGridViewRow>()
                .Any(r => !(r.IsNewRow) && Convert.ToBoolean(r.Cells["Seleccionado"].Value ?? false));

            if (!haySeleccionados)
            {
                MessageBox.Show("Debés tildar al menos un jugador para asignar.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security=true"))
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridViewJugadores.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool seleccionado = Convert.ToBoolean(row.Cells["Seleccionado"].Value ?? false);
                    if (!seleccionado) continue;

                    int jugadorId = Convert.ToInt32(row.Cells["idJugador"].Value);

                    // Verificar si ya está asignado
                    SqlCommand checkCmd = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM Entrenamiento_Jugador 
                WHERE entrenamiento_id = @entrenamiento_id AND jugador_id = @jugador_id", conn);

                    checkCmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                    checkCmd.Parameters.AddWithValue("@jugador_id", jugadorId);
                    int existe = (int)checkCmd.ExecuteScalar();

                    if (existe == 0)
                    {
                        // ✅ Insertar en Entrenamiento_Jugador
                        SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO Entrenamiento_Jugador (entrenamiento_id, jugador_id) 
                    VALUES (@entrenamiento_id, @jugador_id)", conn);

                        insertCmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                        insertCmd.Parameters.AddWithValue("@jugador_id", jugadorId);
                        insertCmd.ExecuteNonQuery();

                        // ✅ Registrar en auditoría
                        SqlCommand auditCmd = new SqlCommand(@"
                    INSERT INTO AuditoriaEntrenamientos 
                    (entrenamiento_id, jugador_id, entrenador_id, fecha_asignacion, accion) 
                    VALUES 
                    (@entrenamiento_id, @jugador_id, @entrenador_id, @fecha, 'Asignación')", conn);

                        auditCmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                        auditCmd.Parameters.AddWithValue("@jugador_id", jugadorId);
                        auditCmd.Parameters.AddWithValue("@entrenador_id", UserCache.UserID);
                        auditCmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        auditCmd.ExecuteNonQuery();
                    }
                }
            }

            // 🔄 Refrescar grillas
            CargarJugadoresAsignados(entrenamientoId);
            CargarAuditoria();

            // ✅ Limpiar tildados
            foreach (DataGridViewRow row in dataGridViewJugadores.Rows)
            {
                if (row.Cells["Seleccionado"] != null)
                    row.Cells["Seleccionado"].Value = false;
            }

            MessageBox.Show("Jugadores asignados y auditoría registrada correctamente.");
        }








        private void dataGridViewEntrenamientos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEntrenamientos.CurrentRow != null)
            {
                CargarJugadores();

                int entrenamientoId = Convert.ToInt32(dataGridViewEntrenamientos.CurrentRow.Cells["id"].Value);
                CargarJugadoresAsignados(entrenamientoId);
            }
        }


        private void CargarJugadoresAsignados(int entrenamientoId)
        {
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT j.idJugador, j.Name, j.LastName
            FROM Entrenamiento_Jugador ej
            INNER JOIN Jugadores j ON ej.jugador_id = j.idJugador
            WHERE ej.entrenamiento_id = @entrenamiento_id", conn);

                cmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dataGridViewAsignados.DataSource = tabla;

                // Cambiar nombres de columna si querés
                dataGridViewAsignados.Columns["idJugador"].HeaderText = "ID";
                dataGridViewAsignados.Columns["Name"].HeaderText = "Nombre";
                dataGridViewAsignados.Columns["LastName"].HeaderText = "Apellido";
            }
        }







        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportarAuditoria_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuditoria.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la auditoría para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = "AuditoriaEntrenamientos.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // ✅ EPPlus 8+ requiere esto
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Auditoría");

                        // Encabezados
                        for (int i = 0; i < dataGridViewAuditoria.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridViewAuditoria.Columns[i].HeaderText;
                        }

                        // Filas
                        for (int i = 0; i < dataGridViewAuditoria.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewAuditoria.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridViewAuditoria.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        package.SaveAs(new FileInfo(sfd.FileName));
                        MessageBox.Show("Auditoría exportada exitosamente.");
                    }
                }
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugadores.CurrentRow != null)
            {
                int jugadorId = Convert.ToInt32(dataGridViewJugadores.CurrentRow.Cells["idJugador"].Value);
                FormHistorialJugador historialForm = new FormHistorialJugador(jugadorId);
                historialForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccioná un jugador para ver su historial.");
            }
        }

        private void btnDesasignarJugador_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var form = new Presentacion.FormEstadisticasAuditoria.FormEstadisticasAuditoria();
            form.ShowDialog();
        }
    }



}
