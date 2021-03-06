﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblusuario.Visible = false;
            lblcontraseña.Visible = false;
            lblerror.Visible = false;
        }
        
        private void txtiniciar_sesion_Click(object sender, EventArgs e)
        {

            try
            {
                CL_Consultas cl_objeto = new CL_Consultas();
                MySqlDataReader consulta;
                cl_objeto.Usuario = txtusuario.Text;
                cl_objeto.Contraseña = txtcontraseña.Text;


                // Loguear = ObjAdministrador.iniacirsesion();

                if (txtusuario.Text == "")
                {
                    lblcontraseña.Visible = false;
                    lblerror.Visible = false;
                    lblusuario.Text = "Ingrese nombre de usuario";
                    lblusuario.Visible = true;
                }
                else if (txtcontraseña.Text == "")
                {
                    lblerror.Visible = false;
                    lblusuario.Visible = false;
                    lblcontraseña.Text = "Ingrese contraseña";
                    lblcontraseña.Visible = true;
                }
                else
                {
                    if (cl_objeto.Usuario == txtusuario.Text && cl_objeto.Contraseña == txtcontraseña.Text)
                    {
                        consulta = cl_objeto.ConsultaInicioSesion();

                        if (consulta.Read() == true)
                        {
                            // agrega la hora y fecha a bitacora
                            CL_Altas bitacora = new CL_Altas();
                            MySqlDataReader alta;
                            bitacora.Id_Administrador = consulta["id_administrador"].ToString();
                            bitacora.Fecha_Hora_Entrada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            alta = bitacora.AltasBitacora();
                            Menu menu = new Menu(consulta["id_administrador"].ToString().ToString());
                            this.Hide();
                            menu.Show();
                        }
                        else
                        {
                            lblusuario.Visible = false;
                            lblcontraseña.Visible = false;
                            lblerror.Text = "Usuario o contraseña invalidas, intente de nuevo";
                            txtcontraseña.Text = "";
                            lblerror.Visible = true;
                        }
                    }
                    else
                    {
                        lblusuario.Visible = false;
                        lblcontraseña.Visible = false;
                        lblerror.Text = "Usuario o contraseña invalidas, intente de nuevo";
                        txtcontraseña.Text = "";
                        lblerror.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                txtusuario.Text = "";
                txtcontraseña.Text = "";
                MessageBox.Show("No hay conexión con el servidor, infórmalo con bibliotecario ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
