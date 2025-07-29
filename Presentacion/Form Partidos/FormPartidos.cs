using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;


namespace Presentacion
{
    public partial class FormPartidos : Form
    {
        public FormPartidos()
        {
            InitializeComponent();
        }

        private void btnAñadirPartido_Click(object sender, EventArgs e)
        {
            var formAddPartido = new FormAddPartido();
            formAddPartido.ShowDialog();

            // ✅ Refrescar lista al volver
            CargarPartidos();
        }

        private void FormPartidos_Load(object sender, EventArgs e)
        {
            CargarPartidos();
        }

        private void CargarPartidos()
        {
            PartidoModel model = new PartidoModel();
            var lista = model.ObtenerTodosLosPartidos();

            dgvPartidos.DataSource = lista;

            if (dgvPartidos.Columns["Hora"] != null)
            {
                dgvPartidos.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";
            }

            // dgvPartidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPartidos.ReadOnly = true;
            //dgvPartidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;
            var form = new FormCargarDatosPartido(partido);
            form.ShowDialog();
            CargarPartidos(); // Recargar grilla
        }

        private void btnEditarResultado_Click(object sender, EventArgs e)
        {
            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;
            var form = new FormEditarPartidoJugado(partido);
            form.ShowDialog();
            CargarPartidos();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;
            var form = new FormVerDetallePartido(partido);
            form.ShowDialog();
        }

        private void dgvPartidos_SelectionChanged(object sender, EventArgs e)
        {
            btnCargarDatos.Enabled = false;
            btnEditarResultado.Enabled = false;
            btnVerDetalles.Enabled = false;
            btnEliminarPartido.Enabled = false;

            if (dgvPartidos.SelectedRows.Count > 0)
            {
                Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;

                btnEliminarPartido.Enabled = true;

                if (partido.PartidoJugado)
                {
                    btnEditarResultado.Enabled = true;
                    btnVerDetalles.Enabled = true;
                }
                else
                {
                    btnCargarDatos.Enabled = true;
                }
            }
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            if (dgvPartidos.SelectedRows.Count == 0)
                return;

            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"¿Estás seguro de que querés eliminar el partido entre {partido.EquipoLocal} y {partido.EquipoVisitante}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                PartidoModel model = new PartidoModel();
                model.EliminarPartido(partido.IdPartido);
                MessageBox.Show("Partido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidos();
            }
        }
        private void FiltrarPartidos()
        {
            PartidoModel model = new PartidoModel();
            var partidos = model.ObtenerTodosLosPartidos();

            // 🔍 Filtro por nombre de equipo (local o visitante) según selección
            string equipo = txtBuscarEquipo.Text.Trim().ToLower();
            string tipoEquipo = cmbTipoEquipo.SelectedItem?.ToString() ?? "Ambos";

            if (!string.IsNullOrEmpty(equipo))
            {
                partidos = partidos.Where(p =>
                    (tipoEquipo == "Ambos" &&
                        ((p.EquipoLocal != null && p.EquipoLocal.ToLower().Contains(equipo)) ||
                         (p.EquipoVisitante != null && p.EquipoVisitante.ToLower().Contains(equipo))))
                    ||
                    (tipoEquipo == "Local" &&
                        (p.EquipoLocal != null && p.EquipoLocal.ToLower().Contains(equipo)))
                    ||
                    (tipoEquipo == "Visitante" &&
                        (p.EquipoVisitante != null && p.EquipoVisitante.ToLower().Contains(equipo)))
                ).ToList();
            }

            // 📅 Filtro por fecha
            if (chkFecha.Checked)
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;
                partidos = partidos.Where(p => p.Fecha.Date >= desde && p.Fecha.Date <= hasta).ToList();
            }

            // ✅ Filtro por estado (Todos / Jugados / No Jugados)
            if (cmbEstado.SelectedItem != null)
            {
                string estado = cmbEstado.SelectedItem.ToString();
                if (estado == "Jugados")
                    partidos = partidos.Where(p => p.PartidoJugado).ToList();
                else if (estado == "No Jugados")
                    partidos = partidos.Where(p => !p.PartidoJugado).ToList();
            }

            // 📍 Filtro por ubicación
            if (!string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                string ubicacion = txtUbicacion.Text.Trim().ToLower();
                partidos = partidos.Where(p =>
                    p.Ubicacion != null && p.Ubicacion.ToLower().Contains(ubicacion)
                ).ToList();
            }

            // Mostrar resultado en la grilla
            dgvPartidos.DataSource = partidos;

            if (dgvPartidos.Columns["Hora"] != null)
                dgvPartidos.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBuscarEquipo.Text = "";
            txtUbicacion.Text = "";

            chkFecha.Checked = false;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            cmbEstado.SelectedIndex = -1;        // Limpiar selección de Estado
            cmbTipoEquipo.SelectedIndex = -1;    // Limpiar selección de tipo de equipo

            CargarPartidos(); // Recargar todo sin filtros
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFecha.Checked;
            dtpHasta.Enabled = chkFecha.Checked;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPartidos();
        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {
            FiltrarPartidos();
        }

        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            FiltrarPartidos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarPartidos();
        }

        private void cmbTipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPartidos();
        }
    }
}
