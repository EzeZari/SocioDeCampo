namespace Common.Cache
{
    public class AuditoriaCache
    {
        public int Id { get; set; }
        public int? EntrenamientoId { get; set; }
        public int? JugadorId { get; set; }
        public int EntrenadorId { get; set; }
        public string Accion { get; set; }
        public System.DateTime Fecha { get; set; }
    }
}
