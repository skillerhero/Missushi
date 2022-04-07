namespace Missushi.Forms.Administrador {
    partial class FormHacerReservacionAdministrador {
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
            this.lblZona = new System.Windows.Forms.Label();
            this.btnElegirZona = new System.Windows.Forms.Button();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.nudCantidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.cbHoraInicio = new System.Windows.Forms.ComboBox();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnHacerReservacion = new System.Windows.Forms.Button();
            this.btnElegirUsuario = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(159, 167);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(34, 15);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "Zona";
            // 
            // btnElegirZona
            // 
            this.btnElegirZona.Location = new System.Drawing.Point(334, 163);
            this.btnElegirZona.Name = "btnElegirZona";
            this.btnElegirZona.Size = new System.Drawing.Size(75, 23);
            this.btnElegirZona.TabIndex = 3;
            this.btnElegirZona.Text = "Elegir Zona";
            this.btnElegirZona.UseVisualStyleBackColor = true;
            this.btnElegirZona.Click += new System.EventHandler(this.btnElegirZona_Click);
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(122, 225);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(121, 15);
            this.lblCantidadPersonas.TabIndex = 0;
            this.lblCantidadPersonas.Text = "Cantidad de personas";
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Location = new System.Drawing.Point(106, 95);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(76, 15);
            this.lblFechaYHora.TabIndex = 0;
            this.lblFechaYHora.Text = "Fecha y Hora";
            // 
            // nudCantidadPersonas
            // 
            this.nudCantidadPersonas.Location = new System.Drawing.Point(320, 217);
            this.nudCantidadPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadPersonas.Name = "nudCantidadPersonas";
            this.nudCantidadPersonas.Size = new System.Drawing.Size(120, 23);
            this.nudCantidadPersonas.TabIndex = 4;
            this.nudCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.Location = new System.Drawing.Point(444, 92);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(121, 23);
            this.cbHoraInicio.TabIndex = 2;
            this.cbHoraInicio.SelectedIndexChanged += new System.EventHandler(this.cbHoraInicio_SelectedIndexChanged);
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(197, 92);
            this.dpFechaInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpFechaInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(227, 23);
            this.dpFechaInicio.TabIndex = 1;
            this.dpFechaInicio.ValueChanged += new System.EventHandler(this.dpFechaInicio_ValueChanged);
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(271, 328);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(205, 23);
            this.btnHacerReservacion.TabIndex = 6;
            this.btnHacerReservacion.Text = "Hacer reservación";
            this.btnHacerReservacion.UseVisualStyleBackColor = true;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            // 
            // btnElegirUsuario
            // 
            this.btnElegirUsuario.Location = new System.Drawing.Point(334, 278);
            this.btnElegirUsuario.Name = "btnElegirUsuario";
            this.btnElegirUsuario.Size = new System.Drawing.Size(106, 23);
            this.btnElegirUsuario.TabIndex = 5;
            this.btnElegirUsuario.Text = "Elegir Usuario";
            this.btnElegirUsuario.UseVisualStyleBackColor = true;
            this.btnElegirUsuario.Click += new System.EventHandler(this.btnElegirUsuario_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(173, 282);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // FormHacerReservacionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 419);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnElegirUsuario);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.btnElegirZona);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.lblFechaYHora);
            this.Controls.Add(this.nudCantidadPersonas);
            this.Controls.Add(this.cbHoraInicio);
            this.Controls.Add(this.dpFechaInicio);
            this.Controls.Add(this.btnHacerReservacion);
            this.Name = "FormHacerReservacionAdministrador";
            this.Text = "FormHacerReservacionAdministrador";
            this.Load += new System.EventHandler(this.FormHacerReservacionAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblZona;
        private Button btnElegirZona;
        private Label lblCantidadPersonas;
        private Label lblFechaYHora;
        private NumericUpDown nudCantidadPersonas;
        private ComboBox cbHoraInicio;
        private DateTimePicker dpFechaInicio;
        private Button btnHacerReservacion;
        private Button btnElegirUsuario;
        private Label lblUsuario;
    }
}