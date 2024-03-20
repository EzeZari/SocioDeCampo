using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;
using System.Data.SqlClient;
using System.Data;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting); //Retornamos el mensaje q retorna el metodo de la capa de acceso a datos. (Enviamos usuario solicitante)
        }

        public void AddUsuario (string loginName, string firstName, string lastName, string Email, string pass, string position)
        {
            userDao.AddUser(loginName,firstName,lastName,Email,pass,position);
        }


        //FORM JUGADORES
         public DataTable MostrarJugadores()
        {
            DataTable tabla = new DataTable();//Creamos un registro para guardar lo q nos devuelve el DataAcces.
            tabla = userDao.Mostrar();
            return tabla;
        }

        public void AddJugador(string Name, string LastName, string Birthdate, string Nationality, string Position)
        {
            userDao.AddJugador(Name, LastName, Birthdate, Nationality, Position);
        }


        public void AnyMethod() 
        {
            if (UserCache.Position == Position.Administrador) //Cuando entra el admin, pasa tal cosa
            {
                //Codigo
            }
            if (UserCache.Position == Position.Entrenador || UserCache.Position == Position.AyudanteDeCampo) //Cuando entra Entrenador o ayudante tecnico, pasa otra cosa
            {
                //Codigo
            }
        }
    }
}
