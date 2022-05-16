using Missushi.Clases;

namespace Missushi.Forms
{
    partial class FormLogin{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCorreo = new Missushi.Forms.TextBoxPersonalizado();
            this.txtContraseña = new Missushi.Forms.TextBoxPersonalizado();
            this.btnIngresar = new Missushi.Forms.BotonPersonalizado();
            this.pictureBoxPersonalizado1 = new Missushi.Forms.PictureBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonalizado1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblCorreo.Location = new System.Drawing.Point(330, 309);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(78, 50);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblContraseña.Location = new System.Drawing.Point(330, 372);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 50);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "Contraseña";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.gerenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(179, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // gerenteToolStripMenuItem
            // 
            this.gerenteToolStripMenuItem.Name = "gerenteToolStripMenuItem";
            this.gerenteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gerenteToolStripMenuItem.Text = "Gerente";
            this.gerenteToolStripMenuItem.Click += new System.EventHandler(this.gerenteToolStripMenuItem_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtCorreo.Location = new System.Drawing.Point(477, 321);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(175, 26);
            this.txtCorreo.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtContraseña.Location = new System.Drawing.Point(476, 384);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(175, 26);
            this.txtContraseña.TabIndex = 2;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnIngresar.Location = new System.Drawing.Point(330, 448);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(321, 38);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Iniciar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // pictureBoxPersonalizado1
            // 
            this.pictureBoxPersonalizado1.BackColor = System.Drawing.Color.White;
            this.pictureBoxPersonalizado1.Image = global::Missushi.Properties.Resources.login;
            this.pictureBoxPersonalizado1.Location = new System.Drawing.Point(402, 141);
            this.pictureBoxPersonalizado1.Name = "pictureBoxPersonalizado1";
            this.pictureBoxPersonalizado1.Size = new System.Drawing.Size(220, 165);
            this.pictureBoxPersonalizado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersonalizado1.TabIndex = 0;
            this.pictureBoxPersonalizado1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.pictureBoxPersonalizado1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogin";
            this.Text = "Missushi - Login";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.pictureBoxPersonalizado1, 0);
            this.Controls.SetChildIndex(this.lblCorreo, 0);
            this.Controls.SetChildIndex(this.lblContraseña, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            this.Controls.SetChildIndex(this.txtContraseña, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonalizado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCorreo;
        private Label lblContraseña;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem gerenteToolStripMenuItem;
        private TextBoxPersonalizado txtCorreo;
        private TextBoxPersonalizado txtContraseña;
        private BotonPersonalizado btnIngresar;
        private PictureBoxPersonalizado pictureBoxPersonalizado1;
    }
}