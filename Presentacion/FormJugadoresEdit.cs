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
    public partial class FormJugadoresEdit : Form
    {
        UserModel objeto = new UserModel();
        private string idJugador = null;
        // Constructor de FormJugadoresEdit para recibir datos
        public FormJugadoresEdit(string nombre, string apellido, string fechaNacimiento, string nacionalidad, string posicion, string idJugador)
        {
            InitializeComponent();

            // Mostrar los datos recibidos en los TextBox del formulario FormJugadoresEdit
            txtName.Text = nombre;
            txtLastNameJug.Text = apellido;
            txtBirthdate.Text = fechaNacimiento;
            txtNationality.Text = nacionalidad;
            txtPositionJug.Text = posicion;

            // Guardar el ID del jugador (si es necesario para la edición)
            this.idJugador = idJugador;
        }

        // Evento de clic del botón Guardar en el formulario FormJugadoresEdit

        private void btnSaveJugador_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBox
                string nombre = txtName.Text;
                string apellido = txtLastNameJug.Text;
                string fechaNacimiento = txtBirthdate.Text;
                string nacionalidad = txtNationality.Text;
                string posicion = txtPositionJug.Text;

                // Llamar al método en tu capa de negocio o dominio para editar los datos en la base de datos
                objeto.EditarJugador(nombre, apellido, fechaNacimiento, nacionalidad, posicion, idJugador);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Se editó correctamente");

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("No se pudo editar el Jugador debido a: " + ex.Message);
            }
        }
    }
}
