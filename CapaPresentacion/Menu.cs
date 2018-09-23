using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormPrincipal(Object FormPrincipal)
        {
            //se verifica si existe un control en el panel
            if (this.panel_general.Controls.Count > 0)
                this.panel_general.Controls.RemoveAt(0);
            //creacion de un formulario con un nombre
            Form formulario_secundario = FormPrincipal as Form;
            formulario_secundario.TopLevel = false;
            //se acopla a todo el panel general 
            formulario_secundario.Dock = DockStyle.Fill;
            //se agrega al panel
            this.panel_general.Controls.Add(formulario_secundario);
            //se establese instancia como contenedor de datos del panel
            this.panel_general.Tag = formulario_secundario;
            //mostrar
            formulario_secundario.Show();
        }

        private void btnnuevo_administrador_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Nuevo_Administrador());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnnuevo_usuario_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Nuevo_Usuario());
        }

        private void btnnueva_carrera_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Nueva_Carrera());
        }

        private void btnactualizar_usuario_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Actualizar_Usuario());
        }
    }
}
