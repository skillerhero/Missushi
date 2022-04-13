using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Missushi.Funciones{
    static internal class Validacion{
        public static bool validarCorreo(string correo){
                var correoFormateado = correo.Trim();
                if (correoFormateado.EndsWith(".")){
                    return false;
                }
                string strRegex = @"(?<username>#?[_a-zA-Z0-9-+]+(\.[_a-zA-Z0-9-+]+)*)@(?<domain>[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.(([0-9]{1,3})|([a-zA-Z]{2,3})|(aero|arpa|asia|coop|info|jobs|mobi|museum|name|travel)))";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(correoFormateado)) {

                    try {
                        var addr = new System.Net.Mail.MailAddress(correo);
                        var validador = new EmailAddressAttribute();
                    if(addr.Address == correoFormateado) {
                        return validador.IsValid(correoFormateado);
                    } else {
                        return addr.Address == correoFormateado;
                    }
                    } catch {
                        return false;
                    }
            } else {
                return (false);
            }           
        }

        public static bool esAlfabetico(string cadena){
            return cadena.All(c => char.IsWhiteSpace(c) || char.IsLetter(c));
        }

        public static bool esMenor(string cadena, int tamaño) {
            if(cadena.Length <= tamaño) {
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
            byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(cadena);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer);
        }

        public static bool IsNumeric(string text) { 
            bool numero = float.TryParse(text, out float _);
            return numero;
        }
    }
}
