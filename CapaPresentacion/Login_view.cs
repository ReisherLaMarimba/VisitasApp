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
    public partial class Login_view : Form
    {
        public Login_view()
        {
            InitializeComponent();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor= Color.DimGray;
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro de cerrar?","warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )

            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text != "Usuario") {
                if(txt_password.Text != "Contraseña")
                {
                    Negocio_login user = new Negocio_login();
                    var validarlogin = user.LoginUser(txt_usuario.Text, txt_password.Text);
                    if(validarlogin == true)

                    {
                        MainView mainmenu = new MainView();
                        mainmenu.Show();
                        mainmenu.FormClosed += cerrar_sesion;
                        this.Hide();
                    }
                    else
                    {
                        mensaje_error("Usuario o Contraseña Incorrecta");
                        txt_password.Clear();
                        txt_password.Focus();
                    }
                }
                else
                {
                    mensaje_error("Esta no es una contrasena valida");
                }

            }
            else
            {
                mensaje_error("Este no es un nombre de usuarios valido");
            }

           
        }
        private void mensaje_error(string msg)
        {
        label_error.Text = "    "+msg;
            label_error.Visible = true;
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "**********")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "**********";
                txt_password.ForeColor = Color.Black;
            }
        }

        private void cerrar_sesion(object sender, FormClosedEventArgs e)
        {
            txt_password.Clear();
            txt_usuario.Clear();
            label_error.Visible = false;
            this.Show();
            txt_usuario.Focus();
        }

    }
}
