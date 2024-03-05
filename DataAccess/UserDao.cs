using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao:ConnectionToSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();//Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable
                using (var command = new SqlCommand())
                { 
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user); //Le asignamos el valor de entrada usuario.
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    using (var reader = command.ExecuteReader())
                        //SqlDataAdapter reader = command.ExecuteReader(); //SI ALGO NO ANDA, VER ACA EL ERROR
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                           {
                                UserLoginCache.UserID = reader.GetInt32(0);
                                UserLoginCache.FirstName = reader.GetString(2);
                                UserLoginCache.LastName = reader.GetString(3);
                                UserLoginCache.Email = reader.GetString(4);
                                UserLoginCache.Position = reader.GetString(6);
                            }

                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
