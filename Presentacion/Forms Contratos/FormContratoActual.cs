using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms_Contratos
{
    public partial class FormContratoActual : Form
    {
        
        public FormContratoActual(string idJugador, string nombre, string apellido, string monto, string fechaInicio, string fechaFin)
        {
            InitializeComponent();
            lblIdJugador.Text = idJugador;
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblMonto.Text = monto;
            lblFechaInicio.Text = fechaInicio;
            lblFechaFin.Text = fechaFin;
        }

        private void btnEntendido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
