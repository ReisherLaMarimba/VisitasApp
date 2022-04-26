using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntiedad;
using CapaDatos;
using System.Configuration;
namespace CapaDatos
{
    public  class Datos_roles
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);
        public List<Entidad_roles> ListRoles(string buscar)
        {
            SqlDataReader LectorFilas;
            SqlCommand cmd = new SqlCommand("Sp_Buscar_roles", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LectorFilas = cmd.ExecuteReader();

            List<Entidad_roles> listar = new List<Entidad_roles>();
            while (LectorFilas.Read())
            {
                listar.Add(new Entidad_roles
                {
                    Id_roles = LectorFilas.GetInt32(0),
                    NombreRol= LectorFilas.GetString(1),

                });
            }
            conexion.Close();
            LectorFilas.Close();
            return listar;
        }

        public void insertarroles(Entidad_roles roles)
        {
            SqlCommand cmd = new SqlCommand("Sp_ingresar_roles", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_roles", roles.Id_roles);
            cmd.Parameters.AddWithValue("@Nombre", roles.NombreRol);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void Editarroles(Entidad_roles roles)
        {
            SqlCommand cmd = new SqlCommand("Sp_editar_roles", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_roles", roles.Id_roles);
            cmd.Parameters.AddWithValue("@Nombre", roles.NombreRol);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Eliminarroles(Entidad_roles roles)
        {
            SqlCommand cmd = new SqlCommand("Stored_BorrarRoles", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_roles", roles.Id_roles);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
