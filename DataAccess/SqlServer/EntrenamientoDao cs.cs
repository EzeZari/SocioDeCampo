using System;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class EntrenamientoDao
    {
        private readonly string connectionString = "server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security=true";

        public void Crear(EntrenamientoCache entrenamiento)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Entrenamientos (titulo, descripcion, fecha, duracion, lugar, entrenador_id)
                                                  VALUES (@titulo, @descripcion, @fecha, @duracion, @lugar, @entrenador_id)", conn);
                cmd.Parameters.AddWithValue("@titulo", entrenamiento.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", entrenamiento.Descripcion);
                cmd.Parameters.AddWithValue("@fecha", entrenamiento.Fecha);
                cmd.Parameters.AddWithValue("@duracion", entrenamiento.Duracion);
                cmd.Parameters.AddWithValue("@lugar", entrenamiento.Lugar);
                cmd.Parameters.AddWithValue("@entrenador_id", entrenamiento.EntrenadorId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Entrenamientos WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarEntrenamientos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Entrenamientos", conn);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public int ObtenerUltimoId()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM Entrenamientos", conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        public DataTable FiltrarPorFechas(DateTime desde, DateTime hasta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Entrenamientos WHERE fecha BETWEEN @desde AND @hasta", conn);
                da.SelectCommand.Parameters.AddWithValue("@desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }



        public DataTable ObtenerJugadores()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT idJugador, Name, LastName FROM Jugadores", conn);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public DataTable ObtenerJugadoresAsignados(int entrenamientoId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT j.idJugador, j.Name, j.LastName
            FROM Entrenamiento_Jugador ej
            INNER JOIN Jugadores j ON ej.jugador_id = j.idJugador
            WHERE ej.entrenamiento_id = @entrenamiento_id", conn);

                da.SelectCommand.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public void AsignarJugador(int entrenamientoId, int jugadorId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Entrenamiento_Jugador (entrenamiento_id, jugador_id) 
            VALUES (@entrenamiento_id, @jugador_id)", conn);

                cmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                cmd.Parameters.AddWithValue("@jugador_id", jugadorId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
