using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntiedad;
using CapaDatos;
namespace CapaNegocio
{
    public class Negocio_aulas
    {
        Datos_aulas objDato = new Datos_aulas();

        public List<Entidad_aulas> Listaula(string buscar)
        {
            return objDato.Listaula(buscar);
        }

        public void insertaraula(Entidad_aulas aula)
        {
            objDato.insertaraula(aula);
        }

        public void Editaraula(Entidad_aulas aula)
        {
            objDato.Editaraula(aula);
        }

        public void Eliminaraula(Entidad_aulas aula)
        {
            objDato.Eliminaraula(aula);
        }

    }
}
