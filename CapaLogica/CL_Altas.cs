using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
    public class CL_Altas
    {
        //Encapsular variables
        private CD_Altas objetoDato = new CD_Altas();//Instancia a la capa datos de administrador
        //Declarar variables
        private String v_usuario, v_contraseña, v_nombre, v_app, v_apm;
        private String v_grupo,v_id_carrera, v_id_tipo_usuario;
        //Metodos get y set para el manejo de variables
        public String Nombre
        {
            set { v_nombre = value; }
            get { return v_nombre; }
        }
        public String App
        {
            set { v_app = value; }
            get { return v_app; }
        }
        public String Apm
        {
            set { v_apm = value; }
            get { return v_apm; }
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

        public String Grupo
        {
            set { v_grupo = value; }
            get { return v_grupo; }
        }

        public String Id_Carrera
        {
            set { v_id_carrera = value; }
            get { return v_id_carrera; }
        }

        public String Id_Tipo_Usuario
        {
            set { v_id_tipo_usuario = value; }
            get { return v_id_tipo_usuario; }
        }


        //Constructor
        public CL_Altas() { }
        //Funciones o metodos
        public MySqlDataReader AltasAdministrador()
        {
            MySqlDataReader alta;
            alta = objetoDato.Altas_Administrador(Nombre, App, Apm, Usuario, Contraseña);
            return alta;
        }
        public MySqlDataReader AltasCarrera()
        {
            MySqlDataReader alta;
            alta = objetoDato.Altas_Carrera(Nombre);
            return alta;
        }

        public MySqlDataReader AltasUsuario()
        {
            MySqlDataReader alta;
            alta = objetoDato.Altas_Usuario(Id_Carrera, Id_Tipo_Usuario,Nombre, App, Apm, Grupo);
            return alta;
        }
    }
}
