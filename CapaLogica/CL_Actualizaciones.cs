using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CapaLogica
{
    public class CL_Actualizaciones
    {
        //Encapsular variables
        private CD_Actualizaciones objetoDato = new CD_Actualizaciones();//Instancia a la capa datos de administrador
        //Declarar variables
        private String v_matricula, v_nombre, v_app, v_apm, v_grupo, v_id_carrera, v_id_tipo_usuario, v_id_usuario;

        //Metodos get y set para el manejo de variables

        public String Matricula
        {
            set { v_matricula = value; }
            get { return v_matricula; }
        }

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

            set { v_id_tipo_usuario= value; }
            get { return v_id_tipo_usuario; }
        }
        public String Id_Usuario
        {
            set { v_id_usuario = value; }
            get { return v_id_usuario; }
        }

        //Funciones o metodos
        public MySqlDataReader ActualizarUsuario()
        {
            MySqlDataReader alta;
            alta = objetoDato.Actualizar_Usuario(Matricula, Nombre, App, Apm, Grupo, Id_Carrera, Id_Tipo_Usuario, Id_Usuario);
            return alta;
        }
    }
}
