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
using Domain.Composite;

namespace Presentacion
{
    public partial class FormPartidos : Form
    {
        private Permiso permisosUsuario;

        public FormPartidos()
        {
            InitializeComponent();
        }

        private void FormPartidos_Load(object sender, EventArgs e)
        {
            permisosUsuario = FabricaPermisos.ObtenerPermisosPorCargo(UserCache.Position);

            CargarPartidos();
            InicializarBotones();
            AplicarPermisos();
        }
        private void AplicarPermisos()
        {
            // Deshabilita los botones si NO tiene el permiso de Gestión de Partidos
            if (!permisosUsuario.TienePermiso("GestionPartidos"))
            {
                btnAñadirPartido.Visible = false;
                btnEliminarPartido.Visible = false;
                btnCargarDatos.Visible = false;
                btnVerAuditoria.Visible = false;
                btnGenerarInforme.Visible = false;

            }
        }

        private void InicializarBotones()
        {
            btnCargarDatos.Enabled = false;
            btnVerDetalles.Enabled = false;
            btnEliminarPartido.Enabled = false;
            btnAñadirPartido.Enabled = true;
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

            dgvPartidos.ReadOnly = true;
        }

        #region Botones Acción
        private void btnAñadirPartido_Click(object sender, EventArgs e)
        {
            var formAddPartido = new FormAddPartido();
            formAddPartido.ShowDialog();
            CargarPartidos();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;
            var form = new FormCargarDatosPartido(partido);
            form.ShowDialog();
            CargarPartidos();
        }

        private void btnEditarResultado_Click(object sender, EventArgs e)
        {
            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;
            var form = new FormEditarPartidoJugado(partido);
            form.ShowDialog();
            CargarPartidos();
        }



        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            if (dgvPartidos.SelectedRows.Count == 0) return;

            Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"¿Estás seguro de que querés eliminar el partido entre {partido.EquipoLocal} y {partido.EquipoVisitante}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                new PartidoModel().EliminarPartido(partido.IdPartido);
                MessageBox.Show("Partido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidos();
            }
        }
        #endregion

        #region Selección
        private void dgvPartidos_SelectionChanged(object sender, EventArgs e)
        {
            InicializarBotones();

            if (dgvPartidos.SelectedRows.Count > 0)
            {
                Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;
                btnEliminarPartido.Enabled = true;

                if (partido.PartidoJugado)
                {
                    
                    btnVerDetalles.Enabled = true;
                }
                else
                {
                    btnCargarDatos.Enabled = true;
                }
            }
        }
        #endregion

        #region Filtros
        private void FiltrarPartidos()
        {
            PartidoModel model = new PartidoModel();
            var partidos = model.ObtenerTodosLosPartidos();

            string equipo = txtBuscarEquipo.Text.Trim().ToLower();
            string tipoEquipo = cmbTipoEquipo.SelectedItem?.ToString() ?? "Ambos";

            if (!string.IsNullOrEmpty(equipo))
            {
                partidos = partidos.Where(p =>
                    (tipoEquipo == "Ambos" &&
                        ((p.EquipoLocal?.ToLower().Contains(equipo) ?? false) ||
                         (p.EquipoVisitante?.ToLower().Contains(equipo) ?? false))) ||
                    (tipoEquipo == "Local" && (p.EquipoLocal?.ToLower().Contains(equipo) ?? false)) ||
                    (tipoEquipo == "Visitante" && (p.EquipoVisitante?.ToLower().Contains(equipo) ?? false))
                ).ToList();
            }

            if (chkFecha.Checked)
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;
                partidos = partidos.Where(p => p.Fecha.Date >= desde && p.Fecha.Date <= hasta).ToList();
            }

            if (cmbEstado.SelectedItem != null)
            {
                string estado = cmbEstado.SelectedItem.ToString();
                partidos = partidos.Where(p => estado == "Jugados" ? p.PartidoJugado : !p.PartidoJugado).ToList();
            }

            if (!string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                string ubicacion = txtUbicacion.Text.Trim().ToLower();
                partidos = partidos.Where(p => p.Ubicacion?.ToLower().Contains(ubicacion) ?? false).ToList();
            }

            dgvPartidos.DataSource = partidos;

            if (dgvPartidos.Columns["Hora"] != null)
                dgvPartidos.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";
        }

        private void btnFiltrar_Click(object sender, EventArgs e) => FiltrarPartidos();

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBuscarEquipo.Text = "";
            txtUbicacion.Text = "";
            chkFecha.Checked = false;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            cmbEstado.SelectedIndex = -1;
            cmbTipoEquipo.SelectedIndex = -1;
            CargarPartidos();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFecha.Checked;
            dtpHasta.Enabled = chkFecha.Checked;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e) => FiltrarPartidos();
        private void txtUbicacion_TextChanged(object sender, EventArgs e) => FiltrarPartidos();
        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e) => FiltrarPartidos();
        private void cmbTipoEquipo_SelectedIndexChanged(object sender, EventArgs e) => FiltrarPartidos();
        #endregion

        private void btnGenerarInforme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var partidos = dgvPartidos.DataSource as List<Partido>;

            if (partidos == null || partidos.Count == 0)
            {
                MessageBox.Show("No hay partidos para mostrar en el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formReporte = new FormReporteListaPartidos(partidos);
            formReporte.ShowDialog();
        }

        private void btnVerAuditoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formAuditoria = new FormAuditoria();
            formAuditoria.ShowDialog();
        }
    }

}

