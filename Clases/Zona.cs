namespace Missushi.Clases {
    internal class Zona {
        private int idZona;
        private int cupo;
        private string foto;
        private int cupoDisponible;
        public Zona() {
            idZona = -1;
            cupo = 0;
            foto = "";
            cupoDisponible = 0;
        }
        public Zona(int idZona, int cupo, string foto) {
            this.idZona = idZona;
            this.cupo = cupo;
            this.foto = foto;
            cupoDisponible = 0;
        }

        public Zona(int idZona, int cupo, string foto, int cupoDisponible) {
            this.idZona = idZona;
            this.cupo = cupo;
            this.foto = foto;
            this.cupoDisponible = cupoDisponible;
        }

        public int IdZona { get => idZona; set => idZona = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public string Foto { get => foto; set => foto = value; }
        public int CupoDisponible { get => cupoDisponible; set => cupoDisponible = value; }
    }
}
