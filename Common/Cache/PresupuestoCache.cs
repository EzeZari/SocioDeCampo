using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class PresupuestoCache
    {
        public int id { get; set; }
        public string categoria { get; set; }
        public decimal monto_presupuestado { get; set; }
        public string temporada { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public string notas { get; set; }
    }
}
