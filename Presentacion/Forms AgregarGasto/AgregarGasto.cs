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
            GastosCache gastos = new GastosCache();
            gastos.tipo_de_gasto = CbTipoGasto.Text;
            gastos.cantidad = decimal.Parse(txtCantidad.Text);
            gastos.fecha = dateTimePickerGasto.Value.Date;
            gastos.nota = TBnota.Text;

            //formFinanzas.AgregarGasto(CbTipoGasto.Text, double.Parse(txtCantidad.Text), dateTimePickerGasto.Value.Date, TBnota.Text);
            gastosModel.CrearGasto(gastos);
            MessageBox.Show("insertado correctamente");


            GastoAgregado?.Invoke(this, EventArgs.Empty);

            this.Close();
        }
    }
}