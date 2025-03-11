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

        public DataTable FiltrarGasto(DateTime fechainicio, DateTime fechafinal)
        {
            DataTable tabla = new DataTable();
            tabla = gastosDao.FiltrarGasto(fechainicio, fechafinal);
            return tabla;
        }

        public decimal ObtenerTotalGastos()
        {
            DataTable tabla = gastosDao.Mostrar();
            if (tabla.Rows.Count > 0)
            {
                return tabla.AsEnumerable().Sum(row => row.Field<decimal>("cantidad"));
            }
            return 0;
        }
        // Añade este método al GastosModel existente
        public DataTable MostrarUltimosMovimientos()
        {
            DataTable tabla = new DataTable();//Creamos un registro para guardar lo q nos devuelve el DataAcces.
            tabla = gastosDao.MostrarUltimosMovimientos();
            return tabla;
        }

    }



}