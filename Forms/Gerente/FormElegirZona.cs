using System.Diagnostics;
using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi.Forms.Gerente{
    public partial class FormElegirZona : Form{
        private DateTime fechaInicio;
        private List<Zona> zonas = ConexionBD.consultarZonas();
        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private List<Label> labelList = new List<Label>();
        private Rectangle rectangulo = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Globales.azulSeleccion);
        private int seleccionado = -1;
        public FormElegirZona(){
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public FormElegirZona(DateTime fechaInicio){
            InitializeComponent();
            this.DoubleBuffered = true;
            this.fechaInicio = fechaInicio;
        }

        private void FormElegirZona_Load(object sender, EventArgs e){
            int x = 0, y = 0, desplazamientoX = 0, desplazamientoY = 0;
            rectangulo = new Rectangle();
            for (int i = 0; i < zonas.Count; i++){
                zonas[i].CupoDisponible = ConexionBD.consultarCupoZona(zonas[i].IdZona, fechaInicio);
                x = i % 3;
                desplazamientoX = x * 320;
                if (i % 3 == 0 && i > 0){
                    y++;
                    desplazamientoY = y * 400;
                }
                LabelPersonalizado lblIdZona = new LabelPersonalizado(){
                    Name = "lblIdZona" + i,
                    Size = new Size(160, 20),
                    Location = new Point(80 + desplazamientoX, 10 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = "Zona " + zonas[i].IdZona.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Gabriola", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    BackColor = Globales.rojoBoton,
                    Cursor = Cursors.Default
                };
                LabelPersonalizado lblCupoDisponible = new LabelPersonalizado(){
                    Name = "lblIdZona" + i,
                    Size = new Size(160, 20),
                    Location = new Point(80 + desplazamientoX, 40 + desplazamientoY),
                    Text = "Cupo " + zonas[i].CupoDisponible.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray,
                    Font = new Font("Gabriola", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Cursor = Cursors.Default
                };
                PictureBox picture = new PictureBox{
                    Name = "pbZona" + i,
                    Size = new Size(320, 320),
                    Location = new Point(desplazamientoX, 70 + desplazamientoY),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                rectangulo.Size = picture.Size;
                rectangulo.Location = new Point(0, 0);
                picture.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                try{
                    picture.LoadAsync(zonas[i].Foto);
                }
                catch (Exception ex){
                    Debug.WriteLine("Error al cargar la foto\n" + ex.Message);
                }
                lblIdZona.desactivarLabel();
                lblCupoDisponible.desactivarLabel();
                pictureBoxList.Add(picture);
                labelList.Add(lblIdZona);
                labelList.Add(lblCupoDisponible);
            }

            foreach (PictureBox p in pictureBoxList){
                this.Controls.Add(p);
            }
            foreach (Label l in labelList){
                this.Controls.Add(l);
            }
        }

        private void pictureBox_MouseDown(object? sender, MouseEventArgs e){
            try{
                if (sender != null && sender is PictureBox){
                    PictureBox pb = (PictureBox)sender;
                    for (int i = 0; i < pictureBoxList.Count; i++){
                        if (pictureBoxList[i] == pb){
                            if (e.Clicks == 2){
                                Globales.zonaSeleccionada = zonas[i];
                                this.DialogResult = DialogResult.OK;
                                return;
                            }
                            Graphics g = pictureBoxList[i].CreateGraphics();
                            if (i == seleccionado){
                                seleccionado = -1;
                                pictureBoxList[i].Refresh();
                                return;
                            }
                            if (seleccionado != -1){
                                pictureBoxList[seleccionado].Refresh();
                            }
                            g.FillRectangle(selectionBrush, rectangulo);
                            seleccionado = i;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnScroll(ScrollEventArgs se){
            base.OnScroll(se);
            this.Invalidate(false);
        }
    }
}
