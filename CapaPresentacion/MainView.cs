using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Comun;
namespace CapaPresentacion
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                this.Close();
        }

        private void cargar_datos_usuario()
        {
            label_name_user.Text = CacheLogin.nombreUser;
            label_rol.Text = CacheLogin.id_roles.ToString();

            if(CacheLogin.id_roles == 1)
            {
                label_rol.Text = "Admin";
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            cargar_datos_usuario();
        }


        private void Cargar_form<Mi_main>()where Mi_main : Form, new()
        {
            Form formulario;
            formulario = Main_panel.Controls.OfType<Mi_main>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new Mi_main();
                formulario.TopLevel = false;
                Main_panel.Controls.Add(formulario);
                Main_panel.Tag = formulario;
                formulario.Show();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_ver_visitas_Click(object sender, EventArgs e)
        {
            Cargar_form<Visitas_view>();
        }
    }
}
