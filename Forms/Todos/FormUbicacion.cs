using Missushi.Clases;
using Missushi.Funciones;
using System.Diagnostics;

namespace Missushi.Forms.Todos {
    public partial class FormUbicacion {
        public FormUbicacion() {
            InitializeComponent();
            cargarDatos();
            cargarPantallaUbicacion();
        }

        private void cargarDatos() {
            try {
                pbFotoMaps.ImageLocation = Globales.restaurante.FotoMaps;
                lblDescripcion.Text = Globales.restaurante.Descripcion;
                lblDireccion.Text = Globales.restaurante.Direccion;
                pbFotoMaps.Location = centrarComponente(pbFotoMaps);
                lblDescripcion.Location = centrarComponente(lblDescripcion);
                lblDireccion.Location = centrarComponente(lblDireccion);
            } catch (Exception e) {
                ConexionBD.manejarErrores(e);
            }
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
