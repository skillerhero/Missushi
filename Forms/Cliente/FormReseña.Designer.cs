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
            this.panelReseñas = new System.Windows.Forms.Panel();
            this.lblBarraInferior = new System.Windows.Forms.Label();
            this.lblBarraInferior2 = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbCantidadEstrellas = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panelReseñas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidadEstrellas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReseñas
            // 
            this.panelReseñas.Controls.Add(this.lblBarraInferior);
            this.panelReseñas.Controls.Add(this.lblBarraInferior2);
            this.panelReseñas.Controls.Add(this.lblComentario);
            this.panelReseñas.Controls.Add(this.lblFecha);
            this.panelReseñas.Controls.Add(this.pbCantidadEstrellas);
            this.panelReseñas.Controls.Add(this.lblNombre);
            this.panelReseñas.Location = new System.Drawing.Point(62, 135);
            this.panelReseñas.Name = "panelReseñas";
            this.panelReseñas.Size = new System.Drawing.Size(512, 196);
            this.panelReseñas.TabIndex = 2;
            this.panelReseñas.Visible = false;
            // 
            // lblBarraInferior
            // 
            this.lblBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
            this.lblBarraInferior.Location = new System.Drawing.Point(31, 138);
            this.lblBarraInferior.Name = "lblBarraInferior";
            this.lblBarraInferior.Size = new System.Drawing.Size(100, 5);
            this.lblBarraInferior.TabIndex = 2;
            // 
            // lblBarraInferior2
            // 
            this.lblBarraInferior2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
            this.lblBarraInferior2.Location = new System.Drawing.Point(26, 170);
            this.lblBarraInferior2.Name = "lblBarraInferior2";
            this.lblBarraInferior2.Size = new System.Drawing.Size(100, 5);
            this.lblBarraInferior2.TabIndex = 5;
            // 
            // lblComentario
            // 
            this.lblComentario.Location = new System.Drawing.Point(26, 153);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(852, 31);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Comentario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(142, 113);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 21);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // pbCantidadEstrellas
            // 
            this.pbCantidadEstrellas.Image = global::Missushi.Properties.Resources._0_estrellas;
            this.pbCantidadEstrellas.Location = new System.Drawing.Point(26, 74);
            this.pbCantidadEstrellas.Name = "pbCantidadEstrellas";
            this.pbCantidadEstrellas.Size = new System.Drawing.Size(83, 25);
            this.pbCantidadEstrellas.TabIndex = 0;
            this.pbCantidadEstrellas.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(36, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 45);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // FormReseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelReseñas);
            this.Name = "FormReseña";
            this.Text = "FormReseña";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panelReseñas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.panelReseñas.ResumeLayout(false);
            this.panelReseñas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidadEstrellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelReseñas;
        private Label lblBarraInferior;
        private Label lblNombre;
        private PictureBox pbCantidadEstrellas;
        private Label lblComentario;
        private Label lblFecha;
        private Label lblBarraInferior2;
    }
}