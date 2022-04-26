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
using CapaEntiedad;
namespace CapaPresentacion
{

    public partial class Edificios_view : Form
    {

        private string id_edificio;
        bool editarse = false;
        Entidad_edificio objentidad = new Entidad_edificio();
        Negocio_edificio objnegocio = new Negocio_edificio();

        public Edificios_view()
        {
            InitializeComponent();
        }

        private void Edificios_view_Load(object sender, EventArgs e)
        {
            mostrar("");
            accionesEnTabla();
        }

        public void accionesEnTabla()
        {
            tabla_ver_edificio.Columns[0].Visible = false;
            tabla_ver_edificio.ClearSelection();
        }

        public void mostrar(string buscar)
        {
            Negocio_edificio objUsuario = new Negocio_edificio();
            tabla_ver_edificio.DataSource = objUsuario.ListEdificio(buscar);
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objentidad.NombreEdificio = txt_nombre_Edificio.Text;
                    objnegocio.insertarEdificio(objentidad);
                    MessageBox.Show("Edificio Agregado");
                    txt_nombre_Edificio.Clear();
                    mostrar("");
                    editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }if(editarse == true)
            {
                try
                {
                    objentidad.Id_edificio =  Convert.ToInt32(id_edificio);
                    objentidad.NombreEdificio= txt_nombre_Edificio.Text;
                    objnegocio.EditarEdificio(objentidad);
                    MessageBox.Show("Se edito el registro");
                    mostrar("");
                    editarse=false;
                }catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar" +ex);
                }
            }
        }
        



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostrar("");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tabla_ver_edificio.SelectedCells.Count > 0)
            {
                editarse = true;
                id_edificio = tabla_ver_edificio.CurrentRow.Cells[0].Value.ToString();
                txt_nombre_Edificio.Text = (string)tabla_ver_edificio.CurrentRow.Cells[1].Value;



            }
            else
            {
                MessageBox.Show("Debe seleccionar una faila para editar");
            }
            

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(tabla_ver_edificio.SelectedCells.Count > 0)
            {
                objentidad.Id_edificio = Convert.ToInt32(tabla_ver_edificio.CurrentRow.Cells [0].Value.ToString());
                objnegocio.EliminarEdificio(objentidad);
                MessageBox.Show("Elimado");
            }
            else
            {
                MessageBox.Show("no se pude");
            }
        }
    }
}
