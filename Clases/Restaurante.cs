namespace Missushi.Clases {
    internal class Restaurante {
        private string nombre;
        private string descripcion;
        private string latitud;
        private string longitud;
        private string fotoPrincipal;
        private int idGerente;

        public Restaurante(string nombre, string descripcion, string latitud, string longitud, string fotoPrincipal, int idGerente) {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.latitud = latitud;
            this.longitud = longitud;
            this.fotoPrincipal = fotoPrincipal;
            this.idGerente = idGerente;
        }

        public Restaurante() {
            nombre = "";
            descripcion = "";
            latitud = "";
            longitud = "";
            fotoPrincipal = "";
            idGerente = 0;
        }

        public string getNombre() {
            return nombre;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public string getDescription() {
            return descripcion;
        }

        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }

        public string getLatitud() {
            return latitud;
        }

        public void setLatitud(string latitud) {
            this.latitud = latitud;
        }

        public string getLongitud() {
            return longitud;
        }

        public void setLongitud(string longitud) {
            this.longitud = longitud;
        }

        public string getFotoPrincipal() {
            return fotoPrincipal;
        }

        public void setFotoPrincipal(string fotoPrincipal) {
            this.fotoPrincipal = fotoPrincipal;
        }

        public int getIdGerente() { 
            return idGerente; 
        }

        public void setGerente(int idGerente) {
            this.idGerente = idGerente;
        }
    }
}
