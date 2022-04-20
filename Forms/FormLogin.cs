using Missushi.Forms.Gerente;
using Missushi.Funciones;
using System.Runtime.InteropServices;

namespace Missushi.Forms{
    public partial class FormLogin{

        public FormLogin(){
            InitializeComponent();
            this.cargarPantallaIngresar();
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
                    this.DialogResult = DialogResult.Abort;
                } else
                if (ConexionBD.login(correo, contraseña)) {
                    MessageBox.Show("Bienvenido/a");
                    this.DialogResult = DialogResult.OK;
                    
                } else {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                }
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('C')) {
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("No hay clientes registrados.");
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('A')) {
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("No hay administradores registrados.");
            }
        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('G')) {
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("No hay gerentes registrados.");
            }
        }
    }
}
