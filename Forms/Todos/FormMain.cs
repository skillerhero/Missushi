using Missushi.Funciones;
using Missushi.Clases;
using Missushi.Forms.Todos;
using Missushi.Forms.Cliente;

namespace Missushi {
    public partial class FormMain {
        public FormMain() {
            InitializeComponent();
            cargarPantallaPrincipal();
            cargarInfoRestaurante();
            if (Globales.usuarioActual.usuarioLogeado()) {
                HandleCreated -= new EventHandler(mostrarPantallaDeCarga);
                cargarBarraUsuario();
                return;
            }
            Globales.instancia = this;
        }

        private void cargarInfoRestaurante() {
            try {
                Restaurante restaurante = Globales.restaurante;
                Usuario gerente = Globales.gerente;
                if (!ConexionBD.existeInfoRestaurante()) {
                    restaurante.Telefono = "No registrado.";
                }
                if (!ConexionBD.existeGerente()) {
                    gerente.Correo = "No registrado.";
                }
                lblInfoRestaurante.colorLetra = Color.Black;
                lblInfoRestaurante.desactivarLabel();
                lblInfoRestaurante.Text = "Correo: " + gerente.Correo + "    Teléfono: " + restaurante.Telefono;
            } catch(Exception e) {
                ConexionBD.manejarErrores(e);
            }
        }
        private void mostrarPantallaDeCarga(Object sender, EventArgs e) {
            FormPantallaDeCarga formPantallaDeCarga = new FormPantallaDeCarga();
            formPantallaDeCarga.setDuracionTimer(2);
            if (formPantallaDeCarga.ShowDialog() == DialogResult.OK) {
                this.BringToFront();
                this.Activate();
            }
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e) {
            if(this == Globales.instancia) {
                cargarInfoRestaurante();
            }
        }

        private void FormMain_Shown(object sender, EventArgs e) {
            if (Globales.usuarioActual.usuarioLogeado()) {
                HandleCreated -= new EventHandler(mostrarPantallaDeCarga);
                cargarBarraUsuario();
                if (Visible == true && ConexionBD.existeReservacionAsistida(Globales.usuarioActual.IdUsuario) && ConexionBD.existeReseña(Globales.usuarioActual.IdUsuario) == -1) {
                    DialogResult dialogResult = MessageBox.Show("¿Le gustaria dejar una reseña?", "¡Nos interesa saber tu opinión!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        FormReseña formReseña = new FormReseña();
                        Globales.transition();
                        formReseña.Show();
                        Close();
                    } else if (dialogResult == DialogResult.No) {

                    }
                }
            }
        }
    }
}