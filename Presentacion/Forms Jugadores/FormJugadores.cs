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
        }
        private void MostrarJugadores()
        {
            UserModel objetoCD = new UserModel();
            dataGridView1.DataSource = objetoCD.MostrarJugadores();
        }

        //private void btnSaveJugador_Click(object sender, EventArgs e)
        //{
        //    // INSERTAR
        //    if (Editar == false) // Si editar es falso, agrega el registro.
        //    {
        //        try
        //        {
        //            objeto.AddJugador(txtName.Text, txtLastNameJug.Text, txtBirthdate.Text, txtNationality.Text, txtPositionJug.Text); // Los ponemos sin convertirlos pq la capa dominio se encarga de hacer eso.
        //            MessageBox.Show("Se insertó correctamente");
        //            MostrarJugadores();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("No se pudo añadir el Jugador debido a:  " + ex);
        //        }
        //    }

        //    // EDITAR
        //    if (Editar == true) // Si editar es verdadero, editará el registro.
        //    {
        //        try
        //        {
        //            objeto.EditarJugador(txtName.Text, txtLastNameJug.Text, txtBirthdate.Text, txtNationality.Text, txtPositionJug.Text, idJugador);
        //            MessageBox.Show("Se Editó correctamente");
        //            MostrarJugadores();
        //            clearForm();
        //            Editar = false; // Lo volvemos a pasar a falso para reinicializar y que el botón siga agregando registros.
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("No se pudo editar el jugador debido a:  " + ex);
        //        }
        //    }
        //}

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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
          
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormReport report = new FormReport();
            report.ShowDialog();
        }
    }
}
