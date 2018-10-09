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
            CL_Consultas cl_objeto = new CL_Consultas();
            comboBox_carrera.DataSource = cl_objeto.ConsultaCarrera();
            comboBox_carrera.DisplayMember = "nombre_carrera";
            comboBox_carrera.ValueMember = "id_carrera";

            comboBox_tipo_usuario.DataSource = cl_objeto.ConsultaTipoUsurio();
            comboBox_tipo_usuario.DisplayMember = "tipo";
            comboBox_tipo_usuario.ValueMember = "id_tipo";
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            CL_Actualizaciones cl_objeto = new CL_Actualizaciones();
            MySqlDataReader actulizar_usuario;
            cl_objeto.Id_Usuario = "1";
            cl_objeto.Matricula = txtmatricula.Text;
            cl_objeto.Nombre = txtnombre.Text;
            cl_objeto.App = txtapp.Text;
            cl_objeto.Apm = txtapm.Text;
            cl_objeto.Grupo = txtgrupo.Text;
            cl_objeto.Id_Carrera = comboBox_carrera.SelectedValue.ToString();
            cl_objeto.Id_Tipo_Usuario = comboBox_tipo_usuario.SelectedValue.ToString();
            actulizar_usuario = cl_objeto.ActualizarUsuario();

            if (actulizar_usuario.Read() == true)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("no se pudo actualizar");
            }
        }
    }
}
