using Missushi.Clases;
using Missushi.Funciones;
using Missushi.Properties;
using System.Runtime.InteropServices;


namespace Missushi.Forms.Cliente {
    public partial class FormValoracion : Form {
        public FormValoracion() {
            InitializeComponent();
            lblTitulo.colorLetra = Globales.verdeFuerteLetra;
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
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
        private void pbEstrella1_Click(object sender, EventArgs e) {
            Globales.reseñaSeleccionada.CantidadEstrellas = 1;
            pbEstrella2.Image = Resources.estrella_vacia;
            pbEstrella3.Image = Resources.estrella_vacia;
            pbEstrella4.Image = Resources.estrella_vacia;
            pbEstrella5.Image = Resources.estrella_vacia;
        }
        private void pbEstrella2_Click(object sender, EventArgs e) {
            Globales.reseñaSeleccionada.CantidadEstrellas = 2;
            pbEstrella2.Image = Resources.estrella_rellena;
            pbEstrella3.Image = Resources.estrella_vacia;
            pbEstrella4.Image = Resources.estrella_vacia;
            pbEstrella5.Image = Resources.estrella_vacia;
        }

        private void pbEstrella3_Click(object sender, EventArgs e) {
            Globales.reseñaSeleccionada.CantidadEstrellas = 3;
            pbEstrella2.Image = Resources.estrella_rellena;
            pbEstrella3.Image = Resources.estrella_rellena;
            pbEstrella4.Image = Resources.estrella_vacia;
            pbEstrella5.Image = Resources.estrella_vacia;
        }

        private void pbEstrella4_Click(object sender, EventArgs e) {
            Globales.reseñaSeleccionada.CantidadEstrellas = 4;
            pbEstrella2.Image = Resources.estrella_rellena;
            pbEstrella3.Image = Resources.estrella_rellena;
            pbEstrella4.Image = Resources.estrella_rellena;
            pbEstrella5.Image = Resources.estrella_vacia;
        }

        private void pbEstrella5_Click(object sender, EventArgs e) {
            Globales.reseñaSeleccionada.CantidadEstrellas = 5;
            pbEstrella2.Image = Resources.estrella_rellena;
            pbEstrella3.Image = Resources.estrella_rellena;
            pbEstrella4.Image = Resources.estrella_rellena;
            pbEstrella5.Image = Resources.estrella_rellena;
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            try {
                int idReseña = ConexionBD.existeReseña(Globales.usuarioActual.IdUsuario);
                if (idReseña == -1) {
                    ConexionBD.agregarResenia(Globales.usuarioActual.IdUsuario, Globales.reseñaSeleccionada.CantidadEstrellas, Globales.reseñaSeleccionada.Comentario, DateTime.Now);
                    MessageBox.Show("Reseña hecha con éxito.");
                    DialogResult = DialogResult.OK;
                } else {
                    ConexionBD.actualizarReseña(Globales.usuarioActual.IdUsuario, Globales.reseñaSeleccionada.CantidadEstrellas, Globales.reseñaSeleccionada.Comentario, DateTime.Now, idReseña);
                    MessageBox.Show("Reseña actualizada con éxito.");
                    DialogResult = DialogResult.OK;
                }
              
            } catch (Exception ex) {
                ConexionBD.manejarErrores(ex);
            }
        }
    }
}
