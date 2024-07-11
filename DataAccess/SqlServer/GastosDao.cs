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
            using (var connection = GetConnection())
            {
                //connection.Open(); // Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable//
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;


                    // Asegúrate de que los nombres de los parámetros coincidan con los utilizados en la consulta SQL
                    command.Parameters.AddWithValue("@tipo_de_gasto", gastos.tipo_de_gasto);
                    command.Parameters.AddWithValue("@cantidad", gastos.cantidad);
                    command.Parameters.AddWithValue("@fecha", gastos.fecha);
                    command.Parameters.AddWithValue("@nota", gastos.nota);

                    // Define la consulta SQL con los nombres de los parámetros correctos
                    command.CommandText = "INSERT INTO gastos (tipo_de_gasto, cantidad, nota, fecha) VALUES (@tipo_de_gasto, @cantidad, @nota, @fecha)";

                    // Abre la conexión, ejecuta la consulta y cierra la conexión

                    command.ExecuteNonQuery();



                }
            }

        }
        public DataTable Mostrar() // Mostrar registros de tabla gastos
        {
            try
            {
                using (var connection = GetConnection())
                {
                     //connection.Open(); // Abrimos la conexión

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "MostrarGastos"; // Usamos el procedimiento almacenado
                        command.CommandType = CommandType.StoredProcedure;

                        using (var leer = command.ExecuteReader())
                        {
                            var tabla = new DataTable();
                            tabla.Load(leer); // Nuestra tabla será rellenada con el resultado del DataReader.
                            return tabla;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepción
                // Por ejemplo, puedes registrar el error o mostrar un mensaje
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public void EliminarGasto(int idGasto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "DELETE FROM dbo.gastos WHERE id = @idGasto";
                        command.Parameters.AddWithValue("@idGasto", idGasto);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery(); // Ejecuta la consulta
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }





}







/*public void AgregarGasto(string tipo_de_gasto, double Cantidad, DateTime Fecha, string Nota)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

        // Asegúrate de que los nombres de los parámetros coincidan con los utilizados en la consulta SQL
        cmd.Parameters.AddWithValue("@tipo_de_gasto", tipo_de_gasto);
        cmd.Parameters.AddWithValue("@cantidad", Cantidad);
        cmd.Parameters.AddWithValue("@fecha", Fecha);
        cmd.Parameters.AddWithValue("@nota", Nota);

        // Define la consulta SQL con los nombres de los parámetros correctos
        cmd.CommandText = "INSERT INTO gastos (tipo_de_gasto, cantidad, nota, fecha) VALUES (@tipo_de_gasto, @cantidad, @nota, @fecha)";

        // Abre la conexión, ejecuta la consulta y cierra la conexión
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    */