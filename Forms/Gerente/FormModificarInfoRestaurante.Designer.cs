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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDireccionMaps = new System.Windows.Forms.Label();
            this.lblFotoPrincipal = new System.Windows.Forms.Label();
            this.lblIdGerente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDireccionMaps = new System.Windows.Forms.TextBox();
            this.txtIdGerente = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombreGerente = new System.Windows.Forms.Label();
            this.txtFotoPrincipal = new System.Windows.Forms.TextBox();
            this.txtNombreGerente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(59, 135);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(59, 183);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDireccionMaps
            // 
            this.lblDireccionMaps.AutoSize = true;
            this.lblDireccionMaps.Location = new System.Drawing.Point(34, 233);
            this.lblDireccionMaps.Name = "lblDireccionMaps";
            this.lblDireccionMaps.Size = new System.Drawing.Size(94, 15);
            this.lblDireccionMaps.TabIndex = 0;
            this.lblDireccionMaps.Text = "Url google maps";
            // 
            // lblFotoPrincipal
            // 
            this.lblFotoPrincipal.AutoSize = true;
            this.lblFotoPrincipal.Location = new System.Drawing.Point(48, 322);
            this.lblFotoPrincipal.Name = "lblFotoPrincipal";
            this.lblFotoPrincipal.Size = new System.Drawing.Size(80, 15);
            this.lblFotoPrincipal.TabIndex = 0;
            this.lblFotoPrincipal.Text = "Foto Principal";
            // 
            // lblIdGerente
            // 
            this.lblIdGerente.AutoSize = true;
            this.lblIdGerente.Location = new System.Drawing.Point(59, 366);
            this.lblIdGerente.Name = "lblIdGerente";
            this.lblIdGerente.Size = new System.Drawing.Size(60, 15);
            this.lblIdGerente.TabIndex = 0;
            this.lblIdGerente.Text = "Id gerente";
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(369, 428);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombreGerente
            // 
            this.lblNombreGerente.AutoSize = true;
            this.lblNombreGerente.Location = new System.Drawing.Point(291, 369);
            this.lblNombreGerente.Name = "lblNombreGerente";
            this.lblNombreGerente.Size = new System.Drawing.Size(100, 15);
            this.lblNombreGerente.TabIndex = 14;
            this.lblNombreGerente.Text = "Nombre gerente: ";
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
            this.txtNombreGerente.Location = new System.Drawing.Point(397, 366);
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
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(58, 275);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono";
            // 
            // FormModificarInfoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtNombreGerente);
            this.Controls.Add(this.txtFotoPrincipal);
            this.Controls.Add(this.lblNombreGerente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtIdGerente);
            this.Controls.Add(this.txtDireccionMaps);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdGerente);
            this.Controls.Add(this.lblFotoPrincipal);
            this.Controls.Add(this.lblDireccionMaps);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormModificarInfoRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarInfo";
            this.Load += new System.EventHandler(this.FormModificarInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblDireccion;
        private Label lblDireccionMaps;
        private Label lblFotoPrincipal;
        private Label lblIdGerente;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtDireccion;
        private TextBox txtDireccionMaps;
        private TextBox txtIdGerente;
        private Label lblInfo;
        private Button btnModificar;
        private Label lblNombreGerente;
        private TextBox txtFotoPrincipal;
        private TextBox txtNombreGerente;
        private TextBox txtTelefono;
        private Label lblTelefono;
    }
}