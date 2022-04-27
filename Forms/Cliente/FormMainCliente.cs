using Missushi.Clases;
using Missushi.Forms.Cliente;

namespace Missushi.Forms {
    public partial class FormMainCliente : FormDiseño {
        public FormMainCliente() {
            InitializeComponent();
        }

        private void FormMainCliente_Load(object sender, EventArgs e) {
            label1.Text = Globales.usuarioActual.IdUsuario.ToString();
            
        }

        private void btnHacerReservacion_Click(object sender, EventArgs e) {
            Globales.zonaSeleccionada.IdZona = -1;
            FormReservacionCliente formReservacion = new FormReservacionCliente();
            formReservacion.ShowDialog();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            FormReseñas formReseñas = new FormReseñas();
            formReseñas.ShowDialog();
        }
    }
}
