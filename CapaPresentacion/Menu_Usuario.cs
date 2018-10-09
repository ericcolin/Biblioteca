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
    public partial class Menu_Usuario : Form
    {
        public Menu_Usuario()
        {
            InitializeComponent();

            CL_Consultas cl_objeto = new CL_Consultas();
            comboBox_carrera.DataSource = cl_objeto.ConsultaCarrera();
            comboBox_carrera.DisplayMember = "nombre_carrera";
            comboBox_carrera.ValueMember = "id_carrera";
            this.comboBox_carrera.SelectedItem = null;

            comboBox_tipo_usuario.DataSource = cl_objeto.ConsultaTipoUsurio();
            comboBox_tipo_usuario.DisplayMember = "tipo";
            comboBox_tipo_usuario.ValueMember = "id_tipo";
            this.comboBox_tipo_usuario.SelectedItem = null;

        }


        private void tbtnregistrar_Click(object sender, EventArgs e)
        {
            CL_Altas cl_objeto = new CL_Altas();
            MySqlDataReader alta;
            cl_objeto.Matricula = txtmatricula.Text;
            cl_objeto.Nombre = txtnombre.Text;
            cl_objeto.App = txtapp.Text;
            cl_objeto.Apm = txtapm.Text;
            cl_objeto.Grupo = txtgrupo.Text;
            cl_objeto.Id_Carrera = comboBox_carrera.SelectedValue.ToString();
            cl_objeto.Id_Tipo = comboBox_tipo_usuario.SelectedValue.ToString();
            alta = cl_objeto.AltasUsuario();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //no aparece la ultima celda del DataGrid
            dataGridView_usuario.AllowUserToAddRows = false;
            CL_Consultas cl_objeto = new CL_Consultas();
            cl_objeto.Numero_Control = txtbuscar.Text;
            dataGridView_usuario.DataSource = cl_objeto.ConsultaUsuario().Tables[0];
        }

        private void dataGridView_usuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_usuario.Rows.Count > 0)
            {
                Actualizar_Usuario actualizar = new Actualizar_Usuario();
                // = dataGridView_usuario.SelectedCells[0].Value.ToString();
                actualizar.txtmatricula.Text= dataGridView_usuario.SelectedRows[0].Cells["matricula"].Value.ToString();
                actualizar.txtnombre.Text = dataGridView_usuario.SelectedRows[0].Cells["nombre"].Value.ToString();
                actualizar.txtapp.Text = dataGridView_usuario.SelectedRows[0].Cells["app"].Value.ToString();
                actualizar.txtapm.Text = dataGridView_usuario.SelectedRows[0].Cells["apm"].Value.ToString();
                actualizar.txtgrupo.Text = dataGridView_usuario.SelectedRows[0].Cells["grupo"].Value.ToString();
                actualizar.comboBox_carrera.Text = dataGridView_usuario.SelectedCells[6].Value.ToString();
                actualizar.comboBox_tipo_usuario.Text = dataGridView_usuario.SelectedCells[7].Value.ToString();
                actualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("seleccione una fila");
            }
        }
    }
}
