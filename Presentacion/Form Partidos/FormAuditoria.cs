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
    public partial class FormAuditoria : Form
    {
        public FormAuditoria()
        {
            InitializeComponent();
        }

        private void FormAuditoria_Load(object sender, EventArgs e)
        {
            try
            {
                PartidoModel model = new PartidoModel();
                DataTable dt = model.ObtenerTodasLasAuditorias();

                dgvAuditoria.DataSource = dt;
                dgvAuditoria.ReadOnly = true;
                dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la auditoría: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}