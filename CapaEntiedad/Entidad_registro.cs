using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntiedad
{
    public class Entidad_registro
    {

        private int _Id_user;
        private string _CodigoRegistro;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private string _correo;
        private string _edificio;
        private string _aula;
        private DateTime _hora_entrada;
        private DateTime _hora_salida;
        private string _motivo;
        private string _objetivo;
        public int Id_user { get => _Id_user; set => _Id_user = value; }
        public string CodigoRegistro { get => _CodigoRegistro; set => _CodigoRegistro = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Edificio { get => _edificio; set => _edificio = value; }
        public string Aula { get => _aula; set => _aula = value; }
        public DateTime Hora_entrada { get => _hora_entrada; set => _hora_entrada = value; }
        public DateTime Hora_salida { get => _hora_salida; set => _hora_salida = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        
        public string Objetivo { get => _objetivo; set=> _objetivo = value; }
    }
}
