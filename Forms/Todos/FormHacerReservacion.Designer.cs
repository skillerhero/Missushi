using Missushi.Clases;

namespace Missushi.Forms.Cliente {
    partial class FormHacerReservacion {
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
            this.dpFechaInicio = new Missushi.Forms.DateTimePickerPersonalizado();
            this.cbHoraInicio = new Missushi.Forms.ComboBoxPersonalizado();
            this.btnElegirZona = new Missushi.Forms.BotonPersonalizado();
            this.btnElegirUsuario = new Missushi.Forms.BotonPersonalizado();
            this.btnHacerReservacion = new Missushi.Forms.BotonPersonalizado();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.nudCantidadPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dpFechaInicio);
            this.panel1.Controls.Add(this.cbHoraInicio);
            this.panel1.Controls.Add(this.btnElegirZona);
            this.panel1.Controls.Add(this.btnElegirUsuario);
            this.panel1.Controls.Add(this.btnHacerReservacion);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblZona);
            this.panel1.Controls.Add(this.nudCantidadPersonas);
            this.panel1.Controls.Add(this.lblCantidadPersonas);
            this.panel1.Controls.Add(this.lblFechaYHora);
            this.panel1.Location = new System.Drawing.Point(243, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 365);
            this.panel1.TabIndex = 6;
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(202, 92);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(200, 23);
            this.dpFechaInicio.TabIndex = 35;
            this.dpFechaInicio.ValueChanged += new System.EventHandler(this.dpFechaInicio_ValueChanged);
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.cbHoraInicio.DisplayMember = "Text";
            this.cbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHoraInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.cbHoraInicio.FormattingEnabled = true;
            this.cbHoraInicio.Location = new System.Drawing.Point(455, 87);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(121, 23);
            this.cbHoraInicio.TabIndex = 34;
            this.cbHoraInicio.ValueMember = "Value";
            this.cbHoraInicio.SelectedIndexChanged += new System.EventHandler(this.cbHoraInicio_SelectedIndexChanged);
            // 
            // btnElegirZona
            // 
            this.btnElegirZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.btnElegirZona.FlatAppearance.BorderSize = 0;
            this.btnElegirZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirZona.ForeColor = System.Drawing.Color.White;
            this.btnElegirZona.Location = new System.Drawing.Point(295, 163);
            this.btnElegirZona.Name = "btnElegirZona";
            this.btnElegirZona.Size = new System.Drawing.Size(95, 30);
            this.btnElegirZona.TabIndex = 33;
            this.btnElegirZona.Text = "Elegir zona";
            this.btnElegirZona.UseVisualStyleBackColor = false;
            this.btnElegirZona.Click += new System.EventHandler(this.btnElegirZona_Click);
            this.btnElegirZona.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // btnElegirUsuario
            // 
            this.btnElegirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.btnElegirUsuario.FlatAppearance.BorderSize = 0;
            this.btnElegirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnElegirUsuario.Location = new System.Drawing.Point(295, 35);
            this.btnElegirUsuario.Name = "btnElegirUsuario";
            this.btnElegirUsuario.Size = new System.Drawing.Size(135, 36);
            this.btnElegirUsuario.TabIndex = 32;
            this.btnElegirUsuario.Text = "Elegir usuario";
            this.btnElegirUsuario.UseVisualStyleBackColor = false;
            this.btnElegirUsuario.Click += new System.EventHandler(this.btnElegirUsuario_Click);
            this.btnElegirUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnHacerReservacion.FlatAppearance.BorderSize = 0;
            this.btnHacerReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerReservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnHacerReservacion.Location = new System.Drawing.Point(278, 308);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(135, 39);
            this.btnHacerReservacion.TabIndex = 31;
            this.btnHacerReservacion.Text = "Hacer reservación";
            this.btnHacerReservacion.UseVisualStyleBackColor = false;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            this.btnHacerReservacion.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(170, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 29;
            this.lblUsuario.Text = "Usuario";
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
            // nudCantidadPersonas
            // 
            this.nudCantidadPersonas.Location = new System.Drawing.Point(278, 223);
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
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Location = new System.Drawing.Point(100, 95);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(76, 15);
            this.lblFechaYHora.TabIndex = 23;
            this.lblFechaYHora.Text = "Fecha y Hora";
            // 
            // FormHacerReservacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panel1);
            this.Name = "FormHacerReservacion";
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
        private NumericUpDown nudCantidadPersonas;
        private Label lblCantidadPersonas;
        private Label lblFechaYHora;
        private Label lblUsuario;
        private DateTimePickerPersonalizado dpFechaInicio;
        private ComboBoxPersonalizado cbHoraInicio;
        private BotonPersonalizado btnElegirZona;
        private BotonPersonalizado btnElegirUsuario;
        private BotonPersonalizado btnHacerReservacion;
    }
}