using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi{
    internal static class Program{
        [STAThread]
        static void Main(){
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConexionBD.conectarBD();
            Globales.constructor();
            Application.Run(new FormMain());
            if(ConexionBD.connection != null) {
                ConexionBD.connection.Close();
            }
        }
    }
}