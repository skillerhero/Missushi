using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missushi.Funciones
{
    internal class ConexionBD{
        public static MySqlConnection connection;
        public ConexionBD(){
            conectarBD();
        }
        private void conectarBD(){
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "missushi";
            builder.Password = "";
            builder.ApplicationName = "";
            //builder.ApplicationName = "app";
            //builder.Port = 3306;
            connection = new MySqlConnection(builder.ToString());
        }
    }  
}
