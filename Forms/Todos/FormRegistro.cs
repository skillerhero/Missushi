using Missushi.Clases;
using Missushi.Funciones;
using System.Net;
using System.Net.Mail;

namespace Missushi.Forms{
    public partial class FormRegistro : FormDiseño{
        public FormRegistro(){
            InitializeComponent();
            if (Globales.usuarioActual.Tipo != 'A') {
                lblTipo.Visible = false;
                cbTipo.Visible = false;
            } else {
                cargarBarraUsuario();
            }
            cbTipo.Items.Add("Cliente");
            cbTipo.Items.Add("Administrador");
            cbTipo.Items.Add("Gerente");
            cbTipo.Text = cbTipo.Items[0].ToString();
            cargarPantallaRegistro();
            centrarComponente(panelRegistro);
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            try {
                String nombres = Validacion.ajustarEspacios(txtNombres.Text.Trim()), apellidos = Validacion.ajustarEspacios(txtApellidos.Text.Trim()), 
                    contraseña = txtContraseña.Text.Trim(), correo = txtCorreo.Text.Trim(), contraseña2 = Validacion.ajustarEspacios(txtConfirmarContra.Text.Trim());

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
                }else if (Validacion.esMenor(nombres, 2)) {
                    MessageBox.Show("El nombre es demasiado corto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacion.esAlfabetico(apellidos)){
                    MessageBox.Show("Los apellidos contienen caracteres no válidos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if (Validacion.esMenor(apellidos, 3)) {
                    MessageBox.Show("Los apellidos son demasiado cortos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Validacion.esMenor(contraseña, 7)) {
                    MessageBox.Show("La contraseña es demasiado corta.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(contraseña != contraseña2) {
                    MessageBox.Show("Las contraseñas no coinciden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacion.validarCorreo(correo)) {
                    MessageBox.Show("El correo no es válido.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if (Validacion.esMenor(correo, 5)) {
                    MessageBox.Show("El correo es demasiado corto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (contraseña == contraseña2)
                {
                    if (ConexionBD.existeCorreo(correo))
                    {
                        MessageBox.Show("El correo ya existe.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (tipo == 'G' && ConexionBD.existeGerente())
                    {
                        MessageBox.Show("Ya existe un gerente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (ConexionBD.insertarUsuario(nombres, apellidos, Validacion.encriptar(contraseña), correo, tipo))
                    {
                        mandarCorreo();
                        MessageBox.Show("Le enviamos un correo de confirmación a su email.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                }
               
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        private void mandarCorreo() {
            try {
                Usuario usuario = ConexionBD.consultarUsuario(txtCorreo.Text.Trim());
                string remitente = "missushi.contacto@gmail.com";
                string destinatario = usuario.Correo;
                //string copiaA = "danna.medina2869@alumnos.udg.mx";

                var dirRemitente = new MailAddress(remitente, "Missushi");
                var dirDestinatario = new MailAddress(destinatario, usuario.Nombres);
                const string contra = "frribGLDb7D2mf";
                const string asunto = "Confirmación de registro";
                string url = "http://" + ConexionBD.ipServidor + "/confirmarCuenta.php?idUsuario=" + usuario.IdUsuario;
                string body = "<h4>Para confirmar su registro haga click en el siguiente enlace: </h4><br><a href='"+url+"'>Confirmar registro</a>";

                var smtp = new SmtpClient {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(dirRemitente.Address, contra)
                };
                var message = new MailMessage(dirRemitente, dirDestinatario);
                //message.Bcc.Add(copiaA);
                message.Subject = asunto;
                message.Body = body;
                message.IsBodyHtml = true;
                smtp.Send(message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e) {

        }
    }
}
