namespace Missushi.Forms.Cliente {
    partial class FormReservacionCliente {
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
            this.btnHacerReservacion = new System.Windows.Forms.Button();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.cbHoraInicio = new System.Windows.Forms.ComboBox();
            this.cbHoraFin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(348, 318);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(205, 23);
            this.btnHacerReservacion.TabIndex = 0;
            this.btnHacerReservacion.Text = "Hacer reservación";
            this.btnHacerReservacion.UseVisualStyleBackColor = true;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(258, 136);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(227, 23);
            this.dpFechaInicio.TabIndex = 1;
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.Location = new System.Drawing.Point(349, 194);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(200, 23);
            this.dpFechaFin.TabIndex = 2;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(365, 257);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 23);
            this.domainUpDown1.TabIndex = 3;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.Location = new System.Drawing.Point(639, 129);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(121, 23);
            this.cbHoraInicio.TabIndex = 4;
            // 
            // cbHoraFin
            // 
            this.cbHoraFin.FormattingEnabled = true;
            this.cbHoraFin.Location = new System.Drawing.Point(663, 204);
            this.cbHoraFin.Name = "cbHoraFin";
            this.cbHoraFin.Size = new System.Drawing.Size(121, 23);
            this.cbHoraFin.TabIndex = 5;
            // 
            // FormReservacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbHoraFin);
            this.Controls.Add(this.cbHoraInicio);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.dpFechaFin);
            this.Controls.Add(this.dpFechaInicio);
            this.Controls.Add(this.btnHacerReservacion);
            this.Name = "FormReservacionCliente";
            this.Text = "FormReservacionCliente";
            this.Load += new System.EventHandler(this.FormReservacionCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHacerReservacion;
        private DateTimePicker dpFechaInicio;
        private DateTimePicker dpFechaFin;
        private DomainUpDown domainUpDown1;
        private ComboBox cbHoraInicio;
        private ComboBox cbHoraFin;
    }
}