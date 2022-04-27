using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaEntiedad;

namespace CapaPresentacion
{
    public partial class Usuarios_view : Form
    {
        private string UserId;
        bool editarse = false;
        Datos_usuario dat = new Datos_usuario();
         Entidad_usuarios objEntidad = new Entidad_usuarios();
        Negocio_usuarios objNegocio = new Negocio_usuarios();
        public Usuarios_view()
        {
            InitializeComponent();
        }

        private void Usuarios_view_Load(object sender, EventArgs e)
        {
            mostrar("");
            cargar_combo();
        
        }

        private void cargar_combo()
        {
            combo_rol.DataSource = dat.cargarRoles();
            combo_rol.DisplayMember = "Nombre";
            combo_rol.ValueMember = "id_roles";
        }

        private void limpiar()
        {
            txt_lastName.Clear();
            txt_loginName.Clear();
            txt_name.Clear();
            txt_pass.Clear();
            
        }


        private void mostrar(string buscar)
        {
            Negocio_usuarios objUsuario = new Negocio_usuarios();
            tabla_ver_usario.DataSource = objUsuario.ListUsuario(buscar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(editarse == false)
            {
                try
                {
                    objEntidad.LoginName = txt_loginName.Text.ToUpper();
                    objEntidad.Password =  txt_pass.Text.ToUpper();
                    objEntidad.NombreUser = txt_name.Text.ToUpper();
                    objEntidad.Apellido =  txt_lastName.Text.ToUpper();
                    objEntidad.Id_roles = Convert.ToInt32(combo_rol.SelectedValue);
                    objEntidad.Fecha_nacimientoUser = Convert.ToDateTime(data_nacimiento.Text);
                    objNegocio.insertarUsuario(objEntidad);
                    MessageBox.Show("Usuario agregado correctamente");
                    mostrar("");
                    limpiar();

                }catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el usuario "+ ex);
                }
            } 
            
            if(editarse == true)
            {
                try
                {
                    objEntidad.User_id = Convert.ToInt32(UserId);    
                    objEntidad.LoginName = txt_loginName.Text.ToUpper();
                    objEntidad.Password = txt_pass.Text.ToUpper();
                    objEntidad.NombreUser = txt_name.Text.ToUpper();
                    objEntidad.Apellido = txt_lastName.Text.ToUpper();
                    objEntidad.Id_roles = combo_rol.SelectedIndex+1;
                    objEntidad.Fecha_nacimientoUser = Convert.ToDateTime(data_nacimiento.Text);
                    objNegocio.EditarUsuario(objEntidad);
                    MessageBox.Show("Se edito el registro correctamente");
                    
                    mostrar("");
                    limpiar();
                }catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar" + ex);
                }
            }


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(tabla_ver_usario.SelectedRows.Count > 0)
            {
                editarse = true;
                UserId = tabla_ver_usario.CurrentRow.Cells[0].Value.ToString();
                txt_loginName.Text = tabla_ver_usario.CurrentRow.Cells[1].Value.ToString();
                txt_pass.Text = tabla_ver_usario.CurrentRow.Cells[2].Value.ToString();
                txt_name.Text = tabla_ver_usario.CurrentRow.Cells[3].Value.ToString();
                txt_lastName.Text = tabla_ver_usario.CurrentRow.Cells[4].Value.ToString();
                combo_rol.SelectedItem = tabla_ver_usario.CurrentRow.Cells[5].Value.ToString();
                data_nacimiento.Text = tabla_ver_usario.CurrentRow.Cells[6].Value.ToString();


            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder realizar la edicion");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (tabla_ver_usario.SelectedRows.Count > 0)
            {
                objEntidad.User_id = Convert.ToInt32(tabla_ver_usario.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarUsuario(objEntidad);
                MessageBox.Show("Registro Eliminado");
                mostrar("");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            mostrar("");
            limpiar();
        }
    }
}
