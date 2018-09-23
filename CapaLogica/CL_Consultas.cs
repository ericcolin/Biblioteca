using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaLogica
{
    public class CL_Consultas
    {
        //Encapsular variables
        private CD_Consultas objetoDato = new CD_Consultas();//Instancia a la capa datos de administrador
        //Declarar variables
        private String v_usuario, v_contraseña, v_numero_control;
        //Metodos get y set para el manejo de variables
        public String Numero_Control
        {
            set { v_numero_control = value; }
            get { return v_numero_control; }
        }

        public String Usuario
        {
            set { v_usuario = value; }
            get { return v_usuario; }
        }
        public String Contraseña
        {
            set { v_contraseña = value; }
            get { return v_contraseña; }
        }
        //Constructor
        public CL_Consultas() { }
        //Funciones o metodos
        public MySqlDataReader ConsultaInicioSesion()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_Inicio_Sesion(Usuario, Contraseña);
            return consulta;
        }

        public DataTable ConsultaCarrera()
        {
            DataTable consulta;
            consulta = objetoDato.Consulta_Carrera();
            return consulta;
        }

        public DataTable ConsultaTipoUsurio()
        {
            DataTable consulta;
            consulta = objetoDato.Consulta_Tipo_Usuario();
            return consulta;
        }

        public DataSet ConsultaUsuario()
        {
            DataSet consulta;
            consulta = objetoDato.Consulta_Buscar_Usuario(Numero_Control);
            return consulta;
        }
    }
}
