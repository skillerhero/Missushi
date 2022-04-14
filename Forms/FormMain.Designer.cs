namespace Missushi
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarComoGerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarComoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarComoAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(141, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info.";
            this.lblInfo.Visible = false;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(12, 136);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 25;
            this.dgUsuarios.Size = new System.Drawing.Size(928, 150);
            this.dgUsuarios.TabIndex = 3;
            this.dgUsuarios.Visible = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(198, 367);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistroClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(34, 42);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(286, 309);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            this.pbLogo.WaitOnLoad = true;
            // 
            // cbTablas
            // 
            this.cbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(289, 107);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(121, 23);
            this.cbTablas.TabIndex = 5;
            this.cbTablas.Visible = false;
            this.cbTablas.SelectedIndexChanged += new System.EventHandler(this.cbTablas_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.entrarToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.verBaseDeDatosToolStripMenuItem,
            this.qRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarComoGerenteToolStripMenuItem,
            this.entrarComoClienteToolStripMenuItem,
            this.entrarComoAdminToolStripMenuItem});
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.entrarToolStripMenuItem.Text = "Entrar";
            // 
            // entrarComoGerenteToolStripMenuItem
            // 
            this.entrarComoGerenteToolStripMenuItem.Name = "entrarComoGerenteToolStripMenuItem";
            this.entrarComoGerenteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entrarComoGerenteToolStripMenuItem.Text = "Entrar como gerente";
            this.entrarComoGerenteToolStripMenuItem.Click += new System.EventHandler(this.entrarComoGerenteToolStripMenuItem_Click);
            // 
            // entrarComoClienteToolStripMenuItem
            // 
            this.entrarComoClienteToolStripMenuItem.Name = "entrarComoClienteToolStripMenuItem";
            this.entrarComoClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entrarComoClienteToolStripMenuItem.Text = "Entrar como cliente";
            this.entrarComoClienteToolStripMenuItem.Click += new System.EventHandler(this.entrarComoClienteToolStripMenuItem_Click);
            // 
            // entrarComoAdminToolStripMenuItem
            // 
            this.entrarComoAdminToolStripMenuItem.Name = "entrarComoAdminToolStripMenuItem";
            this.entrarComoAdminToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entrarComoAdminToolStripMenuItem.Text = "Entrar como admin";
            this.entrarComoAdminToolStripMenuItem.Click += new System.EventHandler(this.entrarComoAdminToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // verBaseDeDatosToolStripMenuItem
            // 
            this.verBaseDeDatosToolStripMenuItem.Name = "verBaseDeDatosToolStripMenuItem";
            this.verBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.verBaseDeDatosToolStripMenuItem.Text = "Ver Base de datos";
            this.verBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.verBaseDeDatosToolStripMenuItem_Click);
            // 
            // qRToolStripMenuItem
            // 
            this.qRToolStripMenuItem.Name = "qRToolStripMenuItem";
            this.qRToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.qRToolStripMenuItem.Text = "QR";
            this.qRToolStripMenuItem.Click += new System.EventHandler(this.qRToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 411);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Label lblInfo;
        private DataGridView dgUsuarios;
        private Button btnRegistro;
        private Button btnLogin;
        private PictureBox pbLogo;
        private ComboBox cbTablas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem entrarToolStripMenuItem;
        private ToolStripMenuItem entrarComoGerenteToolStripMenuItem;
        private ToolStripMenuItem entrarComoClienteToolStripMenuItem;
        private ToolStripMenuItem entrarComoAdminToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem verBaseDeDatosToolStripMenuItem;
        private ToolStripMenuItem qRToolStripMenuItem;
    }
}