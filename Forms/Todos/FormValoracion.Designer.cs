namespace Missushi.Forms.Cliente {
    partial class FormValoracion {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValoracion));
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new Missushi.Forms.LabelPersonalizado();
            this.pbEstrella1 = new System.Windows.Forms.PictureBox();
            this.pbEstrella2 = new System.Windows.Forms.PictureBox();
            this.pbEstrella3 = new System.Windows.Forms.PictureBox();
            this.pbEstrella4 = new System.Windows.Forms.PictureBox();
            this.pbEstrella5 = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new Missushi.Forms.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarraTitulo
            // 
            this.lblBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
            this.lblBarraTitulo.Location = new System.Drawing.Point(181, 52);
            this.lblBarraTitulo.Name = "lblBarraTitulo";
            this.lblBarraTitulo.Size = new System.Drawing.Size(149, 7);
            this.lblBarraTitulo.TabIndex = 1;
            this.lblBarraTitulo.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(181, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 68);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Valoración";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Visible = false;
            // 
            // pbEstrella1
            // 
            this.pbEstrella1.Image = global::Missushi.Properties.Resources.estrella_rellena1;
            this.pbEstrella1.Location = new System.Drawing.Point(119, 105);
            this.pbEstrella1.Name = "pbEstrella1";
            this.pbEstrella1.Size = new System.Drawing.Size(50, 50);
            this.pbEstrella1.TabIndex = 3;
            this.pbEstrella1.TabStop = false;
            this.pbEstrella1.Click += new System.EventHandler(this.pbEstrella1_Click);
            // 
            // pbEstrella2
            // 
            this.pbEstrella2.Image = global::Missushi.Properties.Resources.estrella_vacia;
            this.pbEstrella2.Location = new System.Drawing.Point(175, 105);
            this.pbEstrella2.Name = "pbEstrella2";
            this.pbEstrella2.Size = new System.Drawing.Size(50, 50);
            this.pbEstrella2.TabIndex = 4;
            this.pbEstrella2.TabStop = false;
            this.pbEstrella2.Click += new System.EventHandler(this.pbEstrella2_Click);
            // 
            // pbEstrella3
            // 
            this.pbEstrella3.Image = global::Missushi.Properties.Resources.estrella_vacia;
            this.pbEstrella3.Location = new System.Drawing.Point(231, 105);
            this.pbEstrella3.Name = "pbEstrella3";
            this.pbEstrella3.Size = new System.Drawing.Size(50, 50);
            this.pbEstrella3.TabIndex = 5;
            this.pbEstrella3.TabStop = false;
            this.pbEstrella3.Click += new System.EventHandler(this.pbEstrella3_Click);
            // 
            // pbEstrella4
            // 
            this.pbEstrella4.Image = global::Missushi.Properties.Resources.estrella_vacia;
            this.pbEstrella4.Location = new System.Drawing.Point(287, 105);
            this.pbEstrella4.Name = "pbEstrella4";
            this.pbEstrella4.Size = new System.Drawing.Size(50, 50);
            this.pbEstrella4.TabIndex = 6;
            this.pbEstrella4.TabStop = false;
            this.pbEstrella4.Click += new System.EventHandler(this.pbEstrella4_Click);
            // 
            // pbEstrella5
            // 
            this.pbEstrella5.Image = global::Missushi.Properties.Resources.estrella_vacia;
            this.pbEstrella5.Location = new System.Drawing.Point(343, 105);
            this.pbEstrella5.Name = "pbEstrella5";
            this.pbEstrella5.Size = new System.Drawing.Size(50, 50);
            this.pbEstrella5.TabIndex = 7;
            this.pbEstrella5.TabStop = false;
            this.pbEstrella5.Click += new System.EventHandler(this.pbEstrella5_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(206, 184);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 43);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.btnEnviar.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // FormValoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pbEstrella5);
            this.Controls.Add(this.pbEstrella4);
            this.Controls.Add(this.pbEstrella3);
            this.Controls.Add(this.pbEstrella2);
            this.Controls.Add(this.pbEstrella1);
            this.Controls.Add(this.lblBarraTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormValoracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missushi - Valoración";
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstrella5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Label lblBarraTitulo;
        private LabelPersonalizado lblTitulo;
        private PictureBox pbEstrella1;
        private PictureBox pbEstrella2;
        private PictureBox pbEstrella3;
        private PictureBox pbEstrella4;
        private PictureBox pbEstrella5;
        private BotonPersonalizado btnEnviar;
    }
}