using Missushi.Clases;
using Missushi.Forms.Cliente;
using Missushi.Forms.Todos;

namespace Missushi.Forms {
    public partial class FormMainCliente : FormDiseño {
        public FormMainCliente() {
            InitializeComponent();
            cargarPantallaMainCliente();
        }

        private void FormMainCliente_Load(object sender, EventArgs e) {
            
        }

        private void hacerReseñaToolStripMenuItem_Click(object sender, EventArgs e) {
            FormReseña formReseña = new FormReseña();
            Globales.transicion = true;
            formReseña.Show();
        }

        private void hacerReservaciónToolStripMenuItem_Click(object sender, EventArgs e) {
            Globales.zonaSeleccionada.IdZona = -1;
            FormReservacionCliente formReservacion = new FormReservacionCliente();
            Globales.transicion = true;
            formReservacion.ShowDialog();
        }

        private void desplegableToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMenuDesplegable formMenuDesplegable = new FormMenuDesplegable();
            formMenuDesplegable.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e) {
            FormHistorialReservaciones formHistorialReservaciones = new FormHistorialReservaciones();
            Globales.transicion = true;
            formHistorialReservaciones.Show();
        }
    }
}
