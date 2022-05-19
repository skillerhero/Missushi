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
                lblInfoRestaurante.Text = "Correo: " + gerente.Correo + "    Tel�fono: " + restaurante.Telefono;
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
                if (Visible == true && ConexionBD.existeReservacionAsistida(Globales.usuarioActual.IdUsuario) && ConexionBD.existeRese�a(Globales.usuarioActual.IdUsuario) == -1) {
                    DialogResult dialogResult = MessageBox.Show("�Le gustaria dejar una rese�a?", "�Nos interesa saber tu opini�n!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        FormRese�a formRese�a = new FormRese�a();
                        Globales.transition();
                        formRese�a.Show();
                        Close();
                    } else if (dialogResult == DialogResult.No) {

                    }
                }
            }
        }
    }
}