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

            if (dgvPartidos.SelectedRows.Count > 0)
            {
                Partido partido = (Partido)dgvPartidos.CurrentRow.DataBoundItem;

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

    }
}
