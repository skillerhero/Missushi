using Missushi.Clases;
using Missushi.Forms.Gerente;
using Missushi.Funciones;

namespace Missushi.Forms{
    public partial class FormLogin : FormDiseño {
        public FormLogin(){
            InitializeComponent();
            this.cargarPantallaIngresar();
        }

        private void entrar() {
            if (Globales.usuarioActual.Tipo == 'C') {
                FormMainCliente formMainCliente = new FormMainCliente();
                formMainCliente.Show();
                Globales.transicion = true;
                Close();
            } else if (Globales.usuarioActual.Tipo == 'A') {
                FormMainAdministrador formMainAdministrador = new FormMainAdministrador();
                formMainAdministrador.Show();
                Globales.transicion = true;
                Close();
            } else if (Globales.usuarioActual.Tipo == 'G') {
                FormMainGerente formMainGerente = new FormMainGerente();
                formMainGerente.Show();
                Globales.transicion = true;
                Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            try {
                string correo = txtCorreo.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();
                contraseña = Validacion.encriptar(contraseña);
                if (contraseña.Length > 200) {
                    contraseña = contraseña[..200];
                }
                if (ConexionBD.usuarioSuspendido(correo, contraseña)) {
                    MessageBox.Show("Este usuario ha sido suspendido.");
                    Close();
                } else
                if (ConexionBD.login(correo, contraseña)) {
                    MessageBox.Show("Bienvenido/a");
                    entrar();
                    
                } else {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                }
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('C')) {
                entrar();
            } else {
                MessageBox.Show("No hay clientes registrados.");
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('A')) {
                entrar();
            } else {
                MessageBox.Show("No hay administradores registrados.");
            }
        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('G')) {
                entrar();
            } else {
                MessageBox.Show("No hay gerentes registrados.");
            }
        }
    }
}
