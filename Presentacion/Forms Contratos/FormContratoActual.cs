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

        public FormContratoActual(string idJugador, string nombre, string apellido, string monto, string fechaInicio, string fechaFin, string clausula, string salario, string bonificacion, string obligacion)
        {
            InitializeComponent();

            // Asignar los valores a los controles correspondientes
            lblIdJugador.Text = idJugador;
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblMonto.Text = monto;
            lblFechaInicio.Text = fechaInicio;
            lblFechaFin.Text = fechaFin;
            lblClausula.Text = clausula;        // Agregar la cláusula
            lblSalario.Text = salario;          // Agregar el salario
            lblBonificacion.Text = bonificacion; // Agregar la bonificación
            lblObligacion.Text = obligacion;    // Agregar la obligación
        }

        private void btnEntendido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
