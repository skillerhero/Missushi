using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Missushi.Funciones{
    static internal class Validacion{

        private static byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static bool validarCorreo(string correo){
                var correoFormateado = correo.Trim();
                if (correoFormateado.EndsWith(".")){
                    return false;
                }
                try{
                    var addr = new System.Net.Mail.MailAddress(correo);
                    return addr.Address == correoFormateado;
                }catch{
                    return false;
                }
        }

        public static bool esAlfabetico(string cadena){
            return cadena.All(c => char.IsWhiteSpace(c) || char.IsLetter(c));
        }

        public static bool esMenor(string cadena, int tamaño) {
            if(cadena.Length < tamaño) {
                return true;
            } else {
                return false;
            }
        }

        public static string ajustarEspacios(string cadena) {
            Regex regex = new Regex(@"[ ]{2,}", RegexOptions.None);
            cadena = regex.Replace(cadena, @" ");
            return cadena;
        }

        public static string encriptar(string cadena) {
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(cadena);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer);
        }
    }
}
