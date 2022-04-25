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

namespace CapaPresentacion
{
    public partial class Usuarios_view : Form
    {
        public Usuarios_view()
        {
            InitializeComponent();
        }

        private void Usuarios_view_Load(object sender, EventArgs e)
        {
            mostrar("");
        }
        private void mostrar(string buscar)
        {
            Negocio_usuarios objUsuario = new Negocio_usuarios();
            tabla_ver_usario.DataSource = objUsuario.ListUsuario(buscar);
        }
    }
}
