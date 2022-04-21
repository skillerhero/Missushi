namespace Missushi.Clases{
    internal class Menu{
        private string nombre;
        private string descripcion;
        private float precio;
        private string foto;
        private string tipo;

        public Menu(int idPlatillo, string nombre, string descripcion, float precio, string foto, string tipo) {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Foto = foto;
            this.Tipo = tipo;
        }

        public Menu() {
            this.Nombre = "";
            this.Descripcion = "";
            this.Precio = 0;
            this.Foto = "";
            this.Tipo = "";
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Tipo { get => tipo; set => tipo = value; }

    }
}
