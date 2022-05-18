using Missushi.Clases;
using Missushi.Forms.Todos;
using Missushi.Forms.Cliente;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Missushi.Forms.Administrador;
using Missushi.Forms.Gerente;

namespace Missushi.Forms {
    public partial class FormDiseño : Form {
        public FormDiseño() {
            InitializeComponent();
        }
        public Point centrarComponente(Control componente) {
            componente.Location = new Point((1024 - componente.Width) / 2, componente.Location.Y);
            return componente.Location;
        }

        public void centrarComponenteHorizontal(ref Control componente) {
            componente.Location = new Point((this.Width - componente.Width) / 2, componente.Location.Y);
        }

        protected void cargarPantallaPrincipal() {
            pbImagenesRestaurante.ImageLocation = Globales.restaurante.FotoPrincipal;
            lblRegistro.Visible = true;
            lblIngresar.Visible = true;
            btnReseñas.Visible = true;
            pbLetrasLogo.Visible = true;
            pbImagenesRestaurante.Visible = true;
            }

        protected void noCargarPantallaPrincipal() {
            pbImagenesRestaurante.Visible = false;
            btnReseñas.Visible = false;
            pbLetrasLogo.Visible = false;
        }

        protected void cargarPantallaIngresar() {
            noCargarPantallaPrincipal();
            lblIngresar.colorLetra = Globales.verdeFuerteLetra;
            lblIngresar.Enabled = false;
            lblTitulo.colorLetra = Globales.verdeFuerteLetra;
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "INICIAR SESIÓN";            
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
        }

        protected void cargarPantallaUbicacion() {
            noCargarPantallaPrincipal();
            lblUbicacion.colorLetra = Globales.verdeFuerteLetra;
            lblUbicacion.Enabled = false;
            pbUbicacion.Enabled = false;
            if(Globales.usuarioActual.IdUsuario != -1) {
                cargarBarraUsuario();
            }
        }

        protected void cargarPantallaDisponibilidad() {
            noCargarPantallaPrincipal();
            lblDisponibilidad.colorLetra = Globales.verdeFuerteLetra;
            lblDisponibilidad.Enabled = false;
            pbDisponibilidad.Enabled = false;
            if (Globales.usuarioActual.IdUsuario != -1) {
                cargarBarraUsuario();
            }
        }

        protected void cargarPantallaMenu() {
            noCargarPantallaPrincipal();
            lblMenu.colorLetra = Globales.verdeFuerteLetra;
            lblMenu.Enabled = false;
            pbMenu.Enabled = false;
            if (Globales.usuarioActual.IdUsuario != -1) {
                cargarBarraUsuario();
            }
        }

        protected void cargarPantallaReseñas() {
            if (Globales.usuarioActual.IdUsuario != -1) {
                cargarBarraUsuario();
            }
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "RESEÑAS";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
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
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
        }

        protected void cargarFormBDAdmin() {
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "BASE DE DATOS";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
        }

        protected void cargarSuspenderUsuario() {
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "USUARIOS";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
        }

        protected void cargarPantallaHistorial() {
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "HISTORIAL";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
        }
        //-------------------------------------------------------------Usuario------------------------------------------------
        protected void cargarBarraUsuario() {
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

        protected void inicializarMenuDesplegable(List<(string, EventHandler)> nombres) {
            PictureBoxPersonalizado pbLogoLetrasAux = pbLogoLetras;
            pnlPrincipalMenu.Controls.Clear();

            for (int i = 0; i < nombres.Count; i++) {
                LabelPersonalizado lbl = new LabelPersonalizado();
                lbl.Dock = DockStyle.Fill;
                lbl.Font = new Font("Gabriola", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
                lbl.ForeColor = Color.White;
                lbl.Location = new Point(0, 0);
                lbl.Margin = new Padding(0);
                lbl.Name = "lblPanel" + i;
                lbl.TabIndex = 0;
                lbl.Text = nombres[i].Item1;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Click += nombres[i].Item2;

                Panel pnl = new Panel();
                pnl.Controls.Add(lbl);
                pnl.Dock = DockStyle.Top;
                pnl.Location = new Point(0, 0);
                pnl.Name = "pnlMenu" + i;
                pnl.Size = new Size(230, 80);

                pnlPrincipalMenu.Controls.Add(pnl);
            }
            if(Globales.usuarioActual.Tipo == 'G') {
                pnlPrincipalMenu.Width = 300;
            } else {
                pnlPrincipalMenu.Width = 230;
            }
            
            pnlPrincipalMenu.Controls.Add(pbLogoLetrasAux);
            pnlPrincipalMenu.Visible = true;
            pnlPrincipalMenu.AutoScroll = false;
            pnlPrincipalMenu.HorizontalScroll.Enabled = false;
            pnlPrincipalMenu.HorizontalScroll.Visible = false;
            pnlPrincipalMenu.HorizontalScroll.Maximum = 0;
            pnlPrincipalMenu.AutoScroll = true;
            pnlPrincipalMenu.BringToFront();
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
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.transition();
                Close();
            } else {
                Hide();
            }
        }
        private void lblRegistro_Click(object sender, EventArgs e) {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.transition();
                Close();
            } else {
                Hide();
            }
        }

        private void Menu_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.transition();
                Close();
            } else {
                Hide();
            }
        }
        private void Ubicacion_Click(object sender, EventArgs e) {
            FormUbicacion formUbicacion = new FormUbicacion();
            formUbicacion.Show();
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.transition();
                Close();
            } else {
                Hide();
            }
        }

        private void Disponibilidad_Click(object sender, EventArgs e) {
            FormDisponibilidad formDisponibilidad = new FormDisponibilidad();
            formDisponibilidad.Show();
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.transition();
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
            Globales.usuarioActual = new Usuario();
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.instancia.Show();
                Close();
            } else {
                Close();
            }
        }
        protected void historial_Click(object sender, EventArgs e) {
            FormHistorialReservaciones formHistorialReservaciones = new FormHistorialReservaciones();
            Globales.transition();
            Close();
            formHistorialReservaciones.Show();
        }
        protected void hacerReservación_Click(object sender, EventArgs e) {
            Globales.zonaSeleccionada = new Zona();
            FormHacerReservacion formReservacion = new FormHacerReservacion();
            Globales.transition();
            formReservacion.Show();
            Close();
        }

        protected void modificarInfoRestaurante_Click(object sender, EventArgs e) {
            FormModificarInfoRestaurante formModificarInfo = new FormModificarInfoRestaurante();
            formModificarInfo.ShowDialog();
        }

        protected void modificarZona_Click(object sender, EventArgs e) {
            FormModificarZona formModificarZona = new FormModificarZona();
            formModificarZona.ShowDialog();
        }

        protected void agregarZona_Click(object sender, EventArgs e) {
            FormAgregarZona formAgregarZona = new FormAgregarZona();
            formAgregarZona.ShowDialog();
        }

        protected void agregarPlatillo_Click(object sender, EventArgs e) {
            FormAgregarPlatillo formAgregarPlatillo = new FormAgregarPlatillo();
            formAgregarPlatillo.Show();
            Globales.transition();
            Close();
        }

        protected void modificarPlatillo_Click(object sender, EventArgs e) {
            FormModificarPlatillo formModificarPlatillo = new FormModificarPlatillo();
            formModificarPlatillo.Show();
            Globales.transition();
            Close();
        }

        protected void eliminarPlatillo_Click(object sender, EventArgs e) {
            FormModificarMenu formEliminarPlatillo = new FormModificarMenu();
            formEliminarPlatillo.Show();
            Globales.transition();
            Close();
        }

        protected void nada_Click(object sender, EventArgs e) {

        }
        private void pbMenuDesplegable_Click(object sender, EventArgs e) {
            if (pnlMuestraMenuDesplegable.Visible == false) {
                if (Globales.usuarioActual.Tipo == 'C') {
                    inicializarMenuDesplegable(new List<(string, EventHandler)> {
                      ("Historial",historial_Click),
                      ("Reseñas", Reseñas_Click),
                      ("Menú", Menu_Click),
                      ("Ubicación", Ubicacion_Click),
                      ("Disponibilidad", Disponibilidad_Click),
                      ("Reservaciones", hacerReservación_Click)
                 });
                } else if(Globales.usuarioActual.Tipo == 'A') {
                    inicializarMenuDesplegable(new List<(string, EventHandler)> {
                      ("Registrar usuarios", lblRegistro_Click),
                      ("Base de datos",verBD_Click),
                      ("Reseñas", Reseñas_Click),
                      ("Reservaciones", ReservacionesAdmin_Click),
                      ("Suspender usuarios", suspenderUsuarios_Click)
                 });

                } else if(Globales.usuarioActual.Tipo == 'G') {
                    inicializarMenuDesplegable(new List<(string, EventHandler)> {
                        ("",nada_Click),
                        ("Modificar platillos",modificarPlatillo_Click),
                        ("Modificar Menú",eliminarPlatillo_Click),
                        ("Modificar info del restaurante",modificarInfoRestaurante_Click),
                        ("Modificar zona",modificarZona_Click),
                        ("Agregar zona",agregarZona_Click),
                      ("Reservaciones",ReservacionesAdmin_Click),
                      ("Disponibilidad", Disponibilidad_Click)
                 });
                }
               
            }
        }

        private void FormDiseño_FormClosing(object sender, FormClosingEventArgs e) {
            if (Globales.transicion) {
                Globales.transicion = false;
            } else if ((Globales.usuarioActual.usuarioLogeado()) && this is not FormMain) {
                FormMain formMain = new FormMain();
                formMain.Show();
            } else{
                Globales.instancia.Show();
                Globales.constructor();
            }
        }

        protected void verBD_Click(object sender, EventArgs e) {
            FormBDAdmin formBDAdmin = new FormBDAdmin();
            formBDAdmin.Show();
            Globales.transition();
            Close();
        }

        protected void suspenderUsuarios_Click(object sender, EventArgs e) {
            FormSuspenderUsuario formSuspenderUsuario = new FormSuspenderUsuario();
            Globales.transition();
            formSuspenderUsuario.Show();
            Close();
        }
        protected void ReservacionesAdmin_Click(object sender, EventArgs e) {
            FormPanelReservaciones formReservacionAdministrador = new FormPanelReservaciones();
            Globales.transition();
            formReservacionAdministrador.Show();
            Close();
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

        private void Reseñas_Click(object sender, EventArgs e) {
            FormReseña formReseña = new FormReseña();
            formReseña.Show();
            if (this is not FormMain || Globales.usuarioActual.usuarioLogeado()) {
                Globales.transition();
                Close();
            } else {
                Hide();
            }
        }

        private void pbLogoLetras_Click(object sender, EventArgs e) {
            pnlPrincipalMenu.Visible = false;
        }
    }
    public class BotonPersonalizado : Button {
        public BotonPersonalizado() {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = Globales.letraCenturyGothic;
            Cursor = Cursors.Hand;
            BackColor = Globales.rojoBoton;
        }
    }



    public class PictureBoxPersonalizado : PictureBox {
        public PictureBoxPersonalizado() {
            this.BackColor = Globales.verdeBarra;
            this.SizeMode = PictureBoxSizeMode.Normal;
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
            ForeColor = colorLetra;
            TabIndex = 0;
            TextAlign = ContentAlignment.MiddleCenter;
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            MouseHover += new EventHandler(this.hover);
            MouseLeave += new EventHandler(this.leave);
            Font = new Font("Gabriola", 15.25F, FontStyle.Regular);
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
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); 
        }
    }

    public class ComboBoxPersonalizado : ComboBox {
        public ComboBoxPersonalizado() {
            DropDownStyle = ComboBoxStyle.DropDownList;
            //DrawMode = DrawMode.OwnerDrawFixed;
            FlatStyle = FlatStyle.Flat;
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); 
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height+3, 15, 15)); 
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
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); 
        }
    }
    public class TextBoxPersonalizado : TextBox {
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
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 15, 15)); 
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
    }
    public class SelectableLabel : Label {
        public SelectableLabel() {
            SetStyle(ControlStyles.Selectable, true);
            TabStop = true;
        }

        protected override void OnEnter(EventArgs e) {
            BackColor = Globales.grisClaro;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e) {
            BackColor = Color.Black;
            base.OnLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            this.Focus();
            base.OnMouseDown(e);
        }
    }
}
