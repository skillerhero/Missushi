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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReseña));
            this.panelPadre = new System.Windows.Forms.Panel();
            this.panelReseñas = new System.Windows.Forms.Panel();
            this.btnEliminar = new Missushi.Forms.BotonPersonalizado();
            this.lblBarraInferior2 = new System.Windows.Forms.Label();
            this.lblBarraInferior = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbCantidadEstrellas = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.panelHacerReseña = new System.Windows.Forms.Panel();
            this.btnHacerReseña = new System.Windows.Forms.Button();
            this.lblBarraInferiorReseña = new Missushi.Forms.SelectableLabel();
            this.txtReseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panelPadre.SuspendLayout();
            this.panelReseñas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCantidadEstrellas)).BeginInit();
            this.panelHacerReseña.SuspendLayout();
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
            this.panelReseñas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReseñas.Controls.Add(this.btnEliminar);
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(770, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
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
            this.panelHacerReseña.Controls.Add(this.btnHacerReseña);
            this.panelHacerReseña.Controls.Add(this.lblBarraInferiorReseña);
            this.panelHacerReseña.Controls.Add(this.txtReseña);
            this.panelHacerReseña.Location = new System.Drawing.Point(0, 521);
            this.panelHacerReseña.Name = "panelHacerReseña";
            this.panelHacerReseña.Size = new System.Drawing.Size(512, 44);
            this.panelHacerReseña.TabIndex = 0;
            // 
            // btnHacerReseña
            // 
            this.btnHacerReseña.BackColor = System.Drawing.SystemColors.Window;
            this.btnHacerReseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHacerReseña.BackgroundImage")));
            this.btnHacerReseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHacerReseña.FlatAppearance.BorderSize = 0;
            this.btnHacerReseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerReseña.Location = new System.Drawing.Point(494, 8);
            this.btnHacerReseña.Name = "btnHacerReseña";
            this.btnHacerReseña.Size = new System.Drawing.Size(15, 15);
            this.btnHacerReseña.TabIndex = 3;
            this.btnHacerReseña.UseVisualStyleBackColor = false;
            this.btnHacerReseña.Click += new System.EventHandler(this.btnHacerReseña_Click);
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
            this.AcceptButton = this.btnHacerReseña;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelHacerReseña);
            this.Controls.Add(this.panelPadre);
            this.Name = "FormReseña";
            this.Text = "Missushi - Reseñas";
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
        private SelectableLabel lblBarraInferiorReseña;
        private Button btnHacerReseña;
        private BotonPersonalizado btnEliminar;
    }
}