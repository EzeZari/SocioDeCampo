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
using Domain;
using Common.Cache;

namespace Presentacion
{
    public partial class FormFinanzas : Form
    {
        GastosModel gatosModel = new GastosModel();
        int idGasto;

        IngresosModel IngresosModel = new IngresosModel();
        int idIngreso = 0;


        public FormFinanzas()
        {
            InitializeComponent();
            dgvDatos.DataSource = gatosModel.Mostrargastos();
            dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
        }




        private void Mostrargastos()
        {
            GastosModel objetoCD = new GastosModel();
            dgvDatos.DataSource = objetoCD.Mostrargastos();
          
        }

        private void MostrarIngresos()
        {
            IngresosModel objetoI = new IngresosModel();
            dvgIngresos.DataSource = objetoI.MostrarIngresos();

        }



        static string ConexionString = "server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true";
        SqlConnection con = new SqlConnection(ConexionString);
     

        private void FormFinanzas_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = gatosModel.Mostrargastos();
            Mostrargastos();
            dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
            MostrarIngresos();
        }





 

        private void DTPFechaHasta_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                DateTime fechainicio = DTPFechaDesde.Value;
                DateTime fechafinal = DTPFechaHasta.Value;
                dgvDatos.DataSource = gatosModel.FiltrarGasto(fechainicio, fechafinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DTPFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarGasto agregarGasto = new AgregarGasto();
            agregarGasto.GastoAgregado += (s, args) =>
            {
                // Actualizar el DataGridView con los gastos actualizados
                dgvDatos.DataSource = gatosModel.Mostrargastos();
                Mostrargastos();
            };
            agregarGasto.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idGasto != 0)
            {

                gatosModel.EliminarGasto(idGasto);
                MessageBox.Show("Gasto eliminado correctamente.");
                dgvDatos.DataSource = gatosModel.Mostrargastos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {

            Ingresos agregarIngresos = new Ingresos();
            agregarIngresos.IngresoAgregado += (s, args) =>
            {
                // Actualizar el DataGridView con los gastos actualizados
                dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
                MostrarIngresos();
            };
            agregarIngresos.ShowDialog();
        }

        private void btnEliminarIngresos_Click(object sender, EventArgs e)
        {
            if (idIngreso != 0)
            {

                IngresosModel.EliminarIngreso(idIngreso);
                MessageBox.Show("Ingreso eliminado correctamente.");
                dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

       

        private void dvgIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Poner los datos del cliente seleccionado en los campos correspondientes
                if (dvgIngresos.CurrentRow != null)
                {
                    idIngreso = Convert.ToInt32(dvgIngresos.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Poner los datos del cliente seleccionado en los campos correspondientes
                if (dgvDatos.CurrentRow != null)
                {
                    idGasto = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtpFechaDesdeIngreso_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicioIngreso = dtpFechaDesdeIngreso.Value;
                DateTime fechaFinalIngreso = dtpFechaHastaIngreso.Value;
                dvgIngresos.DataSource = IngresosModel.FiltrarIngresos(fechaInicioIngreso, fechaFinalIngreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtpFechaHastaIngreso_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicioIngreso = dtpFechaDesdeIngreso.Value;
                DateTime fechaFinalIngreso = dtpFechaHastaIngreso.Value;
                dvgIngresos.DataSource = IngresosModel.FiltrarIngresos(fechaInicioIngreso, fechaFinalIngreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }


}




