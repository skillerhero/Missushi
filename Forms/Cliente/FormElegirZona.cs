using Missushi.Clases;
using Missushi.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms.Cliente {
    public partial class FormElegirZona : Form {
        private List<Zona> zonas = ConexionBD.consultarZonas();
        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private List<Label> labelList = new List<Label>();
        private List<Rectangle> rectangulos = new List<Rectangle>();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        private int seleccionado = -1;
        public FormElegirZona() {
            InitializeComponent();
        }

        private void FormElegirZona_Load(object sender, EventArgs e) {
            int x = 0, y = 0;
            for (int i = 0; i < zonas.Count; i++) {
                Rectangle rectangulo = new Rectangle();
                x = i % 3;
                if( i % 3 == 0 && i>0) {
                    y++;
                }
                Label label = new Label() {
                    Name = "lblZona" + i,
                    Size = new Size(160, 20),
                    Location = new Point(80 + 320 * x, y * 360 + 10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = "Zona " + zonas[i].getIdZona().ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                PictureBox picture = new PictureBox {
                    Name = "pbZona" + i,
                    Size = new Size(320, 320),
                    Location = new Point(x * 320, y * 360 + 40),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                rectangulo.Size = picture.Size;
                rectangulo.Location = new Point(0,0);
                picture.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                try {
                    picture.Load(zonas[i].getFoto());
                } catch(Exception ex) {
                    Debug.WriteLine("Error al cargar la foto");
                }
                
                pictureBoxList.Add(picture);
                labelList.Add(label);
                rectangulos.Add(rectangulo);
            }

            foreach (PictureBox p in pictureBoxList) {
                this.Controls.Add(p);
            }
            foreach (Label l in labelList) {
                this.Controls.Add(l);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e) {
            try {
                if (sender != null && sender is PictureBox) {
                    PictureBox pb = (PictureBox)sender;
                    for (int i = 0; i < pictureBoxList.Count; i++) {
                        if (pictureBoxList[i] == pb) {
                            if (e.Clicks == 2) {
                                Zona.id = zonas[i].getIdZona();
                                this.DialogResult = DialogResult.OK;
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
                            g.FillRectangle(selectionBrush, rectangulos[i]);
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
