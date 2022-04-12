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
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.btnLoginCliente = new System.Windows.Forms.Button();
            this.btnLoginGerente = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(169, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info.";
            this.lblInfo.Visible = false;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(21, 471);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 25;
            this.dgUsuarios.Size = new System.Drawing.Size(745, 150);
            this.dgUsuarios.TabIndex = 3;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(219, 372);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistroClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(76, 372);
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
            this.pbLogo.Location = new System.Drawing.Point(46, 41);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(286, 313);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            this.pbLogo.WaitOnLoad = true;
            // 
            // cbTablas
            // 
            this.cbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(451, 440);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(121, 23);
            this.cbTablas.TabIndex = 5;
            this.cbTablas.SelectedIndexChanged += new System.EventHandler(this.cbTablas_SelectedIndexChanged);
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Location = new System.Drawing.Point(460, 292);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(95, 47);
            this.btnLoginAdmin.TabIndex = 6;
            this.btnLoginAdmin.Text = "Entrar como admin";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // btnLoginCliente
            // 
            this.btnLoginCliente.Location = new System.Drawing.Point(460, 225);
            this.btnLoginCliente.Name = "btnLoginCliente";
            this.btnLoginCliente.Size = new System.Drawing.Size(89, 47);
            this.btnLoginCliente.TabIndex = 7;
            this.btnLoginCliente.Text = "Entrar como cliente";
            this.btnLoginCliente.UseVisualStyleBackColor = true;
            this.btnLoginCliente.Click += new System.EventHandler(this.btnLoginCliente_Click);
            // 
            // btnLoginGerente
            // 
            this.btnLoginGerente.Location = new System.Drawing.Point(464, 142);
            this.btnLoginGerente.Name = "btnLoginGerente";
            this.btnLoginGerente.Size = new System.Drawing.Size(85, 47);
            this.btnLoginGerente.TabIndex = 8;
            this.btnLoginGerente.Text = "Entrar como gerente";
            this.btnLoginGerente.UseVisualStyleBackColor = true;
            this.btnLoginGerente.Click += new System.EventHandler(this.btnLoginGerente_Click);
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(332, 439);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(75, 23);
            this.btnQR.TabIndex = 9;
            this.btnQR.Text = "QR";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(229, 439);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(82, 22);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 648);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnLoginGerente);
            this.Controls.Add(this.btnLoginCliente);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private Button btnLoginAdmin;
        private Button btnLoginCliente;
        private Button btnLoginGerente;
        private Button btnQR;
        private Button btnMenu;
    }
}