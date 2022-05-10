using System.Text.RegularExpressions;
using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi.Forms.Cliente {
    public partial class FormReseña : FormDiseño {
        public FormReseña() {
            InitializeComponent();
            cargarPantallaReseñas();
            cargarReseñas();
            if (!Globales.usuarioActual.usuarioLogeado()) {
                panelHacerReseña.Visible = false;
            }
        }

        public void cargarReseñas() {
            panelPadre.Controls.Clear();
            List<Reseña> reseñas = ConexionBD.consultarReseñas();
            List<Usuario> usuarios = new List<Usuario>();
            List<Panel> paneles = new List<Panel>();


            foreach (Reseña reseña in reseñas) {
                usuarios.Add(ConexionBD.consultarUsuario(reseña.IdUsuario));
            }
            for (int i = 0; i < reseñas.Count; i++) {
                PanelReseña panel = new PanelReseña();
                panel.Name = "panel" + i;
                panel.LblNombre.Text = Regex.Match(usuarios[i].Nombres, @"^([\w\-]+)").Value;
                panel.LblComentario.Text = reseñas[i].Comentario;
                panel.Location = new Point(256, 0 + i * 196);
                panel.LblFecha.Text = reseñas[i].Fecha.ToString("dd/MM/yyyy");
                panel.IdResenia = reseñas[i].IdResenia;
                switch (reseñas[i].CantidadEstrellas) {
                    case 1:
                        panel.PbCantidadEstrellas.Image = Properties.Resources._1_estrellas;
                        break;
                    case 2:
                        panel.PbCantidadEstrellas.Image = Properties.Resources._2_estrellas;
                        break;
                    case 3:
                        panel.PbCantidadEstrellas.Image = Properties.Resources._3_estrellas;
                        break;
                    case 4:
                        panel.PbCantidadEstrellas.Image = Properties.Resources._4_estrellas;
                        break;
                    case 5:
                        panel.PbCantidadEstrellas.Image = Properties.Resources._5_estrellas;
                        break;
                }
                if(Globales.usuarioActual.Tipo != 'A') {     
                    panel.BtnEliminar.Visible = false;
                } else {
                    panel.Form = this;
                    panel.BtnEliminar.Paint += new PaintEventHandler(cortarEsquinas);
                }

                panel.Location = new Point((panelPadre.Width-panel.Width)/2, panel.Location.Y);
                paneles.Add(panel);
            }

            foreach (PanelReseña panel in paneles) {
                panel.Controls.SetChildIndex(panel.LblBarraInferior, 0);
                panel.Controls.SetChildIndex(panel.LblNombre, 1);
                panel.Controls.SetChildIndex(panel.LblComentario, 0);
                panel.LblComentario.SendToBack();
                panel.LblNombre.SendToBack();
                panel.LblBarraInferior.BringToFront();
                panel.LblBarraInferior2.BringToFront();
                panelPadre.Controls.Add(panel);

            }

            panelPadre.HorizontalScroll.Maximum = 0;
            panelPadre.AutoScroll = false;
            panelPadre.VerticalScroll.Visible = false;
            panelPadre.AutoScroll = true;
            centrarComponente(panelHacerReseña);

        }

        private class PanelReseña : Panel {
            private Label lblBarraInferior;
            private Label lblNombre;
            private PictureBox pbCantidadEstrellas;
            private Label lblComentario;
            private Label lblFecha;
            private Label lblBarraInferior2;
            private BotonPersonalizado btnEliminar;
            private int idResenia = -1;
            private FormReseña form;
            public PanelReseña() {
                lblComentario = new Label();
                lblFecha = new Label();
                lblBarraInferior = new Label();
                lblNombre = new Label();
                pbCantidadEstrellas = new PictureBox();
                lblBarraInferior2 = new Label();
                btnEliminar = new BotonPersonalizado();


                // pbCantidadEstrellas
                // 
                this.pbCantidadEstrellas.Image = Properties.Resources._0_estrellas;
                this.pbCantidadEstrellas.Location = new Point(0, 0);
                this.pbCantidadEstrellas.Name = "pbCantidadEstrellas";
                this.pbCantidadEstrellas.Size = new Size(83, 25);
                this.pbCantidadEstrellas.SizeMode = PictureBoxSizeMode.Normal;
                this.pbCantidadEstrellas.TabIndex = 0;
                this.pbCantidadEstrellas.TabStop = false;
                // 
                // lblNombre
                // 
                this.lblNombre.AutoSize = true;
                this.lblNombre.ForeColor = Globales.verdeFuerteLetra;
                this.lblNombre.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point);
                this.lblNombre.Location = new Point(0, pbCantidadEstrellas.Height);
                this.lblNombre.Name = "lblNombre";
                this.lblNombre.Size = new Size(122, 36);
                this.lblNombre.TabIndex = 0;
                this.lblNombre.Text = "Nombre";
                // 
                // lblFecha
                // 
                this.lblFecha.AutoSize = true;
                this.lblFecha.ForeColor = Color.Gray;
                this.lblFecha.Size = new Size(38, 15);
                this.lblFecha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.lblFecha.Location = new Point(lblNombre.Width+5, pbCantidadEstrellas.Height+(lblNombre.Height-lblFecha.Height)/2);
                this.lblFecha.Name = "lblFecha";
                this.lblFecha.TabIndex = 0;
                this.lblFecha.Text = "Fecha";

                // lblBarraInferior
                // 
                this.lblBarraInferior.BackColor = Globales.grisClaro;
                this.lblBarraInferior.Location = new Point(0, lblNombre.Location.Y+lblNombre.Height);
                this.lblBarraInferior.Name = "lblBarraInferior";
                this.lblBarraInferior.Size = new Size(lblNombre.Width, 1);
                this.lblBarraInferior.TabIndex = 0;

                // 
                //lblComentario
                this.lblComentario.Location = new Point(0, lblNombre.Location.Y+lblNombre.Height+5);
                this.lblComentario.Name = "lblComentario";
                this.lblComentario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.lblComentario.Size = new Size(512, 60);
                this.lblComentario.TabIndex = 0;
                this.lblComentario.Text = "Comentario";


                this.lblBarraInferior2.BackColor = Globales.grisClaro;
                this.lblBarraInferior2.Location = new Point(0, lblComentario.Location.Y+lblComentario.Height);
                this.lblBarraInferior2.Name = "lblBarraInferior2";
                this.lblBarraInferior2.Size = new Size(512, 4);

                // btnEliminar
                // 
                this.btnEliminar.BackColor =Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
                this.btnEliminar.FlatAppearance.BorderSize = 0;
                this.btnEliminar.FlatStyle = FlatStyle.Flat;
                this.btnEliminar.ForeColor = Color.White;
                this.btnEliminar.Location = new Point(lblComentario.Location.X + lblComentario.Width - btnEliminar.Width, lblComentario.Location.Y);
                this.btnEliminar.Name = "btnEliminar";
                this.btnEliminar.Size = new Size(75, 23);
                this.btnEliminar.TabIndex = 0;
                this.btnEliminar.Text = "Eliminar";
                this.btnEliminar.UseVisualStyleBackColor = false;
                this.btnEliminar.Click += new EventHandler(btnEliminarReseña_Click);


                this.Controls.Add(this.pbCantidadEstrellas);
                this.Controls.Add(this.lblNombre);
                this.Controls.Add(this.lblFecha);
                this.Controls.Add(this.lblBarraInferior);
                this.Controls.Add(this.lblComentario);
                this.Controls.Add(this.lblBarraInferior2);
                this.Controls.Add(this.btnEliminar);
                this.Location = new Point(0, 0);
                this.Size = new Size(512, 200);
                this.Visible = true;
            }
            private void btnEliminarReseña_Click(object sender, EventArgs e) {
                try { 
                    ConexionBD.eliminarReseña(idResenia);
                    MessageBox.Show("Eliminado con éxito");
                    if(form is not null) {
                        form.cargarReseñas();
                    }
                } catch (Exception ex) {
                    ConexionBD.manejarErrores(ex);
                }

            }
            public Label LblBarraInferior { get => lblBarraInferior; set => lblBarraInferior = value; }
            public Label LblNombre { get => lblNombre; set => lblNombre = value; }
            public PictureBox PbCantidadEstrellas { get => pbCantidadEstrellas; set => pbCantidadEstrellas = value; }
            public Label LblComentario { get => lblComentario; set => lblComentario = value; }
            public Label LblFecha { get => lblFecha; set => lblFecha = value; }
            public Label LblBarraInferior2 { get => lblBarraInferior2; set => lblBarraInferior2 = value; }
            public BotonPersonalizado BtnEliminar { get => btnEliminar; set => btnEliminar = value; }
            public int IdResenia { get => idResenia; set => idResenia = value; }
            public FormReseña Form { get => form; set => form = value; }
        }

        private void btnHacerReseña_Click(object sender, EventArgs e) {
            FormValoracion formValoracion = new FormValoracion();
            Globales.reseñaSeleccionada = new Reseña();
            Globales.reseñaSeleccionada.Comentario = txtReseña.Text;
            Globales.reseñaSeleccionada.CantidadEstrellas = 1;
            if (formValoracion.ShowDialog() == DialogResult.OK) {
                FormReseña formReseña = new FormReseña();
                Globales.transition();
                this.Close();
                formReseña.Show();
            }
        }

    }
}
