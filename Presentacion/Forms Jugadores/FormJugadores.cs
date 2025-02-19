using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Presentacion.Forms_Contratos;

namespace Presentacion
{
    public partial class FormJugadores : Form
    {
        UserModel objeto = new UserModel();
        private string idJugador = null; //Creamos una variable para almacenar d manera nula.
        private bool Editar = false;
        public FormJugadores()
        {
            InitializeComponent();
        }

        private void FormJugadores_Load(object sender, EventArgs e)
        {
            MostrarJugadores();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void MostrarJugadores()
        {
            UserModel objetoCD = new UserModel();
            dataGridView1.DataSource = objetoCD.MostrarJugadores();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var FormJugadoresAdd = new FormJugadoresAdd();
            FormJugadoresAdd.FormClosed += (s, args) => {
                MostrarJugadores(); // Llamar a MostrarJugadores() cuando se cierre el formulario de edición
            };
            FormJugadoresAdd.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada en el DataGridView
                string nombre = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                string fechaNacimiento = dataGridView1.CurrentRow.Cells["Birthdate"].Value.ToString();
                string nacionalidad = dataGridView1.CurrentRow.Cells["Nationality"].Value.ToString();
                string posicion = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();

                // Crear una instancia del formulario FormJugadoresEdit
                var FormJugadoresEdit = new FormJugadoresEdit(nombre, apellido, fechaNacimiento, nacionalidad, posicion, idJugador);
                FormJugadoresEdit.FormClosed += (s, args) => {
                    MostrarJugadores(); // Llamar a MostrarJugadores() cuando se cierre el formulario de edición
                };
                FormJugadoresEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                objeto.EliminarJugador(idJugador);
                MessageBox.Show("Eliminado correctamente");
                MostrarJugadores();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Muestra el botón solo si hay una fila seleccionada
            gunaButton1.Visible = dataGridView1.SelectedRows.Count > 0;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idJugador = dataGridView1.CurrentRow.Cells["idJugador"].Value.ToString();
                FormContratoAdd formContratoAdd = new FormContratoAdd(idJugador);
                formContratoAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un jugador antes de agregar un contrato.");
            }
        }


    }
}
