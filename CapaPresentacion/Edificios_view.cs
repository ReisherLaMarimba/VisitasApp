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
namespace CapaPresentacion
{
    public partial class Edificios_view : Form
    {
        public Edificios_view()
        {
            InitializeComponent();
        }

        private void Edificios_view_Load(object sender, EventArgs e)
        {
            mostrar("");
        }

        public void mostrar(string buscar)
        {
            Negocio_edificio objUsuario = new Negocio_edificio();
            tabla_ver_edificio.DataSource = objUsuario.ListEdificio(buscar);
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Edificios_add edificio = new Edificios_add();
            edificio.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostrar("");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
