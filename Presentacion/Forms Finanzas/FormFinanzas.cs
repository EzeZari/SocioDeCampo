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
        public FormFinanzas()
        {
            InitializeComponent();
            dgvDatos.DataSource = gatosModel.Mostrargastos();
        }


        private void Mostrargastos()
        {
            GastosModel objetoCD = new GastosModel();
            dgvDatos.DataSource = objetoCD.Mostrargastos();

        }



        static string ConexionString = "server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true";
        SqlConnection con = new SqlConnection(ConexionString);



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





        private void FormFinanzas_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = gatosModel.Mostrargastos();
            Mostrargastos();


        }


        private void DTPFcheDesde_ValueChanged(object sender, EventArgs e)
        {

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

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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





    }
}






