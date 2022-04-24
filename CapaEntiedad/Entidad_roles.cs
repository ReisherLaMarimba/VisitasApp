using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntiedad
{
    public class Entidad_roles
    {
        private int _id_roles;
        private string _nombreRol;

        public int Id_roles { get => _id_roles; set => _id_roles = value; }
        public string NombreRol { get => _nombreRol; set => _nombreRol = value; }
    }
}
