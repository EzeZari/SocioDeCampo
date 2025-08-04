using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Domain.Composite
{
    public class PermisoCompuesto : Permiso
    {
        private List<Permiso> permisos = new List<Permiso>();

        public void Agregar(Permiso permiso)
        {
            permisos.Add(permiso);
        }

        public override bool TienePermiso(string nombrePermiso)
        {
            return permisos.Any(p => p.TienePermiso(nombrePermiso));
        }
    }
}

