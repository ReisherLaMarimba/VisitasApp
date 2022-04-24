using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntiedad;
using CapaDatos;

namespace CapaNegocio
{
    public class Negocio_roles
    {
        Datos_roles objDato = new Datos_roles();

        public List<Entidad_roles>ListRoles(string buscar)
        {
            return objDato.ListRoles(buscar);
        }
        
        public void insertarroles(Entidad_roles roles)
        {
            objDato.insertarroles(roles);
        }

        public void Editarroles (Entidad_roles roles)
        {
            objDato.Editarroles(roles);
        }

        public void Eliminarroles(Entidad_roles roles)
        {
            objDato.Eliminarroles(roles);
        }
    }
}
