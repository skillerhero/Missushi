using Missushi.Clases;

namespace Missushi.Forms.Cliente {
    partial class FormReseña {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelPadre = new System.Windows.Forms.Panel();
            this.panelReseñas = new System.Windows.Forms.Panel();
            this.lblBarraInferior2 = new System.Windows.Forms.Label();
            this.lblBarraInferior = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbCantidadEstrellas = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.panelHacerReseña = new System.Windows.Forms.Panel();
            this.lblBarraInferiorReseña = new Missushi.Forms.SelectableLabel();
            this.pbHacerReseña = new System.Windows.Forms.PictureBox();
            this.txtReseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panelPadre.SuspendLayout();
            this.panelReseñas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidadEstrellas)).BeginInit();
            this.panelHacerReseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHacerReseña)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPadre
            // 
            this.panelPadre.Controls.Add(this.panelReseñas);
            this.panelPadre.Location = new System.Drawing.Point(0, 135);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(1024, 465);
            this.panelPadre.TabIndex = 0;
            // 
            // panelReseñas
            // 
            this.panelReseñas.Controls.Add(this.lblBarraInferior2);
            this.panelReseñas.Controls.Add(this.lblBarraInferior);
            this.panelReseñas.Controls.Add(this.lblFecha);
            this.panelReseñas.Controls.Add(this.pbCantidadEstrellas);
            this.panelReseñas.Controls.Add(this.lblNombre);
            this.panelReseñas.Controls.Add(this.lblComentario);
            this.panelReseñas.Location = new System.Drawing.Point(0, 0);
            this.panelReseñas.Name = "panelReseñas";
            this.panelReseñas.Size = new System.Drawing.Size(1024, 472);
            this.panelReseñas.TabIndex = 0;
            this.panelReseñas.Visible = false;
            // 
            // lblBarraInferior2
            // 
            this.lblBarraInferior2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
            this.lblBarraInferior2.Location = new System.Drawing.Point(0, 170);
            this.lblBarraInferior2.Name = "lblBarraInferior2";
            this.lblBarraInferior2.Size = new System.Drawing.Size(100, 5);
            this.lblBarraInferior2.TabIndex = 0;
            // 
            // lblBarraInferior
            // 
            this.lblBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
            this.lblBarraInferior.Location = new System.Drawing.Point(0, 138);
            this.lblBarraInferior.Name = "lblBarraInferior";
            this.lblBarraInferior.Size = new System.Drawing.Size(100, 5);
            this.lblBarraInferior.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(95, 115);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // pbCantidadEstrellas
            // 
            this.pbCantidadEstrellas.Image = global::Missushi.Properties.Resources._0_estrellas;
            this.pbCantidadEstrellas.Location = new System.Drawing.Point(0, 74);
            this.pbCantidadEstrellas.Name = "pbCantidadEstrellas";
            this.pbCantidadEstrellas.Size = new System.Drawing.Size(83, 25);
            this.pbCantidadEstrellas.TabIndex = 0;
            this.pbCantidadEstrellas.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(0, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 45);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblComentario
            // 
            this.lblComentario.Location = new System.Drawing.Point(0, 147);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(852, 31);
            this.lblComentario.TabIndex = 0;
            this.lblComentario.Text = "Comentario";
            // 
            // panelHacerReseña
            // 
            this.panelHacerReseña.Controls.Add(this.lblBarraInferiorReseña);
            this.panelHacerReseña.Controls.Add(this.pbHacerReseña);
            this.panelHacerReseña.Controls.Add(this.txtReseña);
            this.panelHacerReseña.Location = new System.Drawing.Point(0, 521);
            this.panelHacerReseña.Name = "panelHacerReseña";
            this.panelHacerReseña.Size = new System.Drawing.Size(512, 44);
            this.panelHacerReseña.TabIndex = 0;
            // 
            // lblBarraInferiorReseña
            // 
            this.lblBarraInferiorReseña.BackColor = System.Drawing.Color.LightGray;
            this.lblBarraInferiorReseña.Location = new System.Drawing.Point(0, 22);
            this.lblBarraInferiorReseña.Name = "lblBarraInferiorReseña";
            this.lblBarraInferiorReseña.Size = new System.Drawing.Size(512, 1);
            this.lblBarraInferiorReseña.TabIndex = 1;
            this.lblBarraInferiorReseña.TabStop = true;
            // 
            // pbHacerReseña
            // 
            this.pbHacerReseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHacerReseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHacerReseña.Image = global::Missushi.Properties.Resources.Cerrar;
            this.pbHacerReseña.Location = new System.Drawing.Point(494, 8);
            this.pbHacerReseña.Name = "pbHacerReseña";
            this.pbHacerReseña.Size = new System.Drawing.Size(15, 15);
            this.pbHacerReseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHacerReseña.TabIndex = 0;
            this.pbHacerReseña.TabStop = false;
            this.pbHacerReseña.Click += new System.EventHandler(this.pbHacerReseña_Click);
            // 
            // txtReseña
            // 
            this.txtReseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReseña.Location = new System.Drawing.Point(0, 0);
            this.txtReseña.Name = "txtReseña";
            this.txtReseña.PlaceholderText = "Escribe tu reseña...";
            this.txtReseña.Size = new System.Drawing.Size(512, 19);
            this.txtReseña.TabIndex = 2;
            // 
            // FormReseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelHacerReseña);
            this.Controls.Add(this.panelPadre);
            this.Name = "FormReseña";
            this.Text = "FormReseña";
            this.Controls.SetChildIndex(this.panelPadre, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panelHacerReseña, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.panelPadre.ResumeLayout(false);
            this.panelReseñas.ResumeLayout(false);
            this.panelReseñas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidadEstrellas)).EndInit();
            this.panelHacerReseña.ResumeLayout(false);
            this.panelHacerReseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHacerReseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelPadre;
        private Panel panelReseñas;
        private Label lblBarraInferior;
        private Label lblBarraInferior2;
        private Label lblComentario;
        private Label lblFecha;
        private PictureBox pbCantidadEstrellas;
        private Label lblNombre;
        private Panel panelHacerReseña;
        private TextBox txtReseña;
        private PictureBox pbHacerReseña;
        private SelectableLabel lblBarraInferiorReseña;
    }
}