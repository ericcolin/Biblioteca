using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CapaDatos
{
    public class CD_Actualizaciones
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;

        public MySqlDataReader Actualizar_Usuario(string matricula, string nombre, string app, string apm, string grupo, string id_carrera, string id_tipo, string id_usuario)
        {
            string mysql = "UPDATE tbusuarios SET matricula = '"+matricula+"', nombre = '"+nombre+"', app = '"+app+"', apm = '"+apm+"', grupo = '"+grupo+"', id_carrera = '"+id_carrera+"', id_tipo = '"+id_tipo+"' WHERE id_usuario = '"+id_usuario+"'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
