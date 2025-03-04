using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common;
using Domain;

namespace Presentacion
{
    public partial class AgregarGasto : Form
    {
        public AgregarGasto()
        {
            InitializeComponent();
        }

        public event EventHandler GastoAgregado;
        FormFinanzas formFinanzas = new FormFinanzas();
        GastosModel gastosModel = new GastosModel();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void AgregarGasto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbTipoGasto.Text) ||
        string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la cantidad sea un número positivo
            if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear y asignar valores al objeto de gasto
            GastosCache gasto = new GastosCache
            {
                tipo_de_gasto = CbTipoGasto.Text,
                cantidad = cantidad,
                fecha = dateTimePickerGasto.Value.Date,
                nota = TBnota.Text
            };

            // Insertar en la base de datos
            gastosModel.CrearGasto(gasto);
            MessageBox.Show("Gasto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Notificar que se agregó un gasto
            GastoAgregado?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}