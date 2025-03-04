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
            if (string.IsNullOrWhiteSpace(txTipoIngresos.Text) ||
        string.IsNullOrWhiteSpace(txtMonto.Text) ||
        string.IsNullOrWhiteSpace(cbMetodoDePago.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el monto sea un número positivo
            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear y asignar valores al objeto de ingreso
            IngresosCache ingreso = new IngresosCache
            {
                tipo_de_ingreso = txTipoIngresos.Text,
                monto = monto,
                fecha = dateTimePickerIngresos.Value.Date,
                metodo_de_pago = cbMetodoDePago.Text
            };

            // Insertar en la base de datos
            IngresoModel.CrearIngreso(ingreso);
            MessageBox.Show("Ingreso registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Notificar que se agregó un ingreso
            IngresoAgregado?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {

        }
    }
}