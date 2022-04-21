namespace Missushi.Clases {
    internal class Globales {
        static public Usuario? usuarioActual;
        static public Usuario? usuarioSeleccionado;
        static public Menu? platilloSeleccionado;
        static public Zona? zonaSeleccionada;
        static public Restaurante? restaurante;
        static public Color verdeFuerteLetra = Color.FromArgb(57, 74, 44);
        static public Color verdeBarra = Color.FromArgb(97, 120, 79);
        static public Color azulSeleccion = Color.FromArgb(128, 72, 145, 220);
        static public Color rosaTextBox = Color.FromArgb(255, 216, 196);

        public Globales() {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            usuarioActual = new Usuario();
            usuarioSeleccionado = new Usuario();
            platilloSeleccionado = new Menu();
            zonaSeleccionada = new Zona();
            restaurante = new Restaurante();
        }
    }
}
