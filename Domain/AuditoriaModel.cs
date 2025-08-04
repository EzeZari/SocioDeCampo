using DataAccess;
using System.Data;

namespace Domain
{
    public class AuditoriaModel
    {
        private readonly AuditoriaDao dao = new AuditoriaDao();

        public void RegistrarCreacionEntrenamiento(int entrenamientoId)
        {
            dao.RegistrarCreacionEntrenamiento(entrenamientoId);
        }

        public void RegistrarEliminacionEntrenamiento(int entrenamientoId)
        {
            dao.RegistrarEliminacionEntrenamiento(entrenamientoId);
        }

        public void RegistrarAsignacionJugador(int entrenamientoId, int jugadorId)
        {
            dao.RegistrarAsignacionJugador(entrenamientoId, jugadorId);
        }

        public DataTable ObtenerAuditorias()
        {
            return dao.ObtenerAuditorias();
        }
    }
}
