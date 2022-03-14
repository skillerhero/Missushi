namespace Missushi.Clases {
    internal class Usuario {
        public static int id;
        public static char type;
        private int idUsuario;
        private string nombres;
        private string apellidos;
        private string contraseña;
        private string correo;
        private char tipo;

        public Usuario(int idUsuario, string nombres, string apellidos, string contraseña, string correo, char tipo) {
            id = idUsuario;
            type = '\x0';
            this.idUsuario = idUsuario;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.contraseña = contraseña;
            this.correo = correo;
            this.tipo = tipo;
        }

        public Usuario() {
            id = 0;
            type = '\x0';
            idUsuario = 0;
            nombres = "";
            apellidos = "";
            contraseña = "";
            correo = "";
            tipo = '\x0';
        }
        public int getIdUsuario() {
            return idUsuario;
        }

        public void setIdUsuario(int idUsuario) {
            this.idUsuario = idUsuario;
        }

        public string getNombres() {
            return nombres;
        }

        public void setNombres(String nombres) {
            this.nombres = nombres;
        }

        public string getApellidos() {
            return apellidos;
        }

        public void setApellidos(String apellidos) {
            this.apellidos = apellidos;
        }

        public string getContraseña() {
            return contraseña;
        }

        public void setContraseña(string contraseña) {
            this.contraseña = contraseña;
        }

        public string getCorreo() {
            return correo;
        }

        public void setCorreo(string correo) {
            this.correo = correo;
        }

        public char getTipo() {
            return tipo;
        }

        public void setTipo(char tipo) {
            this.tipo = tipo;
        }
    }
}