using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Composite
{
    public abstract class Permiso
    {
        public abstract bool TienePermiso(string nombrePermiso);
    }
}

