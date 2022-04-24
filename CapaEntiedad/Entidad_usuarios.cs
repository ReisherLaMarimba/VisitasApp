using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntiedad
{
    public  class Entidad_usuarios
    {
        private int _User_id;
        private string _LoginName;
        private string _Password;
        private string _nombreUser;
        private string _apellido;
        private int _id_roles;
        private DateTime _fecha_nacimientoUser;

        public int User_id { get => _User_id; set => _User_id = value; }
        public string LoginName { get => _LoginName; set => _LoginName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string NombreUser { get => _nombreUser; set => _nombreUser = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Id_roles { get => _id_roles; set => _id_roles = value; }
        public DateTime Fecha_nacimientoUser { get => _fecha_nacimientoUser; set => _fecha_nacimientoUser = value; }
    }
}
