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
  
    
    public partial class Aulas_view : Form
    {
        Datos_edificio dat = new Datos_edificio();
        private string id_aula;
        bool editarse = false;
       
        Entidad_aulas objentidad = new Entidad_aulas();
        Negocio_aulas objnegocio = new Negocio_aulas();

        public Aulas_view()
        {
            InitializeComponent();
        }


        private void accionesEnTabla()
        {
            tabla_aulas.Columns[0].Visible = false;
            tabla_aulas.ClearSelection();
            
        }


        public void mostrar(string buscar)
        {
            Negocio_aulas objAula = new Negocio_aulas();
            tabla_aulas.DataSource = objAula.Listaula(buscar);
        }

        private void limpiar()
        {
            txt_name.Clear();
        }
        private void Aulas_view_Load(object sender, EventArgs e)
        {
            mostrar("");
            cargar_combo();
           
        }

        private void cargar_combo()
        {
            combo_edificio.DataSource = dat.cargarCombo();
            combo_edificio.DisplayMember = "Nombre";
            combo_edificio.ValueMember = "id_edificio";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    objentidad.NombreAula = txt_name.Text;
                    objentidad.Id_edificio = Convert.ToInt32(combo_edificio.SelectedValue);
                    objnegocio.insertaraula(objentidad);
                    MessageBox.Show("Aula Agregado");
                    txt_name.Clear();
                    mostrar("");
                    limpiar();
                    editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pue no" + ex.Message);
                }
            }
            if (editarse == true)
            {
                try
                {
                    objentidad.Id_aula = Convert.ToInt32(id_aula);
                    objentidad.NombreAula = txt_name.Text;
                    objentidad.Id_edificio = combo_edificio.SelectedIndex + 1;
                    objnegocio.Editaraula(objentidad);
                    MessageBox.Show("Se edito el registro");
                    mostrar("");
                    limpiar();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar" + ex);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tabla_aulas.SelectedRows.Count > 0)
            {
                editarse = true;
                id_aula = tabla_aulas.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = tabla_aulas.CurrentRow.Cells[1].Value.ToString();
                combo_edificio.SelectedItem = tabla_aulas.CurrentRow.Cells[2].Value.ToString();
                


            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder realizar la edicion");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (tabla_aulas.SelectedRows.Count > 0)
            {
                objentidad.Id_aula= Convert.ToInt32(tabla_aulas.CurrentRow.Cells[0].Value.ToString());
                objnegocio.Eliminaraula(objentidad);
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
