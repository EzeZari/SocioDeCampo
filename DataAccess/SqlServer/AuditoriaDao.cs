using Common.Cache;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class AuditoriaDao
    {
        private readonly string connectionString = "server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security=true";

        public void RegistrarCreacionEntrenamiento(int entrenamientoId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO AuditoriaEntrenamientos (entrenamiento_id, jugador_id, entrenador_id, fecha_asignacion, accion)
                    VALUES (@entrenamiento_id, NULL, @entrenador_id, @fecha, @accion)", conn);

                cmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                cmd.Parameters.AddWithValue("@entrenador_id", UserCache.UserID);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@accion", "Entrenamiento creado");

                cmd.ExecuteNonQuery();
            }
        }

        public void RegistrarEliminacionEntrenamiento(int entrenamientoId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO AuditoriaEntrenamientos (entrenamiento_id, jugador_id, entrenador_id, fecha_asignacion, accion)
                    VALUES (@entrenamiento_id, NULL, @entrenador_id, @fecha, @accion)", conn);

                cmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                cmd.Parameters.AddWithValue("@entrenador_id", UserCache.UserID);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@accion", "Entrenamiento eliminado");

                cmd.ExecuteNonQuery();
            }
        }

        public void RegistrarAsignacionJugador(int entrenamientoId, int jugadorId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO AuditoriaEntrenamientos (entrenamiento_id, jugador_id, entrenador_id, fecha_asignacion, accion)
                    VALUES (@entrenamiento_id, @jugador_id, @entrenador_id, @fecha, @accion)", conn);

                cmd.Parameters.AddWithValue("@entrenamiento_id", entrenamientoId);
                cmd.Parameters.AddWithValue("@jugador_id", jugadorId);
                cmd.Parameters.AddWithValue("@entrenador_id", UserCache.UserID);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@accion", "Asignación");

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerAuditorias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        ae.id,
                        ae.entrenamiento_id,
                        ISNULL(e.titulo, '(Entrenamiento eliminado)') AS entrenamiento,
                        ae.jugador_id,
                        ISNULL(j.Name + ' ' + j.LastName, '(Jugador eliminado)') AS jugador,
                        ae.entrenador_id,
                        ISNULL(u.FirstName + ' ' + u.LastName, '(Entrenador eliminado)') AS entrenador,
                        ae.fecha_asignacion,
                        ae.accion
                    FROM AuditoriaEntrenamientos ae
                    LEFT JOIN Entrenamientos e ON ae.entrenamiento_id = e.id
                    LEFT JOIN Jugadores j ON ae.jugador_id = j.idJugador
                    LEFT JOIN Users u ON ae.entrenador_id = u.UserID
                    ORDER BY ae.fecha_asignacion DESC", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
