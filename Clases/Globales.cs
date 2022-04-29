using Missushi.Funciones;

namespace Missushi.Clases {
    internal class Globales {
        static public Usuario usuarioActual;
        static public Usuario? usuarioSeleccionado;
        static public Usuario? gerente;
        static public Menu? platilloSeleccionado;
        static public Zona? zonaSeleccionada;
        static public Restaurante? restaurante;
        static public Color rojoTinto = Color.FromArgb(159, 84, 76);
        static public Color gris = Color.FromArgb(234, 234, 234);
        static public Color verdeFuerteLetra = Color.FromArgb(57, 74, 44);
        static public Color verdeBarra = Color.FromArgb(97, 120, 79);
        static public Color azulSeleccion = Color.FromArgb(128, 72, 145, 220);
        static public Color rosaTextBox = Color.FromArgb(255, 216, 196);
        static public Color rojoBoton = Color.FromArgb(143, 68, 60);
        static public Color grisClaro = Color.FromArgb(242, 230, 212);
        static public Color verdeClaro = Color.FromArgb(184, 199, 183);
        static public Form instancia;
        static public bool transicion = false;
        public Globales(Form form) {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            usuarioActual = new Usuario();
            usuarioSeleccionado = new Usuario();
            platilloSeleccionado = new Menu();
            zonaSeleccionada = new Zona();
            restaurante = ConexionBD.consultarRestaurante();
            gerente = ConexionBD.consultarGerente();
            instancia = form;
        }

        public static void transition() {
            transicion = true;
        }

    }
}
