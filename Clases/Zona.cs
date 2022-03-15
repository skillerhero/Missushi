using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missushi.Clases {
    internal class Zona {
        private int idZona;
        private int cupo;
        private string foto;
        public Zona() {
            idZona = 0;
            cupo = 0;
            foto = "";
        }
        public Zona(int idZona, int cupo, string foto) {
            this.idZona = idZona;
            this.cupo = cupo;
            this.foto = foto;
        }
        public int getIdZona() {
            return idZona;
        }
        public void setIdZona(int idZona) {
            this.idZona = idZona;
        }
        public int getCupo() {
            return cupo;
        }
        public void setCupo(int cupo) {
            this.cupo = cupo;
        }
        public string getFoto() {
            return foto;
        }
        public void setFoto(string foto) {
            this.foto = foto;
        }
    }
}
