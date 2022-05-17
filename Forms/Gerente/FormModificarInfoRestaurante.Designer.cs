namespace Missushi.Forms.Gerente {
    partial class FormModificarInfoRestaurante {
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDireccionMaps = new System.Windows.Forms.TextBox();
            this.txtIdGerente = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtFotoPrincipal = new System.Windows.Forms.TextBox();
            this.txtNombreGerente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtFotoMaps = new System.Windows.Forms.TextBox();
            this.txtFotoMapaZonas = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDireccionMaps = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFotoPrincipal = new System.Windows.Forms.Label();
            this.lblIdGerente = new System.Windows.Forms.Label();
            this.lblFotoMaps = new System.Windows.Forms.Label();
            this.lblFotoMapaZonas = new System.Windows.Forms.Label();
            this.lblNombreGerente = new System.Windows.Forms.Label();
            this.btnModificar = new Missushi.Forms.BotonPersonalizado();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 87);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(155, 127);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(351, 42);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(155, 175);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtDireccionMaps
            // 
            this.txtDireccionMaps.Location = new System.Drawing.Point(155, 225);
            this.txtDireccionMaps.MaxLength = 100;
            this.txtDireccionMaps.Name = "txtDireccionMaps";
            this.txtDireccionMaps.Size = new System.Drawing.Size(100, 23);
            this.txtDireccionMaps.TabIndex = 3;
            // 
            // txtIdGerente
            // 
            this.txtIdGerente.Enabled = false;
            this.txtIdGerente.Location = new System.Drawing.Point(155, 366);
            this.txtIdGerente.Name = "txtIdGerente";
            this.txtIdGerente.Size = new System.Drawing.Size(100, 23);
            this.txtIdGerente.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(246, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(72, 15);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Información";
            // 
            // txtFotoPrincipal
            // 
            this.txtFotoPrincipal.Location = new System.Drawing.Point(155, 319);
            this.txtFotoPrincipal.Name = "txtFotoPrincipal";
            this.txtFotoPrincipal.Size = new System.Drawing.Size(100, 23);
            this.txtFotoPrincipal.TabIndex = 4;
            // 
            // txtNombreGerente
            // 
            this.txtNombreGerente.Enabled = false;
            this.txtNombreGerente.Location = new System.Drawing.Point(480, 361);
            this.txtNombreGerente.Name = "txtNombreGerente";
            this.txtNombreGerente.Size = new System.Drawing.Size(160, 23);
            this.txtNombreGerente.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 272);
            this.txtTelefono.MaxLength = 100;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtFotoMaps
            // 
            this.txtFotoMaps.Location = new System.Drawing.Point(540, 225);
            this.txtFotoMaps.Name = "txtFotoMaps";
            this.txtFotoMaps.Size = new System.Drawing.Size(100, 23);
            this.txtFotoMaps.TabIndex = 18;
            // 
            // txtFotoMapaZonas
            // 
            this.txtFotoMapaZonas.Location = new System.Drawing.Point(540, 293);
            this.txtFotoMapaZonas.Name = "txtFotoMapaZonas";
            this.txtFotoMapaZonas.Size = new System.Drawing.Size(100, 23);
            this.txtFotoMapaZonas.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblNombre.Location = new System.Drawing.Point(48, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 45);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblDescripcion.Location = new System.Drawing.Point(34, 124);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(107, 45);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblDireccion.Location = new System.Drawing.Point(39, 161);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 45);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDireccionMaps
            // 
            this.lblDireccionMaps.AutoSize = true;
            this.lblDireccionMaps.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccionMaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblDireccionMaps.Location = new System.Drawing.Point(7, 211);
            this.lblDireccionMaps.Name = "lblDireccionMaps";
            this.lblDireccionMaps.Size = new System.Drawing.Size(142, 45);
            this.lblDireccionMaps.TabIndex = 25;
            this.lblDireccionMaps.Text = "Url google maps";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblTelefono.Location = new System.Drawing.Point(38, 258);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 45);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFotoPrincipal
            // 
            this.lblFotoPrincipal.AutoSize = true;
            this.lblFotoPrincipal.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFotoPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblFotoPrincipal.Location = new System.Drawing.Point(25, 305);
            this.lblFotoPrincipal.Name = "lblFotoPrincipal";
            this.lblFotoPrincipal.Size = new System.Drawing.Size(124, 45);
            this.lblFotoPrincipal.TabIndex = 27;
            this.lblFotoPrincipal.Text = "Foto Principal";
            // 
            // lblIdGerente
            // 
            this.lblIdGerente.AutoSize = true;
            this.lblIdGerente.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdGerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblIdGerente.Location = new System.Drawing.Point(34, 352);
            this.lblIdGerente.Name = "lblIdGerente";
            this.lblIdGerente.Size = new System.Drawing.Size(92, 45);
            this.lblIdGerente.TabIndex = 28;
            this.lblIdGerente.Text = "Id gerente";
            // 
            // lblFotoMaps
            // 
            this.lblFotoMaps.AutoSize = true;
            this.lblFotoMaps.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFotoMaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblFotoMaps.Location = new System.Drawing.Point(336, 211);
            this.lblFotoMaps.Name = "lblFotoMaps";
            this.lblFotoMaps.Size = new System.Drawing.Size(170, 45);
            this.lblFotoMaps.TabIndex = 29;
            this.lblFotoMaps.Text = "Foto de google maps";
            // 
            // lblFotoMapaZonas
            // 
            this.lblFotoMapaZonas.AutoSize = true;
            this.lblFotoMapaZonas.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFotoMapaZonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblFotoMapaZonas.Location = new System.Drawing.Point(301, 279);
            this.lblFotoMapaZonas.Name = "lblFotoMapaZonas";
            this.lblFotoMapaZonas.Size = new System.Drawing.Size(218, 45);
            this.lblFotoMapaZonas.TabIndex = 30;
            this.lblFotoMapaZonas.Text = "Foto del mapa de las zonas";
            // 
            // lblNombreGerente
            // 
            this.lblNombreGerente.AutoSize = true;
            this.lblNombreGerente.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreGerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblNombreGerente.Location = new System.Drawing.Point(336, 347);
            this.lblNombreGerente.Name = "lblNombreGerente";
            this.lblNombreGerente.Size = new System.Drawing.Size(138, 45);
            this.lblNombreGerente.TabIndex = 31;
            this.lblNombreGerente.Text = "Nombre gerente";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnModificar.Location = new System.Drawing.Point(102, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(195, 34);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.Paint += new PaintEventHandler(cortarEsquinas);
            // 
            // FormModificarInfoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(772, 492);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblNombreGerente);
            this.Controls.Add(this.lblFotoMapaZonas);
            this.Controls.Add(this.lblFotoMaps);
            this.Controls.Add(this.lblIdGerente);
            this.Controls.Add(this.lblFotoPrincipal);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccionMaps);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFotoMapaZonas);
            this.Controls.Add(this.txtFotoMaps);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombreGerente);
            this.Controls.Add(this.txtFotoPrincipal);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtIdGerente);
            this.Controls.Add(this.txtDireccionMaps);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormModificarInfoRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missushi - Modificar info de restaurante";
            this.Load += new System.EventHandler(this.FormModificarInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtDireccion;
        private TextBox txtDireccionMaps;
        private TextBox txtIdGerente;
        private Label lblInfo;
        private TextBox txtFotoPrincipal;
        private TextBox txtNombreGerente;
        private TextBox txtTelefono;
        private TextBox txtFotoMaps;
        private TextBox txtFotoMapaZonas;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblDireccion;
        private Label lblDireccionMaps;
        private Label lblTelefono;
        private Label lblFotoPrincipal;
        private Label lblIdGerente;
        private Label lblFotoMaps;
        private Label lblFotoMapaZonas;
        private Label lblNombreGerente;
        private BotonPersonalizado btnModificar;
    }
}