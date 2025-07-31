using Common.Cache;
using DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EntrenamientoModel
    {
        private EntrenamientoDao entrenamientoDao = new EntrenamientoDao();

        public void CrearEntrenamiento(EntrenamientoCache entrenamiento)
        {
            entrenamientoDao.CrearEntrenamiento(entrenamiento);
        }

        public DataTable MostrarEntrenamientos()
        {
            return entrenamientoDao.MostrarEntrenamientos();
        }

        public void EliminarEntrenamiento(int id)
        {
            entrenamientoDao.EliminarEntrenamiento(id);
        }

        public DataTable FiltrarEntrenamientos(DateTime fechaInicio, DateTime fechaFin)
        {
            return entrenamientoDao.FiltrarEntrenamientos(fechaInicio, fechaFin);
        }
    }
}
