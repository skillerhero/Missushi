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
            this.cbHoraInicio = new System.Windows.Forms.ComboBox();
            this.nudCantidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.btnElegirZona = new System.Windows.Forms.Button();
            this.lblZona = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(297, 361);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(205, 23);
            this.btnHacerReservacion.TabIndex = 4;
            this.btnHacerReservacion.Text = "Hacer reservación";
            this.btnHacerReservacion.UseVisualStyleBackColor = true;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(190, 142);
            this.dpFechaInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpFechaInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(227, 23);
            this.dpFechaInicio.TabIndex = 0;
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.Location = new System.Drawing.Point(437, 142);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(121, 23);
            this.cbHoraInicio.TabIndex = 1;
            // 
            // nudCantidadPersonas
            // 
            this.nudCantidadPersonas.Location = new System.Drawing.Point(297, 199);
            this.nudCantidadPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadPersonas.Name = "nudCantidadPersonas";
            this.nudCantidadPersonas.Size = new System.Drawing.Size(120, 23);
            this.nudCantidadPersonas.TabIndex = 2;
            this.nudCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Location = new System.Drawing.Point(99, 145);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(76, 15);
            this.lblFechaYHora.TabIndex = 0;
            this.lblFechaYHora.Text = "Fecha y Hora";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(99, 207);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(121, 15);
            this.lblCantidadPersonas.TabIndex = 0;
            this.lblCantidadPersonas.Text = "Cantidad de personas";
            // 
            // btnElegirZona
            // 
            this.btnElegirZona.Location = new System.Drawing.Point(316, 274);
            this.btnElegirZona.Name = "btnElegirZona";
            this.btnElegirZona.Size = new System.Drawing.Size(75, 23);
            this.btnElegirZona.TabIndex = 3;
            this.btnElegirZona.Text = "Elegir Zona";
            this.btnElegirZona.UseVisualStyleBackColor = true;
            this.btnElegirZona.Click += new System.EventHandler(this.btnElegirZona_Click);
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(141, 278);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(34, 15);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "Zona";
            // 
            // FormReservacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.btnElegirZona);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.lblFechaYHora);
            this.Controls.Add(this.nudCantidadPersonas);
            this.Controls.Add(this.cbHoraInicio);
            this.Controls.Add(this.dpFechaInicio);
            this.Controls.Add(this.btnHacerReservacion);
            this.Name = "FormReservacionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservacionCliente";
            this.Load += new System.EventHandler(this.FormReservacionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHacerReservacion;
        private DateTimePicker dpFechaInicio;
        private ComboBox cbHoraInicio;
        private NumericUpDown nudCantidadPersonas;
        private Label lblFechaYHora;
        private Label lblCantidadPersonas;
        private Button btnElegirZona;
        private Label lblZona;
    }
}