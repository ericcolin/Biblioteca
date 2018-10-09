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

        public MySqlDataReader Altas_Bitacora(string id_administrador, string fecha_hora_entrada, string fecha_hora_salida)
        {
            string mysql = "INSERT INTO tbbitacora(id_bitacora, id_administrador, fecha_hora_entrada, fecha_hora_salida) VALUES ('', '"+id_administrador+"','" + fecha_hora_entrada + "', '" + fecha_hora_salida + "')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

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

        public MySqlDataReader Altas_Prestamo(string id_administrador, string id_usuario, string id_ejemplar, string fecha_prestamo, string fecha_entrega, string fecha_devolucion, string estado)
        {
            string mysql = "INSERT INTO tbprestamo(id_prestamo, id_administrador, id_usuario, id_ejemplar, fecha_prestamo, fecha_entrega, fecha_devolucion, estado) VALUES ('', '" + id_administrador + "', '" + id_usuario + "', '" + id_ejemplar + "', '" + fecha_prestamo + "', '" + fecha_entrega + "', '" + fecha_devolucion + "', '"+estado+"')";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
