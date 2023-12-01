using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TiendaComputadoras.Clases
{
    public class Conexion
    {
        string db;
        string servidor;
        string usuario;
        string contraseña;
        string ssl;
    
        public Conexion()
        {
            this.db = "tiendacomputadoras";
            this.servidor = "localhost";
            this.usuario = "root";
            this.contraseña = "";
            this.ssl = "None";
        }
        
        public MySqlConnection ObtenerConexion()
        { 
            MySqlConnection cadena = new MySqlConnection();
        
            try
            {
                cadena.ConnectionString = "Database=" + db +
                    "; Data Source=" + servidor +
                    "; User Id=" + usuario +
                    "; Password=" + contraseña +
                    "; SSL Mode=" + ssl + ";";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }
    }   
}
