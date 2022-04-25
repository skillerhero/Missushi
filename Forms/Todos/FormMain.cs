using Missushi.Funciones;
using Missushi.Clases;
using Missushi.Forms.Todos;

namespace Missushi{
    public partial class FormMain{
        private Globales globales;
        private FormPantallaDeCarga formPantallaDeCarga = new FormPantallaDeCarga();
        public FormMain(){
            globales = new Globales();
            InitializeComponent();
            cargarPantallaPrincipal();
            cargarInfoRestaurante();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e){
            if(ConexionBD.connection != null) {
                ConexionBD.connection.Close();
            }
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
            lblInfoRestaurante.MouseHover -= lblInfoRestaurante.hover;
            lblInfoRestaurante.MouseLeave -= lblInfoRestaurante.leave;
            lblInfoRestaurante.Text = "Correo: " + gerente.Correo + "    Teléfono: " + restaurante.Telefono;
        }
        private void mostrarPantallaDeCarga(Object sender, EventArgs e) {
            //formPantallaDeCarga.setDuracionTimer(1);
            //formPantallaDeCarga.ShowDialog();
        }

        private void FormMain_Shown(object sender, EventArgs e) {
            
        }
    }
}