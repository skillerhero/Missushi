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
        private char estado;

        public Usuario(int idUsuario, string nombres, string apellidos, string contraseña, string correo, char tipo, char estado) {
            id = idUsuario;
            type = '\x0';
            this.idUsuario = idUsuario;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.contraseña = contraseña;
            this.correo = correo;
            this.tipo = tipo;
            this.estado = estado;
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
            estado = 'a';
        }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public char Estado { get => estado; set => estado = value; }
    }
}