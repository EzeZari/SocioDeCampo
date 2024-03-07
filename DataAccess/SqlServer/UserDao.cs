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
                                UserCache.UserID = reader.GetInt32(0);
                                UserCache.FirstName = reader.GetString(2);
                                UserCache.LastName = reader.GetString(3);
                                UserCache.Email = reader.GetString(4);
                                UserCache.Position = reader.GetString(6);
                            }

                        return true;
                    }
                    else
                        return false;
                }
            }

            
        }

        public string recoverPassword(string userRequesting) //Funcion para recuperar contraseña
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) //Instanciamos al comando sql
                {
                    command.Connection = connection; //Especificamos la conexion al comando.
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail"; //Seleccionamos td de la tabla User (Lo puede soliciar mediante correo o User )
                    command.Parameters.AddWithValue("@user", userRequesting); //Agregamos valor al parametro con el dato que se recibe del usuario solicitante.
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader(); //Declaramos un lector de datos de sql y ejecutamos el lector.

                    if (reader.Read() == true) //Si la consulta existe tenemos los datos del usuario.
                    {
                        string userName = reader.GetString(2) + " " + reader.GetString(3);
                        string userMail = reader.GetString(4);
                        string accountPassword = reader.GetString(5);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail( //Requiere que mandemos el cuerpo y titulo.
                            subject: "Recuperar contraseña",
                            body: "Hola, " + userName + ". \nLe recordamos que su contraseña es: " + accountPassword + " \nPor favor cambie su contraseña una vez ingresado al Sistema.",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hola " +userName + " Olvidaste tu contraseña \n " + " Revisa en tu correo "+userMail;
                    }
                    else
                        return "No existe una cuenta con este Usuario o correo electronico";
                }
            }
        }


        public void AnyMethod()
        {
            if (UserCache.Position == Position.Administrador) //Cuando entra el admin, pasa tal cosa
            {
                //Codigo
            }
            if(UserCache.Position == Position.Entrenador || UserCache.Position == Position.AyudanteDeCampo) //Cuando entra Entrenador o ayudante tecnico, pasa otra cosa
            {
                //Codigo
            }
        }
    }
}
