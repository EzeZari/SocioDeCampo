using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class Contrato
    {
        public int Id { get; set; }
        public int IdJugador { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Monto { get; set; }
        public string Clausula { get; set; }
        public decimal Salario { get; set; }
        public string Bonificacion { get; set; }
        public string Obligacion { get; set; }
    }
}

