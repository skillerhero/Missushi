using Missushi.Clases;
using System.Diagnostics;

namespace Missushi.Forms.Todos {
    public partial class FormUbicacion {
        public FormUbicacion() {
            InitializeComponent();
            cargarDatos();
            cargarPantallaUbicacion();
        }

        private void cargarDatos() {
            pbFotoMaps.ImageLocation = Globales.restaurante.FotoMaps;
            lblDescripcion.Text = Globales.restaurante.Descripcion;
            lblDireccion.Text = Globales.restaurante.Direccion;
        }

        private void pbFotoMaps_Click(object sender, EventArgs e) {
            try {
                Process.Start(Globales.restaurante.DireccionMaps);
            } catch {
                Process.Start(new ProcessStartInfo(Globales.restaurante.DireccionMaps) { UseShellExecute = true });
            }
        }
    }
}
