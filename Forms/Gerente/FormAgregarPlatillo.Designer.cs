namespace Missushi.Forms.Gerente {
    partial class FormAgregarPlatillo {
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
            this.txtFotoMenu = new System.Windows.Forms.TextBox();
            this.cbTipoMenu = new System.Windows.Forms.ComboBox();
            this.txtPrecioMenu = new System.Windows.Forms.TextBox();
            this.txtDescripcionMenu = new System.Windows.Forms.TextBox();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.bntAceptarMenu = new System.Windows.Forms.Button();
            this.lblTipoPlatillo = new System.Windows.Forms.Label();
            this.lblFotoPlatillo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombrePlatillo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFotoMenu
            // 
            this.txtFotoMenu.Location = new System.Drawing.Point(289, 185);
            this.txtFotoMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFotoMenu.Name = "txtFotoMenu";
            this.txtFotoMenu.Size = new System.Drawing.Size(110, 23);
            this.txtFotoMenu.TabIndex = 20;
            // 
            // cbTipoMenu
            // 
            this.cbTipoMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMenu.FormattingEnabled = true;
            this.cbTipoMenu.Location = new System.Drawing.Point(289, 239);
            this.cbTipoMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoMenu.Name = "cbTipoMenu";
            this.cbTipoMenu.Size = new System.Drawing.Size(133, 23);
            this.cbTipoMenu.TabIndex = 21;
            // 
            // txtPrecioMenu
            // 
            this.txtPrecioMenu.Location = new System.Drawing.Point(289, 148);
            this.txtPrecioMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioMenu.Name = "txtPrecioMenu";
            this.txtPrecioMenu.Size = new System.Drawing.Size(110, 23);
            this.txtPrecioMenu.TabIndex = 19;
            // 
            // txtDescripcionMenu
            // 
            this.txtDescripcionMenu.Location = new System.Drawing.Point(289, 103);
            this.txtDescripcionMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionMenu.Name = "txtDescripcionMenu";
            this.txtDescripcionMenu.Size = new System.Drawing.Size(110, 23);
            this.txtDescripcionMenu.TabIndex = 18;
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.Location = new System.Drawing.Point(289, 65);
            this.txtNombrePlatillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(110, 23);
            this.txtNombrePlatillo.TabIndex = 17;
            // 
            // bntAceptarMenu
            // 
            this.bntAceptarMenu.Location = new System.Drawing.Point(235, 307);
            this.bntAceptarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntAceptarMenu.Name = "bntAceptarMenu";
            this.bntAceptarMenu.Size = new System.Drawing.Size(82, 22);
            this.bntAceptarMenu.TabIndex = 16;
            this.bntAceptarMenu.Text = "Aceptar";
            this.bntAceptarMenu.UseVisualStyleBackColor = true;
            this.bntAceptarMenu.Click += new System.EventHandler(this.bntAceptarMenu_Click);
            // 
            // lblTipoPlatillo
            // 
            this.lblTipoPlatillo.AutoSize = true;
            this.lblTipoPlatillo.Location = new System.Drawing.Point(131, 245);
            this.lblTipoPlatillo.Name = "lblTipoPlatillo";
            this.lblTipoPlatillo.Size = new System.Drawing.Size(30, 15);
            this.lblTipoPlatillo.TabIndex = 15;
            this.lblTipoPlatillo.Text = "Tipo";
            // 
            // lblFotoPlatillo
            // 
            this.lblFotoPlatillo.AutoSize = true;
            this.lblFotoPlatillo.Location = new System.Drawing.Point(131, 191);
            this.lblFotoPlatillo.Name = "lblFotoPlatillo";
            this.lblFotoPlatillo.Size = new System.Drawing.Size(31, 15);
            this.lblFotoPlatillo.TabIndex = 14;
            this.lblFotoPlatillo.Text = "Foto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(131, 156);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(115, 15);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio                       $";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(131, 108);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombrePlatillo
            // 
            this.lblNombrePlatillo.AutoSize = true;
            this.lblNombrePlatillo.Location = new System.Drawing.Point(131, 65);
            this.lblNombrePlatillo.Name = "lblNombrePlatillo";
            this.lblNombrePlatillo.Size = new System.Drawing.Size(51, 15);
            this.lblNombrePlatillo.TabIndex = 11;
            this.lblNombrePlatillo.Text = "Nombre";
            // 
            // FormAgregarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 402);
            this.Controls.Add(this.txtFotoMenu);
            this.Controls.Add(this.cbTipoMenu);
            this.Controls.Add(this.txtPrecioMenu);
            this.Controls.Add(this.txtDescripcionMenu);
            this.Controls.Add(this.txtNombrePlatillo);
            this.Controls.Add(this.bntAceptarMenu);
            this.Controls.Add(this.lblTipoPlatillo);
            this.Controls.Add(this.lblFotoPlatillo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombrePlatillo);
            this.Name = "FormAgregarPlatillo";
            this.Text = "FormAgregarPlatillo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFotoMenu;
        private ComboBox cbTipoMenu;
        private TextBox txtPrecioMenu;
        private TextBox txtDescripcionMenu;
        private TextBox txtNombrePlatillo;
        private Button bntAceptarMenu;
        private Label lblTipoPlatillo;
        private Label lblFotoPlatillo;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNombrePlatillo;
    }
}