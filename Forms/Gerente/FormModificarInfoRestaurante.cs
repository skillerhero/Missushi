using Missushi.Clases;
using Missushi.Funciones;
using System.Runtime.InteropServices;

namespace Missushi.Forms.Gerente {
    public partial class FormModificarInfoRestaurante : Form {
        public FormModificarInfoRestaurante() {
            InitializeComponent();
        }

        private void FormModificarInfo_Load(object sender, EventArgs e) {
            Restaurante restaurante = Globales.restaurante;
            Usuario gerente = Globales.gerente;
            txtNombre.Text= restaurante.Nombre;
            txtDescripcion.Text = restaurante.Descripcion;
            txtDireccion.Text = restaurante.Direccion;
            txtDireccionMaps.Text = restaurante.DireccionMaps;
            txtTelefono.Text = restaurante.Telefono;
            txtFotoPrincipal.Text = restaurante.FotoPrincipal;
            txtFotoMapaZonas.Text = restaurante.FotoMapaZonas;
            txtFotoMaps.Text = restaurante.FotoMaps;
            if (ConexionBD.existeGerente()) {
                txtIdGerente.Text = gerente.IdUsuario.ToString();
                txtNombreGerente.Text = gerente.Nombres + " " + gerente.Apellidos;
            } else {
                txtIdGerente.Enabled = true;
                txtNombreGerente.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                string direccion = txtDireccion.Text;
                string direccionMaps = txtDireccionMaps.Text;
                string fotoMaps = txtFotoMaps.Text;
                string fotoMapaZonas = txtFotoMapaZonas.Text;
                string telefono = txtTelefono.Text;
                string fotoPrincipal = txtFotoPrincipal.Text;
                int idGerente = Convert.ToInt32(txtIdGerente.Text);
                if (ConexionBD.existeInfoRestaurante()) {
                    ConexionBD.modificarRestaurante(nombre, descripcion, direccion, direccionMaps, fotoMaps, fotoMapaZonas, telefono, fotoPrincipal, idGerente);
                } else {
                    ConexionBD.insertarRestaurante(nombre, descripcion, direccion, direccionMaps, fotoMaps, fotoMapaZonas, telefono, fotoPrincipal, idGerente);
                }
                MessageBox.Show("Modificado con éxito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globales.restaurante = ConexionBD.consultarRestaurante();
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                ConexionBD.manejarErrores(ex);
                this.DialogResult = DialogResult.No;
            }
        }
        //----------------------Código para redondear el botón-----------------------
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

