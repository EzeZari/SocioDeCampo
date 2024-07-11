using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.SqlServer;
using Common;
using System.Data;

namespace Domain
{
    public class GastosModel
    {
        GastosDao gastosDao = new GastosDao();
        public void CrearGasto(GastosCache gastos)
        {
            gastosDao.CrearGasto(gastos);
        }

        public DataTable Mostrargastos()
        {
            DataTable tabla = new DataTable();//Creamos un registro para guardar lo q nos devuelve el DataAcces.
            tabla = gastosDao.Mostrar();
            return tabla;
        }


        public void EliminarGasto(int idGasto)
        {
            gastosDao.EliminarGasto(idGasto);
        }
    }



}
