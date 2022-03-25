using Missushi.Clases;
using Missushi.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms.Cliente {
    public partial class FormReservacionCliente : Form {
        public FormReservacionCliente() {
            InitializeComponent();
        }

        private void btnHacerReservacion_Click(object sender, EventArgs e) {
            try {
                DateTime fechaInicio = obtenerFechaInicio();
                DateTime fechaFin = obtenerFechaFin();
                int cantidadPersonas = (int)nudCantidadPersonas.Value;
                int idUsuario = Usuario.id;
                int idZona = Zona.id;
                string estado = "En espera";
                
                ConexionBD.agregarReservacion(fechaInicio, fechaFin, cantidadPersonas, idUsuario, idZona, estado);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormReservacionCliente_Load(object sender, EventArgs e) {
            var horarios = new[] {
                 new { Text = "08:00-11:00", Value = 0 },
                 new { Text = "11:00-14:00", Value = 1 },
                 new { Text = "14:00-17:00", Value = 2 },
                 new { Text = "17:00-20:00", Value = 3 },
                 new { Text = "20:00-23:00", Value = 4 }
            };
            cbHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHoraInicio.DisplayMember = "Text";
            cbHoraInicio.ValueMember = "Value";
            cbHoraInicio.DataSource = horarios;
            btnHacerReservacion.Enabled = false;
            nudCantidadPersonas.Enabled = false;
            dpFechaInicio.MinDate = DateTime.Today;
        }
        private void btnElegirZona_Click(object sender, EventArgs e) {
            FormElegirZona formElegirZona = new FormElegirZona(obtenerFechaInicio());
            if(formElegirZona.ShowDialog() == DialogResult.OK) {
                this.btnElegirZona.Text = "Zona " + Zona.id;
                this.btnHacerReservacion.Focus();

                nudCantidadPersonas.Maximum = ConexionBD.consultarCupoZona(Zona.id,obtenerFechaInicio());
                nudCantidadPersonas.Enabled = true;
                btnHacerReservacion.Enabled = true;
            }
        }

        private DateTime obtenerFechaInicio() {
            DateTime fechaInicio;
            fechaInicio = dpFechaInicio.Value.Date;
            ;
            switch (cbHoraInicio.SelectedIndex) {
                case 0:
                    fechaInicio = fechaInicio.AddHours(8);
                    break;
                case 1:
                    fechaInicio = fechaInicio.AddHours(11);
                    break;
                case 2:
                    fechaInicio = fechaInicio.AddHours(14);
                    break;
                case 3:
                    fechaInicio = fechaInicio.AddHours(17);
                    break;
                case 4:
                    fechaInicio = fechaInicio.AddHours(20);
                    break;
            }
            return fechaInicio;
        }
        private DateTime obtenerFechaFin() {
            DateTime fechaInicio = obtenerFechaInicio();
            DateTime fechaFin = fechaInicio;
            fechaFin = fechaFin.AddHours(3);
            return fechaFin;
        }
    }
}
