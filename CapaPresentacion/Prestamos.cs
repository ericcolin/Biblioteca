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
    public partial class Prestamos : Form
    {
        public Prestamos(string id_administrador)
        {
            InitializeComponent();
            calendario.MinDate = DateTime.Now.Date;
            calendario.MaxDate = DateTime.Now.AddDays(1).Date;
            this.id_administrador = id_administrador;
        }
        string id_administrador;
        private void tbtnregistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id_administrador);
            string id_usuario = "", id_ejemplar = "";
            int cantidad = 0, total = 0;

            CL_Consultas cl_objeto = new CL_Consultas();
            MySqlDataReader consulta;
            cl_objeto.Numero_Control = txtmatricula.Text;
            consulta = cl_objeto.ConsultaBuscarIdUsuario();

            if (consulta.Read() == true)
            {
                id_usuario = consulta["id_usuario"].ToString();

                CL_Consultas cl_estado = new CL_Consultas();
                MySqlDataReader consulta_estado;
                cl_estado.Id_Usuario = id_usuario;
                cl_estado.Estado = "Prestamo";
                consulta_estado = cl_estado.ConsultaEstadoPrestamo();

                if (consulta_estado.Read() == true)
                {
                    MessageBox.Show("Tienes prestamos pendientes por entregar no se le permite el prestamo de ejemplares");
                }
                else
                {
                    MessageBox.Show("no tienes prestamos pendientes");
                    CL_Consultas buscar_ejemplar = new CL_Consultas();
                    MySqlDataReader consulta_ejemplar;
                    buscar_ejemplar.Id_Actual = txtlibro.Text;
                    consulta_ejemplar = buscar_ejemplar.ConsultaBuscarIdEjemplar();

                    if (consulta_ejemplar.Read() == true)
                    {
                        id_ejemplar = consulta_ejemplar["id_ejemplar"].ToString();

                        CL_Consultas consulta_contar_libros = new CL_Consultas();
                        MySqlDataReader consulta_contar;
                        consulta_contar_libros.Id_Ejemplar = id_ejemplar;
                        consulta_contar = consulta_contar_libros.ConsultaContarLibros();

                        if (consulta_contar.Read() == true)
                        {
                            // agrega la hora y fecha a bitacora
                            CL_Altas prestamo = new CL_Altas();
                            MySqlDataReader alta;
                           // prestamo.Id_Administrador = id_administrador;
                            prestamo.Id_Usuario = id_usuario;
                            prestamo.Id_Ejemplar = id_ejemplar;
                            prestamo.Fecha_Prestamo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            MessageBox.Show(calendario.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                            prestamo.Fecha_Entrega = calendario.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            prestamo.Fecha_Devolucion = "";
                            prestamo.Estado = "Prestamo";
                            alta = prestamo.AltasPrestamo();
                            if (alta.Read() == true)
                            {
                                cantidad = Convert.ToInt32(consulta_contar["cantidad"].ToString());
                                total = cantidad - 1;
                                MessageBox.Show("Total de libros disponibles: " + total);
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("solo hay un ejemplar no se puede rellizar prestamos fuera de la biblioteca");
                        }
                        }
                    else
                    {
                        MessageBox.Show("Número de ejemplar incorrecto");
                    }
                    }
            }
            else
            {
                MessageBox.Show("Numero de matricula no existe ");
            }
            }
    }
}
