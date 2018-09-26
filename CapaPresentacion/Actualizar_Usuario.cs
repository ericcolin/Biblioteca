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
            cl_objeto.Numero_Control = txtmatricula.Text;
            dataGridView_usuario.DataSource = cl_objeto.ConsultaUsuario().Tables[0];
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView_usuario.SelectedRows.Count > 0)
            {
                txtnombre.Text = dataGridView_usuario.CurrentRow.Cells["nombre"].Value.ToString();
                txtapp.Text = dataGridView_usuario.CurrentRow.Cells["app"].Value.ToString();
                txtapm.Text = dataGridView_usuario.CurrentRow.Cells["apm"].Value.ToString();
                txtgrupo.Text = dataGridView_usuario.CurrentRow.Cells["grupo"].Value.ToString();

                CL_Consultas cl_objeto = new CL_Consultas();
                comboBox_carrera.DataSource = cl_objeto.ConsultaCarrera();
                comboBox_carrera.ValueMember = "id_carrera";
                comboBox_carrera.DisplayMember = "nombre_carrera";
                comboBox_carrera.Text = dataGridView_usuario.SelectedCells[6].Value.ToString();

                comboBox_tipo_usuario.DataSource = cl_objeto.ConsultaTipoUsurio();
                comboBox_tipo_usuario.ValueMember = "id_tipo";
                comboBox_tipo_usuario.DisplayMember = "tipo";
                comboBox_tipo_usuario.Text = dataGridView_usuario.SelectedCells[7].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void dataGridView_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > 0 )
            //{
            //    DataGridViewRow row = this.dataGridView_usuario.Rows[e.RowIndex];
            //    txtnombre.Text= row.Cells["nombre"].Value.ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CL_Actualizaciones cl_objeto = new CL_Actualizaciones();
            MySqlDataReader alta;
            cl_objeto.Matricula = txtmatricula.Text;
            cl_objeto.Nombre = txtnombre.Text;
            cl_objeto.App = txtapp.Text;
            cl_objeto.Apm = txtapm.Text;
            cl_objeto.Grupo = txtgrupo.Text;
            cl_objeto.Id_Carrera = comboBox_carrera.SelectedValue.ToString();
            cl_objeto.Id_Tipo_Usuario = comboBox_tipo_usuario.SelectedValue.ToString();
            cl_objeto.Id_Usuario = dataGridView_usuario.SelectedCells[0].Value.ToString();
            alta = cl_objeto.ActualizarUsuario();
        }
    }
}
