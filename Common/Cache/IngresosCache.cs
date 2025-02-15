using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class IngresosCache
    {
        public int id { get; set; }
        public string tipo_de_ingreso { get; set; }
    
        public decimal monto { get; set; }
        public string metodo_de_pago { get; set; }
        public DateTime fecha { get; set; }
    }
}
