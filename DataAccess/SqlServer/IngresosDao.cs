using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer
{
    using System.Data;
    using System.Data.SqlClient;
    using Common;
    using Common.Cache;

    namespace DataAccess.SqlServer
    {
        public class IngresosDao : ConnectionToSQL
        {
            public void CrearIngreso(IngresosCache ingreso)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("CrearIngreso", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@tipo_de_ingreso", ingreso.tipo_de_ingreso);

                        command.Parameters.AddWithValue("@monto", ingreso.monto);
                        command.Parameters.AddWithValue("@metodo_de_pago", ingreso.metodo_de_pago);
                        command.Parameters.AddWithValue("@fecha", ingreso.fecha);
                        command.ExecuteNonQuery();
                    }


                }
            }

            public DataTable MostrarIngresos()
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("MostrarIngresos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable tabla = new DataTable();
                            tabla.Load(reader);
                            return tabla;
                        }
                    }
                }
            }

            public void EliminarIngreso(int id)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("EliminarIngreso", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public DataTable FiltrarIngresos(DateTime fechaInicio, DateTime fechaFin)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("FiltrarIngresos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable tabla = new DataTable();
                            tabla.Load(reader);
                            return tabla;
                        }
                    }
                }
            }
        }
    }

}
