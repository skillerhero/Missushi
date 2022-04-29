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

        static public void manejarErrores(Exception e) {
            if (e is MySqlException) {
                if(connection != null) {
                    connection.Close();
                }
            }
            MessageBox.Show(e.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /*----------------------------------------General----------------------------------------*/
        static public MySqlDataAdapter consultarTablaAdapter(string? tabla) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "SELECT * FROM " + tabla;
            if (connection != null) {
                connection.Open();
                adapter = new MySqlDataAdapter(sql, connection);
                connection.Close();
            }
            return adapter;
        }

        static public bool login(string correo, string contraseña) {
            bool exito = false;
            string sql = "SELECT * FROM usuario WHERE correo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", correo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    if (reader.GetString(3) == contraseña) {
                        exito = true;
                        Globales.usuarioActual = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5), reader.GetChar(6));
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


        static public bool existePlatillo(string nombre) {
            bool existe = false;
            string sql = "SELECT * FROM menu WHERE nombre = @0;";
            if (connection != null)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", nombre);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    existe = true;
                }
                connection.Close();
            }
            return existe;
        }


        static public bool consultarPrimerUsuario(char tipo) {
            bool existe = false;
            string sql = "SELECT * FROM usuario where tipo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", tipo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    existe = true;
                    Globales.usuarioActual = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5), reader.GetChar(6));
                }
                connection.Close();
            }
            return existe;
        }

        static public bool usuarioSuspendido(string correo, string contraseña) {
            bool suspendido = false;
            string sql = "SELECT idUsuario, contrasenia, tipo FROM usuario WHERE correo = @0 and estado = 's';";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", correo);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    if (reader.GetString(1) == contraseña) {
                        suspendido = true;
                    }
                }
                connection.Close();
            }
            return suspendido;
        }

        /*----------------------------------------Usuario----------------------------------------*/
        static public List<Usuario> consultarUsuarios() {
            List<Usuario> usuarios = new List<Usuario>();
            string sql = "SELECT * FROM usuario;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    usuarios.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5), reader.GetChar(6)));
                }
                connection.Close();
            }
            return usuarios;
        }
        static public Usuario consultarUsuario(int id) {
            Usuario usuario = new Usuario();
            string sql = "SELECT * FROM usuario where idUsuario = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    usuario = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5), reader.GetChar(6));
                }
                connection.Close();
            }
            return usuario;
        }
        static public bool insertarUsuario(string nombres, string apellidos, string contraseña, string correo, char tipo) {
            string sql = "INSERT INTO usuario(nombres, apellidos, contrasenia, correo, tipo, estado) VALUES(@0,@1,@2, @3, @4, 'a');";
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
            string sql = "SELECT * FROM usuario WHERE tipo = 'G';";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    gerente = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetChar(5), reader.GetChar(6));
                }
                connection.Close();
            }
            return gerente;
        }
        
        /*-------------------------------------Administrador-------------------------------------*/

        static public bool VerificarEstado(string correo) {
            bool existe = false;
            string sql = "SELECT * FROM usuario WHERE correo = @0 AND estado='s';";
            if (connection != null){
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", correo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    existe = true;
                }
                connection.Close();
            }
            return existe;
        }

        static public bool SuspenderUsuario(string correo) {
            bool exito = false;
            string sql = "UPDATE usuario SET estado = 's' WHERE correo = @0;";
            if (connection != null){
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = correo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return exito;
        }


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
        static public bool modificarRestaurante(string nombre, string descripcion, string direccion, string direccionMaps, string fotoMaps, string fotoMapaZonas, string telefono, string fotoPrincipal, int idGerente) {
            string sql = "UPDATE restaurante SET nombre=@0, descripcion=@1, direccion=@2, direccionMaps=@3, fotoMaps=@4, fotoMapaZonas=@5, telefono=@6, fotoPrincipal=@7, idGerente=@8;";
            if (connection != null) {
                connection.Open();  
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 500).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.VarChar, 100).Value = direccion;
                cmd.Parameters.Add("@3", MySqlDbType.String).Value = direccionMaps;
                cmd.Parameters.Add("@4", MySqlDbType.String).Value = fotoMaps;
                cmd.Parameters.Add("@5", MySqlDbType.String).Value = fotoMapaZonas;
                cmd.Parameters.Add("@6", MySqlDbType.VarChar, 15).Value = telefono;
                cmd.Parameters.Add("@7", MySqlDbType.String).Value = fotoPrincipal;
                cmd.Parameters.Add("@8", MySqlDbType.Int32).Value = idGerente;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        static public bool insertarRestaurante(string nombre, string descripcion, string direccion, string direccionMaps, string fotoMaps, string fotoMapaZonas, string telefono, string fotoPrincipal, int idGerente) {
            string sql = "INSERT INTO restaurante(nombre, descripcion, direccion, direccionMaps, fotoMaps, fotoMapaZonas, telefono, fotoPrincipal, idGerente) VALUES(@0, @1, @2, @3, @4, @5, @6, @7, (SELECT idUsuario FROM usuario WHERE tipo = 'G'));";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 500).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.VarChar, 100).Value = direccion;
                cmd.Parameters.Add("@3", MySqlDbType.String).Value = direccionMaps;
                cmd.Parameters.Add("@4", MySqlDbType.String).Value = fotoMaps;
                cmd.Parameters.Add("@5", MySqlDbType.String).Value = fotoMapaZonas;
                cmd.Parameters.Add("@6", MySqlDbType.VarChar, 15).Value = telefono;
                cmd.Parameters.Add("@7", MySqlDbType.String).Value = fotoPrincipal;
                cmd.Parameters.Add("@8", MySqlDbType.Int32).Value = idGerente;
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
                    restaurante.Nombre = reader.GetString(0);
                    restaurante.Descripcion = reader.GetString(1);
                    restaurante.Direccion = reader.GetString(2);
                    restaurante.DireccionMaps = reader.GetString(3);
                    restaurante.FotoMaps = reader.GetString(4);
                    restaurante.FotoMapaZonas = reader.GetString(5);
                    restaurante.Telefono = reader.GetString(6);
                    restaurante.FotoPrincipal = reader.GetString(7);
                    restaurante.IdGerente = reader.GetInt32(8);
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
            string sql = "SELECT * FROM zona;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    zonas.Add(new Zona(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2)));
                }
                connection.Close();
            }
            return zonas;
        }

        static public Zona consultarZona(int idZona) {
            Zona zona = new Zona();
            string sql = "SELECT * FROM zona where idZona = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", idZona);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    zona = new Zona(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));
                }
                connection.Close();
            }
            return zona;
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

        /*--------------------------------------Reseñas--------------------------------------*/
        static public bool agregarResenia(DateTime Now, int cantidadEstrellas, int idUsuario,string comentario){
            string sql = "INSERT INTO resenia(fecha,cantidadEstrellas,idUsuario,comentario) VALUES(@0, @1, @2, @3);";
            if (connection != null)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.DateTime).Value = Now;
                cmd.Parameters.Add("@1", MySqlDbType.Int32).Value =  cantidadEstrellas;
                cmd.Parameters.Add("@2", MySqlDbType.Int32).Value =  idUsuario;
                cmd.Parameters.Add("@3", MySqlDbType.String).Value =  comentario;
                
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        static public List<Reseña> consultarReseñas() {
            List<Reseña> reseñas = new List<Reseña>();
            string sql = "SELECT * FROM resenia;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    reseñas.Add(new Reseña(reader.GetInt32(0),reader.GetInt32(1),reader.GetInt32(2),reader.GetString(3),reader.GetDateTime(4)));
                }
                connection.Close();
            }
            return reseñas;
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
            string sql = "SELECT * FROM reservacion;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
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

        static public Reservacion consultarReservacion(int idUsuario) {
            Reservacion reservacion = new Reservacion();
            string sql = "SELECT * FROM reservacion WHERE idUsuario = @0 and estado = 'En espera';";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@0", idUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    reservacion = new Reservacion(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.GetInt32(3),reader.GetInt32(4),reader.GetInt32(5),reader.GetString(6));
                }
                connection.Close();
            }
            return reservacion;
        }

        static public MySqlDataAdapter consultarReservacionAdapter(int idUsuario) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "SELECT idReservacion, fechaHoraInicio, fechaHoraFin, cantidadPersonas, idZona, estado FROM reservacion WHERE idUsuario = @0";
            if (connection != null) {
                connection.Open();
                adapter = new MySqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.Add(
                    new MySqlParameter {
                        ParameterName = "@0",
                        Value = idUsuario,
                        MySqlDbType = MySqlDbType.Int32
                    }
                    );
                connection.Close();
            }
            return adapter;
        }


        /*--------------------------------------Menu--------------------------------------*/

        static public List<Menu> consultarMenu() {
            List<Menu> menu = new List<Menu>();
            string sql = "SELECT * FROM menu;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
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
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 200).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.Float).Value = precio;
                cmd.Parameters.Add("@3", MySqlDbType.String).Value = foto;
                cmd.Parameters.Add("@4", MySqlDbType.VarChar, 20).Value = tipo;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
       
        static public List<string> consultarTiposMenu() {
            List<string> tipos = new List<string>();
            string sql = "SELECT DISTINCT tipo FROM menu;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    tipos.Add(reader.GetString(0));
                }
                connection.Close();
            }
            return tipos;
        }
        static public List<Menu> consultarMenu(string tipo) {
            List<Menu> menu = new List<Menu>();
            string sql = "SELECT * FROM menu WHERE tipo = @0;";
            if (connection != null) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar).Value = tipo;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    menu.Add(new Menu(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetString(4), reader.GetString(5)));
                }
                connection.Close();
            }
            return menu;
        }

        static public MySqlDataAdapter consultarTablaMenu() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "SELECT nombre,descripcion,precio,tipo FROM menu";
            if (connection != null)
            {
                connection.Open();
                adapter = new MySqlDataAdapter(sql, connection);
                connection.Close();
            }
            return adapter;
        }


        static public bool modificarPlatillo(string nombre, string descripcion, float precio, string foto, string tipo) {
            string sql = "UPDATE menu SET descripcion=@1, precio=@2, foto=@3, tipo=@4 WHERE nombre = @0;";
            if (connection != null)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 200).Value = descripcion;
                cmd.Parameters.Add("@2", MySqlDbType.Float).Value = precio;
                cmd.Parameters.Add("@3", MySqlDbType.String).Value = foto;
                cmd.Parameters.Add("@4", MySqlDbType.VarChar, 20).Value = tipo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        static public bool eliminarPlatillo(string nombre) {
            string sql = "DELETE FROM menu WHERE nombre = @0;";

            if (connection != null)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 50).Value = nombre;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            return true;
        }
    }
}
