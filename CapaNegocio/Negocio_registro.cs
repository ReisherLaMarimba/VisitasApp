using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntiedad;
using CapaDatos;
namespace CapaNegocio
{
    public class Negocio_registro
    {
        Datos_registro objDato = new Datos_registro();

        public List<Entidad_registro> ListRegistro(string buscar)
        {
            return objDato.ListRegistro(buscar);
        }
        public List<Entidad_registro> ListRegistroEdificio(string buscar)
        {
            return objDato.ListRegistroEdificio(buscar);
        }


        public void insertarRegistro(Entidad_registro Registro)
        {
            objDato.insertarRegistro(Registro);
        }

        public void EditarRegistro(Entidad_registro Registro)
        {
            objDato.EditarRegistro(Registro);
        }

        public void EliminarRegistro(Entidad_registro Registro)
        {
            objDato.EliminarRegistro(Registro);
        }



    }
}
