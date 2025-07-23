using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormVerDetallePartido : Form
    {
        private Partido partido;
        public FormVerDetallePartido(Partido partido)
        {
            InitializeComponent();
            this.partido = partido;
        }

        private void FormVerDetallePartido_Load(object sender, EventArgs e)
        {
            lblFecha.Text = partido.Fecha.ToShortDateString();
            lblHora.Text = partido.Hora.ToString(@"hh\:mm");
            lblLocal.Text = partido.EquipoLocal;
            lblVisitante.Text = partido.EquipoVisitante;

            lblResultadoLocal.Text = partido.ResultadoLocal.ToString();
            lblResultadoVisitante.Text = partido.ResultadoVisitante.ToString();
            lblObservaciones.Text = partido.Observaciones;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
