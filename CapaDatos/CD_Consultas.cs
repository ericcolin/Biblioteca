using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Consultas
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;

        public MySqlDataReader Consulta_Inicio_Sesion(string usuario, string contraseña)
        {
            string mysql = "select Nombre_usuario, Contraseña from tbadministrador where Nombre_usuario='" + usuario + "' and Contraseña='" + contraseña + "'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public DataTable Consulta_Carrera()
        {
            DataTable leer = new DataTable();
            string mysql = "select * from tbcarrera";
            MySqlCommand comando = new MySqlCommand(mysql, conexion.AbrirConexion());
            MySqlDataAdapter msda = new MySqlDataAdapter(comando);
            msda.Fill(leer);
            return leer;

        }

        public DataTable Consulta_Tipo_Usuario()
        {
            DataTable leer = new DataTable();
            string mysql = "select * from tbtipo_usuario";
            MySqlCommand comando = new MySqlCommand(mysql, conexion.AbrirConexion());
            MySqlDataAdapter msda = new MySqlDataAdapter(comando);
            msda.Fill(leer);
            return leer;
        }

        public DataSet Consulta_Buscar_Usuario(string numero_control)
        {
            //  DataTable leer = new DataTable();
            DataSet leer = new DataSet();
            string mysql = "SELECT id_usuario, nombre, app, apm, nombre_carrera , tipo from tbusuario,tbcarrera,tbtipo_usuario WHERE tbcarrera.id_carrera=tbusuario.id_carrera and tbtipo_usuario.id_tipo_usuario = tbusuario.id_tipo_usuario and tbusuario.id_usuario = '" + numero_control + "'";
            MySqlCommand comando = new MySqlCommand(mysql, conexion.AbrirConexion());
            MySqlDataAdapter msda = new MySqlDataAdapter(comando);
            msda.Fill(leer);
            return leer;
        }

    }
}
