namespace Missushi.Clases {
    internal class Globales {
        static public Usuario usuarioActual;
        static public Usuario usuarioSeleccionado;
        static public Menu platilloSeleccionado;
        static public Zona zonaSeleccionada;
        static public Restaurante restaurante;
        static public Color verdeFuerte;

        public Globales() {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            verdeFuerte = Color.FromArgb(57, 74, 44);
            usuarioActual = new Usuario();
            usuarioSeleccionado = new Usuario();
            platilloSeleccionado = new Menu();
            zonaSeleccionada = new Zona();
            restaurante = new Restaurante();
        }
    }
}
