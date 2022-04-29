namespace Missushi.Forms {
    partial class FormMainAdministrador {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReservaciones = new System.Windows.Forms.Button();
            this.btnSuspenderUsuarios = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Location = new System.Drawing.Point(461, 141);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(96, 23);
            this.btnReservaciones.TabIndex = 1;
            this.btnReservaciones.Text = "Reservaciones";
            this.btnReservaciones.UseVisualStyleBackColor = true;
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // btnSuspenderUsuarios
            // 
            this.btnSuspenderUsuarios.Location = new System.Drawing.Point(463, 200);
            this.btnSuspenderUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuspenderUsuarios.Name = "btnSuspenderUsuarios";
            this.btnSuspenderUsuarios.Size = new System.Drawing.Size(94, 44);
            this.btnSuspenderUsuarios.TabIndex = 2;
            this.btnSuspenderUsuarios.Text = "suspender usuarios";
            this.btnSuspenderUsuarios.UseVisualStyleBackColor = true;
            this.btnSuspenderUsuarios.Click += new System.EventHandler(this.btnSuspenderUsuarios_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(479, 335);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 3;
            this.btnBD.Text = "Ver BD";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // FormMainAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnSuspenderUsuarios);
            this.Controls.Add(this.btnReservaciones);
            this.Controls.Add(this.label1);
            this.Name = "FormMainAdministrador";
            this.Text = "FormMainAdministrador";
            this.Load += new System.EventHandler(this.FormMainAdministrador_Load);
            this.Controls.SetChildIndex(this.pbImagenesRestaurante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnReservaciones, 0);
            this.Controls.SetChildIndex(this.btnSuspenderUsuarios, 0);
            this.Controls.SetChildIndex(this.btnBD, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnReservaciones;
        private Button btnSuspenderUsuarios;
        private Button btnBD;
    }
}