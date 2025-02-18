using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }
        public event EventHandler IngresoAgregado;
        FormFinanzas formFinanzas = new FormFinanzas();
        IngresosModel IngresoModel = new IngresosModel();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             IngresosCache Ingreso = new IngresosCache();
            Ingreso.tipo_de_ingreso = txTipoIngresos.Text;
            Ingreso.monto = decimal.Parse(txtMonto.Text);
            Ingreso.fecha = dateTimePickerIngresos.Value.Date; // Solo la fecha, sin la hora
            Ingreso.metodo_de_pago = cbMetodoDePago.Text;

            IngresoModel.CrearIngreso(Ingreso);
            MessageBox.Show("insertado correctamente");

            IngresoAgregado?.Invoke(this, EventArgs.Empty);

            this.Close();
        }
    }
}