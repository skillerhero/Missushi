using Missushi.Funciones;
namespace Missushi.Forms{
    public partial class FormRegistro : Form{
        public FormRegistro(){
            InitializeComponent();
            cbTipo.Items.Add("Cliente");
            cbTipo.Items.Add("Administrador");
            cbTipo.Items.Add("Gerente");
            cbTipo.Text = cbTipo.Items[0].ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            try {
                String nombres = Validacion.ajustarEspacios(txtNombres.Text.Trim()), apellidos = Validacion.ajustarEspacios(txtApellidos.Text.Trim()), contraseña = txtContraseña.Text.Trim(), correo = txtCorreo.Text.Trim();
                char tipo=' ';
                switch (cbTipo.SelectedIndex) {
                    case 0:
                        tipo = 'C';
                        break;
                    case 1:
                        tipo = 'A';
                        break;
                    case 2:
                        tipo = 'G';
                        break;
                }
                if(!Validacion.esAlfabetico(nombres)){
                    MessageBox.Show("El nombre contiene caracteres no válidos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else if (Validacion.esMenor(nombres, 3)) {
                    MessageBox.Show("El nombre es demasiado corto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacion.esAlfabetico(apellidos)){
                    MessageBox.Show("Los apellidos contienen caracteres no válidos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if (Validacion.esMenor(apellidos, 8)) {
                    MessageBox.Show("Los apellidos son demasiado cortos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Validacion.esMenor(contraseña, 7)) {
                    MessageBox.Show("La contraseña es demasiado corta.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacion.validarCorreo(correo)) {
                    MessageBox.Show("El correo no es válido.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if (Validacion.esMenor(correo, 5)) {
                    MessageBox.Show("El correo es demasiado corto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ConexionBD.existeCorreo(correo)) {
                    MessageBox.Show("El correo ya existe.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(tipo == 'G' && ConexionBD.existeGerente()) {
                    MessageBox.Show("Ya existe un gerente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(ConexionBD.insertarUsuario(nombres, apellidos, Validacion.encriptar(contraseña), correo, tipo)){
                    MessageBox.Show("Registrado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e){
            if (ConexionBD.connection != null) {
                ConexionBD.connection.Close();
            }
        }
    }
}
