using Missushi.Clases;

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
            this.pnlAgregarPlatillo = new System.Windows.Forms.Panel();
            this.bntAceptarMenu = new Missushi.Forms.BotonPersonalizado();
            this.cbTipoMenu = new Missushi.Forms.ComboBoxPersonalizado();
            this.txtNombrePlatillo = new Missushi.Forms.TextBoxPersonalizado();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcionMenu = new Missushi.Forms.TextBoxPersonalizado();
            this.txtPrecioMenu = new Missushi.Forms.TextBoxPersonalizado();
            this.txtFotoMenu = new Missushi.Forms.TextBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.pnlAgregarPlatillo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregarPlatillo
            // 
            this.pnlAgregarPlatillo.Controls.Add(this.txtFotoMenu);
            this.pnlAgregarPlatillo.Controls.Add(this.txtPrecioMenu);
            this.pnlAgregarPlatillo.Controls.Add(this.txtDescripcionMenu);
            this.pnlAgregarPlatillo.Controls.Add(this.bntAceptarMenu);
            this.pnlAgregarPlatillo.Controls.Add(this.cbTipoMenu);
            this.pnlAgregarPlatillo.Controls.Add(this.txtNombrePlatillo);
            this.pnlAgregarPlatillo.Controls.Add(this.lblTipo);
            this.pnlAgregarPlatillo.Controls.Add(this.lblFoto);
            this.pnlAgregarPlatillo.Controls.Add(this.lblPrecio);
            this.pnlAgregarPlatillo.Controls.Add(this.lblDescripcion);
            this.pnlAgregarPlatillo.Controls.Add(this.lblNombre);
            this.pnlAgregarPlatillo.Location = new System.Drawing.Point(359, 187);
            this.pnlAgregarPlatillo.Name = "pnlAgregarPlatillo";
            this.pnlAgregarPlatillo.Size = new System.Drawing.Size(355, 301);
            this.pnlAgregarPlatillo.TabIndex = 22;
            // 
            // bntAceptarMenu
            // 
            this.bntAceptarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.bntAceptarMenu.FlatAppearance.BorderSize = 0;
            this.bntAceptarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAceptarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.bntAceptarMenu.Location = new System.Drawing.Point(0, 264);
            this.bntAceptarMenu.Name = "bntAceptarMenu";
            this.bntAceptarMenu.Size = new System.Drawing.Size(350, 34);
            this.bntAceptarMenu.TabIndex = 10;
            this.bntAceptarMenu.Text = "Agregar";
            this.bntAceptarMenu.UseVisualStyleBackColor = false;
            this.bntAceptarMenu.Click += new System.EventHandler(this.bntAceptarMenu_Click);
            this.bntAceptarMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // cbTipoMenu
            // 
            this.cbTipoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.cbTipoMenu.DisplayMember = "Text";
            this.cbTipoMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.cbTipoMenu.FormattingEnabled = true;
            this.cbTipoMenu.Location = new System.Drawing.Point(150, 216);
            this.cbTipoMenu.Name = "cbTipoMenu";
            this.cbTipoMenu.Size = new System.Drawing.Size(200, 28);
            this.cbTipoMenu.TabIndex = 9;
            this.cbTipoMenu.ValueMember = "Value";
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtNombrePlatillo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombrePlatillo.Location = new System.Drawing.Point(150, 10);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(200, 30);
            this.txtNombrePlatillo.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblTipo.Location = new System.Drawing.Point(0, 200);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(59, 50);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblFoto.Location = new System.Drawing.Point(0, 150);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(59, 50);
            this.lblFoto.TabIndex = 3;
            this.lblFoto.Text = "Foto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblPrecio.Location = new System.Drawing.Point(0, 100);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(72, 50);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblDescripcion.Location = new System.Drawing.Point(0, 50);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(120, 50);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 50);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDescripcionMenu
            // 
            this.txtDescripcionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtDescripcionMenu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcionMenu.Location = new System.Drawing.Point(150, 60);
            this.txtDescripcionMenu.Name = "txtDescripcionMenu";
            this.txtDescripcionMenu.Size = new System.Drawing.Size(200, 30);
            this.txtDescripcionMenu.TabIndex = 11;
            // 
            // txtPrecioMenu
            // 
            this.txtPrecioMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtPrecioMenu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioMenu.Location = new System.Drawing.Point(150, 110);
            this.txtPrecioMenu.Name = "txtPrecioMenu";
            this.txtPrecioMenu.Size = new System.Drawing.Size(200, 30);
            this.txtPrecioMenu.TabIndex = 12;
            // 
            // txtFotoMenu
            // 
            this.txtFotoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtFotoMenu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFotoMenu.Location = new System.Drawing.Point(150, 160);
            this.txtFotoMenu.Name = "txtFotoMenu";
            this.txtFotoMenu.Size = new System.Drawing.Size(200, 30);
            this.txtFotoMenu.TabIndex = 13;
            // 
            // FormAgregarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.pnlAgregarPlatillo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAgregarPlatillo";
            this.Text = "Missushi - Agregar platillo";
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.pnlAgregarPlatillo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.pnlAgregarPlatillo.ResumeLayout(false);
            this.pnlAgregarPlatillo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlAgregarPlatillo;
        private Label lblNombre;
        private ComboBoxPersonalizado cbTipoMenu;
        private TextBoxPersonalizado txtNombrePlatillo;
        private Label lblTipo;
        private Label lblFoto;
        private Label lblPrecio;
        private Label lblDescripcion;
        private BotonPersonalizado bntAceptarMenu;
        private TextBoxPersonalizado txtFotoMenu;
        private TextBoxPersonalizado txtPrecioMenu;
        private TextBoxPersonalizado txtDescripcionMenu;
    }
}