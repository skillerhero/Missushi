namespace Missushi.Forms {
    partial class FormDiseño {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiseño));
            this.lblBarraPrincipal = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lblBarra1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarraPrincipal
            // 
            this.lblBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblBarraPrincipal.Location = new System.Drawing.Point(0, -1);
            this.lblBarraPrincipal.Name = "lblBarraPrincipal";
            this.lblBarraPrincipal.Size = new System.Drawing.Size(1008, 73);
            this.lblBarraPrincipal.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbLogo.Image = global::Missushi.Properties.Resources.logoFondoRosaHD;
            this.pbLogo.Location = new System.Drawing.Point(0, -1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(73, 73);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblMenu.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(79, 12);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 48);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menú";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbMenu.Image = global::Missushi.Properties.Resources.menu;
            this.pbMenu.Location = new System.Drawing.Point(196, 12);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(46, 48);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 6;
            this.pbMenu.TabStop = false;
            // 
            // lblBarra1
            // 
            this.lblBarra1.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra1.Location = new System.Drawing.Point(166, 12);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(10, 39);
            this.lblBarra1.TabIndex = 7;
            // 
            // FormDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.lblBarra1);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiseño";
            this.Text = "FormDiseño";
            this.Load += new System.EventHandler(this.FormDiseño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblBarraPrincipal;
        private PictureBox pbLogo;
        private Label lblMenu;
        private PictureBox pbMenu;
        private Label lblBarra1;
    }
}