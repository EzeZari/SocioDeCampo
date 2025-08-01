using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormHistorialJugador : Form
    {
        public FormHistorialJugador()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int jugadorId;

        public FormHistorialJugador(int jugadorId)
        {
            InitializeComponent();
            this.jugadorId = jugadorId;
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security=true"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT e.titulo, e.descripcion, e.fecha, e.lugar, e.duracion
            FROM Entrenamientos e
            INNER JOIN Entrenamiento_Jugador ej ON ej.entrenamiento_id = e.id
            WHERE ej.jugador_id = @jugadorId
            ORDER BY e.fecha DESC", conn);

                cmd.Parameters.AddWithValue("@jugadorId", jugadorId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewHistorial.DataSource = dt;
            }
        }





        private void FormHistorialJugador_Load(object sender, EventArgs e)
        {

        }
    }
}
