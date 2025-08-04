using System;
using System.Data;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class EntrenamientoModel
    {
        private EntrenamientoDao dao = new EntrenamientoDao();

        public void CrearEntrenamiento(EntrenamientoCache entrenamiento) => dao.Crear(entrenamiento);
        public void EliminarEntrenamiento(int id) => dao.Eliminar(id);
        public DataTable MostrarEntrenamientos() => dao.MostrarEntrenamientos();
        public int ObtenerUltimoEntrenamientoId() => dao.ObtenerUltimoId();
        public DataTable FiltrarEntrenamientos(DateTime desde, DateTime hasta) => dao.FiltrarPorFechas(desde, hasta);

        // ✅ Métodos que faltaban:
        public DataTable ObtenerJugadores() => dao.ObtenerJugadores();
        public DataTable ObtenerJugadoresAsignados(int entrenamientoId) => dao.ObtenerJugadoresAsignados(entrenamientoId);
        public void AsignarJugador(int entrenamientoId, int jugadorId) => dao.AsignarJugador(entrenamientoId, jugadorId);
    }
}
