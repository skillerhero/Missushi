using Missushi.Clases;
using Missushi.Forms.Gerente;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace Missushi.Forms {
    public partial class FormDiseño : Form {

        public FormDiseño() {
            InitializeComponent();
        }

        private void FormDiseño_Load(object sender, EventArgs e) {

        }

        protected void cargarPantallaPrincipal() {
            lblRegistro.Visible = true;
            lblIngresar.Visible = true;
            pbSalir.Visible = false;
        }

        protected void cargarPantallaIngresar() {
            this.lblIngresar.ForeColor = Color.FromArgb(57, 74, 44);
            this.pbImagenesRestaurante.Visible = false;
            this.btnReseñas.Visible = false;
            pbSalir.Visible = false;
            lblIngresar.Enabled = false;
            pbLetrasLogo.Visible = false;

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
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

        protected void cortarEsquinas(object sender, PaintEventArgs e) {
            if (sender.GetType().Name == "BotonPersonalizado") {
                IntPtr ptr = CreateRoundRectRgn(0, 0, ((BotonPersonalizado)sender).Width, ((BotonPersonalizado)sender).Height, 15, 15);
                btnReseñas.Region = Region.FromHrgn(ptr);
                DeleteObject(ptr);
            }
        }

        //----------------------------Eventos----------------------------------------------
        private void lblIngresar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Abort;
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Closed += (s, args) => this.Show();
            if (formLogin.ShowDialog() == DialogResult.OK) {
                if (Usuario.type == 'C') {
                    this.Hide();
                    FormMainCliente formMainCliente = new FormMainCliente();
                    formMainCliente.Closed += (s, args) => this.Show();
                    formMainCliente.Show();
                } else if (Usuario.type == 'A') {
                    this.Hide();
                    FormMainAdministrador formMainAdministrador = new FormMainAdministrador();
                    formMainAdministrador.Closed += (s, args) => this.Show();
                    formMainAdministrador.Show();
                } else if (Usuario.type == 'G') {
                    this.Hide();
                    FormMainGerente formMainGerente = new FormMainGerente();
                    formMainGerente.Closed += (s, args) => this.Show();
                    formMainGerente.Show();
                }
            }
        }

        private void lblRegistro_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Abort;
            this.Hide();
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Closed += (s, args) => this.Show();
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
            this.Cursor = Cursors.Hand;
        }
    }

    public class LabelPersonalizado : Label {
        public LabelPersonalizado() {
            this.BackColor = Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.Font = new Font("Gabriola", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.White;
            this.TabIndex = 0;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Cursor = Cursors.Hand;
        }
    }

    public class ComboBoxPersonalizado : ComboBox {
        public ComboBoxPersonalizado() {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        }
    }

    public class NumericUpDownPersonalizado : NumericUpDown {
        public NumericUpDownPersonalizado() { }
    }
    class TextBoxPersonalizado : TextBox {
        public TextBoxPersonalizado() {
            this.BackColor = Color.FromArgb(255, 216, 196);
            this.Size = new Size(70, 70);
            this.Multiline = true;
        }
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        }
    }
}
