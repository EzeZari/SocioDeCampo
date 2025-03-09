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
                // Validar los datos antes de proceder
                if (!ValidarDatos())
                {
                    return; // Detener la ejecución si la validación falla
                }

                // Obtener los valores de los controles
                string nombre = txtName.Text;
                string apellido = txtLastNameJug.Text;
                string fechaNacimiento = txtBirthdate.Text;
                string nacionalidad = txtNationality.Text;
                string posicion = cmbPositionJug.SelectedItem.ToString();

                // Llamar al método en tu capa de negocio o dominio para guardar los datos en la base de datos
                objeto.AddJugador(nombre, apellido, fechaNacimiento, nacionalidad, posicion);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Jugador agregado correctamente",
                                "Excelente",
                                MessageBoxButtons.OK);

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("No se pudo añadir el Jugador debido a: " + ex.Message);
            }
        }

        private bool ValidarDatos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastNameJug.Text))
            {
                MessageBox.Show("El campo 'Apellido' no puede estar vacío.");
                txtLastNameJug.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBirthdate.Text))
            {
                MessageBox.Show("El campo 'Fecha de Nacimiento' no puede estar vacío.");
                txtBirthdate.Focus();
                return false;
            }

            if (!ValidarFecha(txtBirthdate.Text))
            {
                MessageBox.Show("El campo 'Fecha de Nacimiento' debe tener el formato --/--/----.");
                txtBirthdate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                MessageBox.Show("El campo 'Nacionalidad' no puede estar vacío.");
                txtNationality.Focus();
                return false;
            }

            // Verificar si se ha seleccionado una posición en el ComboBox
            if (cmbPositionJug.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una posición.");
                cmbPositionJug.Focus();
                return false;
            }

            // Si todos los campos están completos, devolver verdadero
            return true;
        }

        private bool ValidarFecha(string fecha)
        {
            // Verificar si la fecha cumple con el formato --/--/----
            DateTime fechaSalida;
            return DateTime.TryParseExact(fecha, "dd/MM/yyyy",
                                          System.Globalization.CultureInfo.InvariantCulture,
                                          System.Globalization.DateTimeStyles.None,
                                          out fechaSalida);
        }

        private void FormJugadoresAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
