namespace Missushi.Forms
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(107, 65);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(84, 20);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombre (s)";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(239, 61);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.MaxLength = 80;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(114, 27);
            this.txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(239, 144);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidos.MaxLength = 80;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(114, 27);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(239, 216);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(114, 27);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(239, 356);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(114, 27);
            this.txtCorreo.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(239, 423);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(114, 28);
            this.cbTipo.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(190, 506);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 31);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(108, 154);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 20);
            this.lblApellidos.TabIndex = 0;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(107, 216);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(83, 20);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(118, 356);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(54, 20);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(127, 427);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Location = new System.Drawing.Point(46, 289);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(163, 20);
            this.lblContraseña2.TabIndex = 6;
            this.lblContraseña2.Text = "Contraseña confirmada";
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(239, 286);
            this.txtConfirmarContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmarContra.MaxLength = 50;
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(114, 27);
            this.txtConfirmarContra.TabIndex = 3;
            this.txtConfirmarContra.UseSystemPasswordChar = true;
            // 
            // FormRegistro
            // 
            this.AcceptButton = this.btnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 594);
            this.Controls.Add(this.lblContraseña2);
            this.Controls.Add(this.txtConfirmarContra);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistro_FormClosing);
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombres;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtContraseña;
        private TextBox txtCorreo;
        private ComboBox cbTipo;
        private Button btnRegistrar;
        private Label lblApellidos;
        private Label lblContraseña;
        private Label lblCorreo;
        private Label lblTipo;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Label lblContraseña2;
        private TextBox txtConfirmarContra;
    }
}