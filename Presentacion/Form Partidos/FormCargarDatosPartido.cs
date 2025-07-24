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
        private List<GolTemp> golesCargados = new List<GolTemp>();
        private List<TarjetaTemp> tarjetasCargadas = new List<TarjetaTemp>();

        private class GolTemp
        {
            public int IdJugador { get; set; }
            public string NombreJugador { get; set; }
            public int Minuto { get; set; }
        }

        private class TarjetaTemp
        {
            public int IdJugador { get; set; }
            public string NombreJugador { get; set; }
            public string Tipo { get; set; } // Amarilla o Roja
            public int Minuto { get; set; }
        }

        public FormCargarDatosPartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        private void FormCargarDatosPartido_Load(object sender, EventArgs e)
        {
            lblLocal.Text = partido.EquipoLocal;
            lblVisitante.Text = partido.EquipoVisitante;
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            UserModel model = new UserModel();
            DataTable tablaJugadores = model.MostrarJugadores();

            cmbJugadoresGol.DataSource = tablaJugadores.Copy();
            cmbJugadoresGol.DisplayMember = "Nombre";
            cmbJugadoresGol.ValueMember = "IdJugador";

            cmbJugadoresTarjeta.DataSource = tablaJugadores;
            cmbJugadoresTarjeta.DisplayMember = "Nombre";
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

            DataRowView jugadorSeleccionado = (DataRowView)cmbJugadoresGol.SelectedItem;

            var nuevoGol = new GolTemp
            {
                IdJugador = Convert.ToInt32(jugadorSeleccionado["IdJugador"]),
                NombreJugador = jugadorSeleccionado["Nombre"].ToString(),
                Minuto = minuto
            };

            golesCargados.Add(nuevoGol);

            dgvGoles.DataSource = null;
            dgvGoles.DataSource = golesCargados;

            cmbJugadoresGol.SelectedIndex = -1;
            txtMinutoGol.Text = "";
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtResultadoLocal.Text, out int resLocal) ||
                !int.TryParse(txtResultadoVisitante.Text, out int resVisitante))
            {
                MessageBox.Show("Los resultados deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Estás seguro de que querés guardar este resultado, los goles y las tarjetas cargadas?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
                return;

            partido.ResultadoLocal = resLocal;
            partido.ResultadoVisitante = resVisitante;
            partido.Observaciones = txtObservaciones.Text;
            partido.PartidoJugado = true;

            List<Gol> golesAInsertar = golesCargados.Select(g => new Gol
            {
                IdPartido = partido.IdPartido,
                IdJugador = g.IdJugador,
                Minuto = g.Minuto
            }).ToList();

            List<Tarjeta> tarjetasAInsertar = tarjetasCargadas.Select(t => new Tarjeta
            {
                IdPartido = partido.IdPartido,
                IdJugador = t.IdJugador,
                Tipo = t.Tipo,
                Minuto = t.Minuto
            }).ToList();

            try
            {
                PartidoModel model = new PartidoModel();
                model.ActualizarPartidoResultado(partido);

                if (golesAInsertar.Count > 0)
                {
                    model.GuardarGoles(golesAInsertar); // ✅ coincide con el método que ya existe
                }

                if (tarjetasAInsertar.Count > 0)
                {
                    model.GuardarTarjetas(partido.IdPartido, tarjetasAInsertar);
                }

                MessageBox.Show("Datos del partido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            DataRowView jugadorSeleccionado = (DataRowView)cmbJugadoresTarjeta.SelectedItem;

            var nuevaTarjeta = new TarjetaTemp
            {
                IdJugador = Convert.ToInt32(jugadorSeleccionado["IdJugador"]),
                NombreJugador = jugadorSeleccionado["Nombre"].ToString(),
                Tipo = cmbTipoTarjeta.SelectedItem.ToString(),
                Minuto = minuto
            };

            tarjetasCargadas.Add(nuevaTarjeta);

            dgvTarjetas.DataSource = null;
            dgvTarjetas.DataSource = tarjetasCargadas;

            cmbJugadoresTarjeta.SelectedIndex = -1;
            cmbTipoTarjeta.SelectedIndex = -1;
            txtMinutoTarjeta.Text = "";
        }
    }
}
