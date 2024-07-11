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
<<<<<<< Updated upstream
        public ConnectionToSQL() {
=======
        public ConnectionToSQL()
        {
>>>>>>> Stashed changes
            connectionString = "server=LAPTOP-UJ1RQKI3;DataBase=MyCompany;integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conectado a la base de datos");
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

    }




}
