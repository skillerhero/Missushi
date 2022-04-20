using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Clases;
using Missushi.Forms.Gerente;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Missushi.Forms {
    public partial class FormDiseño : Form {

        public FormDiseño() {
            InitializeComponent();
        }

        private void FormDiseño_Load(object sender, EventArgs e) {
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

        //----------------------Código para redondear el botón-----------------------
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);

        private void button1_Paint(object sender, PaintEventArgs e) {
            IntPtr ptr = CreateRoundRectRgn(0, 0, btnReseñas.Width, btnReseñas.Height, 15, 15);
            btnReseñas.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }

        //----------------------------Eventos----------------------------------------------
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

        private void pbMenu_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }

        private void pbUbicacion_Click(object sender, EventArgs e) {

        }

        private void lblUbicacion_Click(object sender, EventArgs e) {

        }

        private void lblDisponibilidad_Click(object sender, EventArgs e) {

        }

        private void pbDisponibilidad_Click(object sender, EventArgs e) {

        }

        private void lblBarraPrincipal_DoubleClick(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormDiseño_DoubleClick(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Close();
        }

    }
    public class BotonPersonalizado : Button {
        public BotonPersonalizado() {
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
        }
    }



    public class PictureBoxPersonalizado : PictureBox {
        public PictureBoxPersonalizado() {
            this.BackColor = Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TabIndex = 0;
        }
    }

    public class LabelPersonalizado : Label {
        public LabelPersonalizado() {
            this.BackColor = Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.Font = new Font("Gabriola", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.White;
            this.TabIndex = 0;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
