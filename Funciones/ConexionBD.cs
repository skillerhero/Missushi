using Missushi.Clases;
using MySqlConnector;
using System.Data;

namespace Missushi.Funciones{
    static internal class ConexionBD{
        static public string ipServidor = "13.59.196.2";
        static public MySqlConnection? connection;
        static public void conectarBD(){
            try{
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = ipServidor;
                builder.UserID = "rafael";
                builder.Database = "missushi";
                builder.Password = "Rafael1234.";
                builder.ApplicationName = "";
                //builder.ApplicationName = "app";
                builder.Port = 3306;
                connection = new MySqlConnection(builder.ToString());
            }catch (Exception e) {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*----------------------------------------General----------------------------------------*/
        static public MySqlDataAdapter consultarTablaAdapter(string? tabla) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "SELECT * FROM " + tabla;
            if (connection != null) {
                connection.Open();
                adapter = new MySqlDataAdapter(query, connection);
                connection.Close();
            }
            return adapter;
        }
        static public bool login(string correo, string contraseña) {
            bool exito = false;
            string sql = "SELECT idUsuario, contrasenia, tipo FROM usuario WHERE correo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", correo);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    if (reader.GetString(1) == contraseña) {
                        exito = true;
                        Usuario.id = reader.GetInt32(0);
                        Usuario.type = reader.GetChar(2);
                    }
                }
                connection.Close();
            }
            return exito;
        }
        static public bool existeCorreo(string correo) {
            bool existe = false;
            string sql = "SELECT * FROM usuario WHERE correo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", correo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    existe = true;
                }
                connection.Close();
            }
            return existe;
        }

        static public bool consultarPrimerUsuario(char tipo) {
            bool existe = false;
            string query = "SELECT * FROM usuario where tipo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@0", tipo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    existe = true;
                    Usuario.id = reader.GetInt32(0);
                    Usuario.type = reader.GetChar(2);
                }
                connection.Close();
            }
            return existe;
        }


        /*----------------------------------------Usuario----------------------------------------*/
        static public List<Usuario> consultarUsuarios() {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT * FROM usuario;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    usuarios.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5)));
                }
                connection.Close();
            }
            return usuarios;
        }
        static public Usuario consultarUsuario(int id) {
            Usuario usuario = new Usuario();
            string query = "SELECT * FROM usuario where idUsuario = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@0", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    usuario = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5));
                }
                connection.Close();
            }
            return usuario;
        }
        static public MySqlDataAdapter consultarUsuariosAdapter() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "SELECT * FROM usuario;";
            if (connection != null) {
                connection.Open();
                adapter = new MySqlDataAdapter(query, connection);
                connection.Close();
            }
            return adapter;
        }
        static public bool insertarUsuario(string nombres, string apellidos, string contraseña, string correo, char tipo) {
            string sql = "INSERT INTO usuario(nombres, apellidos, contrasenia, correo, tipo) VALUES(@0,@1,@2, @3, @4);";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 80).Value = nombres;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 80).Value = apellidos;
                cmd.Parameters.Add("@2", MySqlDbType.VarChar, 50).Value = contraseña;
                cmd.Parameters.Add("@3", MySqlDbType.VarChar, 50).Value = correo;
                cmd.Parameters.Add("@4", MySqlDbType.VarChar, 1).Value = tipo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
        /*----------------------------------------Gerente----------------------------------------*/
        static public bool existeGerente() {
            bool existe = false;
            string sql = "SELECT * FROM usuario WHERE tipo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", "G");
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    existe = true;
                }
                connection.Close();
            }
            return existe;
        }
        static public Usuario consultarGerente() {
            Usuario gerente = new Usuario();
            string query = "SELECT * FROM usuario WHERE tipo = 'G';";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    gerente = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5));
                }
                connection.Close();
            }
            return gerente;
        }
        /*-------------------------------------Administrador-------------------------------------*/


        /*--------------------------------------Restaurante--------------------------------------*/
        static public bool existeInfoRestaurante() {
            bool existe = false;
            string sql = "SELECT * FROM restaurante;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    existe = true;
                }
                connection.Close();
            }
            return existe;
        }
        static public bool modificarRestaurante(string nombre, string descripcion, string latitud, string longitud, string fotoPrincipal, int idGerente) {
            string sql = "UPDATE restaurante SET nombre=@0, descripcion=@1, latitud=@2, longitud=@3, fotoPrincipal=@4, idGerente=@5;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 500).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.VarChar, 100).Value = latitud;
                cmd.Parameters.Add("@3", MySqlDbType.VarChar, 100).Value = longitud;
                cmd.Parameters.Add("@4", MySqlDbType.String).Value = fotoPrincipal;
                cmd.Parameters.Add("@5", MySqlDbType.Int32).Value = idGerente;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        static public bool insertarRestaurante(string nombre, string descripcion, string latitud, string longitud, string fotoPrincipal, int idGerente) {
            string sql = "INSERT INTO restaurante(nombre, descripcion, latitud, longitud, fotoPrincipal, idGerente) VALUES(@0, @1, @2, @3, @4, (SELECT idUsuario FROM usuario WHERE tipo = 'G'));";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 500).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.VarChar, 100).Value = latitud;
                cmd.Parameters.Add("@3", MySqlDbType.VarChar, 100).Value = longitud;
                cmd.Parameters.Add("@4", MySqlDbType.String).Value = fotoPrincipal;
                cmd.Parameters.Add("@5", MySqlDbType.Int32).Value = idGerente;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
        static public Restaurante consultarRestaurante() {
            Restaurante restaurante = new Restaurante();
            string sql = "SELECT * FROM restaurante;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    restaurante.setNombre(reader.GetString(0));
                    restaurante.setDescripcion(reader.GetString(1));
                    restaurante.setLatitud(reader.GetString(2));
                    restaurante.setLongitud(reader.GetString(3));
                    restaurante.setFotoPrincipal(reader.GetString(4));
                    restaurante.setGerente(reader.GetInt32(5));
                }
                connection.Close();
            }
            return restaurante;
        }
        /*-----------------------------------------Zona-----------------------------------------*/
        static public bool agregarZona(int cupo, string foto) {
            string sql = "INSERT INTO zona(cupo, foto) VALUES(@0, @1);";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.Int64).Value = cupo;
                cmd.Parameters.Add("@1", MySqlDbType.String).Value = foto;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        static public List<Zona> consultarZonas() {
            List<Zona> zonas = new List<Zona>();
            string query = "SELECT * FROM zona;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    zonas.Add(new Zona(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2)));
                }
                connection.Close();
            }
            return zonas;
        }

        static public int consultarCupoZona(int idZona) {
            int cupo = 0;
            string sql = "SELECT cupo FROM zona WHERE idZona = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", idZona);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    cupo = reader.GetInt32(0);
                }
                connection.Close();
            }
            return cupo;
        }

        static public int consultarCupoZona(int idZona, DateTime fechaInicio) {
            int cupo = 0;
            string sql = "SELECT cupo FROM zona WHERE idZona = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", idZona);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    cupo = reader.GetInt32(0);
                }
                connection.Close();
                connection.Open();
                sql = "SELECT COALESCE(SUM(cantidadPersonas),0) as ocupado from reservacion where idZona = @0 and fechaHoraInicio = @1;";
                cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", idZona);
                cmd.Parameters.AddWithValue("@1", fechaInicio);
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    cupo -= reader.GetInt32(0);
                }
                connection.Close();
            }
            return cupo;
        }

        static public bool modificarZona(int idZona, int cupo, string foto){
            bool exito = false;
            string sql = "UPDATE zona SET cupo = @0, foto = @1 WHERE idZona = @2;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.Int32).Value = cupo;
                cmd.Parameters.Add("@1", MySqlDbType.Text).Value = foto;
                cmd.Parameters.Add("@2", MySqlDbType.Int32).Value = idZona;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return exito;
        }


        /*--------------------------------------Reservacion--------------------------------------*/
        static public bool agregarReservacion(DateTime fechaHoraInicio, DateTime fechaHoraFin, int cantidadPersonas, int idUsuario, int idZona, string estado) {
            string sql = "INSERT INTO reservacion(fechaHoraInicio, fechaHoraFin, cantidadPersonas, idUsuario, idZona, estado) VALUES(@0, @1, @2, @3, @4, @5);";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.DateTime).Value = fechaHoraInicio;
                cmd.Parameters.Add("@1", MySqlDbType.DateTime).Value = fechaHoraFin;
                cmd.Parameters.Add("@2", MySqlDbType.Int32).Value = cantidadPersonas;
                cmd.Parameters.Add("@3", MySqlDbType.Int32).Value = idUsuario;
                cmd.Parameters.Add("@4", MySqlDbType.Int32).Value = idZona;
                cmd.Parameters.Add("@5", MySqlDbType.VarChar, 10).Value = estado;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        static public bool usuarioTieneReservacionesEnEspera(int idUsuario) {
            int reservaciones = 0;
            bool tieneReservacion = false;
            string sql = "SELECT COUNT(*) AS cantidadReservaciones FROM reservacion WHERE idUsuario = @0 and estado = 'En espera';";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", idUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    reservaciones = reader.GetInt32(0);
                }
                connection.Close();
                if (reservaciones > 0) {
                    tieneReservacion = true;
                }
            }
            return tieneReservacion;
        }

        static public List<Reservacion> consultarReservaciones() {
            List<Reservacion> reservaciones = new List<Reservacion>();
            string query = "SELECT * FROM reservacion;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    reservaciones.Add(new Reservacion(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.GetInt32(3), reader.GetInt32(4),reader.GetInt32(5), reader.GetString(6)));
                }
                connection.Close();
            }
            return reservaciones;
        }

        static public bool cancelarReservacion(int idReservacion) {
            string sql = "UPDATE reservacion SET estado = 'Cancelada' where idReservacion = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.Int32).Value = idReservacion;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }else 
                return false;
        }


        /*--------------------------------------Menu--------------------------------------*/

        static public List<Menu> consultarMenu() {
            List<Menu> menu = new List<Menu>();
            string query = "SELECT * FROM menu;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    menu.Add(new Menu(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetString(4), reader.GetString(5)));
                }
                connection.Close();
            }
            return menu;
        }


        static public bool agregarPlatillo(string nombre, string descripcion, float precio, string foto, string tipo) {
            string sql = "INSERT INTO menu(nombre, descripcion, precio, foto, tipo) VALUES(@0, @1, @2, @3, @4);";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 20).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.Float).Value = precio;
                cmd.Parameters.Add("@3", MySqlDbType.String).Value = foto;
                cmd.Parameters.Add("@4", MySqlDbType.VarChar, 20).Value = tipo;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
       


    }
}
