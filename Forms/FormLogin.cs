using Missushi.Funciones;
namespace Missushi.Forms{
    public partial class FormLogin : Form{

        public FormLogin(){
            InitializeComponent();
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
    }
}
