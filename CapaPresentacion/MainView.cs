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
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                Main_panel.Controls.Add(formulario);
                Main_panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_ver_visitas_Click(object sender, EventArgs e)
        {
            Cargar_form<Visitas_view>();
            label1.Text = ("Menu Visitas");
        }

        private void btn_ver_usuarios_Click(object sender, EventArgs e)
        {
            Cargar_form<Usuarios_view>();
            label1.Text = ("Menu Usuarios");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargar_form<Roles_view>();
            label1.Text = ("Menu Roles");
        }

        private void btn_ver_usuario_Click(object sender, EventArgs e)
        {
            Cargar_form<Edificios_view>();
            label1.Text = ("Menu Edificios");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar la aplicacion?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ver_aula_Click(object sender, EventArgs e)
        {
            Cargar_form<Aulas_view>();
            label1.Text = ("Menu Aulas");
        }
    }
}
