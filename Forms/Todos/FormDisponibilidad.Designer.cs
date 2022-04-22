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
            this.pbMapaZonas = new Missushi.Forms.PictureBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapaZonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHora
            // 
            this.dtHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtHora.FormattingEnabled = true;
            this.dtHora.Location = new System.Drawing.Point(425, 91);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(121, 23);
            this.dtHora.TabIndex = 1;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(184, 91);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(235, 23);
            this.dtFecha.TabIndex = 2;
            // 
            // pbMapaZonas
            // 
            this.pbMapaZonas.BackColor = System.Drawing.Color.White;
            this.pbMapaZonas.Location = new System.Drawing.Point(62, 135);
            this.pbMapaZonas.Name = "pbMapaZonas";
            this.pbMapaZonas.Size = new System.Drawing.Size(100, 50);
            this.pbMapaZonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapaZonas.TabIndex = 0;
            this.pbMapaZonas.TabStop = false;
            this.pbMapaZonas.WaitOnLoad = true;
            // 
            // FormDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.pbMapaZonas);
            this.Name = "FormDisponibilidad";
            this.Text = "FormDisponibilidad";
            this.Load += new System.EventHandler(this.FormDisponibilidad_Load);
            this.Controls.SetChildIndex(this.pbMapaZonas, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.dtHora, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbMapaZonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBoxPersonalizado dtHora;
        private DateTimePickerPersonalizado dtFecha;
        private PictureBoxPersonalizado pbMapaZonas;
    }
}