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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZona = new System.Windows.Forms.Label();
            this.btnElegirZona = new System.Windows.Forms.Button();
            this.nudCantidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.btnHacerReservacion = new System.Windows.Forms.Button();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbHoraInicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblZona);
            this.panel1.Controls.Add(this.btnElegirZona);
            this.panel1.Controls.Add(this.nudCantidadPersonas);
            this.panel1.Controls.Add(this.lblCantidadPersonas);
            this.panel1.Controls.Add(this.btnHacerReservacion);
            this.panel1.Controls.Add(this.lblFechaYHora);
            this.panel1.Controls.Add(this.dpFechaInicio);
            this.panel1.Controls.Add(this.cbHoraInicio);
            this.panel1.Location = new System.Drawing.Point(95, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 365);
            this.panel1.TabIndex = 6;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(153, 167);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(34, 15);
            this.lblZona.TabIndex = 21;
            this.lblZona.Text = "Zona";
            // 
            // btnElegirZona
            // 
            this.btnElegirZona.Location = new System.Drawing.Point(328, 163);
            this.btnElegirZona.Name = "btnElegirZona";
            this.btnElegirZona.Size = new System.Drawing.Size(75, 23);
            this.btnElegirZona.TabIndex = 26;
            this.btnElegirZona.Text = "Elegir Zona";
            this.btnElegirZona.UseVisualStyleBackColor = true;
            this.btnElegirZona.Click += new System.EventHandler(this.btnElegirZona_Click);
            // 
            // nudCantidadPersonas
            // 
            this.nudCantidadPersonas.Location = new System.Drawing.Point(314, 217);
            this.nudCantidadPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadPersonas.Name = "nudCantidadPersonas";
            this.nudCantidadPersonas.Size = new System.Drawing.Size(120, 23);
            this.nudCantidadPersonas.TabIndex = 27;
            this.nudCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(116, 225);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(121, 15);
            this.lblCantidadPersonas.TabIndex = 22;
            this.lblCantidadPersonas.Text = "Cantidad de personas";
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(298, 311);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(205, 23);
            this.btnHacerReservacion.TabIndex = 28;
            this.btnHacerReservacion.Text = "Hacer reservación";
            this.btnHacerReservacion.UseVisualStyleBackColor = true;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Location = new System.Drawing.Point(100, 95);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(76, 15);
            this.lblFechaYHora.TabIndex = 23;
            this.lblFechaYHora.Text = "Fecha y Hora";
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(191, 92);
            this.dpFechaInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpFechaInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(227, 23);
            this.dpFechaInicio.TabIndex = 24;
            this.dpFechaInicio.ValueChanged += new System.EventHandler(this.dpFechaInicio_ValueChanged);
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.Location = new System.Drawing.Point(438, 92);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(121, 23);
            this.cbHoraInicio.TabIndex = 25;
            this.cbHoraInicio.SelectedIndexChanged += new System.EventHandler(this.cbHoraInicio_SelectedIndexChanged);
            // 
            // FormReservacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormReservacionCliente";
            this.Text = "FormReservacionCliente";
            this.Load += new System.EventHandler(this.FormReservacionCliente_Load);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblZona;
        private Button btnElegirZona;
        private NumericUpDown nudCantidadPersonas;
        private Label lblCantidadPersonas;
        private Button btnHacerReservacion;
        private Label lblFechaYHora;
        private DateTimePicker dpFechaInicio;
        private ComboBox cbHoraInicio;
    }
}