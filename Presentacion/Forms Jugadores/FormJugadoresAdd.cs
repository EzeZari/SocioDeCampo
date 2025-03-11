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
                if (!ValidarDatos())
                {
                    return;
                }
                string nombre = txtName.Text;
                string apellido = txtLastNameJug.Text;
                string fechaNacimiento = txtBirthdate.Text;
                string nacionalidad = txtNationality.Text;
                string posicion = cmbPositionJug.SelectedItem.ToString();

                // Llamar al método en tu capa de negocio o dominio para guardar los datos en la base de datos
                objeto.AddJugador(nombre, apellido, fechaNacimiento, nacionalidad, posicion);
                MessageBox.Show("Jugador agregado correctamente",
                                "Excelente", MessageBoxButtons.OK);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir el Jugador debido a: " + ex.Message);
            }
        }

        private bool ValidarDatos()
        {
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
            if (cmbPositionJug.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una posición.");
                cmbPositionJug.Focus();
                return false;
            }

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
