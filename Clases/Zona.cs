namespace Missushi.Clases {
    internal class Zona {
        public static int id = -1;
        private int idZona;
        private int cupo;
        private string foto;
        private int cupoDisponible;
        public Zona() {
            idZona = 0;
            cupo = 0;
            foto = "";
            cupoDisponible = 0;
        }
        public Zona(int idZona, int cupo, string foto) {
            this.idZona = idZona;
            this.cupo = cupo;
            this.foto = foto;
        }

        public Zona(int idZona, int cupo, string foto, int cupoDisponible) {
            this.idZona = idZona;
            this.cupo = cupo;
            this.foto = foto;
            this.cupoDisponible = cupoDisponible;
        }
        public int getIdZona() {
            return idZona;
        }
        public void setIdZona(int idZona) {
            this.idZona = idZona;
        }
        public int getCupo() {
            return cupo;
        }
        public void setCupo(int cupo) {
            this.cupo = cupo;
        }
        public int getCupoDisponible() {
            return cupoDisponible;
        }
        public void setCupoDisponible(int cupoDisponible) {
            this.cupoDisponible = cupoDisponible;
        }
        public string getFoto() {
            return foto;
        }
        public void setFoto(string foto) {
            this.foto = foto;
        }
    }
}
