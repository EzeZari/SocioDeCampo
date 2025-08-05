using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormCargarDatosPartido : Form
    {
        private Partido partido;
        private List<Gol> golesCargados = new List<Gol>();
        private List<Tarjeta> tarjetasCargadas = new List<Tarjeta>();

        public FormCargarDatosPartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        private void FormCargarDatosPartido_Load(object sender, EventArgs e)
        {
            lblLocal.Text = $" {partido.EquipoLocal}";
            lblVisitante.Text = $" {partido.EquipoVisitante}";
            lblEstadio.Text = $"{partido.Estadio}";
            lblNumeroFecha.Text = $"{partido.NumeroFecha}";
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            UserModel model = new UserModel();
            DataTable tablaJugadores = model.MostrarJugadores();

            cmbJugadoresGol.DataSource = tablaJugadores.Copy();
            cmbJugadoresGol.DisplayMember = "Apellido";
            cmbJugadoresGol.ValueMember = "IdJugador";

            cmbJugadoresTarjeta.DataSource = tablaJugadores;
            cmbJugadoresTarjeta.DisplayMember = "Apellido";
            cmbJugadoresTarjeta.ValueMember = "IdJugador";

            cmbTipoTarjeta.Items.Add("Amarilla");
            cmbTipoTarjeta.Items.Add("Roja");
        }

        private void btnAgregarGol_Click(object sender, EventArgs e)
        {
            if (cmbJugadoresGol.SelectedItem == null || string.IsNullOrWhiteSpace(txtMinutoGol.Text))
            {
                MessageBox.Show("Debe seleccionar un jugador y especificar el minuto del gol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMinutoGol.Text, out int minuto) || minuto < 0 || minuto > 130)
            {
                MessageBox.Show("El minuto debe ser un número válido entre 0 y 130.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView jugador = (DataRowView)cmbJugadoresGol.SelectedItem;

            golesCargados.Add(new Gol
            {
                IdPartido = partido.IdPartido,
                IdJugador = Convert.ToInt32(jugador["IdJugador"]),
                NombreJugador = jugador["Nombre"].ToString(),
                Minuto = minuto
            });

            dgvGoles.DataSource = null;
            dgvGoles.DataSource = golesCargados;

            cmbJugadoresGol.SelectedIndex = -1;
            txtMinutoGol.Text = "";
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            if (cmbJugadoresTarjeta.SelectedItem == null || cmbTipoTarjeta.SelectedItem == null || string.IsNullOrWhiteSpace(txtMinutoTarjeta.Text))
            {
                MessageBox.Show("Debe seleccionar un jugador, un tipo de tarjeta y un minuto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMinutoTarjeta.Text, out int minuto) || minuto < 0 || minuto > 130)
            {
                MessageBox.Show("El minuto debe ser un número válido entre 0 y 130.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView jugador = (DataRowView)cmbJugadoresTarjeta.SelectedItem;
            int idJugador = Convert.ToInt32(jugador["IdJugador"]);
            string tipo = cmbTipoTarjeta.SelectedItem.ToString();

            // Validar duplicado exacto
            if (tarjetasCargadas.Any(t => t.IdJugador == idJugador && t.Tipo == tipo && t.Minuto == minuto))
            {
                MessageBox.Show("Ya existe una tarjeta igual para ese jugador en ese minuto.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tarjetasCargadas.Add(new Tarjeta
            {
                IdPartido = partido.IdPartido,
                IdJugador = idJugador,
                NombreJugador = jugador["Nombre"].ToString(),
                Tipo = tipo,
                Minuto = minuto
            });

            // Verificar doble amarilla
            if (tipo == "Amarilla")
            {
                int cantAmarillas = tarjetasCargadas.Count(t => t.IdJugador == idJugador && t.Tipo == "Amarilla");
                bool yaTieneRoja = tarjetasCargadas.Any(t => t.IdJugador == idJugador && t.Tipo == "Roja");

                if (cantAmarillas == 2 && !yaTieneRoja)
                {
                    tarjetasCargadas.Add(new Tarjeta
                    {
                        IdPartido = partido.IdPartido,
                        IdJugador = idJugador,
                        NombreJugador = jugador["Nombre"].ToString(),
                        Tipo = "Roja",
                        Minuto = minuto + 1
                    });

                    MessageBox.Show("⚠️ Segunda amarilla: se agregó automáticamente una tarjeta roja.", "Doble amarilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            dgvTarjetas.DataSource = null;
            dgvTarjetas.DataSource = tarjetasCargadas;

            cmbJugadoresTarjeta.SelectedIndex = -1;
            cmbTipoTarjeta.SelectedIndex = -1;
            txtMinutoTarjeta.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtResultadoLocal.Text, out int resLocal) || !int.TryParse(txtResultadoVisitante.Text, out int resVisitante) || resLocal < 0 || resVisitante < 0)
            {
                MessageBox.Show("Los resultados deben ser números válidos y no negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Estás seguro de que querés guardar este resultado, los goles y las tarjetas cargadas?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            partido.ResultadoLocal = resLocal;
            partido.ResultadoVisitante = resVisitante;
            partido.Observaciones = txtObservaciones.Text;
            partido.PartidoJugado = true;

            try
            {
                PartidoModel model = new PartidoModel();
                model.ActualizarPartidoResultado(partido);

                if (golesCargados.Count > 0)
                    model.GuardarGoles(golesCargados);

                if (tarjetasCargadas.Count > 0)
                {

                }
                    model.GuardarTarjetas(partido.IdPartido, tarjetasCargadas);
                model.RegistrarMensajeAuditoria(partido.EquipoLocal, partido.EquipoVisitante);
                MessageBox.Show("Datos del partido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarGol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvGoles.SelectedRows.Count > 0)
            {
                var seleccionado = (Gol)dgvGoles.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show($"¿Eliminar gol de {seleccionado.NombreJugador} al minuto {seleccionado.Minuto}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    golesCargados.Remove(seleccionado);
                    dgvGoles.DataSource = null;
                    dgvGoles.DataSource = golesCargados;
                }
            }
        }

        private void btnEliminarTarjeta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvTarjetas.SelectedRows.Count > 0)
            {
                var seleccionado = (Tarjeta)dgvTarjetas.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show($"¿Eliminar tarjeta {seleccionado.Tipo} de {seleccionado.NombreJugador} al minuto {seleccionado.Minuto}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tarjetasCargadas.Remove(seleccionado);
                    dgvTarjetas.DataSource = null;
                    dgvTarjetas.DataSource = tarjetasCargadas;
                }
            }
        }
    }
}
