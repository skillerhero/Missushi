namespace Missushi.Forms.Gerente {
    partial class FormModificarPlatillo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.lblDescripcionModificacion = new System.Windows.Forms.Label();
            this.txtDescripcionModi = new System.Windows.Forms.TextBox();
            this.txtPrecioModi = new System.Windows.Forms.TextBox();
            this.lblPrecioModificacion = new System.Windows.Forms.Label();
            this.txtImagenMod = new System.Windows.Forms.TextBox();
            this.lblImagenModificacion = new System.Windows.Forms.Label();
            this.txtNombreModi = new System.Windows.Forms.TextBox();
            this.lblNombreModificacion = new System.Windows.Forms.Label();
            this.lblTipoModificacion = new System.Windows.Forms.Label();
            this.cbTipoModi = new System.Windows.Forms.ComboBox();
            this.dgPlatillosModi = new System.Windows.Forms.DataGridView();
            this.btnModificarPlatillo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcionModificacion
            // 
            this.lblDescripcionModificacion.AutoSize = true;
            this.lblDescripcionModificacion.Location = new System.Drawing.Point(158, 531);
            this.lblDescripcionModificacion.Name = "lblDescripcionModificacion";
            this.lblDescripcionModificacion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcionModificacion.TabIndex = 1;
            this.lblDescripcionModificacion.Text = "Descripcion";
            // 
            // txtDescripcionModi
            // 
            this.txtDescripcionModi.Location = new System.Drawing.Point(275, 526);
            this.txtDescripcionModi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionModi.Name = "txtDescripcionModi";
            this.txtDescripcionModi.Size = new System.Drawing.Size(110, 23);
            this.txtDescripcionModi.TabIndex = 2;
            // 
            // txtPrecioModi
            // 
            this.txtPrecioModi.Location = new System.Drawing.Point(593, 424);
            this.txtPrecioModi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioModi.Name = "txtPrecioModi";
            this.txtPrecioModi.Size = new System.Drawing.Size(110, 23);
            this.txtPrecioModi.TabIndex = 4;
            // 
            // lblPrecioModificacion
            // 
            this.lblPrecioModificacion.AutoSize = true;
            this.lblPrecioModificacion.Location = new System.Drawing.Point(477, 429);
            this.lblPrecioModificacion.Name = "lblPrecioModificacion";
            this.lblPrecioModificacion.Size = new System.Drawing.Size(40, 15);
            this.lblPrecioModificacion.TabIndex = 3;
            this.lblPrecioModificacion.Text = "Precio";
            // 
            // txtImagenMod
            // 
            this.txtImagenMod.Location = new System.Drawing.Point(593, 466);
            this.txtImagenMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImagenMod.Name = "txtImagenMod";
            this.txtImagenMod.Size = new System.Drawing.Size(110, 23);
            this.txtImagenMod.TabIndex = 6;
            // 
            // lblImagenModificacion
            // 
            this.lblImagenModificacion.AutoSize = true;
            this.lblImagenModificacion.Location = new System.Drawing.Point(477, 472);
            this.lblImagenModificacion.Name = "lblImagenModificacion";
            this.lblImagenModificacion.Size = new System.Drawing.Size(47, 15);
            this.lblImagenModificacion.TabIndex = 5;
            this.lblImagenModificacion.Text = "Imagen";
            // 
            // txtNombreModi
            // 
            this.txtNombreModi.Location = new System.Drawing.Point(276, 473);
            this.txtNombreModi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreModi.Name = "txtNombreModi";
            this.txtNombreModi.Size = new System.Drawing.Size(110, 23);
            this.txtNombreModi.TabIndex = 8;
            // 
            // lblNombreModificacion
            // 
            this.lblNombreModificacion.AutoSize = true;
            this.lblNombreModificacion.Location = new System.Drawing.Point(159, 478);
            this.lblNombreModificacion.Name = "lblNombreModificacion";
            this.lblNombreModificacion.Size = new System.Drawing.Size(51, 15);
            this.lblNombreModificacion.TabIndex = 7;
            this.lblNombreModificacion.Text = "Nombre";
            // 
            // lblTipoModificacion
            // 
            this.lblTipoModificacion.AutoSize = true;
            this.lblTipoModificacion.Location = new System.Drawing.Point(178, 436);
            this.lblTipoModificacion.Name = "lblTipoModificacion";
            this.lblTipoModificacion.Size = new System.Drawing.Size(30, 15);
            this.lblTipoModificacion.TabIndex = 9;
            this.lblTipoModificacion.Text = "Tipo";
            // 
            // cbTipoModi
            // 
            this.cbTipoModi.FormattingEnabled = true;
            this.cbTipoModi.Location = new System.Drawing.Point(276, 424);
            this.cbTipoModi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoModi.Name = "cbTipoModi";
            this.cbTipoModi.Size = new System.Drawing.Size(110, 23);
            this.cbTipoModi.TabIndex = 10;
            // 
            // dgPlatillosModi
            // 
            this.dgPlatillosModi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlatillosModi.Location = new System.Drawing.Point(12, 217);
            this.dgPlatillosModi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPlatillosModi.Name = "dgPlatillosModi";
            this.dgPlatillosModi.RowHeadersWidth = 51;
            this.dgPlatillosModi.RowTemplate.Height = 29;
            this.dgPlatillosModi.Size = new System.Drawing.Size(811, 173);
            this.dgPlatillosModi.TabIndex = 11;
            this.dgPlatillosModi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlatillosModi_CellDoubleClick);
            // 
            // btnModificarPlatillo
            // 
            this.btnModificarPlatillo.Location = new System.Drawing.Point(477, 523);
            this.btnModificarPlatillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPlatillo.Name = "btnModificarPlatillo";
            this.btnModificarPlatillo.Size = new System.Drawing.Size(226, 22);
            this.btnModificarPlatillo.TabIndex = 12;
            this.btnModificarPlatillo.Text = "Modificar";
            this.btnModificarPlatillo.UseVisualStyleBackColor = true;
            this.btnModificarPlatillo.Click += new System.EventHandler(this.btnModificarPlatillo_Click);
            // 
            // FormModificarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 562);
            this.Controls.Add(this.dgPlatillosModi);
            this.Controls.Add(this.btnModificarPlatillo);
            this.Controls.Add(this.cbTipoModi);
            this.Controls.Add(this.lblTipoModificacion);
            this.Controls.Add(this.txtNombreModi);
            this.Controls.Add(this.lblNombreModificacion);
            this.Controls.Add(this.txtImagenMod);
            this.Controls.Add(this.lblImagenModificacion);
            this.Controls.Add(this.txtPrecioModi);
            this.Controls.Add(this.lblPrecioModificacion);
            this.Controls.Add(this.txtDescripcionModi);
            this.Controls.Add(this.lblDescripcionModificacion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificarPlatillo";
            this.Text = "FormModificarPlatillo";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.lblDescripcionModificacion, 0);
            this.Controls.SetChildIndex(this.txtDescripcionModi, 0);
            this.Controls.SetChildIndex(this.lblPrecioModificacion, 0);
            this.Controls.SetChildIndex(this.txtPrecioModi, 0);
            this.Controls.SetChildIndex(this.lblImagenModificacion, 0);
            this.Controls.SetChildIndex(this.txtImagenMod, 0);
            this.Controls.SetChildIndex(this.lblNombreModificacion, 0);
            this.Controls.SetChildIndex(this.txtNombreModi, 0);
            this.Controls.SetChildIndex(this.lblTipoModificacion, 0);
            this.Controls.SetChildIndex(this.cbTipoModi, 0);
            this.Controls.SetChildIndex(this.btnModificarPlatillo, 0);
            this.Controls.SetChildIndex(this.dgPlatillosModi, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblDescripcionModificacion;
        private TextBox txtDescripcionModi;
        private TextBox txtPrecioModi;
        private Label lblPrecioModificacion;
        private TextBox txtImagenMod;
        private Label lblImagenModificacion;
        private TextBox txtNombreModi;
        private Label lblNombreModificacion;
        private Label lblTipoModificacion;
        private ComboBox cbTipoModi;
        private DataGridView dgPlatillosModi;
        private Button btnModificarPlatillo;
    }
}