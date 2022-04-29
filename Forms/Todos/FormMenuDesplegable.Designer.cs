namespace Missushi.Forms.Todos {
    partial class FormMenuDesplegable {
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenuSub = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlbotonMenu = new System.Windows.Forms.Panel();
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.pnlMissushi = new System.Windows.Forms.Panel();
            this.lblMissushi = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlMenuSub.SuspendLayout();
            this.pnlbotonMenu.SuspendLayout();
            this.pnlMissushi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPrincipal.Controls.Add(this.pnlMenuSub);
            this.pnlPrincipal.Controls.Add(this.pnlbotonMenu);
            this.pnlPrincipal.Controls.Add(this.pnlMissushi);
            this.pnlPrincipal.Location = new System.Drawing.Point(1, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(240, 585);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlMenuSub
            // 
            this.pnlMenuSub.Controls.Add(this.btnEliminar);
            this.pnlMenuSub.Controls.Add(this.btnModificar);
            this.pnlMenuSub.Controls.Add(this.btnAgregar);
            this.pnlMenuSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuSub.Location = new System.Drawing.Point(0, 91);
            this.pnlMenuSub.Name = "pnlMenuSub";
            this.pnlMenuSub.Size = new System.Drawing.Size(240, 145);
            this.pnlMenuSub.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.Location = new System.Drawing.Point(0, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(240, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "eliminar platillo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.Location = new System.Drawing.Point(0, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(240, 29);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "modificar platillo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "agregar platillo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlbotonMenu
            // 
            this.pnlbotonMenu.Controls.Add(this.btnDesplegar);
            this.pnlbotonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbotonMenu.Location = new System.Drawing.Point(0, 51);
            this.pnlbotonMenu.Name = "pnlbotonMenu";
            this.pnlbotonMenu.Size = new System.Drawing.Size(240, 40);
            this.pnlbotonMenu.TabIndex = 1;
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesplegar.Location = new System.Drawing.Point(0, 0);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(240, 35);
            this.btnDesplegar.TabIndex = 0;
            this.btnDesplegar.Text = "menu";
            this.btnDesplegar.UseVisualStyleBackColor = true;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // pnlMissushi
            // 
            this.pnlMissushi.Controls.Add(this.lblMissushi);
            this.pnlMissushi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMissushi.Location = new System.Drawing.Point(0, 0);
            this.pnlMissushi.Name = "pnlMissushi";
            this.pnlMissushi.Size = new System.Drawing.Size(240, 51);
            this.pnlMissushi.TabIndex = 0;
            // 
            // lblMissushi
            // 
            this.lblMissushi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMissushi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMissushi.Location = new System.Drawing.Point(0, 0);
            this.lblMissushi.Name = "lblMissushi";
            this.lblMissushi.Size = new System.Drawing.Size(240, 51);
            this.lblMissushi.TabIndex = 0;
            this.lblMissushi.Text = "MISSUSHI";
            this.lblMissushi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMissushi.Click += new System.EventHandler(this.lblMissushi_Click);
            // 
            // FormMenuDesplegable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FormMenuDesplegable";
            this.Text = "FormMenuDesplegable";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlMenuSub.ResumeLayout(false);
            this.pnlbotonMenu.ResumeLayout(false);
            this.pnlMissushi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlPrincipal;
        private Panel pnlMenuSub;
        private Panel pnlMissushi;
        private Label lblMissushi;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Panel pnlbotonMenu;
        private Button btnDesplegar;
    }
}