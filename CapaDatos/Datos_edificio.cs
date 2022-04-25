using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaDatos;
using CapaEntiedad;

namespace CapaDatos
{
 public class Datos_edificio
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);
        public List<Entidad_edificio> ListEdificio(string buscar)
        {
            SqlDataReader LectorFilas;
            SqlCommand cmd = new SqlCommand("Sp_Buscar_edificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LectorFilas = cmd.ExecuteReader();

            List<Entidad_edificio> listar = new List<Entidad_edificio>();
            while (LectorFilas.Read())
            {
                listar.Add(new Entidad_edificio
                {
                    Id_edificio = LectorFilas.GetInt32(0),
                    NombreEdificio = LectorFilas.GetString(1),
                    
                });
            }
            conexion.Close();
            LectorFilas.Close();
            return listar;
        }

        public void insertarEdificio(Entidad_edificio edificio)
        {
            SqlCommand cmd = new SqlCommand("Sp_ingresar_edificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_edificio", edificio.Id_edificio);
            cmd.Parameters.AddWithValue("@NombreEdificio", edificio.NombreEdificio);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void EditarEdificio(Entidad_edificio edificio)
        {
            SqlCommand cmd = new SqlCommand("Sp_editar_edificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_edificio", edificio.Id_edificio);
            cmd.Parameters.AddWithValue("@NombreEdificio", edificio.NombreEdificio);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEdificio(Entidad_edificio edificio)
        {
            SqlCommand cmd = new SqlCommand("Stored_BorrarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_edificio", edificio.Id_edificio);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }


    }
}
