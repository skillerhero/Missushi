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
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcionModificacion
            // 
            this.lblDescripcionModificacion.AutoSize = true;
            this.lblDescripcionModificacion.Location = new System.Drawing.Point(189, 441);
            this.lblDescripcionModificacion.Name = "lblDescripcionModificacion";
            this.lblDescripcionModificacion.Size = new System.Drawing.Size(87, 20);
            this.lblDescripcionModificacion.TabIndex = 1;
            this.lblDescripcionModificacion.Text = "Descripcion";
            // 
            // txtDescripcionModi
            // 
            this.txtDescripcionModi.Location = new System.Drawing.Point(322, 434);
            this.txtDescripcionModi.Name = "txtDescripcionModi";
            this.txtDescripcionModi.Size = new System.Drawing.Size(125, 27);
            this.txtDescripcionModi.TabIndex = 2;
            // 
            // txtPrecioModi
            // 
            this.txtPrecioModi.Location = new System.Drawing.Point(686, 298);
            this.txtPrecioModi.Name = "txtPrecioModi";
            this.txtPrecioModi.Size = new System.Drawing.Size(125, 27);
            this.txtPrecioModi.TabIndex = 4;
            // 
            // lblPrecioModificacion
            // 
            this.lblPrecioModificacion.AutoSize = true;
            this.lblPrecioModificacion.Location = new System.Drawing.Point(553, 305);
            this.lblPrecioModificacion.Name = "lblPrecioModificacion";
            this.lblPrecioModificacion.Size = new System.Drawing.Size(50, 20);
            this.lblPrecioModificacion.TabIndex = 3;
            this.lblPrecioModificacion.Text = "Precio";
            // 
            // txtImagenMod
            // 
            this.txtImagenMod.Location = new System.Drawing.Point(686, 355);
            this.txtImagenMod.Name = "txtImagenMod";
            this.txtImagenMod.Size = new System.Drawing.Size(125, 27);
            this.txtImagenMod.TabIndex = 6;
            // 
            // lblImagenModificacion
            // 
            this.lblImagenModificacion.AutoSize = true;
            this.lblImagenModificacion.Location = new System.Drawing.Point(553, 362);
            this.lblImagenModificacion.Name = "lblImagenModificacion";
            this.lblImagenModificacion.Size = new System.Drawing.Size(59, 20);
            this.lblImagenModificacion.TabIndex = 5;
            this.lblImagenModificacion.Text = "Imagen";
            // 
            // txtNombreModi
            // 
            this.txtNombreModi.Location = new System.Drawing.Point(323, 364);
            this.txtNombreModi.Name = "txtNombreModi";
            this.txtNombreModi.Size = new System.Drawing.Size(125, 27);
            this.txtNombreModi.TabIndex = 8;
            // 
            // lblNombreModificacion
            // 
            this.lblNombreModificacion.AutoSize = true;
            this.lblNombreModificacion.Location = new System.Drawing.Point(190, 371);
            this.lblNombreModificacion.Name = "lblNombreModificacion";
            this.lblNombreModificacion.Size = new System.Drawing.Size(64, 20);
            this.lblNombreModificacion.TabIndex = 7;
            this.lblNombreModificacion.Text = "Nombre";
            // 
            // lblTipoModificacion
            // 
            this.lblTipoModificacion.AutoSize = true;
            this.lblTipoModificacion.Location = new System.Drawing.Point(189, 306);
            this.lblTipoModificacion.Name = "lblTipoModificacion";
            this.lblTipoModificacion.Size = new System.Drawing.Size(39, 20);
            this.lblTipoModificacion.TabIndex = 9;
            this.lblTipoModificacion.Text = "Tipo";
            // 
            // cbTipoModi
            // 
            this.cbTipoModi.FormattingEnabled = true;
            this.cbTipoModi.Location = new System.Drawing.Point(323, 298);
            this.cbTipoModi.Name = "cbTipoModi";
            this.cbTipoModi.Size = new System.Drawing.Size(125, 28);
            this.cbTipoModi.TabIndex = 10;
            // 
            // dgPlatillosModi
            // 
            this.dgPlatillosModi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlatillosModi.Location = new System.Drawing.Point(22, 23);
            this.dgPlatillosModi.Name = "dgPlatillosModi";
            this.dgPlatillosModi.RowHeadersWidth = 51;
            this.dgPlatillosModi.RowTemplate.Height = 29;
            this.dgPlatillosModi.Size = new System.Drawing.Size(927, 231);
            this.dgPlatillosModi.TabIndex = 11;
            this.dgPlatillosModi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlatillosModi_CellDoubleClick);
            // 
            // btnModificarPlatillo
            // 
            this.btnModificarPlatillo.Location = new System.Drawing.Point(553, 431);
            this.btnModificarPlatillo.Name = "btnModificarPlatillo";
            this.btnModificarPlatillo.Size = new System.Drawing.Size(258, 30);
            this.btnModificarPlatillo.TabIndex = 12;
            this.btnModificarPlatillo.Text = "Modificar";
            this.btnModificarPlatillo.UseVisualStyleBackColor = true;
            this.btnModificarPlatillo.Click += new System.EventHandler(this.btnModificarPlatillo_Click);
            // 
            // FormModificarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 525);
            this.Controls.Add(this.btnModificarPlatillo);
            this.Controls.Add(this.dgPlatillosModi);
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
            this.Name = "FormModificarPlatillo";
            this.Text = "FormModificarPlatillo";
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