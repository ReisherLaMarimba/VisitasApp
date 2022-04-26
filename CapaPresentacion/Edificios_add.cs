using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntiedad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Edificios_add : Form
    {
        bool editarse = false;
        Entidad_edificio objentidad = new Entidad_edificio();
        Negocio_edificio objnegocio = new Negocio_edificio();
        
        public Edificios_add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objentidad.NombreEdificio = txt_nombre_Edificio.Text;
                    objnegocio.insertarEdificio(objentidad);
                    MessageBox.Show("Edificio Agregado");
                    
                    editarse = false;
                    
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
