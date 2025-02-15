using Common.Cache;
using DataAccess.SqlServer.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class IngresosModel
    {
        private IngresosDao ingresosDao = new IngresosDao();

        public void CrearIngreso(IngresosCache ingreso)
        {
            ingresosDao.CrearIngreso(ingreso);
        }

        public DataTable MostrarIngresos()
        {
            return ingresosDao.MostrarIngresos();
        }

        public void EliminarIngreso(int id)
        {
            ingresosDao.EliminarIngreso(id);
        }

        public DataTable FiltrarIngresos(DateTime fechaInicio, DateTime fechaFin)
        {
            return ingresosDao.FiltrarIngresos(fechaInicio, fechaFin);
        }
    }
}
