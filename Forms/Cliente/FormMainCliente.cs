using Missushi.Clases;
using Missushi.Forms.Cliente;

namespace Missushi.Forms {
    public partial class FormMainCliente : Form {
        public FormMainCliente() {
            InitializeComponent();
        }

        private void FormMainCliente_Load(object sender, EventArgs e) {
            label1.Text = Clases.Usuario.id.ToString();
            
        }

        private void btnHacerReservacion_Click(object sender, EventArgs e) {
            Zona.id = -1;
            FormReservacionCliente formReservacion = new FormReservacionCliente();
            formReservacion.ShowDialog();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios");
        }
    }
}
