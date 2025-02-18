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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet.gastos' Puede moverla o quitarla según sea necesario.
            this.gastosTableAdapter.Fill(this.MyCompanyDataSet.gastos);
            // TODO: esta línea de código carga datos en la tabla 'MyCompanyDataSet2.ingresos' Puede moverla o quitarla según sea necesario.
            this.ingresosTableAdapter.Fill(this.MyCompanyDataSet2.ingresos);

            this.reportViewer1.RefreshReport();

            decimal totalIngresos = 0, totalGastos = 0, balance = 0;

            foreach (MyCompanyDataSet2.ingresosRow row in MyCompanyDataSet2.ingresos)
                totalIngresos += row.monto;

            foreach (MyCompanyDataSet2.gastosRow row in MyCompanyDataSet2.gastos)
                totalGastos += row.cantidad;
        }
    }
}
