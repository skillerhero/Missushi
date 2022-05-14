namespace Missushi.Forms.Gerente
{
    partial class FormElegirZona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelZonas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelZonas
            // 
            this.panelZonas.Location = new System.Drawing.Point(0, 100);
            this.panelZonas.Name = "panelZonas";
            this.panelZonas.Size = new System.Drawing.Size(1024, 500);
            this.panelZonas.TabIndex = 0;
            // 
            // FormElegirZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelZonas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormElegirZona";
            this.Text = "FormElegirZona";
            this.Load += new System.EventHandler(this.FormElegirZona_Load);
            this.Controls.SetChildIndex(this.panelZonas, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelZonas;
    }
}