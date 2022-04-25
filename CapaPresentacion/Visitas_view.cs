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
using CapaEntiedad;
namespace CapaPresentacion
{
    public partial class Visitas_view : Form
    {
        Datos_registro dat = new Datos_registro();
       
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
        }




        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrar(txt_buscar.Text);
        }

        private void combo_buscar_edificio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrarEdificio(combo_buscar_edificio.Text);
        }
    }
}
