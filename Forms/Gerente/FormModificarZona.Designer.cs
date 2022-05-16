namespace Missushi.Forms.Gerente {
    partial class FormModificarZona {
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.nudCupo = new System.Windows.Forms.NumericUpDown();
            this.txtFotoZona = new System.Windows.Forms.TextBox();
            this.btnElegirZona = new System.Windows.Forms.Button();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(338, 260);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Aceptar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // nudCupo
            // 
            this.nudCupo.Location = new System.Drawing.Point(322, 117);
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(120, 23);
            this.nudCupo.TabIndex = 2;
            // 
            // txtFotoZona
            // 
            this.txtFotoZona.Location = new System.Drawing.Point(322, 172);
            this.txtFotoZona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFotoZona.Name = "txtFotoZona";
            this.txtFotoZona.Size = new System.Drawing.Size(110, 23);
            this.txtFotoZona.TabIndex = 3;
            // 
            // btnElegirZona
            // 
            this.btnElegirZona.Location = new System.Drawing.Point(338, 58);
            this.btnElegirZona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElegirZona.Name = "btnElegirZona";
            this.btnElegirZona.Size = new System.Drawing.Size(82, 22);
            this.btnElegirZona.TabIndex = 4;
            this.btnElegirZona.Text = "Elegir Zona";
            this.btnElegirZona.UseVisualStyleBackColor = true;
            this.btnElegirZona.Click += new System.EventHandler(this.btnElegirZona_Click);
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(260, 119);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(36, 15);
            this.lblCupo.TabIndex = 5;
            this.lblCupo.Text = "Cupo";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(269, 180);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(47, 15);
            this.lblFoto.TabIndex = 6;
            this.lblFoto.Text = "Url foto";
            // 
            // FormModificarZona
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblCupo);
            this.Controls.Add(this.btnElegirZona);
            this.Controls.Add(this.txtFotoZona);
            this.Controls.Add(this.nudCupo);
            this.Controls.Add(this.btnModificar);
            this.Name = "FormModificarZona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarZona";
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModificar;
        private NumericUpDown nudCupo;
        private TextBox txtFotoZona;
        private Button btnElegirZona;
        private Label lblCupo;
        private Label lblFoto;
    }
}