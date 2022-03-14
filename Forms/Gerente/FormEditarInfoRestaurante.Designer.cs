namespace Missushi.Forms.Gerente {
    partial class FormEditarInfoRestaurante {
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
            this.btnEditarZonas = new System.Windows.Forms.Button();
            this.btnInfoRestaurante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditarZonas
            // 
            this.btnEditarZonas.Location = new System.Drawing.Point(12, 382);
            this.btnEditarZonas.Name = "btnEditarZonas";
            this.btnEditarZonas.Size = new System.Drawing.Size(92, 26);
            this.btnEditarZonas.TabIndex = 0;
            this.btnEditarZonas.Text = "Editar zonas";
            this.btnEditarZonas.UseVisualStyleBackColor = true;
            // 
            // btnInfoRestaurante
            // 
            this.btnInfoRestaurante.Location = new System.Drawing.Point(48, 80);
            this.btnInfoRestaurante.Name = "btnInfoRestaurante";
            this.btnInfoRestaurante.Size = new System.Drawing.Size(149, 39);
            this.btnInfoRestaurante.TabIndex = 1;
            this.btnInfoRestaurante.Text = "Editar info de restaurante";
            this.btnInfoRestaurante.UseVisualStyleBackColor = true;
            this.btnInfoRestaurante.Click += new System.EventHandler(this.btnInfoRestaurante_Click);
            // 
            // FormEditarInfoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfoRestaurante);
            this.Controls.Add(this.btnEditarZonas);
            this.Name = "FormEditarInfoRestaurante";
            this.Text = "FormEditarInfoRestaurante";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEditarZonas;
        private Button btnInfoRestaurante;
    }
}