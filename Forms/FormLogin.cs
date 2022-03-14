using Missushi.Funciones;


namespace Missushi.Forms
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
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
                if (ConexionBD.login(correo, contraseña)) {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Exito");
                } else {
                    this.DialogResult = DialogResult.No;
                    MessageBox.Show("Incorrecto");
                }
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
