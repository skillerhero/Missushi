using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missushi.Clases {
    internal class Reservacion {
        public static int id = -1;
        private int idReservacion;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private int cantidadPersonas;
        private int idUsuario;
        private int idZona;
        private string estado;

        public Reservacion(int idReservacion, DateTime fechaHoraInicio, DateTime fechaHoraFin, int cantidadPersonas, int idUsuario, int idZona, string estado) {
            this.idReservacion = idReservacion;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cantidadPersonas = cantidadPersonas;
            this.idUsuario = idUsuario;
            this.idZona = idZona;
            this.estado = estado;
        }
        public Reservacion() {
            this.idReservacion = -1;
            this.fechaHoraInicio = DateTime.Today;
            this.fechaHoraFin = DateTime.Today;
            this.cantidadPersonas = 0;
            this.idUsuario = -1;
            this.idZona = 0;
            this.estado = "En espera";
        }

        public int IdReservacion { get => idReservacion; set => idReservacion = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public int CantidadPersonas { get => cantidadPersonas; set => cantidadPersonas = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdZona { get => idZona; set => idZona = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
