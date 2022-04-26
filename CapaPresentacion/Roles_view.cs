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
    public partial class Roles_view : Form
    {
        public Roles_view()
        {
            InitializeComponent();
        }

        private void Roles_view_Load(object sender, EventArgs e)
        {
            mostrar("");
        }

        private void mostrar(string buscar)
        {
            Negocio_roles objRegistro = new Negocio_roles();
            tabla_Ver_roles.DataSource = objRegistro.ListRoles(buscar);
        }
    }
}
