using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntiedad
{
    public class Entidad_edificio
    {
        private int _id_edificio;
        private string _nombreEdificio;

        public int Id_edificio { get => _id_edificio; set => _id_edificio = value; }
        public string NombreEdificio { get => _nombreEdificio; set => _nombreEdificio = value; }
    }
}
