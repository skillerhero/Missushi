namespace Missushi.Forms {
    partial class FormMainCliente {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hacerReservaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desplegableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerReservaciónToolStripMenuItem,
            this.desplegableToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 78);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hacerReservaciónToolStripMenuItem
            // 
            this.hacerReservaciónToolStripMenuItem.Name = "hacerReservaciónToolStripMenuItem";
            this.hacerReservaciónToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.hacerReservaciónToolStripMenuItem.Text = "Hacer reservación";
            this.hacerReservaciónToolStripMenuItem.Click += new System.EventHandler(this.hacerReservaciónToolStripMenuItem_Click);
            // 
            // desplegableToolStripMenuItem
            // 
            this.desplegableToolStripMenuItem.Name = "desplegableToolStripMenuItem";
            this.desplegableToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.desplegableToolStripMenuItem.Text = "Desplegable";
            this.desplegableToolStripMenuItem.Click += new System.EventHandler(this.desplegableToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // FormMainCliente
            // 
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainCliente";
            this.Text = "FormMainCliente";
            this.Load += new System.EventHandler(this.FormMainCliente_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hacerReservaciónToolStripMenuItem;
        private ToolStripMenuItem desplegableToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
    }
}