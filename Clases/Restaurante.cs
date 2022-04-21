namespace Missushi.Clases {
    internal class Restaurante {
        private string nombre;
        private string descripcion;
        private string direccion;
        private string direccionMaps;
        private string telefono;
        private string fotoPrincipal;
        private int idGerente;

        public Restaurante(string nombre, string descripcion, string direccion, string direccionMaps, string telefono, string fotoPrincipal, int idGerente) {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.direccionMaps = direccionMaps;
            this.telefono = telefono;
            this.fotoPrincipal = fotoPrincipal;
            this.idGerente = idGerente;
        }

        public Restaurante() {
            nombre = "";
            descripcion = "";
            direccion = "";
            direccionMaps = "";
            telefono = "";
            fotoPrincipal = "";
            idGerente = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string DireccionMaps { get => direccionMaps; set => direccionMaps = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string FotoPrincipal { get => fotoPrincipal; set => fotoPrincipal = value; }
        public int IdGerente { get => idGerente; set => idGerente = value; }
    }
}
