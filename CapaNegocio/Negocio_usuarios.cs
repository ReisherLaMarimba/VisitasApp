using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntiedad;
using CapaDatos;
namespace CapaNegocio
{
    public class Negocio_usuarios
    {
        Datos_usuario objDato = new Datos_usuario();

        public List<Entidad_usuarios> ListUsuario(string buscar)
        {
            return objDato.ListUsuario(buscar);
        }

        public void insertarUsuario(Entidad_usuarios Usuario)
        {
            objDato.insertarUsuario(Usuario);
        }

        public void EditarUsuario(Entidad_usuarios Usuario)
        {
            objDato.EditarUsuario(Usuario);
        }

        public void EliminarUsuario(Entidad_usuarios Usuario)
        {
            objDato.EliminarUsuario(Usuario);
        }



    }
}
