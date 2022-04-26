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
    Datos_aulas dat = new Datos_aulas();

    public partial class Aulas_view : Form
    {
        public Aulas_view()
        {
            InitializeComponent();
        }
    }
}
