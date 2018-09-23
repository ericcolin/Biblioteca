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
using System.Data;

namespace CapaPresentacion
{
    public partial class Nuevo_Usuario : Form
    {
        public Nuevo_Usuario()
        {
            InitializeComponent();
            CL_Consultas cl_objeto = new CL_Consultas();
            comboBox_carrera.DataSource = cl_objeto.ConsultaCarrera();
            comboBox_carrera.DisplayMember = "nombre_carrera";
            comboBox_carrera.ValueMember = "id_carrera";

            comboBox_tipo_usuario.DataSource = cl_objeto.ConsultaTipoUsurio();
            comboBox_tipo_usuario.DisplayMember = "tipo";
            comboBox_tipo_usuario.ValueMember = "id_tipo_usuario";

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            CL_Altas cl_objeto = new CL_Altas();
            MySqlDataReader alta;
            cl_objeto.Nombre = txtnombre.Text;
            cl_objeto.App = txtapp.Text;
            cl_objeto.Apm = txtapm.Text;
            cl_objeto.Grupo = txtgrupo.Text;
            cl_objeto.Id_Carrera = comboBox_carrera.SelectedValue.ToString();
            cl_objeto.Id_Tipo_Usuario = comboBox_tipo_usuario.SelectedValue.ToString();
            alta = cl_objeto.AltasUsuario();
        }
    }
}
