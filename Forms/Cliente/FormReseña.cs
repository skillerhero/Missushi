using System.Text.RegularExpressions;
using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi.Forms.Cliente {
    public partial class FormReseña : FormDiseño {
        public FormReseña() {
            InitializeComponent();
            cargarPantallaReseñas();
            cargarReseñas();
        }
        private void cargarReseñas() {
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
                panel.Location = new Point(100, 100 + i * 196);
                panel.LblFecha.Text = reseñas[i].Fecha.ToString("dd/MM/yyyy");
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

                paneles.Add(panel);
            }

            foreach (PanelReseña panel in paneles) {
                this.Controls.Add(panel);
            }
        }

        private class PanelReseña : Panel {
            private Label lblBarraInferior;
            private Label lblNombre;
            private PictureBox pbCantidadEstrellas;
            private Label lblComentario;
            private Label lblFecha;

            public PanelReseña() {
                lblComentario = new Label();
                lblFecha = new Label();
                lblBarraInferior = new Label();
                lblNombre = new Label();
                pbCantidadEstrellas = new PictureBox();

                this.lblComentario.Location = new Point(26, 153);
                this.lblComentario.Name = "lblComentario";
                this.lblComentario.Size = new Size(852, 31);
                this.lblComentario.TabIndex = 0;
                this.lblComentario.Text = "Comentario";
                // 
                // lblFecha
                // 
                this.lblFecha.AutoSize = true;
                this.lblFecha.Location = new Point(146, 122);
                this.lblFecha.Name = "lblFecha";
                this.lblFecha.Size = new Size(38, 15);
                this.lblFecha.TabIndex = 0;
                this.lblFecha.Text = "Fecha";
                // 
                // lblBarraInferior
                // 
                this.lblBarraInferior.BackColor = Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
                this.lblBarraInferior.Location = new Point(31, 138);
                this.lblBarraInferior.Name = "lblBarraInferior";
                this.lblBarraInferior.Size = new Size(100, 5);
                this.lblBarraInferior.TabIndex = 0;
                // 
                // lblNombre
                // 
                this.lblNombre.AutoSize = true;
                this.lblNombre.Location = new Point(26, 122);
                this.lblNombre.Name = "lblNombre";
                this.lblNombre.Size = new Size(51, 15);
                this.lblNombre.TabIndex = 0;
                this.lblNombre.Text = "Nombre";
                // 
                // pbCantidadEstrellas
                // 
                this.pbCantidadEstrellas.Image = Properties.Resources._0_estrellas;
                this.pbCantidadEstrellas.Location = new Point(17, 53);
                this.pbCantidadEstrellas.Name = "pbCantidadEstrellas";
                this.pbCantidadEstrellas.Size = new Size(126, 106);
                this.pbCantidadEstrellas.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pbCantidadEstrellas.TabIndex = 0;
                this.pbCantidadEstrellas.TabStop = false;

                this.Controls.Add(this.lblComentario);
                this.Controls.Add(this.lblFecha);
                this.Controls.Add(this.lblBarraInferior);
                this.Controls.Add(this.lblNombre);
                this.Controls.Add(this.pbCantidadEstrellas);
                this.Size = new Size(900, 196);
                this.Visible = true;
            }

            public Label LblBarraInferior { get => lblBarraInferior; set => lblBarraInferior = value; }
            public Label LblNombre { get => lblNombre; set => lblNombre = value; }
            public PictureBox PbCantidadEstrellas { get => pbCantidadEstrellas; set => pbCantidadEstrellas = value; }
            public Label LblComentario { get => lblComentario; set => lblComentario = value; }
            public Label LblFecha { get => lblFecha; set => lblFecha = value; }
        }
    }
}
