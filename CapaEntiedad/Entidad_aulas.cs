using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntiedad
{
    public class Entidad_aulas
    {
        private int _id_aula;
        private string _nombreAula;
        private int _id_edificio;

        public int Id_aula { get => _id_aula; set => _id_aula = value; }
        public string NombreAula { get => _nombreAula; set => _nombreAula = value; }
        public int Id_edificio { get => _id_edificio; set => _id_edificio = value; }
    }
}
