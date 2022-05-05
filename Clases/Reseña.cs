namespace Missushi.Clases {
    internal class Reseña {
        private int idResenia;
        private int idUsuario;
        private int cantidadEstrellas;
        private string comentario;
        private DateTime fecha;

        public Reseña(int idResenia, int idUsuario, int cantidadEstrellas, string comentario, DateTime fecha) {
            this.idResenia = idResenia;
            this.idUsuario = idUsuario;
            this.cantidadEstrellas = cantidadEstrellas;
            this.comentario = comentario;
            this.fecha = fecha;
        }
        public Reseña() {
            this.idResenia = -1;
            this.idUsuario = -1;
            this.cantidadEstrellas = -1;
            this.comentario = "";
            this.fecha = DateTime.Today;
        }
        public int IdResenia { get => idResenia; set => idResenia = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int CantidadEstrellas { get => cantidadEstrellas; set => cantidadEstrellas = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
