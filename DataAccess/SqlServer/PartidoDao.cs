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
        public void InsertarGol(Gol gol)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Goles (IdPartido, IdJugador, Minuto) VALUES (@IdPartido, @IdJugador, @Minuto)", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", gol.IdPartido);
                    command.Parameters.AddWithValue("@IdJugador", gol.IdJugador);
                    command.Parameters.AddWithValue("@Minuto", gol.Minuto);

                    command.ExecuteNonQuery();
                }
            }
        }

        
        public void InsertarTarjeta(Tarjeta tarjeta)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Tarjetas (IdPartido, IdJugador, Tipo, Minuto) VALUES (@IdPartido, @IdJugador, @Tipo, @Minuto)", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", tarjeta.IdPartido);
                    command.Parameters.AddWithValue("@IdJugador", tarjeta.IdJugador);
                    command.Parameters.AddWithValue("@Tipo", tarjeta.Tipo);
                    command.Parameters.AddWithValue("@Minuto", tarjeta.Minuto);

                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void InsertarListaDeGoles(List<Gol> goles)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                foreach (var gol in goles)
                {
                    using (var command = new SqlCommand("INSERT INTO Goles (IdPartido, IdJugador, Minuto) VALUES (@IdPartido, @IdJugador, @Minuto)", connection))
                    {
                        command.Parameters.AddWithValue("@IdPartido", gol.IdPartido);
                        command.Parameters.AddWithValue("@IdJugador", gol.IdJugador);
                        command.Parameters.AddWithValue("@Minuto", gol.Minuto);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void InsertarListaDeTarjetas(List<Tarjeta> tarjetas)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                foreach (var tarjeta in tarjetas)
                {
                    using (var command = new SqlCommand("INSERT INTO Tarjetas (IdPartido, IdJugador, Tipo, Minuto) VALUES (@IdPartido, @IdJugador, @Tipo, @Minuto)", connection))
                    {
                        command.Parameters.AddWithValue("@IdPartido", tarjeta.IdPartido);
                        command.Parameters.AddWithValue("@IdJugador", tarjeta.IdJugador);
                        command.Parameters.AddWithValue("@Tipo", tarjeta.Tipo);
                        command.Parameters.AddWithValue("@Minuto", tarjeta.Minuto);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public DataTable ObtenerGolesPorPartido(int idPartido)
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(
                    "SELECT (j.Name + ' ' + j.LastName) AS NombreJugador, g.Minuto FROM Goles g INNER JOIN Jugadores j ON g.IdJugador = j.IdJugador WHERE g.IdPartido = @IdPartido", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", idPartido);
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerTarjetasPorPartido(int idPartido)
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(
                    "SELECT (j.Name + ' ' + j.LastName) AS NombreJugador, t.Tipo, t.Minuto FROM Tarjetas t INNER JOIN Jugadores j ON t.IdJugador = j.IdJugador WHERE t.IdPartido = @IdPartido", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", idPartido);
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

    }
}

