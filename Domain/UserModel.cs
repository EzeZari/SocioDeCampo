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

        #region Formulario Registrarse
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting); //Retornamos el mensaje q retorna el metodo de la capa de acceso a datos. (Enviamos usuario solicitante)
        }

        public void AddUsuario (string loginName, string firstName, string lastName, string Email, string pass, string position)
        {
            userDao.AddUser(loginName,firstName,lastName,Email,pass,position);
        }
        #endregion

        #region Formulario de Jugadores
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

        public void EditarJugador(string Name, string LastName, string Birthdate, string Nationality, string Position, string idJugador)
        {
            userDao.Editar(Name, LastName, Birthdate, Nationality, Position, Convert.ToInt32(idJugador));
        }

        public void EliminarJugador( string idJugador)
        {
            userDao.Eliminar(Convert.ToInt32(idJugador));
        }
        #endregion

        public void AgregarContrato(int idJugador, DateTime fechaInicio, DateTime fechaFin, decimal monto, string clausula)
        {
            userDao.AddContrato(idJugador, fechaInicio, fechaFin, monto, clausula);
        }

        // Método para obtener los contratos
        public List<Contrato> ObtenerContratos()
        {
            return userDao.GetContratos();
        }
        public void EditarUser(string LoginName, string FirstName, string LastName, string Email, string Password, string Position, int UserID)
        {
            userDao.EditarDatosPerfil(LoginName, FirstName,LastName, Email, Password, Position, Convert.ToInt32(UserID));
        }

        public bool ConsultLoginName(string LoginName)
        {
            return userDao.ConsultLoginName(LoginName);
        }
        public bool ConsultEmail(string Email)
        {
            return userDao.ConsultEmail(Email);
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
