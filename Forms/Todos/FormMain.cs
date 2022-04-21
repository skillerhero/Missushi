using Missushi.Funciones;
using Missushi.Clases;

namespace Missushi{
    public partial class FormMain{
        private Globales globales;
        public FormMain(){
            InitializeComponent();
            cargarPantallaPrincipal();
            globales = new Globales();
        }
        private void FormMain_Shown(object sender, EventArgs e) {
            cargarInfoRestaurante();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e){
            if(ConexionBD.connection != null) {
                ConexionBD.connection.Close();
            }
        }

        private void cargarInfoRestaurante() {
            Restaurante restaurante = ConexionBD.consultarRestaurante();
            Usuario gerente = ConexionBD.consultarGerente();
            if (!ConexionBD.existeInfoRestaurante()){
                restaurante.Telefono = "No registrado.";
            }
            if (!ConexionBD.existeGerente()) {
                gerente.Correo = "No registrado.";
            }
            lblInfoRestaurante.Text = "Correo: " + gerente.Correo + "    Teléfono: " + restaurante.Telefono;
        }
    }
}