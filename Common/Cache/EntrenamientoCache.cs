using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class EntrenamientoCache
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int Duracion { get; set; }
        public string Lugar { get; set; }
        public int EntrenadorId { get; set; }
    }
}
