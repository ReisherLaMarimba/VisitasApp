using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntiedad;
using CapaDatos;
namespace CapaNegocio
{
    public class Negocio_edificio
    {
       Datos_edificio objDato = new Datos_edificio();
       
     


        public List<Entidad_edificio> ListEdificio(string buscar)
        {
            return objDato.ListEdificio(buscar);
        }

        public void insertarEdificio(Entidad_edificio Edificio)
        {
            objDato.insertarEdificio(Edificio);
        }

        public void EditarEdificio(Entidad_edificio Edificio)
        {
            objDato.EditarEdificio(Edificio);
        }

        public void EliminarEdificio(Entidad_edificio Edificio)
        {
            objDato.EliminarEdificio(Edificio);
        }


    }
}
