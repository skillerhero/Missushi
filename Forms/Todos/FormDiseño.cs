using Missushi.Clases;
using Missushi.Forms.Gerente;
using Missushi.Forms.Todos;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Missushi.Forms {
    public partial class FormDiseño : Form {
        public FormDiseño() {
            InitializeComponent();
        }

        private void FormDiseño_Load(object sender, EventArgs e) {
        }

        public void centrarComponente(Control componente) {
            componente.Location = new Point((this.Width - componente.Width) / 2, componente.Location.Y);
        }


        protected void cargarPantallaPrincipal() {
            pbImagenesRestaurante.ImageLocation = Globales.restaurante.FotoPrincipal;
            lblRegistro.Visible = true;
            lblIngresar.Visible = true;
            btnReseñas.Visible = true;
            pbLetrasLogo.Visible = true;
        }

        protected void noCargarPantallaPrincipal() {
            pbImagenesRestaurante.Visible = false;
            btnReseñas.Visible = false;
            pbLetrasLogo.Visible = false;
        }

        protected void cargarPantallaIngresar() {
            noCargarPantallaPrincipal();
            lblIngresar.colorLetra = Globales.verdeFuerteLetra;
            lblTitulo.colorLetra = Globales.verdeFuerteLetra;
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "INICIAR SESIÓN";            
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            centrarComponente(lblTitulo);
            centrarComponente(lblBarraTitulo);
        }

        protected void cargarPantallaUbicacion() {
            noCargarPantallaPrincipal();
            lblUbicacion.colorLetra = Globales.verdeFuerteLetra;
            lblUbicacion.Enabled = false;
            pbUbicacion.Enabled = false;
            if(Globales.usuarioActual.IdUsuario != -1) {
                cargarPantallaUsuario();
            }
        }

        protected void cargarPantallaDisponibilidad() {
            noCargarPantallaPrincipal();
            lblDisponibilidad.colorLetra = Globales.verdeFuerteLetra;
            lblDisponibilidad.Enabled = false;
            pbDisponibilidad.Enabled = false;
        }

        protected void cargarPantallaMenu() {
            noCargarPantallaPrincipal();
            lblMenu.colorLetra = Globales.verdeFuerteLetra;
            lblMenu.Enabled = false;
            pbMenu.Enabled = false;
        }

        protected void cargarPantallaMainCliente() {
            cargarPantallaPrincipal();
            cargarPantallaUsuario();
        }

        protected void cargarPantallaReseña() {
            if (Globales.usuarioActual.IdUsuario != -1) {
                cargarPantallaUsuario();
            }
        }

        protected void cargarPantallaUsuario() {
            pbSalir.Visible = true;
            lblIngresar.Visible = false;
            lblRegistro.Visible = true;
            lblMenu.Visible = false;
            lblDisponibilidad.Visible = false;
            lblUbicacion.Visible = false;
            pbLogo.Visible = false;
            pbMenu.Visible = false;
            pbDisponibilidad.Visible = false;
            pbUbicacion.Visible = false;
            lblBarra1.Visible = false;
            lblBarra2.Visible = false;
            lblBarra3.Visible = false;
            lblBarra4.Visible = false;
            lblRegistro.Text = Regex.Match(Globales.usuarioActual.Nombres, @"^([\w\-]+)").Value;
            lblRegistro.desactivarLabel();
            lblRegistro.Location = new Point(lblBarra5.Location.X - 20 - lblRegistro.Width, lblRegistro.Location.Y);
            pbMenuDesplegable.Visible = true;

        }

        protected void cargarPantallaRegistro() {
            noCargarPantallaPrincipal();
            lblRegistro.colorLetra = Globales.verdeFuerteLetra;
            lblRegistro.Enabled = false;
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "REGISTRO";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            centrarComponente(lblTitulo);
            centrarComponente(lblBarraTitulo);
        }


        //----------------------------Eventos----------------------------------------------
        private void hover(object sender, EventArgs e) {
            if (((PictureBoxPersonalizado)sender).Name == "pbMenu") {
                lblMenu.ForeColor = lblMenu.colorLetraSeleccionada;
            } else if (((PictureBoxPersonalizado)sender).Name == "pbUbicacion") {
                lblUbicacion.ForeColor = lblUbicacion.colorLetraSeleccionada;
            } else if (((PictureBoxPersonalizado)sender).Name == "pbDisponibilidad") {
                lblDisponibilidad.ForeColor = lblDisponibilidad.colorLetraSeleccionada;
            }
        }

        private void leave(object sender, EventArgs e) {
            if (((PictureBoxPersonalizado)sender).Name == "pbMenu") {
                lblMenu.ForeColor = lblMenu.colorLetra;
            } else if (((PictureBoxPersonalizado)sender).Name == "pbUbicacion") {
                lblUbicacion.ForeColor = lblUbicacion.colorLetra;
            } else if (((PictureBoxPersonalizado)sender).Name == "pbDisponibilidad") {
                lblDisponibilidad.ForeColor = lblDisponibilidad.colorLetra;
            }
        }

        private void lblIngresar_Click(object sender, EventArgs e) {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }
        private void lblRegistro_Click(object sender, EventArgs e) {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void lblMenu_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void pbMenu_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void pbUbicacion_Click(object sender, EventArgs e) {
            FormUbicacion formUbicacion = new FormUbicacion();
            formUbicacion.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void lblUbicacion_Click(object sender, EventArgs e) {
            FormUbicacion formUbicacion = new FormUbicacion();
            formUbicacion.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void lblDisponibilidad_Click(object sender, EventArgs e) {
            FormDisponibilidad formDisponibilidad = new FormDisponibilidad();
            formDisponibilidad.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void pbDisponibilidad_Click(object sender, EventArgs e) {
            FormDisponibilidad formDisponibilidad = new FormDisponibilidad();
            formDisponibilidad.Show();
            if (this is not FormMain) {
                Globales.transicion = true;
                Close();
            } else {
                Hide();
            }
        }

        private void lblBarraPrincipal_DoubleClick(object sender, EventArgs e) {
           // this.FormBorderStyle = FormBorderStyle.Sizable;
           // this.WindowState = FormWindowState.Minimized;
        }

        private void FormDiseño_DoubleClick(object sender, EventArgs e) {
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Close();
        }

        private void pbLogo_Click(object sender, EventArgs e) {
            if(this is not FormMain) {
                Globales.instancia.Show();
                Close();
            }
        }
        private void pbSalir_Click(object sender, EventArgs e) {
            if (this is not FormMain) {
                Globales.instancia.Show();
                Close();
            } else {
                Close();
            }
        }

        private void pbMenuDesplegable_Click(object sender, EventArgs e) {

        }

        private void FormDiseño_FormClosing(object sender, FormClosingEventArgs e) {
            if (Globales.transicion) {
                Globales.transicion = false;
            } else {
                Globales.instancia.Show();
            }
        }

        //-------------Código para que se vea la animación al restaurar la ventana sin bordes-----------
        protected override void WndProc(ref Message m) {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_RESTORE = 0xF120;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_RESTORE) {
                //this.FormBorderStyle = FormBorderStyle.None;
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
                IntPtr ptr = CreateRoundRectRgn(2, 3, ((BotonPersonalizado)sender).Width, ((BotonPersonalizado)sender).Height, 15, 15);
                ((BotonPersonalizado)sender).Region = Region.FromHrgn(ptr);
                DeleteObject(ptr);
            }
        }
    }
    public class BotonPersonalizado : Button {
        public BotonPersonalizado() {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cursor = Cursors.Hand;
            BackColor = Globales.rojoBoton;
        }
    }



    public class PictureBoxPersonalizado : PictureBox {
        public PictureBoxPersonalizado() {
            this.BackColor = Globales.verdeBarra;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TabIndex = 0;
            this.Cursor = Cursors.Hand;
            this.WaitOnLoad = false;
        }
    }

    public class LabelPersonalizado : Label {
        public Color colorLetra;
        public Color colorLetraSeleccionada;
        public LabelPersonalizado() {
            colorLetra = Color.White;
            colorLetraSeleccionada = Globales.verdeFuerteLetra;
            BackColor = Globales.verdeBarra;
            Font = new Font("Gabriola", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = colorLetra;
            TabIndex = 0;
            TextAlign = ContentAlignment.MiddleCenter;
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            MouseHover += new EventHandler(this.hover);
            MouseLeave += new EventHandler(this.leave);
        }

        public void hover(object? sender, EventArgs e) {
            this.ForeColor = colorLetraSeleccionada;
        }

        public void leave(object? sender, EventArgs e) {
            this.ForeColor = colorLetra;
        }

        public void desactivarLabel() {
            Cursor = Cursors.Default;
            MouseHover -= new EventHandler(this.hover);
            MouseLeave -= new EventHandler(this.leave);
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
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); //play with these values till you are happy
        }
    }

    public class ComboBoxPersonalizado : ComboBox {
        public ComboBoxPersonalizado() {
            DropDownStyle = ComboBoxStyle.DropDownList;
            //DrawMode = DrawMode.OwnerDrawFixed;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Globales.verdeFuerteLetra;
            DisplayMember = "Text";
            ValueMember = "Value";
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); //play with these values till you are happy
        }

    }

    public class DateTimePickerPersonalizado : DateTimePicker {
        public DateTimePickerPersonalizado() { }
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height+3, 15, 15)); //play with these values till you are happy
        }
    }


    public class NumericUpDownPersonalizado : NumericUpDown {
        public NumericUpDownPersonalizado() { }
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
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); //play with these values till you are happy
        }
    }
    class TextBoxPersonalizado : TextBox {
        public TextBoxPersonalizado() {
            BackColor = Globales.rosaTextBox;
            Size = new Size(70, 70);
            Multiline = true;
            KeyDown += new KeyEventHandler(TextBox_KeyDown);
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
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); //play with these values till you are happy
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
    }
}
