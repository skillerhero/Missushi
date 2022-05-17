namespace Missushi.Forms.Gerente {
    partial class FormAgregarZona {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarZona));
            this.udCupo = new System.Windows.Forms.NumericUpDown();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnAgregarZona = new Missushi.Forms.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.udCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // udCupo
            // 
            this.udCupo.Location = new System.Drawing.Point(157, 46);
            this.udCupo.Name = "udCupo";
            this.udCupo.Size = new System.Drawing.Size(120, 23);
            this.udCupo.TabIndex = 1;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(157, 96);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(120, 23);
            this.txtFoto.TabIndex = 3;
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblCupo.Location = new System.Drawing.Point(82, 35);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(61, 45);
            this.lblCupo.TabIndex = 5;
            this.lblCupo.Text = "Cupo";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblFoto.Location = new System.Drawing.Point(82, 85);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(52, 45);
            this.lblFoto.TabIndex = 6;
            this.lblFoto.Text = "Foto";
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnAgregarZona.FlatAppearance.BorderSize = 0;
            this.btnAgregarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnAgregarZona.Location = new System.Drawing.Point(82, 154);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.Size = new System.Drawing.Size(195, 34);
            this.btnAgregarZona.TabIndex = 7;
            this.btnAgregarZona.Text = "Agregar";
            this.btnAgregarZona.UseVisualStyleBackColor = false;
            this.btnAgregarZona.Click += new System.EventHandler(this.btnAgregarZona_Click);
            this.btnAgregarZona.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // FormAgregarZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.btnAgregarZona);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblCupo);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.udCupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarZona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missushi - Agregar zona";
            this.Load += new System.EventHandler(this.FormAgregarZona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udCupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown udCupo;
        private TextBox txtFoto;
        private Label lblCupo;
        private Label lblFoto;
        private BotonPersonalizado btnAgregarZona;
    }
}