using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPresupuestos : Form
    {


        private PresupuestoModel _presupuestoModel = new PresupuestoModel();
        private int _idPresupuestoSeleccionado = 0;
        public event EventHandler PresupuestosActualizados;
        public FormPresupuestos()
        {
            InitializeComponent();
        }

        private void FormPresupuestos_Load(object sender, EventArgs e)
        {
            DataTable categorias = _presupuestoModel.ObtenerCategoriasGastos();
            cmbCategoria.Items.Clear();
            foreach (DataRow row in categorias.Rows)
            {
                cmbCategoria.Items.Add(row["categoria"].ToString());
            }

            // Configurar DateTimePickers para temporada
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, 7, 1); // Inicio de temporada típico: 1 de julio
            dtpFechaFin.Value = new DateTime(DateTime.Now.Year + 1, 6, 30); // Fin de temporada típico: 30 de junio

            // Generar nombre temporada automáticamente
            GenerarNombreTemporada();

            // Cargar presupuestos existentes
            CargarPresupuestos();
        }


        private void GenerarNombreTemporada()
        {
            int añoInicio = dtpFechaInicio.Value.Year;
            int añoFin = dtpFechaFin.Value.Year;
            txtTemporada.Text = $"{añoInicio}-{añoFin}";
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value <= dtpFechaInicio.Value)
            {
                dtpFechaFin.Value = dtpFechaInicio.Value.AddYears(1);
            }
            GenerarNombreTemporada();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value <= dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha fin debe ser posterior a la fecha inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1);
            }
            GenerarNombreTemporada();
        }

        private void CargarPresupuestos()
        {
            dgvPresupuestos.DataSource = _presupuestoModel.MostrarPresupuestos();

            // Configurar DataGridView
            dgvPresupuestos.Columns["id"].HeaderText = "ID";
            dgvPresupuestos.Columns["categoria"].HeaderText = "Categoría";
            dgvPresupuestos.Columns["monto_presupuestado"].HeaderText = "Monto Presupuestado";
            dgvPresupuestos.Columns["temporada"].HeaderText = "Temporada";
            dgvPresupuestos.Columns["fecha_inicio"].HeaderText = "Fecha Inicio";
            dgvPresupuestos.Columns["fecha_fin"].HeaderText = "Fecha Fin";
            dgvPresupuestos.Columns["notas"].HeaderText = "Notas";

            if (dgvPresupuestos.Columns.Contains("fecha_creacion"))
            {
                dgvPresupuestos.Columns["fecha_creacion"].HeaderText = "Fecha Creación";
            }

            // Formatear columnas numéricas
            dgvPresupuestos.Columns["monto_presupuestado"].DefaultCellStyle.Format = "C2";

            // Limpiar selección
            _idPresupuestoSeleccionado = 0;
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            cmbCategoria.SelectedIndex = -1;
            txtMonto.Text = "";
            txtNotas.Text = "";
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, 7, 1);
            dtpFechaFin.Value = new DateTime(DateTime.Now.Year + 1, 6, 30);
            GenerarNombreTemporada();
            _idPresupuestoSeleccionado = 0;
            btnGuardar.Text = "Guardar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCategoria.Text) || string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("La categoría y el monto son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un número positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PresupuestoCache presupuesto = new PresupuestoCache
            {
                categoria = cmbCategoria.Text,
                monto_presupuestado = monto,
                temporada = txtTemporada.Text,
                fecha_inicio = dtpFechaInicio.Value,
                fecha_fin = dtpFechaFin.Value,
                notas = txtNotas.Text
            };

            try
            {
                if (_idPresupuestoSeleccionado == 0)
                {
                    // Crear nuevo presupuesto
                    _presupuestoModel.CrearPresupuesto(presupuesto);
                    MessageBox.Show("Presupuesto creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizar presupuesto existente
                    presupuesto.id = _idPresupuestoSeleccionado;
                    _presupuestoModel.EditarPresupuesto(presupuesto);
                    MessageBox.Show("Presupuesto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarFormulario();
                CargarPresupuestos();
                PresupuestosActualizados?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idPresupuestoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un presupuesto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Estás seguro de eliminar este presupuesto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _presupuestoModel.EliminarPresupuesto(_idPresupuestoSeleccionado);
                    MessageBox.Show("Presupuesto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarPresupuestos();
                    PresupuestosActualizados?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void dgvPresupuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _idPresupuestoSeleccionado = Convert.ToInt32(dgvPresupuestos.Rows[e.RowIndex].Cells["id"].Value);
                cmbCategoria.Text = dgvPresupuestos.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
                txtMonto.Text = Convert.ToDecimal(dgvPresupuestos.Rows[e.RowIndex].Cells["monto_presupuestado"].Value).ToString();
                txtTemporada.Text = dgvPresupuestos.Rows[e.RowIndex].Cells["temporada"].Value.ToString();
                dtpFechaInicio.Value = Convert.ToDateTime(dgvPresupuestos.Rows[e.RowIndex].Cells["fecha_inicio"].Value);
                dtpFechaFin.Value = Convert.ToDateTime(dgvPresupuestos.Rows[e.RowIndex].Cells["fecha_fin"].Value);
                txtNotas.Text = dgvPresupuestos.Rows[e.RowIndex].Cells["notas"].Value != DBNull.Value ? dgvPresupuestos.Rows[e.RowIndex].Cells["notas"].Value.ToString() : "";

                btnGuardar.Text = "Actualizar";
            }
        }
    }


}
