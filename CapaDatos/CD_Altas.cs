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
            string mysql = "INSERT INTO tbadministrador(id_administrador, nombre, app, apm, nombre_usuario, contraseña) VALUES ('', '" + nombre + "', '" + app + "', '" + apm + "', '" + nombre_usuario + "', '" + contraseña + "')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Altas_Carrera(string carrera)
        {
            string mysql = "INSERT INTO tbcarreras(id_carrera, nombre_carrera) VALUES ('', '" + carrera + "')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }
        public MySqlDataReader Altas_Usuario(string matricula, string nombre, string app, string apm, string grupo, string id_carrera, string id_tipo)
        {
            string mysql = "INSERT INTO tbusuarios(id_usuario, matricula, nombre, app, apm, grupo, id_carrera, id_tipo) VALUES ('', '"+matricula+"', '"+nombre+"', '"+app+"', '"+apm+"', '"+grupo+ "', '" + id_carrera + "', '" + id_tipo + "')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
