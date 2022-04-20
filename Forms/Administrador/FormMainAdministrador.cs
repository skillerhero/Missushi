using Missushi.Forms.Administrador;

namespace Missushi.Forms {
    public partial class FormMainAdministrador : Form {
        public FormMainAdministrador() {
            InitializeComponent();
        }

        private void FormMainAdministrador_Load(object sender, EventArgs e) {
            label1.Text = Clases.Usuario.id.ToString();
        }

        private void btnReservaciones_Click(object sender, EventArgs e) {
            FormReservacionAdministrador formReservacionAdministrador = new FormReservacionAdministrador();
            formReservacionAdministrador.ShowDialog();
        }

        private void btnSuspenderUsuarios_Click(object sender, EventArgs e) {
            FormSuspenderUsuario formSuspenderUsuario = new FormSuspenderUsuario();
            formSuspenderUsuario.ShowDialog();

        }

        private void btnBD_Click(object sender, EventArgs e) {
            FormBDAdmin formBDAdmin = new FormBDAdmin();
            formBDAdmin.Show();
        }
    }
}
