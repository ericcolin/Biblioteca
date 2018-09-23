using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Altas
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;

        public MySqlDataReader Altas_Administrador(string nombre, string app, string apm, string nombre_usuario, string contraseña)
        {
            string mysql = "INSERT INTO tbadministrador(id_administrador, Nombre, App, Apm, Nombre_usuario, Contraseña) VALUES ('', '" + nombre + "', '" + app + "', '" + apm + "', '" + nombre_usuario + "', '" + contraseña + "')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Altas_Carrera(string carrera)
        {
            string mysql = "INSERT INTO tbcarrera(id_carrera, nombre_carrera) VALUES ('', '" + carrera + "')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }
        public MySqlDataReader Altas_Usuario(string id_carrera, string id_tipo_usuario, string nombre, string app, string apm, string grupo)
        {
            string mysql = "INSERT INTO tbusuario(id_usuario, id_carrera, id_tipo_usuario, nombre, app, apm, grupo) VALUES ('', '" + id_carrera + "', '"+id_tipo_usuario+"', '"+nombre+"', '"+app+"', '"+apm+"', '"+grupo+"')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
