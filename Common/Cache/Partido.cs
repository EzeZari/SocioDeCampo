﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Common.Cache
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Ubicacion { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int ResultadoLocal { get; set; }
        public int ResultadoVisitante { get; set; }
        public string Observaciones { get; set; }
        public bool PartidoJugado { get; set; }
        public string Estadio { get; set; }
        public int NumeroFecha { get; set; }


    }
    public class Gol
    {
        public int IdPartido { get; set; }
        public int IdJugador { get; set; }
        public int Minuto { get; set; }
        public string NombreJugador { get; set; } // solo para mostrar en UI
    }
    public class Tarjeta
    {
        public int IdPartido { get; set; }
        public int IdJugador { get; set; }
        public string Tipo { get; set; } // "Amarilla" o "Roja"
        public int Minuto { get; set; }
        public string NombreJugador { get; set; } // solo para mostrar en UI
    }
}

