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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.pbPruebaMenu = new System.Windows.Forms.PictureBox();
            this.lblPruebaTipo = new System.Windows.Forms.Label();
            this.lblPruebaDescripcion = new System.Windows.Forms.Label();
            this.lblPruebaPrecio = new System.Windows.Forms.Label();
            this.lblPruebaNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPruebaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMenu
            // 
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.Location = new System.Drawing.Point(61, 477);
            this.dgMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.RowHeadersWidth = 51;
            this.dgMenu.RowTemplate.Height = 29;
            this.dgMenu.Size = new System.Drawing.Size(642, 122);
            this.dgMenu.TabIndex = 0;
            // 
            // pbPruebaMenu
            // 
            this.pbPruebaMenu.Location = new System.Drawing.Point(100, 85);
            this.pbPruebaMenu.Name = "pbPruebaMenu";
            this.pbPruebaMenu.Size = new System.Drawing.Size(75, 75);
            this.pbPruebaMenu.TabIndex = 1;
            this.pbPruebaMenu.TabStop = false;
            // 
            // lblPruebaTipo
            // 
            this.lblPruebaTipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPruebaTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPruebaTipo.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPruebaTipo.ForeColor = System.Drawing.Color.White;
            this.lblPruebaTipo.Location = new System.Drawing.Point(100, 25);
            this.lblPruebaTipo.Name = "lblPruebaTipo";
            this.lblPruebaTipo.Size = new System.Drawing.Size(600, 45);
            this.lblPruebaTipo.TabIndex = 2;
            this.lblPruebaTipo.Text = "Tipo";
            this.lblPruebaTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPruebaDescripcion
            // 
            this.lblPruebaDescripcion.Location = new System.Drawing.Point(190, 115);
            this.lblPruebaDescripcion.Name = "lblPruebaDescripcion";
            this.lblPruebaDescripcion.Size = new System.Drawing.Size(450, 45);
            this.lblPruebaDescripcion.TabIndex = 3;
            this.lblPruebaDescripcion.Text = resources.GetString("lblPruebaDescripcion.Text");
            this.lblPruebaDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPruebaPrecio
            // 
            this.lblPruebaPrecio.AutoSize = true;
            this.lblPruebaPrecio.Location = new System.Drawing.Point(657, 115);
            this.lblPruebaPrecio.Name = "lblPruebaPrecio";
            this.lblPruebaPrecio.Size = new System.Drawing.Size(43, 15);
            this.lblPruebaPrecio.TabIndex = 4;
            this.lblPruebaPrecio.Text = "$42069";
            // 
            // lblPruebaNombre
            // 
            this.lblPruebaNombre.Location = new System.Drawing.Point(190, 85);
            this.lblPruebaNombre.Name = "lblPruebaNombre";
            this.lblPruebaNombre.Size = new System.Drawing.Size(450, 30);
            this.lblPruebaNombre.TabIndex = 5;
            this.lblPruebaNombre.Text = "Nombre";
            this.lblPruebaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.lblPruebaNombre);
            this.Controls.Add(this.lblPruebaPrecio);
            this.Controls.Add(this.lblPruebaDescripcion);
            this.Controls.Add(this.lblPruebaTipo);
            this.Controls.Add(this.pbPruebaMenu);
            this.Controls.Add(this.dgMenu);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPruebaMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgMenu;
        private PictureBox pbPruebaMenu;
        private Label lblPruebaTipo;
        private Label lblPruebaDescripcion;
        private Label lblPruebaPrecio;
        private Label lblPruebaNombre;
    }
}