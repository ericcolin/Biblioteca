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

            lblnombre.Hide();
            lblapp.Hide();
            lblapm.Hide();
            lblusuario.Hide();
            lblcontraseña.Hide();
            lblcontraseña2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblnombre.Hide();
            lblapp.Hide();
            lblapm.Hide();
            lblusuario.Hide();
            lblcontraseña.Hide();
            lblcontraseña2.Hide();
            try
            {
                if (txtnombre.Text == "")
                {
                    lblnombre.Text = "Ingrese su nombre(s)";
                    lblnombre.Show();
                }
                else if (txtapp.Text == "")
                {
                    lblapp.Text = "Ingrese su apellido paterno";
                    lblapp.Show();
                }
                else if (txtapm.Text == "")
                {
                    lblapm.Text = "Ingrese su apellido materno";
                    lblapm.Show();
                }
                else if (txtnombre_usuario.Text == "")
                {
                    lblusuario.Text = "Ingrese un nombre de usuario";
                    lblusuario.Show();
                }
                else if (txtcontraseña.Text == "")
                {
                    lblcontraseña.Text = "Ingrese una contraseña";
                    lblcontraseña.Show();
                }
                else if (txtconfimar_contraseña.Text == "")
                {
                    lblcontraseña2.Text = "Confirme su contraseña";
                    lblcontraseña2.Show();
                }
                else
                {
                    CL_Consultas cl_objeto = new CL_Consultas();
                    MySqlDataReader consulta;
                    cl_objeto.Usuario = txtnombre_usuario.Text;

                    consulta = cl_objeto.ConsultaNomUsuarioAdministrador();

                    if (consulta.Read() == true)
                    {
                        lblusuario.Text = "El nombre de usuario ya existe";
                        lblusuario.Show();
                    }
                    else
                    {
                        if (txtcontraseña.Text == txtconfimar_contraseña.Text)
                        {
                            CL_Altas obj_alta_administrador = new CL_Altas();
                            MySqlDataReader alta;
                            obj_alta_administrador.Nombre = txtnombre.Text;
                            obj_alta_administrador.App = txtapp.Text;
                            obj_alta_administrador.Apm = txtapm.Text;
                            obj_alta_administrador.Usuario = txtnombre_usuario.Text;
                            obj_alta_administrador.Contraseña = txtcontraseña.Text;
                            alta = obj_alta_administrador.AltasAdministrador();


                            if (MessageBox.Show("Registrar otro administrador", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                this.Hide();
                            }
                            else
                            {
                                txtnombre.Text = "";
                                txtapp.Text = "";
                                txtapm.Text = "";
                                txtnombre_usuario.Text = "";
                                txtcontraseña.Text = "";
                                txtconfimar_contraseña.Text = "";

                            }
                        }
                        else
                        {
                            lblcontraseña2.Text = "Contraseñas no coincide";
                            lblcontraseña2.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el servidor");
            }

        }
    }
}
