using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Clases;
using Missushi.Forms.Gerente;
using System.Runtime.InteropServices;

namespace Missushi.Forms {
    public partial class FormDiseño : Form {
        public FormDiseño() {
            InitializeComponent();
        }

        private void FormDiseño_Load(object sender, EventArgs e) {
        }

        private void pbCerrar_Click(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Close();
        }

        private void pbMinimizar_Click(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Minimized;
        }

        //-------------Código para que se vea la animación al restaurar la ventana sin bordes-----------
        protected override void WndProc(ref Message m) {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_RESTORE = 0xF120;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_RESTORE) {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            base.WndProc(ref m);
        }

        //-------------Código para que se mueva la ventana sin bordes-----------

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]  
        public static extern bool ReleaseCapture();

        private void FormDiseño_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblIngresar_Click(object sender, EventArgs e) {
            FormLogin formLogin = new FormLogin();
            if (formLogin.ShowDialog() == DialogResult.OK) {
                this.Hide();
                if (Usuario.type == 'C') {
                    FormMainCliente formMainCliente = new FormMainCliente();
                    formMainCliente.Closed += (s, args) => this.Show();
                    formMainCliente.Show();
                } else if (Usuario.type == 'A') {
                    FormMainAdministrador formMainAdministrador = new FormMainAdministrador();
                    formMainAdministrador.Closed += (s, args) => this.Show();
                    formMainAdministrador.Show();
                } else if (Usuario.type == 'G') {
                    FormMainGerente formMainGerente = new FormMainGerente();
                    formMainGerente.Closed += (s, args) => this.Show();
                    formMainGerente.Show();
                }
            }
        }

        private void lblRegistro_Click(object sender, EventArgs e) {
            FormRegistro formRegistro = new FormRegistro();
            if (formRegistro.ShowDialog() == DialogResult.OK) {

            }
        }

        private void lblMenu_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
    }
}
