using Missushi.Funciones;
using System.Drawing.Text;

namespace Missushi.Clases {
    internal class Globales {
        static public Usuario usuarioActual;
        static public Usuario? usuarioSeleccionado;
        static public Usuario? gerente;
        static public Menu? platilloSeleccionado;
        static public Zona? zonaSeleccionada;
        static public Restaurante? restaurante;
        static public Reseña reseñaSeleccionada;
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

        static public Font letraGabriola;
        static public Font letraCenturyGothic;
        public Globales() {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            usuarioActual = new Usuario();
            usuarioSeleccionado = new Usuario();
            platilloSeleccionado = new Menu();
            zonaSeleccionada = new Zona();
            reseñaSeleccionada = new Reseña();
            restaurante = ConexionBD.consultarRestaurante();
            gerente = ConexionBD.consultarGerente();
        }
        static public void constructor() {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            usuarioActual = new Usuario();
            usuarioSeleccionado = new Usuario();
            platilloSeleccionado = new Menu();
            zonaSeleccionada = new Zona();
            reseñaSeleccionada = new Reseña();
            restaurante = ConexionBD.consultarRestaurante();
            gerente = ConexionBD.consultarGerente();

            var pfc = new PrivateFontCollection();
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Gabriola.ttf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\..\")));
            pfc.AddFontFile(FileName);
            letraGabriola = new Font(pfc.Families[0], 15.25F, FontStyle.Regular);
            pfc = new PrivateFontCollection();
            FileName = string.Format("{0}Resources\\CenturyGothic.ttf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\..\")));
            pfc.AddFontFile(FileName);
            letraCenturyGothic = new Font(pfc.Families[0], 8F, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void transition() {
            transicion = true;
        }

    }
}
