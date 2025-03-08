// PresupuestoModel.cs
using System;
using System.Collections.Generic;
using System.Data;
using Common.Cache;
using DataAccess.SqlServer;

namespace Domain
{
    public class PresupuestoModel
    {
        private PresupuestoDao _presupuestoDao = new PresupuestoDao();

        public void CrearPresupuesto(PresupuestoCache presupuesto)
        {
            _presupuestoDao.CrearPresupuesto(presupuesto);
        }

        public DataTable MostrarPresupuestos()
        {
            return _presupuestoDao.MostrarPresupuestos();
        }

        public DataTable MostrarPresupuestosPorTemporada(string temporada)
        {
            return _presupuestoDao.MostrarPresupuestosPorTemporada(temporada);
        }

        public void EditarPresupuesto(PresupuestoCache presupuesto)
        {
            _presupuestoDao.EditarPresupuesto(presupuesto);
        }

        public void EliminarPresupuesto(int id)
        {
            _presupuestoDao.EliminarPresupuesto(id);
        }

        public DataTable ObtenerComparativoPresupuestoVsGasto(string temporada)
        {
            return _presupuestoDao.ObtenerComparativoPresupuestoVsGasto(temporada);
        }

        // Método para obtener categorías únicas de gastos para el selector de presupuestos
        public DataTable ObtenerCategoriasGastos()
        {
            GastosDao gastosDao = new GastosDao();
            DataTable tablaGastos = gastosDao.Mostrar();

            DataTable categoriasUnicas = new DataTable();
            categoriasUnicas.Columns.Add("categoria", typeof(string));

            // Usar HashSet para garantizar valores únicos
            HashSet<string> categoriasSet = new HashSet<string>();

            foreach (DataRow row in tablaGastos.Rows)
            {
                string categoria = row["tipo_de_gasto"].ToString();
                if (!string.IsNullOrEmpty(categoria) && !categoriasSet.Contains(categoria))
                {
                    categoriasSet.Add(categoria);
                    categoriasUnicas.Rows.Add(categoria);
                }
            }

            return categoriasUnicas;
        }
    }
}