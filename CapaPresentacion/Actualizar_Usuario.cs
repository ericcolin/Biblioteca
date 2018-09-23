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
using MySql.Data;

namespace CapaPresentacion
{
    public partial class Actualizar_Usuario : Form
    {
        public Actualizar_Usuario()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            //no aparece la ultima celda del DataGrid
            dataGridView_usuario.AllowUserToAddRows = false;
            CL_Consultas cl_objeto = new CL_Consultas();
            cl_objeto.Numero_Control = txtusuario.Text;
            dataGridView_usuario.DataSource = cl_objeto.ConsultaUsuario().Tables[0];
        }
    }
}
