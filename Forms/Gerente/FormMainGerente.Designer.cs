namespace Missushi.Forms.Gerente {
    partial class FormMainGerente {
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
            this.btnModificarZona = new System.Windows.Forms.Button();
            this.btnModificarInfo = new System.Windows.Forms.Button();
            this.btnAgregarZona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarZona
            // 
            this.btnModificarZona.Location = new System.Drawing.Point(25, 48);
            this.btnModificarZona.Name = "btnModificarZona";
            this.btnModificarZona.Size = new System.Drawing.Size(132, 23);
            this.btnModificarZona.TabIndex = 0;
            this.btnModificarZona.Text = "Modificar Zona";
            this.btnModificarZona.UseVisualStyleBackColor = true;
            this.btnModificarZona.Click += new System.EventHandler(this.btnModificarZona_Click);
            // 
            // btnModificarInfo
            // 
            this.btnModificarInfo.Location = new System.Drawing.Point(25, 116);
            this.btnModificarInfo.Name = "btnModificarInfo";
            this.btnModificarInfo.Size = new System.Drawing.Size(195, 23);
            this.btnModificarInfo.TabIndex = 1;
            this.btnModificarInfo.Text = "Modificar Info Restaurante";
            this.btnModificarInfo.UseVisualStyleBackColor = true;
            this.btnModificarInfo.Click += new System.EventHandler(this.btnModificarInfo_Click);
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.Location = new System.Drawing.Point(50, 169);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.Size = new System.Drawing.Size(142, 23);
            this.btnAgregarZona.TabIndex = 2;
            this.btnAgregarZona.Text = "Agregar Zona";
            this.btnAgregarZona.UseVisualStyleBackColor = true;
            this.btnAgregarZona.Click += new System.EventHandler(this.btnAgregarZona_Click);
            // 
            // FormMainGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarZona);
            this.Controls.Add(this.btnModificarInfo);
            this.Controls.Add(this.btnModificarZona);
            this.Name = "FormMainGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainGrerente";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnModificarZona;
        private Button btnModificarInfo;
        private Button btnAgregarZona;
    }
}