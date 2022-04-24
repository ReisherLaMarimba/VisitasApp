using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntiedad;
using System.Data;

namespace CapaDatos
{
    public class Datos_registro
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);
        public List<Entidad_registro>ListRegistro(string buscar)
        {
            SqlDataReader lectorFilas;
            SqlCommand cmd = new SqlCommand("Sp_Buscar_registro_visitantes", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            lectorFilas = cmd.ExecuteReader();

            List<Entidad_registro> listar = new List<Entidad_registro>();
            while (lectorFilas.Read()) { 
                listar.Add(new Entidad_registro
                {
                    Id_user = lectorFilas.GetInt32(0),
                    CodigoRegistro = lectorFilas.GetString(1),
                    Nombre = lectorFilas.GetString(2),
                    Apellido = lectorFilas.GetString(3),
                    Carrera = lectorFilas.GetString(4),
                    Edificio = lectorFilas.GetString(5),
                    Aula = lectorFilas.GetString(6),
                    Hora_entrada = lectorFilas.GetDateTime(7),
                    Hora_salida = lectorFilas.GetDateTime(8),   
                    Motivo = lectorFilas.GetString(9),
                    Objetivo = lectorFilas.GetString(10),
                });
            }
            conexion.Close();
            lectorFilas.Close();
            return listar;
        }
        public void insertarRegistro(Entidad_registro registro)
        {
            SqlCommand cmd = new SqlCommand("Sp_ingresar_registro_visitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Nombre", registro.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", registro.Apellido);
            cmd.Parameters.AddWithValue("@carrera", registro.Carrera);
          cmd.Parameters.AddWithValue("@correo", registro.Correo);
          cmd.Parameters.AddWithValue("@edificio", registro.Edificio);
            cmd.Parameters.AddWithValue("@aula", registro.Aula);
            cmd.Parameters.AddWithValue("@hora_entrada", registro.Hora_entrada);
            cmd.Parameters.AddWithValue("@ehora_salida", registro.Hora_salida);
            cmd.Parameters.AddWithValue("@motivo", registro.Motivo);
            cmd.Parameters.AddWithValue("@objetivo", registro.Objetivo);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarRegistro(Entidad_registro registro)
        {
            SqlCommand cmd = new SqlCommand("Stored_EditarContacto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Nombre", registro.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", registro.Apellido);
            cmd.Parameters.AddWithValue("@carrera", registro.Carrera);
            cmd.Parameters.AddWithValue("@correo", registro.Correo);
            cmd.Parameters.AddWithValue("@edificio", registro.Edificio);
            cmd.Parameters.AddWithValue("@aula", registro.Aula);
            cmd.Parameters.AddWithValue("@hora_entrada", registro.Hora_entrada);
            cmd.Parameters.AddWithValue("@ehora_salida", registro.Hora_salida);
            cmd.Parameters.AddWithValue("@motivo", registro.Motivo);
            cmd.Parameters.AddWithValue("@objetivo", registro.Objetivo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarRegistro(Entidad_registro registro)
        {
            SqlCommand cmd = new SqlCommand("Stored_BorrarRegistro", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_user", registro.Id_user);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }


    }
}
