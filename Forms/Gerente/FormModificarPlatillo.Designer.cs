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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.dgPlatillosModi = new System.Windows.Forms.DataGridView();
            this.btnModificarPlatillo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(158, 531);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(275, 526);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(110, 23);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(593, 424);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 23);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(477, 429);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(593, 466);
            this.txtFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(110, 23);
            this.txtFoto.TabIndex = 6;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(477, 472);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(31, 15);
            this.lblFoto.TabIndex = 5;
            this.lblFoto.Text = "Foto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(276, 473);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 23);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(159, 478);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(178, 436);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(276, 424);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(110, 23);
            this.cbTipo.TabIndex = 10;
            // 
            // dgPlatillosModi
            // 
            this.dgPlatillosModi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlatillosModi.Location = new System.Drawing.Point(12, 217);
            this.dgPlatillosModi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPlatillosModi.Name = "dgPlatillosModi";
            this.dgPlatillosModi.RowHeadersWidth = 51;
            this.dgPlatillosModi.RowTemplate.Height = 29;
            this.dgPlatillosModi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlatillosModi.Size = new System.Drawing.Size(811, 173);
            this.dgPlatillosModi.TabIndex = 11;
            this.dgPlatillosModi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlatillosModi_CellDoubleClick);
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
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.dgPlatillosModi);
            this.Controls.Add(this.btnModificarPlatillo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificarPlatillo";
            this.Text = "FormModificarPlatillo";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.lblFoto, 0);
            this.Controls.SetChildIndex(this.txtFoto, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.cbTipo, 0);
            this.Controls.SetChildIndex(this.btnModificarPlatillo, 0);
            this.Controls.SetChildIndex(this.dgPlatillosModi, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtFoto;
        private Label lblFoto;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTipo;
        private ComboBox cbTipo;
        private DataGridView dgPlatillosModi;
        private Button btnModificarPlatillo;
    }
}