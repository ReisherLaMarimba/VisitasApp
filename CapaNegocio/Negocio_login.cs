using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class Negocio_login
    {
        Datos_User_Login userDatos = new Datos_User_Login();
        public bool LoginUser(string user, string pass)
        {
            return userDatos.login(user, pass);
        }

    }
}
