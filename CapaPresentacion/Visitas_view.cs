using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using Capa_Comun;
using CapaEntiedad;
namespace CapaPresentacion
{
    public partial class Visitas_view : Form
    {
        string id_user;
        bool editarse =  false;
        Datos_registro dat = new Datos_registro();
        Datos_aulas dat1 = new Datos_aulas();
        Entidad_registro objEntidad = new Entidad_registro();
        Negocio_registro objNegocio = new Negocio_registro();
        public Visitas_view()
        {
            InitializeComponent();
        }

        private void Visitas_view_Load(object sender, EventArgs e)
        {
            mostrar("");
            mostrarEdificio("");
            combo_buscar_edificio.DataSource = dat.cargarCombo();
            combo_buscar_edificio.DisplayMember = "Nombre";
            combo_buscar_edificio.ValueMember = "id_edificio";
            combo_edificio.DataSource = dat.cargarCombo();
            combo_edificio.DisplayMember = "Nombre";
            combo_edificio.ValueMember = "id_edificio";

            comboAula.DataSource = dat1.cargarCombo();
            comboAula.DisplayMember = "Nombre";
            comboAula.ValueMember = "id_aula";


            hora_entrada.CustomFormat = "yyyy-MM-dd";
            hora_entrada.Format = DateTimePickerFormat.Custom;

            Hora_salida.CustomFormat = "yyyy-MM-dd";
            Hora_salida.Format = DateTimePickerFormat.Custom;


            if(CacheLogin.Userid != 1)
            {
                pictureBox1.Visible = false;
                btn_borrar.Visible = false;
                btn_edit.Visible = false;
                btn_update.Visible = false;
            }

        }

        private void mostrar(string buscar)
        {
            Negocio_registro objRegistro = new Negocio_registro();
            table_registro.DataSource = objRegistro.ListRegistro(buscar);
        }

        private void mostrarEdificio(string buscar)
        {
            Negocio_registro objRegistro = new Negocio_registro();
            table_registro.DataSource = objRegistro.ListRegistroEdificio(buscar);
            combo_edificio.DataSource = objRegistro.ListRegistroEdificio(buscar);
        }




        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrar(txt_buscar.Text);
        }

        private void combo_buscar_edificio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrarEdificio(combo_buscar_edificio.Text);
        }






        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void data_nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objEntidad.Nombre = txt_name.Text.ToUpper();
                    objEntidad.Apellido = txt_apellido_visitante.Text.ToUpper();
                    objEntidad.Carrera = txt_carrera.Text.ToUpper();
                    objEntidad.Correo = txt_correo.Text.ToUpper();
                    objEntidad.Edificio = combo_edificio.ValueMember.ToString();
                    objEntidad.Motivo = txt_motivo.Text.ToUpper();
                    objEntidad.Objetivo = txt_obj.Text.ToUpper();
                    objEntidad.Aula = comboAula.ValueMember.ToString();
                    objEntidad.Hora_entrada = Convert.ToDateTime(hora_entrada.Text);
                    objEntidad.Hora_salida = Convert.ToDateTime(Hora_salida.Text);
                    objNegocio.insertarRegistro(objEntidad);
                    MessageBox.Show("Invitado agregado correctamente");
                    mostrar("");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el invitado " + ex);
                }
            }

            if (editarse == true)
            {
                try
                {
                    objEntidad.Id_user= Convert.ToInt32(id_user);
                    objEntidad.Nombre = txt_name.Text.ToUpper();
                    objEntidad.Apellido = txt_apellido_visitante.Text.ToUpper();
                    objEntidad.Carrera = txt_carrera.Text.ToUpper();
                    objEntidad.Correo = txt_correo.Text.ToUpper();
                    objEntidad.Motivo = txt_motivo.Text.ToUpper();
                    objEntidad.Edificio = combo_edificio.ValueMember.ToString();
                    objEntidad.Aula = comboAula.ValueMember.ToString();
                    objEntidad.Objetivo = txt_obj.Text.ToUpper();
                    objEntidad.Hora_entrada = Convert.ToDateTime(hora_entrada.Text);
                    objEntidad.Hora_salida = Convert.ToDateTime(Hora_salida.Value);
                   objNegocio.EditarRegistro(objEntidad);
                    MessageBox.Show("Se edito el registro correctamente");

                    mostrar("");
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar" + ex);
                }
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (table_registro.SelectedRows.Count > 0)
            {
                editarse = true;
                id_user = table_registro.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = table_registro.CurrentRow.Cells[1].Value.ToString();
                txt_apellido_visitante.Text = table_registro.CurrentRow.Cells[2].Value.ToString();
                txt_carrera.Text = table_registro.CurrentRow.Cells[3].Value.ToString();
                txt_correo.Text = table_registro.CurrentRow.Cells[4].Value.ToString();
                combo_edificio.SelectedItem = table_registro.CurrentRow.Cells[5].Value.ToString();
                comboAula.SelectedItem = table_registro.CurrentRow.Cells[6].Value.ToString();
                hora_entrada.Text = table_registro.CurrentRow.Cells[7].Value.ToString();
                Hora_salida.Text = table_registro.CurrentRow.Cells[8].Value.ToString();
                txt_obj.Text = table_registro.CurrentRow.Cells[9].Value.ToString();

                txt_motivo.Text = table_registro.CurrentRow.Cells[10].Value.ToString();
                



            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder realizar la edicion");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(table_registro.SelectedRows.Count > 0)
            {
                objEntidad.Id_user = Convert.ToInt32(table_registro.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarRegistro(objEntidad);
                MessageBox.Show("Registro eliminado");
                mostrar("");
            }
        }
    }
}
