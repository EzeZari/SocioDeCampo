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

namespace Presentacion
{
    public partial class FormFinanzas : Form
    {
        GastosModel gatosModel = new GastosModel();
        int idGasto;

        IngresosModel IngresosModel = new IngresosModel();
        int idIngreso = 0;

        private GastosModel gastosModel = new GastosModel();

        public FormFinanzas()
        {
            InitializeComponent();
            dgvDatos.DataSource = gatosModel.Mostrargastos();
            dvgIngresos.DataSource = IngresosModel.MostrarIngresos();

            CalcularBalance();
            ActualizarGrafico();
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
            Mostrargastos();
            MostrarIngresos();
            CalcularBalance();
            ActualizarGrafico();

        }


        private void dgvDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DTPFechaHasta_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                DateTime fechainicio = DTPFechaDesde.Value;
                DateTime fechafinal = DTPFechaHasta.Value;
                dgvDatos.DataSource = gatosModel.FiltrarGasto(fechainicio, fechafinal);
                CalcularBalanceFiltrado(); // Llamamos al nuevo método
                ActualizarGrafico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DTPFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechainicio = DTPFechaDesde.Value;
                DateTime fechafinal = DTPFechaHasta.Value;
                dgvDatos.DataSource = gatosModel.FiltrarGasto(fechainicio, fechafinal);
                CalcularBalanceFiltrado(); // Llamamos al nuevo método
                ActualizarGrafico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarGasto agregarGasto = new AgregarGasto();
            agregarGasto.GastoAgregado += (s, args) =>
            {
                dgvDatos.DataSource = gatosModel.Mostrargastos();
                Mostrargastos();
                CalcularBalance();
                ActualizarGrafico();
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
                CalcularBalance();
                ActualizarGrafico();
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

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            Ingresos agregarIngresos = new Ingresos();
            agregarIngresos.IngresoAgregado += (s, args) =>
            {
                dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
                CalcularBalance();
                ActualizarGrafico(); // 🔄 Refresca el gráfico
            };
            agregarIngresos.ShowDialog(); ;
        }

        private void dtpFechaDesdeIngreso_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicioIngreso = dtpFechaDesdeIngreso.Value;
                DateTime fechaFinalIngreso = dtpFechaHastaIngreso.Value;
                dvgIngresos.DataSource = IngresosModel.FiltrarIngresos(fechaInicioIngreso, fechaFinalIngreso);
                CalcularBalanceFiltrado(); // Llamamos al nuevo método
                ActualizarGrafico();
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
                CalcularBalanceFiltrado(); // Llamamos al nuevo método
                ActualizarGrafico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarIngresos_Click(object sender, EventArgs e)
        {
            if (idIngreso != 0)
            {
                IngresosModel.EliminarIngreso(idIngreso);
                MessageBox.Show("Ingreso eliminado correctamente.");

                dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
                CalcularBalance();
                ActualizarGrafico(); // 🔄 Refresca el gráfico
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }


        private void CalcularBalance()
        {


            decimal totalIngresos = IngresosModel.ObtenerTotalIngresos();
            decimal totalGastos = gatosModel.ObtenerTotalGastos();
            decimal balance = totalIngresos - totalGastos;

            lblBalance.Text = $"Balance: {balance:C}";

            // Cambiar color del balance según su estado
            if (balance > 0)
                lblBalance.ForeColor = Color.Green;  // Superávit
            else if (balance < 0)
                lblBalance.ForeColor = Color.Red;    // Déficit
            else
                lblBalance.ForeColor = Color.Black;  // Equilibrado



        }


        private void ActualizarGrafico()
        {

            chartBalance.Series.Clear();
            chartBalance.Series.Add("Finanzas");
            chartBalance.Series["Finanzas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            decimal totalIngresos = 0;
            decimal totalGastos = 0;

            // Sumar ingresos filtrados
            if (dvgIngresos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dvgIngresos.Rows)
                {
                    if (row.Cells["monto"].Value != null && row.Cells["monto"].Value != DBNull.Value)
                    {
                        totalIngresos += Convert.ToDecimal(row.Cells["monto"].Value);
                    }
                }
            }

            // Sumar gastos filtrados
            if (dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["cantidad"].Value != null && row.Cells["cantidad"].Value != DBNull.Value)
                    {
                        totalGastos += Convert.ToDecimal(row.Cells["cantidad"].Value);
                    }
                }
            }

            chartBalance.Series["Finanzas"].Points.AddXY("Ingresos", totalIngresos);
            chartBalance.Series["Finanzas"].Points.AddXY("Gastos", totalGastos);



        }




        private void btnImportar_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.ShowDialog();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

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

        private void chartBalance_Click(object sender, EventArgs e)
        {

        }



        private void CalcularBalanceFiltrado()
        {
            decimal totalIngresos = 0;
            decimal totalGastos = 0;

            // Sumar los montos de ingresos mostrados en el DataGridView
            if (dvgIngresos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dvgIngresos.Rows)
                {
                    if (row.Cells["monto"].Value != null && row.Cells["monto"].Value != DBNull.Value)
                    {
                        totalIngresos += Convert.ToDecimal(row.Cells["monto"].Value);
                    }
                }
            }

            // Sumar las cantidades de gastos mostrados en el DataGridView
            if (dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells["cantidad"].Value != null && row.Cells["cantidad"].Value != DBNull.Value)
                    {
                        totalGastos += Convert.ToDecimal(row.Cells["cantidad"].Value);
                    }
                }
            }

            // Calcular y mostrar el balance
            decimal balance = totalIngresos - totalGastos;
            lblBalance.Text = $"Balance: {balance:C}";

            // Cambiar color del balance según su estado
            if (balance > 0)
                lblBalance.ForeColor = Color.Green;  // Superávit
            else if (balance < 0)
                lblBalance.ForeColor = Color.Red;    // Déficit
            else
                lblBalance.ForeColor = Color.Black;  // Equilibrado
        }

       

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarGasto_TextChanged(object sender, EventArgs e)
        {
            if (dgvDatos.DataSource is DataTable dtGastos)
            {
                string searchTerm = txtBuscarGasto.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    // If search box is empty, show all records
                    dgvDatos.DataSource = gatosModel.Mostrargastos();
                    CalcularBalanceFiltrado();
                    ActualizarGrafico();
                    return;
                }

                try
                {
                    // Create a custom filter with the DataTable to search by any column
                    DataTable filteredTable = dtGastos.Clone();

                    foreach (DataRow row in dtGastos.Rows)
                    {
                        bool matchFound = false;

                        // Check each column for a match
                        foreach (DataColumn col in dtGastos.Columns)
                        {
                            if (col.DataType == typeof(string) && row[col] != DBNull.Value)
                            {
                                string cellValue = row[col].ToString().ToLower();
                                if (cellValue.Contains(searchTerm))
                                {
                                    matchFound = true;
                                    break;
                                }
                            }
                        }

                        // If a match was found in any column, add the row to the filtered table
                        if (matchFound)
                        {
                            filteredTable.ImportRow(row);
                        }
                    }

                    // Display the filtered results
                    dgvDatos.DataSource = filteredTable;

                    // Update calculations based on filtered data
                    CalcularBalanceFiltrado();
                    ActualizarGrafico();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la búsqueda: " + ex.Message);
                    MessageBox.Show("Ocurrió un error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void txtBuscarIngreso_TextChanged(object sender, EventArgs e)
        {
            if (dvgIngresos.DataSource is DataTable dtIngresos)
            {
                string searchTerm = txtBuscarIngreso.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    // If search box is empty, show all records
                    dvgIngresos.DataSource = IngresosModel.MostrarIngresos();
                    CalcularBalanceFiltrado();
                    ActualizarGrafico();
                    return;
                }

                try
                {
                    // Create a custom filter with the DataTable to search by any column
                    DataTable filteredTable = dtIngresos.Clone();

                    foreach (DataRow row in dtIngresos.Rows)
                    {
                        bool matchFound = false;

                        // Check each column for a match
                        foreach (DataColumn col in dtIngresos.Columns)
                        {
                            if (col.DataType == typeof(string) && row[col] != DBNull.Value)
                            {
                                string cellValue = row[col].ToString().ToLower();
                                if (cellValue.Contains(searchTerm))
                                {
                                    matchFound = true;
                                    break;
                                }
                            }
                        }

                        // If a match was found in any column, add the row to the filtered table
                        if (matchFound)
                        {
                            filteredTable.ImportRow(row);
                        }
                    }

                    // Display the filtered results
                    dvgIngresos.DataSource = filteredTable;

                    // Update calculations based on filtered data
                    CalcularBalanceFiltrado();
                    ActualizarGrafico();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la búsqueda de ingresos: " + ex.Message);
                    MessageBox.Show("Ocurrió un error al realizar la búsqueda de ingresos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            FormPresupuestos formPresupuestos = new FormPresupuestos();
            formPresupuestos.PresupuestosActualizados += (s, args) =>
            {
                // Actualizar la vista si es necesario
            };
            formPresupuestos.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FormSeguimientoPresupuestario formSeguimiento = new FormSeguimientoPresupuestario();
            formSeguimiento.ShowDialog();
        }
    }




}