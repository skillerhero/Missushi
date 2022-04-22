using Missushi.Clases;
using Missushi.Funciones;
using System.Diagnostics;

namespace Missushi.Forms.Todos {
    public partial class FormDisponibilidad : FormDiseño {
        private List<Zona> zonas = ConexionBD.consultarZonas();
        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private List<Label> labelList = new List<Label>();
        public FormDisponibilidad() {
            InitializeComponent();
            cargarPantallaDisponibilidad();
            cbHora.DisplayMember = "Text";
            cbHora.ValueMember = "Value";
            dtFecha.MinDate = DateTime.Today;
            dtFecha.MaxDate = DateTime.Today.AddDays(7);
        }

        private void FormDisponibilidad_Load(object sender, EventArgs e) {
            pbMapaZonas.ImageLocation = Globales.restaurante.FotoMapaZonas;
            comprobarHoraHoy();
            cargarZonas();
        }

        private void cargarZonas() {
            int x = 0, y = 0, desplazamientoX = 0, desplazamientoY = 0;
            for (int i = 0; i < zonas.Count; i++) {
                zonas[i].CupoDisponible = ConexionBD.consultarCupoZona(zonas[i].IdZona, obtenerFechaInicio());
                x = i % 2;
                desplazamientoX = x * 200;
                if (i % 2 == 0 && i > 0) {
                    y++;
                    desplazamientoY = y * 200;
                }
                Label lblIdZona = new Label() {
                    Name = "lblIdZona" + i,
                    Size = new Size(69, 18),
                    Location = new Point(503 + desplazamientoX, 167 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = "Zona " + zonas[i].IdZona.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label lblCupoDisponible = new Label() {
                    Name = "lblIdZona" + i,
                    Size = new Size(69, 18),
                    Location = new Point(583 + desplazamientoX, 167 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = "Cupo " + zonas[i].CupoDisponible.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                PictureBox picture = new PictureBox {
                    Name = "pbZona" + i,
                    Size = new Size(164, 164),
                    Location = new Point(475 + desplazamientoX, 194 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                try {
                    picture.LoadAsync(zonas[i].Foto);
                } catch (Exception ex) {
                    Debug.WriteLine("Error al cargar la foto.\n" + ex.Message);
                }

                pictureBoxList.Add(picture);
                labelList.Add(lblIdZona);
                labelList.Add(lblCupoDisponible);
            }

            foreach (PictureBox p in pictureBoxList) {
                this.Controls.Add(p);
            }
            foreach (Label l in labelList) {
                this.Controls.Add(l);
            }
        }
        private DateTime obtenerFechaInicio() {
            DateTime fechaInicio;
            fechaInicio = dtFecha.Value.Date;
            ;
            switch (cbHora.SelectedValue) {
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
        private void comprobarHoraHoy() {
            var horarios = new[] {
                 new { Text = "08:00-11:00", Value = 0 },
                 new { Text = "11:00-14:00", Value = 1 },
                 new { Text = "14:00-17:00", Value = 2 },
                 new { Text = "17:00-20:00", Value = 3 },
                 new { Text = "20:00-23:00", Value = 4 }
            };
            if (dtFecha.Value.Date != DateTime.Today) {
                cbHora.DataSource = horarios;
                cbHora.Enabled = true;
                return;
            }
            TimeSpan horario1 = new TimeSpan(8, 0, 0);
            TimeSpan horario2 = new TimeSpan(11, 0, 0);
            TimeSpan horario3 = new TimeSpan(14, 0, 0);
            TimeSpan horario4 = new TimeSpan(17, 0, 0);
            TimeSpan horario5 = new TimeSpan(20, 0, 0);


            if (DateTime.Now.TimeOfDay > horario1) {
                horarios = new[] {
                 new { Text = "11:00-14:00", Value = 1 },
                 new { Text = "14:00-17:00", Value = 2 },
                 new { Text = "17:00-20:00", Value = 3 },
                 new { Text = "20:00-23:00", Value = 4 }
            };
            }
            if (DateTime.Now.TimeOfDay > horario2) {
                horarios = new[] {
                 new { Text = "14:00-17:00", Value = 2 },
                 new { Text = "17:00-20:00", Value = 3 },
                 new { Text = "20:00-23:00", Value = 4 }
            };
            }
            if (DateTime.Now.TimeOfDay > horario3) {
                horarios = new[] {
                 new { Text = "17:00-20:00", Value = 3 },
                 new { Text = "20:00-23:00", Value = 4 }
            };
            }
            if (DateTime.Now.TimeOfDay > horario4) {
                horarios = new[] {
                 new { Text = "20:00-23:00", Value = 4 }
                };
            }
            if (DateTime.Now.TimeOfDay > horario5) {
                horarios = null;
                cbHora.Enabled = false;
            } else {
                cbHora.Enabled = true;
            }
            cbHora.DataSource = horarios;
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e) {
            comprobarHoraHoy();
        }

        protected override void OnScroll(ScrollEventArgs se) {
            base.OnScroll(se);
            this.Invalidate(false);
        }
    }
}
