using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess.SqlServer
{
    public class PartidoDao : ConnectionToSQL
    {
        public void AddPartido(Partido partido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("InsertarPartido", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Fecha", partido.Fecha);
                    command.Parameters.AddWithValue("@Hora", partido.Hora);
                    command.Parameters.AddWithValue("@Ubicacion", partido.Ubicacion ?? "");
                    command.Parameters.AddWithValue("@EquipoLocal", partido.EquipoLocal);
                    command.Parameters.AddWithValue("@EquipoVisitante", partido.EquipoVisitante);
                    command.Parameters.AddWithValue("@Observaciones", partido.Observaciones ?? "");

                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Partido> ObtenerTodos()
        {
            List<Partido> lista = new List<Partido>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Partidos", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Partido
                            {
                                IdPartido = Convert.ToInt32(reader["IdPartido"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Hora = (TimeSpan)reader["Hora"],
                                Ubicacion = reader["Ubicacion"].ToString(),
                                EquipoLocal = reader["EquipoLocal"].ToString(),
                                EquipoVisitante = reader["EquipoVisitante"].ToString(),
                                ResultadoLocal = Convert.ToInt32(reader["ResultadoLocal"]),
                                ResultadoVisitante = Convert.ToInt32(reader["ResultadoVisitante"]),
                                Observaciones = reader["Observaciones"].ToString(),
                                PartidoJugado = Convert.ToBoolean(reader["PartidoJugado"])
                            });
                        }
                    }
                }

            }

            return lista;
        }
        public void ActualizarResultado(Partido partido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE Partidos SET ResultadoLocal = @ResultadoLocal, ResultadoVisitante = @ResultadoVisitante, Observaciones = @Observaciones, PartidoJugado = 1 WHERE IdPartido = @IdPartido", connection))
                {
                    command.Parameters.AddWithValue("@ResultadoLocal", partido.ResultadoLocal);
                    command.Parameters.AddWithValue("@ResultadoVisitante", partido.ResultadoVisitante);
                    command.Parameters.AddWithValue("@Observaciones", partido.Observaciones ?? "");
                    command.Parameters.AddWithValue("@IdPartido", partido.IdPartido);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}

