using System.Diagnostics;
using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi.Forms{
    public partial class FormMenu : FormDiseño {
        public FormMenu() {
            InitializeComponent();
            cargarPantallaMenu();
        }

        private void FormMenu_Load(object sender, EventArgs e) {
            mostrarMenu();
        }

        private void mostrarMenu() {
            List<string> tipos = new List<string>();
            List<Menu> platillos = new List<Menu>();
            int y = 0;
            int desplazamiento = y * 200;
            tipos = ConexionBD.consultarTiposMenu();

            for (int i = 0; i < tipos.Count; i++) {
                Label lblTipo = new Label()
                {
                    Name = "lblTipo" + i,
                    Size = new Size(900, 55),
                    Location = new Point(62, 100 + desplazamiento),
                    Text = tipos[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe Print", 17F, ((FontStyle.Bold | FontStyle.Italic)), GraphicsUnit.Point),
                    BackColor = Color.FromArgb(65, 45, 48),
                    ForeColor = Color.White
                };
                this.Controls.Add(lblTipo);
                platillos = ConexionBD.consultarMenu(tipos[i]);
                for (int j = 0; j < platillos.Count; j++) {
                    PictureBox picture = new PictureBox {
                        Name = "pbPlatillo" + j,
                        Size = new Size(125, 125),
                        Location = new Point(62, 160 + desplazamiento),
                        SizeMode = PictureBoxSizeMode.Normal
                    };
                    Label lblNombre = new Label() {
                        Name = "lblNombre" + j,
                        Size = new Size(450, 45),
                        Location = new Point(297, 160 + desplazamiento),
                        Font = new Font("Segoe Print", 13F, ((FontStyle.Bold)), GraphicsUnit.Point),
                        Text = platillos[j].Nombre,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Label lblDescripcion = new Label() {
                        Name = "lblDescripcion" + j,
                        Size = new Size(420, 55),
                        Location = new Point(297, 200 + desplazamiento),
                        Font = new Font("Century Gothic", 10.5F, ((FontStyle.Regular)), GraphicsUnit.Point),
                        Text = platillos[j].Descripcion,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Label lblPrecio = new Label() {
                        Name = "lblPrecio" + j,
                        Size = new Size(75, 25),
                        Location = new Point(875, 197 + desplazamiento),
                        Font = new Font("Century Gothic", 12.5F, ((FontStyle.Regular)), GraphicsUnit.Point),
                        Text = "$ " + platillos[j].Precio.ToString(),
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
                    desplazamiento = y * 200;
                }
            }
        }

        
    }
}
