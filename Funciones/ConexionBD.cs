using MySqlConnector;
using System.Data;
namespace Missushi.Funciones{
    static internal class ConexionBD{
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        static public MySqlConnection connection;
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        static public void conectarBD(){
            try{
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Database = "missushi";
                builder.Password = "";
                builder.ApplicationName = "";
                //builder.ApplicationName = "app";
                //builder.Port = 3306;
                connection = new MySqlConnection(builder.ToString());
            }catch (Exception e) {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public bool insertarUsuario(string nombres, string apellidos, string contraseña, string correo, char tipo){
            ConexionBD.connection.Open();
            string sql = "INSERT INTO usuario(nombres, apellidos, contrasenia, correo, tipo) VALUES(@0,@1,@2, @3, @4)";
            MySqlCommand cmd = new MySqlCommand(sql, ConexionBD.connection);
            cmd.Parameters.Add("@0", MySqlDbType.VarChar, 80).Value = nombres;
            cmd.Parameters.Add("@1", MySqlDbType.VarChar, 80).Value = apellidos;
            cmd.Parameters.Add("@2", MySqlDbType.VarChar, 50).Value = contraseña;
            cmd.Parameters.Add("@3", MySqlDbType.VarChar, 50).Value = correo;
            cmd.Parameters.Add("@4", MySqlDbType.VarChar, 1).Value = tipo;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ConexionBD.connection.Close();
            MessageBox.Show("Registrado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }  
}
