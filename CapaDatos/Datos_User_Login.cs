using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntiedad;
using Capa_Comun;
namespace CapaDatos
{
    public class Datos_User_Login
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);
        public bool login(string user, string pass)
        {
            SqlDataReader LectorFilas;
            SqlCommand cmd = new SqlCommand("Sp_Loging", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            LectorFilas = cmd.ExecuteReader();

            if (LectorFilas.HasRows)
            {
                while (LectorFilas.Read())
                {
                    CacheLogin.Userid = LectorFilas.GetInt32(0);
                    CacheLogin.LoginName = LectorFilas.GetString(1);
                    CacheLogin.Password = LectorFilas.GetString(2);
                    CacheLogin.nombreUser = LectorFilas.GetString(3);
                    CacheLogin.apellido = LectorFilas.GetString(4);
                    CacheLogin.id_roles = LectorFilas.GetInt32(5);
                    CacheLogin.fecha_nacimiento = LectorFilas.GetDateTime(6);
                }
                
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
 