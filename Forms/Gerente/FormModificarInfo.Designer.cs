namespace Missushi.Forms.Gerente {
    partial class FormModificarInfo {
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
            this.lblLatitud = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblFotoPrincipal = new System.Windows.Forms.Label();
            this.lblIdGerente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtIdGerente = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombreGerente = new System.Windows.Forms.Label();
            this.txtFotoPrincipal = new System.Windows.Forms.TextBox();
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
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(59, 183);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(44, 15);
            this.lblLatitud.TabIndex = 2;
            this.lblLatitud.Text = "Latitud";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(59, 233);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(55, 15);
            this.lblLongitud.TabIndex = 3;
            this.lblLongitud.Text = "Longitud";
            // 
            // lblFotoPrincipal
            // 
            this.lblFotoPrincipal.AutoSize = true;
            this.lblFotoPrincipal.Location = new System.Drawing.Point(48, 282);
            this.lblFotoPrincipal.Name = "lblFotoPrincipal";
            this.lblFotoPrincipal.Size = new System.Drawing.Size(80, 15);
            this.lblFotoPrincipal.TabIndex = 4;
            this.lblFotoPrincipal.Text = "Foto Principal";
            // 
            // lblIdGerente
            // 
            this.lblIdGerente.AutoSize = true;
            this.lblIdGerente.Location = new System.Drawing.Point(59, 326);
            this.lblIdGerente.Name = "lblIdGerente";
            this.lblIdGerente.Size = new System.Drawing.Size(60, 15);
            this.lblIdGerente.TabIndex = 5;
            this.lblIdGerente.Text = "Id gerente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(155, 127);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(155, 175);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(100, 23);
            this.txtLatitud.TabIndex = 8;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(155, 225);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 23);
            this.txtLongitud.TabIndex = 9;
            // 
            // txtIdGerente
            // 
            this.txtIdGerente.Location = new System.Drawing.Point(155, 326);
            this.txtIdGerente.Name = "txtIdGerente";
            this.txtIdGerente.Size = new System.Drawing.Size(100, 23);
            this.txtIdGerente.TabIndex = 11;
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
            this.btnModificar.Location = new System.Drawing.Point(365, 395);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombreGerente
            // 
            this.lblNombreGerente.AutoSize = true;
            this.lblNombreGerente.Location = new System.Drawing.Point(298, 334);
            this.lblNombreGerente.Name = "lblNombreGerente";
            this.lblNombreGerente.Size = new System.Drawing.Size(57, 15);
            this.lblNombreGerente.TabIndex = 14;
            this.lblNombreGerente.Text = "Nombre: ";
            // 
            // txtFotoPrincipal
            // 
            this.txtFotoPrincipal.Location = new System.Drawing.Point(155, 279);
            this.txtFotoPrincipal.Name = "txtFotoPrincipal";
            this.txtFotoPrincipal.Size = new System.Drawing.Size(100, 23);
            this.txtFotoPrincipal.TabIndex = 15;
            // 
            // FormModificarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFotoPrincipal);
            this.Controls.Add(this.lblNombreGerente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtIdGerente);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdGerente);
            this.Controls.Add(this.lblFotoPrincipal);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.lblLatitud);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormModificarInfo";
            this.Text = "FormModificarInfo";
            this.Load += new System.EventHandler(this.FormModificarInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblLatitud;
        private Label lblLongitud;
        private Label lblFotoPrincipal;
        private Label lblIdGerente;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtLatitud;
        private TextBox txtLongitud;
        private TextBox txtIdGerente;
        private Label lblInfo;
        private Button btnModificar;
        private Label lblNombreGerente;
        private TextBox txtFotoPrincipal;
    }
}