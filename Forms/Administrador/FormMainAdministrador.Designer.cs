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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Location = new System.Drawing.Point(527, 188);
            this.btnReservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(110, 31);
            this.btnReservaciones.TabIndex = 1;
            this.btnReservaciones.Text = "Reservaciones";
            this.btnReservaciones.UseVisualStyleBackColor = true;
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // btnSuspenderUsuarios
            // 
            this.btnSuspenderUsuarios.Location = new System.Drawing.Point(529, 267);
            this.btnSuspenderUsuarios.Name = "btnSuspenderUsuarios";
            this.btnSuspenderUsuarios.Size = new System.Drawing.Size(108, 59);
            this.btnSuspenderUsuarios.TabIndex = 2;
            this.btnSuspenderUsuarios.Text = "suspender usuarios";
            this.btnSuspenderUsuarios.UseVisualStyleBackColor = true;
            this.btnSuspenderUsuarios.Click += new System.EventHandler(this.btnSuspenderUsuarios_Click);
            // 
            // FormMainAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnSuspenderUsuarios);
            this.Controls.Add(this.btnReservaciones);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainAdministrador";
            this.Load += new System.EventHandler(this.FormMainAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnReservaciones;
        private Button btnSuspenderUsuarios;
    }
}