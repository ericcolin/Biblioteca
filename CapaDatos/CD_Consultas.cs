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
            string mysql = "select nombre_usuario, contraseña,id_administrador from tbadministrador where nombre_usuario='" + usuario + "' and contraseña='" + contraseña + "'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Consulta_NomUsuario_Administrador(string usuario)
        {
            string mysql = "select nombre_usuario from tbadministrador where nombre_usuario='" + usuario + "'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Consulta_Buscar_Id_Usuario(string matricula)
        {
            string mysql = "select id_usuario from tbusuarios WHERE matricula = '"+matricula+"'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Consulta_Buscar_Id_Ejemplar(string id_actual)
        {
            string mysql = "select id_ejemplar from tbejemplar where id_actual= '" + id_actual + "'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Consulta_Contar_Libros(string id_ejemplar)
        {
            string mysql = "SELECT tblibros.cantidad,tblibros.id_libro from tbejemplar,tblibros WHERE  tbejemplar.Id_ejemplar= '"+id_ejemplar+"'  and tblibros.id_libro = tbejemplar.id_libro and tblibros.cantidad > '1'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public MySqlDataReader Consulta_Estado_Prestamo(string id_usuario, string estado)
        {
            string mysql = "select * from tbprestamo WHERE id_usuario='"+id_usuario+"' and estado = '"+estado+"';";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = mysql;
            leer = comando.ExecuteReader();
            return leer;
        }

        public DataTable Consulta_Carrera()
        {
            DataTable leer = new DataTable();
            string mysql = "select * from tbcarreras";
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
            string mysql = "SELECT id_usuario, matricula, nombre, app, apm, grupo, nombre_carrera , tipo from tbusuarios, tbcarreras, tbtipo_usuario WHERE tbcarreras.id_carrera = tbusuarios.id_carrera and tbtipo_usuario.id_tipo = tbusuarios.id_tipo and tbusuarios.matricula = '" + numero_control + "'";
            MySqlCommand comando = new MySqlCommand(mysql, conexion.AbrirConexion());
            MySqlDataAdapter msda = new MySqlDataAdapter(comando);
            msda.Fill(leer);
            return leer;
        }

    }
}
