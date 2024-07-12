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
    public class UserDao : ConnectionToSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {

          

               // connection.Open(); // Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable

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

                //connection.Open();

                using (var command = new SqlCommand()) // Instanciamos al comando sql

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
                        return "Hola " + userName + " Olvidaste tu contraseña \n " + " Revisa en tu correo " + userMail;
                    }
                    else
                        return "No existe una cuenta con este Usuario o correo electronico";
                }
            }
        }

        public void AddUser(string loginName, string firstName, string lastName, string Email, string pass, string position)
        {
            using (var connection = GetConnection())
            {
                connection.Open();//Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Users values ('"+loginName+"','"+firstName+"','"+lastName+"','"+Email+"','"+pass+"','"+position+"') ";
                    command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                    
                }
            }
        }


    

        #region Mostrar, Añadir, Editar y Eliminar Jugador
        SqlDataReader leer;
        DataTable tabla = new DataTable();      // Agregamos
        SqlCommand comando = new SqlCommand(); // Para ejecutar instrucciones o procedimientos almacenados.

        public DataTable Mostrar() // Mostrar registros de tabla Jugadores
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open(); // Abrimos la conexión

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "MostrarJugadores"; // Usamos el procedimiento almacenado
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



        public void AddJugador(string Name, string LastName, string Birthdate, string Nationality, string Position)
        {
            using (var connection = GetConnection())
            {
                connection.Open(); //Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "InsertarJugador"; //Remplazamos esto por lo de abajo.
                    //"insert into Jugadores values ('" + Name + "','" + LastName + "','" + Brithdate + "','" + Nationality + "','" + Position + "') ";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Birthdate", Birthdate);
                    command.Parameters.AddWithValue("@Nationality", Nationality);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();//Limpiamos los parametros cada vez que termino de hacer una consulta, para que no tenga muchos almacenados.
                    //Y asi reutilizamos el mismo "Command" y no creamos uno nuevo.

                }
                
            }

        }

        public void Editar(string Name, string LastName, string Birthdate, string Nationality, string Position, int idJugador)
        {
            using (var connection = GetConnection())
            {
                connection.Open(); //Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarJugador"; 
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Birthdate", Birthdate);
                    command.Parameters.AddWithValue("@Nationality", Nationality);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@IdJugador", idJugador);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();//Limpiamos los parametros cada vez que termino de hacer una consulta, para que no tenga muchos almacenados.
                }
            }
        }

        public void Eliminar(int idJugador) {

            using (var connection = GetConnection())
            {
                connection.Open(); //Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable
                using (var command = new SqlCommand())
                {
                    command.Connection = connection; //Abrimos la conexion
                    command.CommandText = "EliminarJugador";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idJugador", idJugador);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                }

            }
        }
        #endregion


        public void EditarDatosPerfil(string LoginName, string FirstName, string LastName, string Email, string Password,string Position, int UserID)
        {
            using (var connection = GetConnection())
            {
                connection.Open(); //Abrimos la conexion, no hace falta cerrarlo, pq al usar "Using" es desechable
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarUsuario";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@LoginName", LoginName);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();//Limpiamos los parametros cada vez que termino de hacer una consulta, para que no tenga muchos almacenados.
                }
            }
        }

        public bool ConsultLoginName(string LoginName)
        {
            bool loginNameExists = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ConsultLoginName";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginName", LoginName);
                    int count = (int)command.ExecuteScalar();
                    loginNameExists = (count > 0);
                }
            }
            return loginNameExists;
        }
        public bool ConsultEmail(string Email)
        {
            bool emailExists = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ConsultEmail";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", Email);
                    int count = (int)command.ExecuteScalar();
                    emailExists = (count > 0);
                }
            }
            return emailExists;
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
