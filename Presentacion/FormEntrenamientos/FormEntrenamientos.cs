using Common.Cache;
using Domain;
using OfficeOpenXml;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Common.Cache;
using Domain.Composite;
using Domain;


namespace Presentacion.FormEntrenamientos
{
    public partial class FormEntrenamientos : Form
    {
        private readonly EntrenamientoModel entrenamientoModel = new EntrenamientoModel();
        private readonly AuditoriaModel auditoriaModel = new AuditoriaModel();
        private Permiso permisosUsuario;

        public FormEntrenamientos()
        {
            InitializeComponent();
            dataGridViewEntrenamientos.SelectionChanged += dataGridViewEntrenamientos_SelectionChanged;

        }


        private void FormEntrenamientos_Load(object sender, EventArgs e)
        {
            permisosUsuario = FabricaPermisos.ObtenerPermisosPorCargo(UserCache.Position);

            CargarEntrenamientos();
            CargarJugadores();
            CargarAuditoria();
            AplicarPermisos();

        }
        private void AplicarPermisos()
        {
            // Deshabilita los botones si NO tiene el permiso de Gestión de Partidos
            if (!permisosUsuario.TienePermiso("GestionPartidos"))
            {
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                btnVerHistorial.Visible = false;
                btnAsignarJugadores.Visible = false;
                btnExportarAuditoria.Visible = false;

            }
        }
        private void CargarEntrenamientos()
        {
            dataGridViewEntrenamientos.DataSource = entrenamientoModel.MostrarEntrenamientos();
        }

        private void CargarJugadores()
        {
            var jugadores = entrenamientoModel.ObtenerJugadores();
            jugadores.Columns.Add("Seleccionado", typeof(bool));
            foreach (DataRow row in jugadores.Rows)
                row["Seleccionado"] = false;

            dataGridViewJugadores.DataSource = jugadores;
            dataGridViewJugadores.Columns["idJugador"].HeaderText = "ID";
            dataGridViewJugadores.Columns["Name"].HeaderText = "Nombre";
            dataGridViewJugadores.Columns["LastName"].HeaderText = "Apellido";
            dataGridViewJugadores.Columns["Seleccionado"].HeaderText = "✔ Seleccionar";
        }

        private void CargarJugadoresAsignados(int entrenamientoId)
        {
            var asignados = entrenamientoModel.ObtenerJugadoresAsignados(entrenamientoId);
            dataGridViewAsignados.DataSource = asignados;
            dataGridViewAsignados.Columns["idJugador"].HeaderText = "ID";
            dataGridViewAsignados.Columns["Name"].HeaderText = "Nombre";
            dataGridViewAsignados.Columns["LastName"].HeaderText = "Apellido";
        }

        private void CargarAuditoria()
        {
            dataGridViewAuditoria.DataSource = auditoriaModel.ObtenerAuditorias();
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

            var nuevoEntrenamiento = new Common.Cache.EntrenamientoCache
            {
                Titulo = txtTitulo.Text,
                Descripcion = txtDescripcion.Text,
                Lugar = txtLugar.Text,
                Duracion = duracion,
                Fecha = dateTimePickerFecha.Value,
                EntrenadorId = UserCache.UserID
            };

            entrenamientoModel.CrearEntrenamiento(nuevoEntrenamiento);
            int idNuevo = entrenamientoModel.ObtenerUltimoEntrenamientoId();
            auditoriaModel.RegistrarCreacionEntrenamiento(idNuevo);

            CargarEntrenamientos();
            CargarAuditoria();
            MessageBox.Show("Entrenamiento agregado con éxito.");
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntrenamientos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un entrenamiento para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro que querés eliminar este entrenamiento?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            int entrenamientoId = Convert.ToInt32(dataGridViewEntrenamientos.CurrentRow.Cells["id"].Value);

            auditoriaModel.RegistrarEliminacionEntrenamiento(entrenamientoId);
            entrenamientoModel.EliminarEntrenamiento(entrenamientoId);

            CargarEntrenamientos();
            CargarAuditoria();

            MessageBox.Show("Entrenamiento eliminado correctamente.");
        }




        private void btnAsignarJugadores_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntrenamientos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un entrenamiento.");
                return;
            }

            int entrenamientoId = Convert.ToInt32(dataGridViewEntrenamientos.CurrentRow.Cells["id"].Value);
            bool haySeleccionado = false;

            foreach (DataGridViewRow row in dataGridViewJugadores.Rows)
            {
                bool seleccionado = Convert.ToBoolean(row.Cells["Seleccionado"].Value ?? false);
                if (seleccionado)
                {
                    haySeleccionado = true;
                    int jugadorId = Convert.ToInt32(row.Cells["idJugador"].Value);
                    entrenamientoModel.AsignarJugador(entrenamientoId, jugadorId);
                    auditoriaModel.RegistrarAsignacionJugador(entrenamientoId, jugadorId);
                }
            }

            if (!haySeleccionado)
            {
                MessageBox.Show("Debés seleccionar al menos un jugador.");
                return;
            }

            CargarJugadoresAsignados(entrenamientoId);
            CargarAuditoria();
            MessageBox.Show("Asignación completada.");
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

        private void btnExportarAuditoria_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuditoria.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
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
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("Auditoría");

                        for (int i = 0; i < dataGridViewAuditoria.Columns.Count; i++)
                            ws.Cells[1, i + 1].Value = dataGridViewAuditoria.Columns[i].HeaderText;

                        for (int i = 0; i < dataGridViewAuditoria.Rows.Count; i++)
                            for (int j = 0; j < dataGridViewAuditoria.Columns.Count; j++)
                                ws.Cells[i + 2, j + 1].Value = dataGridViewAuditoria.Rows[i].Cells[j].Value?.ToString();

                        package.SaveAs(new FileInfo(sfd.FileName));
                        MessageBox.Show("Exportación exitosa.");
                    }
                }
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugadores.CurrentRow != null)
            {
                int jugadorId = Convert.ToInt32(dataGridViewJugadores.CurrentRow.Cells["idJugador"].Value);
                var historial = new FormHistorialJugador(jugadorId);
                historial.ShowDialog();
            }
        }

       

        private void btnFiltrar_Click(object sender, EventArgs e)
        {


            DateTime fechaInicio = dateTimePickerInicio.Value.Date;
            DateTime fechaFin = dateTimePickerFin.Value.Date.AddDays(1); // Incluye todo el día final

            dataGridViewEntrenamientos.DataSource = entrenamientoModel.FiltrarEntrenamientos(fechaInicio, fechaFin);


        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var form = new Presentacion.FormEstadisticasAuditoria.FormEstadisticasAuditoria();
            form.ShowDialog();
        }
    }
}
