using Missushi.Funciones;
using Missushi.Clases;
using Missushi.Forms.Todos;

namespace Missushi{
    public partial class FormMain{
        public FormMain(){
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
            Restaurante restaurante = Globales.restaurante;
            Usuario gerente = Globales.gerente;
            if (!ConexionBD.existeInfoRestaurante()){
                restaurante.Telefono = "No registrado.";
            }
            if (!ConexionBD.existeGerente()) {
                gerente.Correo = "No registrado.";
            }
            lblInfoRestaurante.colorLetra = Color.Black;
            lblInfoRestaurante.desactivarLabel();
            lblInfoRestaurante.Text = "Correo: " + gerente.Correo + "    Tel�fono: " + restaurante.Telefono;
        }
        private void mostrarPantallaDeCarga(Object sender, EventArgs e) {
            FormPantallaDeCarga formPantallaDeCarga = new FormPantallaDeCarga();
            formPantallaDeCarga.setDuracionTimer(2);
            if(formPantallaDeCarga.ShowDialog() == DialogResult.OK) {
                this.BringToFront();
                this.Activate();
            }
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e) {
            cargarPantallaPrincipal();
            cargarInfoRestaurante();
            if (Globales.usuarioActual.usuarioLogeado()) {
                HandleCreated -= new EventHandler(mostrarPantallaDeCarga);
                cargarBarraUsuario();
                return;
            }
        }
    }
}