using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace Domain.Composite
{
    public static class FabricaPermisos
    {
        public static Permiso ObtenerPermisosPorCargo(string cargo)
        {
            var permisoRaiz = new PermisoCompuesto();

            switch (cargo)
            {
                case Position.Administrador:
                    permisoRaiz.Agregar(new PermisoSimple("GestionUsuarios"));
                    permisoRaiz.Agregar(new PermisoSimple("GestionPartidos"));
                    permisoRaiz.Agregar(new PermisoSimple("GestionFinanzas"));
                    permisoRaiz.Agregar(new PermisoSimple("GestionFisica"));
                    break;

                case Position.Entrenador:
                    permisoRaiz.Agregar(new PermisoSimple("GestionPartidos"));
                    break;

                case Position.AyudanteDeCampo:
                    permisoRaiz.Agregar(new PermisoSimple("VerEstadisticas"));
                    permisoRaiz.Agregar(new PermisoSimple("GestionPartidos"));
                    break;

                case Position.PreparadorFisico:
                    permisoRaiz.Agregar(new PermisoSimple("GestionFisica"));
                    break;

                case Position.Finanzas:
                    permisoRaiz.Agregar(new PermisoSimple("GestionFinanzas"));
                    break;
            }

            return permisoRaiz;
        }
    }
}

