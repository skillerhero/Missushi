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
            FormReseñas formReseñas = new FormReseñas();
            Globales.transicion = true;
            formReseñas.ShowDialog();
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
    }
}
