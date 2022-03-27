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
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(386, 347);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 31);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Aceptar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // nudCupo
            // 
            this.nudCupo.Location = new System.Drawing.Point(368, 156);
            this.nudCupo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(137, 27);
            this.nudCupo.TabIndex = 2;
            // 
            // txtFotoZona
            // 
            this.txtFotoZona.Location = new System.Drawing.Point(368, 230);
            this.txtFotoZona.Name = "txtFotoZona";
            this.txtFotoZona.Size = new System.Drawing.Size(125, 27);
            this.txtFotoZona.TabIndex = 3;
            // 
            // btnElegirZona
            // 
            this.btnElegirZona.Location = new System.Drawing.Point(386, 77);
            this.btnElegirZona.Name = "btnElegirZona";
            this.btnElegirZona.Size = new System.Drawing.Size(94, 29);
            this.btnElegirZona.TabIndex = 4;
            this.btnElegirZona.Text = "Elegir Zona";
            this.btnElegirZona.UseVisualStyleBackColor = true;
            this.btnElegirZona.Click += new System.EventHandler(this.btnElegirZona_Click);
            // 
            // FormModificarZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnElegirZona);
            this.Controls.Add(this.txtFotoZona);
            this.Controls.Add(this.nudCupo);
            this.Controls.Add(this.btnModificar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}