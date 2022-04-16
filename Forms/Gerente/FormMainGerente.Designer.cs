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
            this.btnAgregarPlatillo = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnModificarPlatillos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarZona
            // 
            this.btnModificarZona.Location = new System.Drawing.Point(115, 144);
            this.btnModificarZona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarZona.Name = "btnModificarZona";
            this.btnModificarZona.Size = new System.Drawing.Size(151, 31);
            this.btnModificarZona.TabIndex = 0;
            this.btnModificarZona.Text = "Modificar Zona";
            this.btnModificarZona.UseVisualStyleBackColor = true;
            this.btnModificarZona.Click += new System.EventHandler(this.btnModificarZona_Click);
            // 
            // btnModificarInfo
            // 
            this.btnModificarInfo.Location = new System.Drawing.Point(115, 235);
            this.btnModificarInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarInfo.Name = "btnModificarInfo";
            this.btnModificarInfo.Size = new System.Drawing.Size(223, 31);
            this.btnModificarInfo.TabIndex = 1;
            this.btnModificarInfo.Text = "Modificar Info Restaurante";
            this.btnModificarInfo.UseVisualStyleBackColor = true;
            this.btnModificarInfo.Click += new System.EventHandler(this.btnModificarInfo_Click);
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.Location = new System.Drawing.Point(115, 336);
            this.btnAgregarZona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.Size = new System.Drawing.Size(162, 31);
            this.btnAgregarZona.TabIndex = 2;
            this.btnAgregarZona.Text = "Agregar Zona";
            this.btnAgregarZona.UseVisualStyleBackColor = true;
            this.btnAgregarZona.Click += new System.EventHandler(this.btnAgregarZona_Click);
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(577, 98);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(164, 57);
            this.btnAgregarPlatillo.TabIndex = 10;
            this.btnAgregarPlatillo.Text = "Agregar platillos";
            this.btnAgregarPlatillo.UseVisualStyleBackColor = false;
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.btnAgregarPlatillo_Click_1);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarP.Location = new System.Drawing.Point(577, 358);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(164, 57);
            this.btnEliminarP.TabIndex = 9;
            this.btnEliminarP.Text = "Eliminar platillos";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click_1);
            // 
            // btnModificarPlatillos
            // 
            this.btnModificarPlatillos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificarPlatillos.Location = new System.Drawing.Point(577, 231);
            this.btnModificarPlatillos.Name = "btnModificarPlatillos";
            this.btnModificarPlatillos.Size = new System.Drawing.Size(164, 57);
            this.btnModificarPlatillos.TabIndex = 8;
            this.btnModificarPlatillos.Text = "Modificar platillos";
            this.btnModificarPlatillos.UseVisualStyleBackColor = false;
            this.btnModificarPlatillos.Click += new System.EventHandler(this.btnModificarPlatillos_Click_1);
            // 
            // FormMainGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnAgregarPlatillo);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnModificarPlatillos);
            this.Controls.Add(this.btnAgregarZona);
            this.Controls.Add(this.btnModificarInfo);
            this.Controls.Add(this.btnModificarZona);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainGrerente";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnModificarZona;
        private Button btnModificarInfo;
        private Button btnAgregarZona;
        private Button btnAgregarPlatillo;
        private Button btnEliminarP;
        private Button btnModificarPlatillos;
    }
}