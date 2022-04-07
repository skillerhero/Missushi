namespace Missushi.Forms.Administrador {
    partial class FormReservacionAdministrador {
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
            this.dgReservaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(50, 248);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(98, 41);
            this.btnHacerReservacion.TabIndex = 0;
            this.btnHacerReservacion.Text = "Hacer reservacion";
            this.btnHacerReservacion.UseVisualStyleBackColor = true;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            // 
            // dgReservaciones
            // 
            this.dgReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservaciones.Location = new System.Drawing.Point(111, 46);
            this.dgReservaciones.Name = "dgReservaciones";
            this.dgReservaciones.RowTemplate.Height = 25;
            this.dgReservaciones.Size = new System.Drawing.Size(240, 150);
            this.dgReservaciones.TabIndex = 1;
            // 
            // FormReservacionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 359);
            this.Controls.Add(this.dgReservaciones);
            this.Controls.Add(this.btnHacerReservacion);
            this.Name = "FormReservacionAdministrador";
            this.Text = "FormReservacionAdministrador";
            this.Load += new System.EventHandler(this.FormReservacionAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHacerReservacion;
        private DataGridView dgReservaciones;
    }
}