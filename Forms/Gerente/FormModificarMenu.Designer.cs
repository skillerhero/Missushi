namespace Missushi.Forms.Gerente {
    partial class FormModificarMenu {
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
            this.lblNombrePlatillo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFotoPlatillo = new System.Windows.Forms.Label();
            this.lblTipoPlatillo = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.bntAceptarMenu = new System.Windows.Forms.Button();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.txtDescripcionMenu = new System.Windows.Forms.TextBox();
            this.txtPrecioMenu = new System.Windows.Forms.TextBox();
            this.txtFotoMenu = new System.Windows.Forms.TextBox();
            this.cbTipoMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombrePlatillo
            // 
            this.lblNombrePlatillo.AutoSize = true;
            this.lblNombrePlatillo.Location = new System.Drawing.Point(238, 50);
            this.lblNombrePlatillo.Name = "lblNombrePlatillo";
            this.lblNombrePlatillo.Size = new System.Drawing.Size(64, 20);
            this.lblNombrePlatillo.TabIndex = 0;
            this.lblNombrePlatillo.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(238, 108);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(238, 164);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(150, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio                       $";
            // 
            // lblFotoPlatillo
            // 
            this.lblFotoPlatillo.AutoSize = true;
            this.lblFotoPlatillo.Location = new System.Drawing.Point(238, 218);
            this.lblFotoPlatillo.Name = "lblFotoPlatillo";
            this.lblFotoPlatillo.Size = new System.Drawing.Size(39, 20);
            this.lblFotoPlatillo.TabIndex = 3;
            this.lblFotoPlatillo.Text = "Foto";
            // 
            // lblTipoPlatillo
            // 
            this.lblTipoPlatillo.AutoSize = true;
            this.lblTipoPlatillo.Location = new System.Drawing.Point(238, 290);
            this.lblTipoPlatillo.Name = "lblTipoPlatillo";
            this.lblTipoPlatillo.Size = new System.Drawing.Size(39, 20);
            this.lblTipoPlatillo.TabIndex = 4;
            this.lblTipoPlatillo.Text = "Tipo";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // bntAceptarMenu
            // 
            this.bntAceptarMenu.BackColor = System.Drawing.Color.Crimson;
            this.bntAceptarMenu.Location = new System.Drawing.Point(315, 366);
            this.bntAceptarMenu.Name = "bntAceptarMenu";
            this.bntAceptarMenu.Size = new System.Drawing.Size(94, 29);
            this.bntAceptarMenu.TabIndex = 5;
            this.bntAceptarMenu.Text = "Aceptar";
            this.bntAceptarMenu.UseVisualStyleBackColor = false;
            this.bntAceptarMenu.Click += new System.EventHandler(this.bntAceptarMenu_Click);
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.Location = new System.Drawing.Point(418, 51);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(125, 27);
            this.txtNombrePlatillo.TabIndex = 6;
            // 
            // txtDescripcionMenu
            // 
            this.txtDescripcionMenu.Location = new System.Drawing.Point(418, 101);
            this.txtDescripcionMenu.Name = "txtDescripcionMenu";
            this.txtDescripcionMenu.Size = new System.Drawing.Size(125, 27);
            this.txtDescripcionMenu.TabIndex = 7;
            // 
            // txtPrecioMenu
            // 
            this.txtPrecioMenu.Location = new System.Drawing.Point(418, 161);
            this.txtPrecioMenu.Name = "txtPrecioMenu";
            this.txtPrecioMenu.Size = new System.Drawing.Size(125, 27);
            this.txtPrecioMenu.TabIndex = 8;
            // 
            // txtFotoMenu
            // 
            this.txtFotoMenu.Location = new System.Drawing.Point(418, 211);
            this.txtFotoMenu.Name = "txtFotoMenu";
            this.txtFotoMenu.Size = new System.Drawing.Size(125, 27);
            this.txtFotoMenu.TabIndex = 9;
            // 
            // cbTipoMenu
            // 
            this.cbTipoMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMenu.FormattingEnabled = true;
            this.cbTipoMenu.Location = new System.Drawing.Point(418, 282);
            this.cbTipoMenu.Name = "cbTipoMenu";
            this.cbTipoMenu.Size = new System.Drawing.Size(151, 28);
            this.cbTipoMenu.TabIndex = 10;
            // 
            // FormModificarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormModificarMenu";
            this.Text = "FormModificarMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombrePlatillo;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblFotoPlatillo;
        private Label lblTipoPlatillo;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Button bntAceptarMenu;
        private TextBox txtNombrePlatillo;
        private TextBox txtDescripcionMenu;
        private TextBox txtPrecioMenu;
        private TextBox txtFotoMenu;
        private ComboBox cbTipoMenu;
    }
}