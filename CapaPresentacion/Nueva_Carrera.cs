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
    public partial class Nueva_Carrera : Form
    {
        public Nueva_Carrera()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            CL_Altas cl_objeto = new CL_Altas();
            MySqlDataReader alta;
            cl_objeto.Nombre = txtcarrera.Text;  
            alta = cl_objeto.AltasCarrera();
        }
    }
}
