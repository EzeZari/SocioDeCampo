using System;
using System.Collections.Generic;
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

        public void AgregarPartido(DateTime fecha, TimeSpan hora, string ubicacion, string equipoLocal, string equipoVisitante, string observaciones)
        {
            Partido nuevoPartido = new Partido
            {
                Fecha = fecha,
                Hora = hora,
                Ubicacion = ubicacion,
                EquipoLocal = equipoLocal,
                EquipoVisitante = equipoVisitante,
                Observaciones = observaciones
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

    }
}

