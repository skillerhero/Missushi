using System.Data;
using System.Diagnostics;
using Missushi.Clases;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms{
    public partial class FormMenu : Form {
        public FormMenu() {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e) {
            mostrarMenu();
        }

        private void mostrarMenu() {
            List<string> tipos = new List<string>();
            List<Menu> platillos = new List<Menu>();
            int y = 0;
            int desplazamiento = y * 155;
            tipos = ConexionBD.consultarTiposMenu();

            for (int i = 0; i < tipos.Count; i++) {
                Label lblTipo = new Label() {
                    Name = "lblTipo" + i,
                    Size = new Size(600, 45),
                    Location = new Point(100, 25 + desplazamiento),
                    Text = tipos[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe Print", 14.25F, ((FontStyle.Bold | FontStyle.Italic) | FontStyle.Underline), GraphicsUnit.Point),
                    BackColor = Color.Black,
                    ForeColor = Color.White
            };
                this.Controls.Add(lblTipo);
                platillos = ConexionBD.consultarMenu(tipos[i]);
                for (int j = 0; j < platillos.Count; j++) {
                    PictureBox picture = new PictureBox {
                        Name = "pbPlatillo" + j,
                        Size = new Size(75, 75),
                        Location = new Point(100, 85 + desplazamiento),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    Label lblNombre = new Label() {
                        Name = "lblNombre" + j,
                        Size = new Size(450, 30),
                        Location = new Point(190, 85 + desplazamiento),
                        Text = platillos[j].Nombre,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Label lblDescripcion = new Label() {
                        Name = "lblDescripcion" + j,
                        Size = new Size(450, 45),
                        Location = new Point(190, 115 + desplazamiento),
                        Text = platillos[j].Descripcion,
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    Label lblPrecio = new Label() {
                        Name = "lblPrecio" + j,
                        Size = new Size(43, 15),
                        Location = new Point(657, 115 + desplazamiento),
                        Text = platillos[j].Precio.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    try {
                        picture.LoadAsync(platillos[j].Foto);
                    } catch (Exception ex) {
                        Debug.WriteLine("Error al cargar la foto\n" + ex.Message);
                    }
                    this.Controls.Add(picture);
                    this.Controls.Add(lblNombre);
                    this.Controls.Add(lblDescripcion);
                    this.Controls.Add(lblPrecio);
                    y++;
                    desplazamiento = y * 155;
                }
            }
        }    
    }
}
