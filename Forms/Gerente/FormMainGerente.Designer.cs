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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarPlatillo = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnModificarPlatillos = new System.Windows.Forms.Button();
            this.btnAgregarZona = new System.Windows.Forms.Button();
            this.btnModificarInfo = new System.Windows.Forms.Button();
            this.btnModificarZona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarPlatillo);
            this.panel1.Controls.Add(this.btnEliminarP);
            this.panel1.Controls.Add(this.btnModificarPlatillos);
            this.panel1.Controls.Add(this.btnAgregarZona);
            this.panel1.Controls.Add(this.btnModificarInfo);
            this.panel1.Controls.Add(this.btnModificarZona);
            this.panel1.Location = new System.Drawing.Point(119, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 173);
            this.panel1.TabIndex = 11;
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(329, 7);
            this.btnAgregarPlatillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(144, 43);
            this.btnAgregarPlatillo.TabIndex = 16;
            this.btnAgregarPlatillo.Text = "Agregar platillos";
            this.btnAgregarPlatillo.UseVisualStyleBackColor = false;
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.btnAgregarPlatillo_Click_1);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarP.Location = new System.Drawing.Point(308, 103);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(144, 43);
            this.btnEliminarP.TabIndex = 15;
            this.btnEliminarP.Text = "Eliminar platillos";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            // 
            // btnModificarPlatillos
            // 
            this.btnModificarPlatillos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificarPlatillos.Location = new System.Drawing.Point(329, 49);
            this.btnModificarPlatillos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPlatillos.Name = "btnModificarPlatillos";
            this.btnModificarPlatillos.Size = new System.Drawing.Size(144, 43);
            this.btnModificarPlatillos.TabIndex = 14;
            this.btnModificarPlatillos.Text = "Modificar platillos";
            this.btnModificarPlatillos.UseVisualStyleBackColor = false;
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.Location = new System.Drawing.Point(41, 103);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.Size = new System.Drawing.Size(142, 23);
            this.btnAgregarZona.TabIndex = 13;
            this.btnAgregarZona.Text = "Agregar Zona";
            this.btnAgregarZona.UseVisualStyleBackColor = true;
            // 
            // btnModificarInfo
            // 
            this.btnModificarInfo.Location = new System.Drawing.Point(3, 49);
            this.btnModificarInfo.Name = "btnModificarInfo";
            this.btnModificarInfo.Size = new System.Drawing.Size(195, 20);
            this.btnModificarInfo.TabIndex = 12;
            this.btnModificarInfo.Text = "Modificar Info Restaurante";
            this.btnModificarInfo.UseVisualStyleBackColor = true;
            // 
            // btnModificarZona
            // 
            this.btnModificarZona.Location = new System.Drawing.Point(28, 13);
            this.btnModificarZona.Name = "btnModificarZona";
            this.btnModificarZona.Size = new System.Drawing.Size(132, 20);
            this.btnModificarZona.TabIndex = 11;
            this.btnModificarZona.Text = "Modificar Zona";
            this.btnModificarZona.UseVisualStyleBackColor = true;
            // 
            // FormMainGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel1);
            this.Name = "FormMainGerente";
            this.Text = "FormMainGrerente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnAgregarPlatillo;
        private Button btnEliminarP;
        private Button btnModificarPlatillos;
        private Button btnAgregarZona;
        private Button btnModificarInfo;
        private Button btnModificarZona;
    }
}