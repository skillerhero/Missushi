using Missushi.Clases;
using Missushi.Funciones;
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
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                ConexionBD.manejarErrores(ex);
                this.DialogResult = DialogResult.No;
            }
        }
    }
}

