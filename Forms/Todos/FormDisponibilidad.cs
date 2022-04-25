using Missushi.Clases;
using Missushi.Funciones;
using System.Diagnostics;
using System.Threading;

namespace Missushi.Forms.Todos {
    public partial class FormDisponibilidad : FormDiseño {
        private List<Zona> zonas = ConexionBD.consultarZonas();
        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private List<Label> labelList = new List<Label>();
        private FormPantallaDeCarga formPantallaDeCarga;
        public FormDisponibilidad() {
            InitializeComponent();
            AutoScroll = false;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
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

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e) {
            obtenerFechaInicio();
            cargarZonas();
        }

        private void limpiar() {
            foreach (PictureBox p in pictureBoxList) {
                Controls.Remove(p);
            }
            foreach (Label l in labelList) {
                Controls.Remove(l);
            }
        }

        private void cargarZonas() {
            limpiar();
            zonas.Clear();
            pictureBoxList.Clear();
            labelList.Clear();

            zonas = ConexionBD.consultarZonas();
            pictureBoxList = new List<PictureBox>();
            labelList = new List<Label>();
            int x = 0, y = 0, desplazamientoX = 0, desplazamientoY = 0;
            for (int i = 0; i < zonas.Count; i++) {
                zonas[i].CupoDisponible = ConexionBD.consultarCupoZona(zonas[i].IdZona, obtenerFechaInicio());
                x = i % 2;
                desplazamientoX = x * 250;
                if (i % 2 == 0 && i > 0) {
                    y++;
                    desplazamientoY = y * 292 + 8;
                }
                LabelPersonalizado lblIdZona = new LabelPersonalizado() {
                    Name = "lblIdZona" + i,
                    Size = new Size(103, 37),
                    Location = new Point(485 + desplazamientoX, 148 + desplazamientoY),
                    Text = "Zona " + zonas[i].IdZona.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Gabriola", 15F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Globales.rojoBoton,
                    Cursor = Cursors.Default
                };
                LabelPersonalizado lblCupoDisponible = new LabelPersonalizado() {
                    Name = "lblIdZona" + i,
                    Size = new Size(103, 37),
                    Location = new Point(597 + desplazamientoX, 148 + desplazamientoY),
                    Text = "Cupo " + zonas[i].CupoDisponible.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray,
                    Font = new Font("Gabriola", 15F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Cursor = Cursors.Default

                };
                PictureBox picture = new PictureBox {
                    Name = "pbZona" + i,
                    Size = new Size(246, 246),
                    Location = new Point(475 + desplazamientoX, 195 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                try {
                    picture.LoadAsync(zonas[i].Foto);
                } catch (Exception ex) {
                    Debug.WriteLine("Error al cargar la foto.\n" + ex.Message);
                }
                lblIdZona.MouseHover -= lblIdZona.hover;
                lblIdZona.MouseLeave -= lblIdZona.leave;
                lblCupoDisponible.MouseHover -= lblCupoDisponible.hover;
                lblCupoDisponible.MouseLeave -= lblCupoDisponible.leave;
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
                 new { Text = "08:00-10:00", Value = 0 },
                 new { Text = "10:00-12:00", Value = 1 },
                 new { Text = "12:00-14:00", Value = 2 },
                 new { Text = "14:00-16:00", Value = 3 },
                 new { Text = "16:00-18:00", Value = 4 },
                 new { Text = "18:00-20:00", Value = 5},
                 new { Text = "20:00-22:00", Value = 6}
            };
            if (dtFecha.Value.Date != DateTime.Today) {
                cbHora.DataSource = horarios;
                cbHora.Enabled = true;
                return;
            }
            TimeSpan horario1 = new TimeSpan(8, 0, 0);
            TimeSpan horario2 = new TimeSpan(10, 0, 0);
            TimeSpan horario3 = new TimeSpan(12, 0, 0);
            TimeSpan horario4 = new TimeSpan(14, 0, 0);
            TimeSpan horario5 = new TimeSpan(16, 0, 0);
            TimeSpan horario6 = new TimeSpan(18, 0, 0);
            TimeSpan horario7 = new TimeSpan(20, 0, 0);

            if (DateTime.Now.TimeOfDay > horario1) {
                horarios = new[] {
                 new { Text = "10:00-12:00", Value = 1 },
                 new { Text = "12:00-14:00", Value = 2 },
                 new { Text = "14:00-16:00", Value = 3 },
                 new { Text = "16:00-18:00", Value = 4 },
                 new { Text = "18:00-20:00", Value = 5},
                 new { Text = "20:00-22:00", Value = 6}
            };
            } else if (DateTime.Now.TimeOfDay > horario2) {
                horarios = new[] {
                 new { Text = "12:00-14:00", Value = 2 },
                 new { Text = "14:00-16:00", Value = 3 },
                 new { Text = "16:00-18:00", Value = 4 },
                 new { Text = "18:00-20:00", Value = 5},
                 new { Text = "20:00-22:00", Value = 6}
            };
            } else if (DateTime.Now.TimeOfDay > horario3) {
                horarios = new[] {
                 new { Text = "14:00-16:00", Value = 3 },
                 new { Text = "16:00-18:00", Value = 4 },
                 new { Text = "18:00-20:00", Value = 5},
                 new { Text = "20:00-22:00", Value = 6}
            };
            } else if (DateTime.Now.TimeOfDay > horario4) {
                horarios = new[] {
                 new { Text = "16:00-18:00", Value = 4 },
                 new { Text = "18:00-20:00", Value = 5},
                 new { Text = "20:00-22:00", Value = 6}
                };
            } else if (DateTime.Now.TimeOfDay > horario5) {
                horarios = new[] {
                 new { Text = "18:00-20:00", Value = 5},
                 new { Text = "20:00-22:00", Value = 6}
                };
            } else if (DateTime.Now.TimeOfDay > horario6) {
                horarios = new[] {
                 new { Text = "20:00-22:00", Value = 6}
                };
            } else if (DateTime.Now.TimeOfDay > horario7) {
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

        private void mostrarPantallaDeCarga(Object sender, EventArgs e) {
            Thread t = new Thread(new ThreadStart(hilo));
            t.SetApartmentState(ApartmentState.STA); // THIS IS REQUIRED!
            t.Start();
        }
        public void hilo() {
            formPantallaDeCarga = new FormPantallaDeCarga();
            formPantallaDeCarga.setDuracionTimer(5);
            Application.Run(formPantallaDeCarga);
        }

        private void FormDisponibilidad_Shown(object sender, EventArgs e) {
            if (formPantallaDeCarga != null) {
                formPantallaDeCarga.BeginInvoke(new Action(() => formPantallaDeCarga.Close()));
            }
        }
    }
}
