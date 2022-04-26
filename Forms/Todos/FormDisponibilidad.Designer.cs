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
            this.cbHora = new Missushi.Forms.ComboBoxPersonalizado();
            this.dtFecha = new Missushi.Forms.DateTimePickerPersonalizado();
            this.pbMapaZonas = new Missushi.Forms.PictureBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapaZonas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHora
            // 
            this.cbHora.BackColor = System.Drawing.SystemColors.Window;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(813, 84);
            this.cbHora.MinimumSize = new System.Drawing.Size(155, 0);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(155, 31);
            this.cbHora.TabIndex = 1;
            this.cbHora.SelectedIndexChanged += new System.EventHandler(this.cbHora_SelectedIndexChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFecha.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtFecha.Location = new System.Drawing.Point(485, 84);
            this.dtFecha.MinimumSize = new System.Drawing.Size(307, 32);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(307, 32);
            this.dtFecha.TabIndex = 2;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // pbMapaZonas
            // 
            this.pbMapaZonas.BackColor = System.Drawing.Color.White;
            this.pbMapaZonas.Location = new System.Drawing.Point(43, 148);
            this.pbMapaZonas.Name = "pbMapaZonas";
            this.pbMapaZonas.Size = new System.Drawing.Size(387, 494);
            this.pbMapaZonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapaZonas.TabIndex = 0;
            this.pbMapaZonas.TabStop = false;
            this.pbMapaZonas.WaitOnLoad = true;
            this.pbMapaZonas.Cursor = Cursors.Default;
            // 
            // FormDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.pbMapaZonas);
            this.Name = "FormDisponibilidad";
            this.Text = "Missushi - Disponibilidad";
            this.Load += new System.EventHandler(this.FormDisponibilidad_Load);
            this.Shown += new System.EventHandler(this.FormDisponibilidad_Shown);
            this.HandleCreated += new System.EventHandler(this.mostrarPantallaDeCarga);
            this.Controls.SetChildIndex(this.pbMapaZonas, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.cbHora, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbMapaZonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBoxPersonalizado cbHora;
        private DateTimePickerPersonalizado dtFecha;
        private PictureBoxPersonalizado pbMapaZonas;
    }
}