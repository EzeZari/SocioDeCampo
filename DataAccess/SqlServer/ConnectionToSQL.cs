using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        private readonly string connectionString;
        public ConnectionToSQL() {
            connectionString = connectionString = "server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true";
        }
        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
        protected void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
