namespace Missushi.Forms
{
    partial class FormMenu
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
            this.pbPruebaMenu = new System.Windows.Forms.PictureBox();
            this.lblPruebaTipo = new System.Windows.Forms.Label();
            this.lblPruebaDescripcion = new System.Windows.Forms.Label();
            this.lblPruebaPrecio = new System.Windows.Forms.Label();
            this.lblPruebaNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPruebaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPruebaMenu
            // 
            this.pbPruebaMenu.Location = new System.Drawing.Point(114, 113);
            this.pbPruebaMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPruebaMenu.Name = "pbPruebaMenu";
            this.pbPruebaMenu.Size = new System.Drawing.Size(86, 100);
            this.pbPruebaMenu.TabIndex = 1;
            this.pbPruebaMenu.TabStop = false;
            this.pbPruebaMenu.Visible = false;
            // 
            // lblPruebaTipo
            // 
            this.lblPruebaTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblPruebaTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPruebaTipo.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPruebaTipo.ForeColor = System.Drawing.Color.White;
            this.lblPruebaTipo.Location = new System.Drawing.Point(114, 33);
            this.lblPruebaTipo.Name = "lblPruebaTipo";
            this.lblPruebaTipo.Size = new System.Drawing.Size(685, 59);
            this.lblPruebaTipo.TabIndex = 2;
            this.lblPruebaTipo.Text = "Tipo";
            this.lblPruebaTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPruebaTipo.Visible = false;
            // 
            // lblPruebaDescripcion
            // 
            this.lblPruebaDescripcion.Location = new System.Drawing.Point(229, 152);
            this.lblPruebaDescripcion.Name = "lblPruebaDescripcion";
            this.lblPruebaDescripcion.Size = new System.Drawing.Size(434, 60);
            this.lblPruebaDescripcion.TabIndex = 3;
            this.lblPruebaDescripcion.Text = "Ingredientes, cantidades, etc";
            this.lblPruebaDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPruebaDescripcion.Visible = false;
            // 
            // lblPruebaPrecio
            // 
            this.lblPruebaPrecio.Location = new System.Drawing.Point(693, 169);
            this.lblPruebaPrecio.Name = "lblPruebaPrecio";
            this.lblPruebaPrecio.Padding = new System.Windows.Forms.Padding(1);
            this.lblPruebaPrecio.Size = new System.Drawing.Size(107, 27);
            this.lblPruebaPrecio.TabIndex = 4;
            this.lblPruebaPrecio.Text = "$4206909809";
            this.lblPruebaPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPruebaPrecio.Visible = false;
            // 
            // lblPruebaNombre
            // 
            this.lblPruebaNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPruebaNombre.Location = new System.Drawing.Point(217, 112);
            this.lblPruebaNombre.Name = "lblPruebaNombre";
            this.lblPruebaNombre.Size = new System.Drawing.Size(514, 40);
            this.lblPruebaNombre.TabIndex = 5;
            this.lblPruebaNombre.Text = "Nombre";
            this.lblPruebaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPruebaNombre.Visible = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(914, 749);
            this.Controls.Add(this.lblPruebaNombre);
            this.Controls.Add(this.lblPruebaPrecio);
            this.Controls.Add(this.lblPruebaDescripcion);
            this.Controls.Add(this.lblPruebaTipo);
            this.Controls.Add(this.pbPruebaMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missushi - Menú";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPruebaMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pbPruebaMenu;
        private Label lblPruebaTipo;
        private Label lblPruebaDescripcion;
        private Label lblPruebaPrecio;
        private Label lblPruebaNombre;
    }
}