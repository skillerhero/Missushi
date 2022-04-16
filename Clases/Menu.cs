using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missushi.Clases{
    internal class Menu{
        public static int idPlatillo = -1;
        private string nombre;
        private string descripcion;
        private float precio;
        private string foto;
        private string tipo;

        public Menu(int idPlatillo, string nombre, string descripcion, float precio, string foto, string tipo) {
            this.IdPlatillo = idPlatillo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Foto = foto;
            this.Tipo = tipo;
        }

        public Menu() {
            this.IdPlatillo = -1;
            this.Nombre = "";
            this.Descripcion = "";
            this.Precio = 0;
            this.Foto = "";
            this.Tipo = "";
        }

        public int IdPlatillo { get => idPlatillo; set => idPlatillo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Tipo { get => tipo; set => tipo = value; }

    }
}
