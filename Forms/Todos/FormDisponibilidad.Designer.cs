namespace Missushi.Forms.Todos {
    partial class FormDisponibilidad {
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
            this.dtHora = new Missushi.Forms.ComboBoxPersonalizado();
            this.dtFecha = new Missushi.Forms.DateTimePickerPersonalizado();
            this.pbMapa = new Missushi.Forms.PictureBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHora
            // 
            this.dtHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtHora.FormattingEnabled = true;
            this.dtHora.Location = new System.Drawing.Point(458, 80);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(121, 23);
            this.dtHora.TabIndex = 1;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(171, 77);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(235, 23);
            this.dtFecha.TabIndex = 2;
            // 
            // pbMapa
            // 
            this.pbMapa.BackColor = System.Drawing.Color.White;
            this.pbMapa.Location = new System.Drawing.Point(59, 151);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(100, 50);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            // 
            // FormDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 414);
            this.Controls.Add(this.pbMapa);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.dtHora);
            this.Name = "FormDisponibilidad";
            this.Text = "FormDisponibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBoxPersonalizado dtHora;
        private DateTimePickerPersonalizado dtFecha;
        private PictureBoxPersonalizado pbMapa;
    }
}