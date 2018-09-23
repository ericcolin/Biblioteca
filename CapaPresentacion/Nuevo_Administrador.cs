using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class Nuevo_Administrador : Form
    {
        public Nuevo_Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CL_Altas cl_objeto = new CL_Altas();
            MySqlDataReader alta;
            cl_objeto.Nombre = txtnombre.Text;
            cl_objeto.App = txtapp.Text;
            cl_objeto.Apm = txtapm.Text;
            cl_objeto.Usuario = txtnombre_usuario.Text;
            cl_objeto.Contraseña = txtcontraseña.Text;
            alta = cl_objeto.AltasAdministrador();
        }
    }
}
