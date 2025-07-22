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

            dgvPartidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPartidos.ReadOnly = true;
            dgvPartidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


    }
}
