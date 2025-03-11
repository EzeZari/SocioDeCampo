using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Cache;

namespace DataAccess.SqlServer
{


    public class GastosDao : ConnectionToSQL
    {
        public void CrearGasto(GastosCache gastos)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO gastos (tipo_de_gasto, cantidad, nota, fecha) VALUES (@tipo_de_gasto, @cantidad, @nota, @fecha)", connection))
                    {
                        command.Parameters.AddWithValue("@tipo_de_gasto", gastos.tipo_de_gasto);
                        command.Parameters.AddWithValue("@cantidad", gastos.cantidad);
                        command.Parameters.AddWithValue("@fecha", gastos.fecha);
                        command.Parameters.AddWithValue("@nota", gastos.nota);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear gasto: " + ex.Message);
            }
        }

        public DataTable Mostrar()
        {
            var tabla = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("MostrarGastos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (var reader = command.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar gastos: " + ex.Message);
            }
            return tabla;
        }

        public void EliminarGasto(int idGasto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("DELETE FROM dbo.gastos WHERE id = @idGasto", connection))
                    {
                        command.Parameters.AddWithValue("@idGasto", idGasto);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar gasto: " + ex.Message);
            }
        }

        public DataTable FiltrarGasto(DateTime fechainicio, DateTime fechafinal)
        {
            var tabla = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Gastos WHERE fecha BETWEEN @Fechainicio AND @Fechafinal", connection))
                    {
                        command.Parameters.AddWithValue("@Fechainicio", fechainicio);
                        command.Parameters.AddWithValue("@Fechafinal", fechafinal);
                        using (var reader = command.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al filtrar gastos: " + ex.Message);
            }
            return tabla;
        }
        // Añade este método al GastosDao existente
        public DataTable MostrarUltimosMovimientos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM vw_UltimosMovimientos ORDER BY fecha DESC", connection))
                {
                    using (SqlDataReader leer = command.ExecuteReader())
                    {
                        DataTable tabla = new DataTable();
                        tabla.Load(leer);
                        return tabla;
                    }
                }
            }
        }
    }
    }




