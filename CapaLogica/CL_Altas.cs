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
        private String v_grupo, v_id_carrera, v_id_tipo, v_matricula;
        private String v_id_administrador, v_fecha_hora_entrada, v_fecha_hora_salida;
        private String v_id_usuario, v_id_ejemplar, v_fecha_prestamo, v_fecha_entrega, v_fecha_devolucion, v_estado;
        //Metodos get y set para el manejo de variables
        //Alta Prestamos

        public String Id_Usuario
        {
            set { v_id_usuario = value; }
            get { return v_id_usuario; }
        }

        public String Id_Ejemplar
        {
            set { v_id_ejemplar = value; }
            get { return v_id_ejemplar; }
        }

        public String Fecha_Prestamo
        {
            set { v_fecha_prestamo = value; }
            get { return v_fecha_prestamo; }
        }

        public String Fecha_Entrega
        {
            set { v_fecha_entrega = value; }
            get { return v_fecha_entrega; }
        }

        public String Fecha_Devolucion
        {
            set { v_fecha_devolucion = value; }
            get { return v_fecha_devolucion; }
        }

        public String Estado
        {
            set { v_estado = value; }
            get { return v_estado; }
        }

        public MySqlDataReader AltasPrestamo()
        {
            MySqlDataReader alta;
            alta = objetoDato.Altas_Prestamo(Id_Administrador, Id_Usuario, Id_Ejemplar, Fecha_Prestamo, Fecha_Entrega, Fecha_Devolucion, Estado);
            return alta;
        }
        ///////////////////////
        public String Id_Administrador
        {
            set { v_id_administrador = value; }
            get { return v_id_administrador; }
        }

        public String Fecha_Hora_Entrada
        {
            set { v_fecha_hora_entrada = value; }
            get { return v_fecha_hora_entrada; }
        }

        public String Fecha_Hora_Salida
        {
            set { v_fecha_hora_salida = value; }
            get { return v_fecha_hora_salida; }
        }

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

        public String Id_Tipo
        {
            set { v_id_tipo = value; }
            get { return v_id_tipo; }
        }


        //Constructor
        public CL_Altas() { }
        //Funciones o metodos
        public MySqlDataReader AltasBitacora()
        {
            MySqlDataReader alta;
            alta = objetoDato.Altas_Bitacora(Id_Administrador, Fecha_Hora_Entrada, Fecha_Hora_Salida);
            return alta;
        }

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
            alta = objetoDato.Altas_Usuario(Matricula, Nombre, App, Apm, Grupo, Id_Carrera, Id_Tipo);
            return alta;
        }
    }
}
