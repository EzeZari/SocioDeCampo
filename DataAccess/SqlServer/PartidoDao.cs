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
        public int AddPartido(Partido partido)
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
                    command.Parameters.AddWithValue("@Estadio", partido.Estadio ?? "");
                    command.Parameters.AddWithValue("@NumeroFecha", partido.NumeroFecha);

                    int idGenerado = Convert.ToInt32(command.ExecuteScalar());

                    // Auditoría
                    string datosNuevos = $"Fecha: {partido.Fecha}, Hora: {partido.Hora}, Local: {partido.EquipoLocal}, Visitante: {partido.EquipoVisitante}, Ubicación: {partido.Ubicacion}, Estadio: {partido.Estadio}, FechaNro: {partido.NumeroFecha}";
                    RegistrarAuditoria("INSERT", idGenerado, null, datosNuevos);

                    return idGenerado;
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
                                PartidoJugado = Convert.ToBoolean(reader["PartidoJugado"]),
                                Estadio = reader["Estadio"]?.ToString(),
                                NumeroFecha = reader["NumeroFecha"] != DBNull.Value ? Convert.ToInt32(reader["NumeroFecha"]) : 0,


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


        public void EliminarPartido(int idPartido)
        {
            string datosAntes = ObtenerDatosPartido(idPartido);

            using (var connection = GetConnection())
            {
                connection.Open();

                // 1. Eliminar Tarjetas
                using (var cmdTarjetas = new SqlCommand("DELETE FROM Tarjetas WHERE IdPartido = @IdPartido", connection))
                {
                    cmdTarjetas.Parameters.AddWithValue("@IdPartido", idPartido);
                    cmdTarjetas.ExecuteNonQuery();
                }

                // 2. Eliminar Goles (si aplicás esto también)
                using (var cmdGoles = new SqlCommand("DELETE FROM Goles WHERE IdPartido = @IdPartido", connection))
                {
                    cmdGoles.Parameters.AddWithValue("@IdPartido", idPartido);
                    cmdGoles.ExecuteNonQuery();
                }

                // 3. Eliminar Partido
                using (var command = new SqlCommand("DELETE FROM Partidos WHERE IdPartido = @IdPartido", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", idPartido);
                    command.ExecuteNonQuery();
                }
            }

            RegistrarAuditoria("DELETE", idPartido, datosAntes, null);
        }



        // MÉTODO ÚNICO DE AUDITORÍA (adaptado a tu estructura de BD)
        public void RegistrarAuditoria(string operacion, int? idPartido, string datosAntes, string datosDespues)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO AuditoriaPartidos (IdPartido, Accion, Usuario, DatosAnteriores, DatosNuevos) VALUES (@IdPartido, @Accion, @Usuario, @DatosAnteriores, @DatosNuevos)", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", (object)idPartido ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Accion", operacion);
                    command.Parameters.AddWithValue("@Usuario", UserCache.LoginName);
                    command.Parameters.AddWithValue("@DatosAnteriores", (object)datosAntes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DatosNuevos", (object)datosDespues ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }


        public string ObtenerDatosPartido(int idPartido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Partidos WHERE IdPartido = @IdPartido", connection))
                {
                    command.Parameters.AddWithValue("@IdPartido", idPartido);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var datos = new StringBuilder();
                            datos.Append("Fecha: " + reader["Fecha"]);
                            datos.Append(", Hora: " + reader["Hora"]);
                            datos.Append(", Ubicacion: " + reader["Ubicacion"]);
                            datos.Append(", Local: " + reader["EquipoLocal"]);
                            datos.Append(", Visitante: " + reader["EquipoVisitante"]);
                            datos.Append(", Resultado: " + reader["ResultadoLocal"] + "-" + reader["ResultadoVisitante"]);
                            datos.Append(", Observaciones: " + reader["Observaciones"]);
                            datos.Append(", Estadio: " + reader["Estadio"]);
                            datos.Append(", NumeroFecha: " + reader["NumeroFecha"]);
                            return datos.ToString();
                        }
                    }
                }
            }
            return "";
        }

        // MÉTODO FALTANTE: Obtener auditoría por partido (adaptado a tu BD)
        public DataTable ObtenerAuditoriaPorPartido(int idPartido)
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(
                    "SELECT IdAuditoria, Accion, FechaHora, Usuario, DatosAnteriores, DatosNuevos FROM AuditoriaPartidos WHERE IdPartido = @IdPartido ORDER BY FechaHora DESC", connection))
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

        // MÉTODO ADICIONAL: Obtener toda la auditoría (adaptado a tu BD)
        public DataTable ObtenerTodasLasAuditorias()
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(
                    "SELECT IdAuditoria, IdPartido, Accion, FechaHora, Usuario, DatosAnteriores, DatosNuevos FROM AuditoriaPartidos ORDER BY FechaHora DESC", connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }
        public void RegistrarMensajeAuditoria(string mensaje)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO AuditoriaPartidos (Accion, Usuario, DatosAnteriores, DatosNuevos) VALUES (@Accion, @Usuario, @DatosAnteriores, @DatosNuevos)", connection))
                {
                    command.Parameters.AddWithValue("@Accion", "INFO");
                    command.Parameters.AddWithValue("@Usuario", UserCache.LoginName);
                    command.Parameters.AddWithValue("@DatosAnteriores", DBNull.Value);
                    command.Parameters.AddWithValue("@DatosNuevos", mensaje);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}


