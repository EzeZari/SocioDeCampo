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

        private void btnSaveJugador_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.AddJugador(txtName.Text, txtLastNameJug.Text, txtBirthdate.Text,txtNationality.Text, txtPositionJug.Text); //Los ponemos sin convertirlos pq la capa dominio se encarga de hacer eso.
                MessageBox.Show("Se inserto correctamente");
                MostrarJugadores(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir el usuario debido a:  " + ex);
            }
        }
    }
}
