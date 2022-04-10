namespace Missushi.Forms {
    partial class FormGenerarQR {
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(162, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Código QR";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(511, 398);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.White;
            this.pbQR.Location = new System.Drawing.Point(205, 54);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(300, 300);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQR.TabIndex = 2;
            this.pbQR.TabStop = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(205, 384);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(300, 54);
            this.txtUrl.TabIndex = 3;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(205, 357);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(181, 15);
            this.lblHelp.TabIndex = 4;
            this.lblHelp.Text = "Ingresa el número de reservación";
            // 
            // FormGenerarQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormGenerarQR";
            this.Text = "FormGenerarQR";
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Button btnGenerar;
        private PictureBox pbQR;
        private TextBox txtUrl;
        private Label lblHelp;
    }
}