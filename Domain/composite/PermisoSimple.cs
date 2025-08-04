using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Composite
{
    public class PermisoSimple : Permiso
    {
        private string nombre;

        public PermisoSimple(string nombre)
        {
            this.nombre = nombre;
        }

        public override bool TienePermiso(string nombrePermiso)
        {
            return nombre.Equals(nombrePermiso);
        }
    }
}

