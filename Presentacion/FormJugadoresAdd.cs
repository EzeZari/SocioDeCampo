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
    public partial class FormJugadoresAdd : Form
    {
        UserModel objeto = new UserModel();
        public FormJugadoresAdd()
        {
            InitializeComponent();
        }

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

                // Llamar al método en tu capa de negocio o dominio para guardar los datos en la base de datos
                objeto.AddJugador(nombre, apellido, fechaNacimiento, nacionalidad, posicion);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Se insertó correctamente");

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("No se pudo añadir el Jugador debido a: " + ex.Message);
            }
        }
    }
}
