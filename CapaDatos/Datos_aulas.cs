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
    public class Datos_aulas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);
        public List<Entidad_aulas> Listaula(string buscar)
        {
            SqlDataReader LectorFilas;
            SqlCommand cmd = new SqlCommand("Sp_Buscar_aula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LectorFilas = cmd.ExecuteReader();

            List<Entidad_aulas> listar = new List<Entidad_aulas>();
            while (LectorFilas.Read())
            {
                listar.Add(new Entidad_aulas
                {
                    Id_aula = LectorFilas.GetInt32(0),
                    NombreAula = LectorFilas.GetString(1),
                    Id_edificio = LectorFilas.GetInt32(2),

                });
            }
            conexion.Close();
            LectorFilas.Close();
            return listar;
        }

        public DataTable cargarCombo()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

            SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_registro_visitantes_edificio_combo", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataedificio = new DataTable();
            da.Fill(dataedificio);
            conexion.Open();
            return dataedificio;
        }


        public void insertaraula(Entidad_aulas aula)
        {
            SqlCommand cmd = new SqlCommand("Sp_ingresar_aula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Nombre", aula.NombreAula);
            cmd.Parameters.AddWithValue("@id_edificio", aula.Id_edificio);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public void Editaraula(Entidad_aulas aula)
        {
            SqlCommand cmd = new SqlCommand("Sp_editar_aula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Nombre", aula.NombreAula);
            cmd.Parameters.AddWithValue("@id_edificio", aula.Id_edificio);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Eliminaraula(Entidad_aulas aula)
        {
            SqlCommand cmd = new SqlCommand("Stored_BorrarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@id_aula", aula.Id_aula);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }


    }
}
