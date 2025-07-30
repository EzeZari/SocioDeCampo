using System;
using System.Collections.Generic;
using System.Data;               // ✅ ESTE ES EL QUE FALTABA
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess.SqlServer;

namespace Domain
{
    public class PartidoModel
    {
        private readonly PartidoDao partidoDao = new PartidoDao();

        public void AgregarPartido(DateTime fecha, TimeSpan hora, string ubicacion, string equipoLocal, string equipoVisitante, string observaciones, string estadio, int numeroFecha)
        {
            Partido nuevoPartido = new Partido
            {
                Fecha = fecha,
                Hora = hora,
                Ubicacion = ubicacion,
                EquipoLocal = equipoLocal,
                EquipoVisitante = equipoVisitante,
                Observaciones = observaciones,
                Estadio = estadio,
                NumeroFecha = numeroFecha
            };

            partidoDao.AddPartido(nuevoPartido);
        }


        public List<Partido> ObtenerTodosLosPartidos()
        {
            PartidoDao dao = new PartidoDao();
            return dao.ObtenerTodos();
        }
        public void ActualizarPartidoResultado(Partido partido)
        {
            partidoDao.ActualizarResultado(partido);
        }
        public void GuardarGoles(List<Gol> goles)
        {
            new PartidoDao().InsertarListaDeGoles(goles);
        }

        public void GuardarTarjetas(List<Tarjeta> tarjetas)
        {
            new PartidoDao().InsertarListaDeTarjetas(tarjetas);
        }

        public void GuardarTarjetas(int idPartido, List<Tarjeta> tarjetas)
        {
            foreach (var tarjeta in tarjetas)
            {
                tarjeta.IdPartido = idPartido; // por las dudas
            }

            PartidoDao dao = new PartidoDao();
            dao.InsertarListaDeTarjetas(tarjetas);
        }
        public DataTable ObtenerGolesPorPartido(int idPartido)
        {
            return new PartidoDao().ObtenerGolesPorPartido(idPartido);
        }

        public DataTable ObtenerTarjetasPorPartido(int idPartido)
        {
            return new PartidoDao().ObtenerTarjetasPorPartido(idPartido);
        }
        public void EliminarPartido(int idPartido)
        {
            partidoDao.EliminarPartido(idPartido);
        }

    }
}

