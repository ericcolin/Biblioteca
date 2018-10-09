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
       
        public Menu(string id_administrador)
        {
            InitializeComponent();
            this.id_administrador = id_administrador;
        }
        string id_administrador;
        //private void AbrirFormPrincipal(Object FormPrincipal)
        //{
        //    //se verifica si existe un control en el panel
        //    if (this.panel_general.Controls.Count > 0)
        //        this.panel_general.Controls.RemoveAt(0);
        //    //creacion de un formulario con un nombre
        //    Form formulario_secundario = FormPrincipal as Form;
        //    formulario_secundario.TopLevel = false;
        //    //se acopla a todo el panel general 
        //    formulario_secundario.Dock = DockStyle.Fill;
        //    //se agrega al panel
        //    this.panel_general.Controls.Add(formulario_secundario);
        //    //se establese instancia como contenedor de datos del panel
        //    this.panel_general.Tag = formulario_secundario;
        //    //mostrar
        //    formulario_secundario.Show();
        //}

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        private void btnnuevo_administrador_Click(object sender, EventArgs e)
        {
            Nuevo_Administrador administrador = new Nuevo_Administrador();
            administrador.MdiParent = this;
            administrador.Show();
            //AbrirFormPrincipal(new Nuevo_Administrador());
        }

        private void btnnuevo_usuario_Click(object sender, EventArgs e)
        {
            Menu_Usuario usuario = new Menu_Usuario();
            usuario.MdiParent = this;
            usuario.Show();
          //  AbrirFormPrincipal(new Menu_Usuario());
        }

        private void btnnueva_carrera_Click(object sender, EventArgs e)
        {
            Nueva_Carrera carrera = new Nueva_Carrera();
            carrera.MdiParent = this;
            carrera.Show();
           // AbrirFormPrincipal(new Nueva_Carrera());
        }

        private void btnactualizar_usuario_Click(object sender, EventArgs e)
        {
            Actualizar_Usuario actualizar = new Actualizar_Usuario();
            actualizar.MdiParent = this;
            actualizar.Show();
           // AbrirFormPrincipal(new Actualizar_Usuario());
        }

        private void btnprestamo_Click(object sender, EventArgs e)
        {
            Prestamos prestamos = new Prestamos(id_administrador);
            prestamos.MdiParent = this;
            prestamos.Show();
           // AbrirFormPrincipal(new Prestamos(id_administrador));
        }
    }
}
