using Missushi.Funciones;
using System.Runtime.InteropServices;

namespace Missushi.Forms.Gerente {
    public partial class FormAgregarZona : Form {
        public FormAgregarZona() {
            InitializeComponent();
        }

        private void btnAgregarZona_Click(object sender, EventArgs e) {
            try {
                if (ConexionBD.agregarZona(Convert.ToInt32(udCupo.Value), txtFoto.Text)) { 
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Zona agregada con éxito");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.No;
            }
        }

        private void FormAgregarZona_Load(object sender, EventArgs e) {

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        protected void cortarEsquinas(object sender, PaintEventArgs e) {
            if (sender.GetType().Name == "BotonPersonalizado") {
                IntPtr ptr = CreateRoundRectRgn(2, 3, ((BotonPersonalizado)sender).Width, ((BotonPersonalizado)sender).Height, 15, 15);
                ((BotonPersonalizado)sender).Region = Region.FromHrgn(ptr);
                DeleteObject(ptr);

            }
        }
    }
}
