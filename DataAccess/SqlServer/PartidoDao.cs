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
    }
}

