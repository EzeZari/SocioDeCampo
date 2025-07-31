using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer
{
    public class EntrenamientoDao : ConnectionToSQL
    {
        public void CrearEntrenamiento(EntrenamientoCache entrenamiento)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("CrearEntrenamiento", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@titulo", entrenamiento.Titulo);
                    command.Parameters.AddWithValue("@descripcion", entrenamiento.Descripcion);
                    command.Parameters.AddWithValue("@fecha", entrenamiento.Fecha);
                    command.Parameters.AddWithValue("@duracion", entrenamiento.Duracion);
                    command.Parameters.AddWithValue("@lugar", entrenamiento.Lugar);
                    command.Parameters.AddWithValue("@entrenador_id", entrenamiento.EntrenadorId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable MostrarEntrenamientos()
        {
            var tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("MostrarEntrenamientos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }
            return tabla;
        }

        public void EliminarEntrenamiento(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("EliminarEntrenamiento", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }



        public DataTable FiltrarEntrenamientos(DateTime fechaInicio, DateTime fechaFin)
        {
            var tabla = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand(@"
                SELECT * FROM Entrenamientos 
                WHERE fecha >= @FechaInicio AND fecha < @FechaFin
                ORDER BY fecha DESC", connection))
                    {
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (var reader = command.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al filtrar entrenamientos: " + ex.Message);
            }

            return tabla;
        }

    }
}
