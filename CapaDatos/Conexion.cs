using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    class Conexion
    {
       
    private MySqlConnection conexion = new MySqlConnection("server = localhost; database = biblioteca; User = root; Password = niutu1996;");

        public MySqlConnection AbrirConexion()
        {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
                return conexion;
        }
        public MySqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    
    

    }
}
