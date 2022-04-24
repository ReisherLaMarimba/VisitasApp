using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
    using CapaEntiedad;

namespace CapaDatos
{
    public class Datos_usuario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<Entidad_usuarios> ListUsuario(string buscar)
        {
            SqlDataReader LectorFilas;
            SqlCommand cmd = new SqlCommand("Sp_Buscar_usuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LectorFilas = cmd.ExecuteReader();

            List<Entidad_usuarios> listar = new List<Entidad_usuarios>();
            while (LectorFilas.Read())
            {
                listar.Add(new Entidad_usuarios
                {
                    User_id= LectorFilas.GetInt32(0),
                    LoginName = LectorFilas.GetString(1),
                    Password = LectorFilas.GetString(2),
                    NombreUser = LectorFilas.GetString(3),
                    Apellido = LectorFilas.GetString(4),
                    Id_roles= LectorFilas.GetInt32(5),
                    Fecha_nacimientoUser= LectorFilas.GetDateTime(6),
                });
            }
            conexion.Close();
            LectorFilas.Close();
            return listar;
        }

        public void insertarUsuario(Entidad_usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("Sp_ingresar_usuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@loginName", usuarios.LoginName);
            cmd.Parameters.AddWithValue("@password", usuarios.Password);
            cmd.Parameters.AddWithValue("@nombre", usuarios.NombreUser);
            cmd.Parameters.AddWithValue("@apellido", usuarios.Apellido);
            cmd.Parameters.AddWithValue("@id_roles", usuarios.Id_roles);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", usuarios.Fecha_nacimientoUser);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarUsuario(Entidad_usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("Sp_editar_usuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@loginName", usuarios.LoginName);
            cmd.Parameters.AddWithValue("@password", usuarios.Password);
            cmd.Parameters.AddWithValue("@nombre", usuarios.NombreUser);
            cmd.Parameters.AddWithValue("@apellido", usuarios.Apellido);
            cmd.Parameters.AddWithValue("@id_roles", usuarios.Id_roles);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", usuarios.Fecha_nacimientoUser);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarUsuario(Entidad_usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("Stored_BorrarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@userid", usuarios.User_id);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
