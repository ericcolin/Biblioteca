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
        private String v_usuario, v_contraseña, v_numero_control, v_id_administrador;
        private String v_id_usuario, v_estado;
        private String v_id_actual, v_id_ejemplar;
        //Metodos get y set para el manejo de variables

        public String Id_Actual
        {
            set { v_id_actual = value; }
            get { return v_id_actual; }
        }

        public String Id_Ejemplar
        {
            set { v_id_ejemplar = value; }
            get { return v_id_ejemplar; }
        }

        public String Id_Usuario
        {
            set { v_id_usuario = value; }
            get { return v_id_usuario; }
        }

        public String Estado
        {
            set { v_estado = value; }
            get { return v_estado; }
        }

        public String Id_Administrador
        {
            set { v_id_administrador = value; }
            get { return v_id_administrador; }
        }

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
        public MySqlDataReader ConsultaContarLibros()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_Contar_Libros(Id_Ejemplar);
            return consulta;
        }

        public MySqlDataReader ConsultaInicioSesion()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_Inicio_Sesion(Usuario, Contraseña);
            return consulta;
        }

        public MySqlDataReader ConsultaNomUsuarioAdministrador()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_NomUsuario_Administrador(Usuario);
            return consulta;
        }

        public MySqlDataReader ConsultaBuscarIdUsuario()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_Buscar_Id_Usuario(Numero_Control);
            return consulta;
        }

        public MySqlDataReader ConsultaBuscarIdEjemplar()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_Buscar_Id_Ejemplar(Id_Actual);
            return consulta;
        }

        public MySqlDataReader ConsultaEstadoPrestamo()
        {
            MySqlDataReader consulta;
            consulta = objetoDato.Consulta_Estado_Prestamo(Id_Usuario,Estado);
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
