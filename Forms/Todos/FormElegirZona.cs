using System.Diagnostics;
using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi.Forms.Gerente {
    public partial class FormElegirZona : Form {
        private DateTime fechaInicio;
        private List<Zona> zonas = ConexionBD.consultarZonas();
        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private List<Label> labelList = new List<Label>();
        private Rectangle rectangulo = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Globales.azulSeleccion);
        private int seleccionado = -1;
        public FormElegirZona() {
            InitializeComponent();
            this.DoubleBuffered = true;
            panelZonas.AutoScroll = false;
            panelZonas.HorizontalScroll.Enabled = false;
            panelZonas.HorizontalScroll.Visible = false;
            panelZonas.HorizontalScroll.Maximum = 0;
            panelZonas.AutoScroll = true;
        }
        public FormElegirZona(DateTime fechaInicio) {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fechaInicio = fechaInicio;
            panelZonas.AutoScroll = false;
            panelZonas.HorizontalScroll.Enabled = false;
            panelZonas.HorizontalScroll.Visible = false;
            panelZonas.HorizontalScroll.Maximum = 0;
            panelZonas.AutoScroll = true;
        }
        private void FormElegirZona_Load(object sender, EventArgs e) {
            int x = 0, y = 0, desplazamientoX = 0, desplazamientoY = 0;
            rectangulo = new Rectangle();
            for (int i = 0; i < zonas.Count; i++) {
                zonas[i].CupoDisponible = ConexionBD.consultarCupoZona(zonas[i].IdZona, fechaInicio);
                x = i % 2;
                desplazamientoX = x * 250;
                if (i % 2 == 0 && i > 0) {
                    y++;
                    desplazamientoY = y * 250;
                }
                LabelPersonalizado lblIdZona = new LabelPersonalizado() {
                    Name = "lblIdZona" + i,
                    Size = new Size(103, 37),
                    Location = new Point(260+desplazamientoX, desplazamientoY),
                    Text = "Zona " + zonas[i].IdZona.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Century gothic", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Globales.rojoTinto,
                    Cursor = Cursors.Default
                };
                LabelPersonalizado lblCupoDisponible = new LabelPersonalizado() {
                    Name = "lblIdZona" + i,
                    Size = new Size(103, 37),
                    Location = new Point(373 + desplazamientoX, desplazamientoY),
                    Text = "Cupo " + zonas[i].CupoDisponible.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Globales.gris,
                    Font = new Font("Century gothic", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Cursor = Cursors.Default
                };
                PictureBox picture = new PictureBox {
                    Name = "pbZona" + i,
                    Size = new Size(225, 185),
                    Location = new Point(263+desplazamientoX, 47 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.Normal
                };

                rectangulo.Size = picture.Size;
                rectangulo.Location = new Point(0, 0);
                picture.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                try {
                    picture.LoadAsync(zonas[i].Foto);
                } catch (Exception ex) {
                    Debug.WriteLine("Error al cargar la foto\n" + ex.Message);
                }
                lblIdZona.desactivarLabel();
                lblCupoDisponible.desactivarLabel();
                pictureBoxList.Add(picture);
                labelList.Add(lblIdZona);
                labelList.Add(lblCupoDisponible);
            }
            foreach (PictureBox p in pictureBoxList) {
                panelZonas.Controls.Add(p);
            }
            foreach (Label l in labelList) {
                panelZonas.Controls.Add(l);
            }
        }

        private void pictureBox_MouseDown(object? sender, MouseEventArgs e) {
            try {
                if (sender != null && sender is PictureBox) {
                    PictureBox pb = (PictureBox)sender;

                    for (int i = 0; i < pictureBoxList.Count; i++) {
                        if (pictureBoxList[i] == pb) {
                            if (e.Clicks == 2) {
                                if (Globales.usuarioActual.Tipo == 'C' || Globales.usuarioActual.Tipo == 'A') {
                                    if (zonas[i].CupoDisponible == 0) {
                                        MessageBox.Show("Esta zona está llena en este horario.");
                                        return;
                                    }
                                }
                                Globales.zonaSeleccionada = zonas[i];
                                this.DialogResult = DialogResult.OK;
                                return;
                            }
                            Graphics g = pictureBoxList[i].CreateGraphics();
                            if (i == seleccionado) {
                                seleccionado = -1;
                                pictureBoxList[i].Refresh();
                                return;
                            }
                            if (seleccionado != -1) {
                                pictureBoxList[seleccionado].Refresh();
                            }
                            g.FillRectangle(selectionBrush, rectangulo);
                            seleccionado = i;
                            return;
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
