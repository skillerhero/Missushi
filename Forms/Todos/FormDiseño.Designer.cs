using Missushi.Clases;

namespace Missushi.Forms {
    partial class FormDiseño {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiseño));
            this.lblBarraPrincipal = new System.Windows.Forms.Label();
            this.pbLogo = new Missushi.Forms.PictureBoxPersonalizado();
            this.lblMenu = new Missushi.Forms.LabelPersonalizado();
            this.pbUbicacion = new Missushi.Forms.PictureBoxPersonalizado();
            this.lblIngresar = new Missushi.Forms.LabelPersonalizado();
            this.lblRegistro = new Missushi.Forms.LabelPersonalizado();
            this.lblUbicacion = new Missushi.Forms.LabelPersonalizado();
            this.lblDisponibilidad = new Missushi.Forms.LabelPersonalizado();
            this.pbDisponibilidad = new Missushi.Forms.PictureBoxPersonalizado();
            this.pbMenu = new Missushi.Forms.PictureBoxPersonalizado();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.lblBarra2 = new System.Windows.Forms.Label();
            this.lblBarra3 = new System.Windows.Forms.Label();
            this.lblBarra4 = new System.Windows.Forms.Label();
            this.lblBarra5 = new System.Windows.Forms.Label();
            this.pbImagenesRestaurante = new System.Windows.Forms.PictureBox();
            this.pbLetrasLogo = new System.Windows.Forms.PictureBox();
            this.btnReseñas = new Missushi.Forms.BotonPersonalizado();
            this.pbSalir = new Missushi.Forms.PictureBoxPersonalizado();
            this.lblTitulo = new Missushi.Forms.LabelPersonalizado();
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.pbMenuDesplegable = new Missushi.Forms.PictureBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisponibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuDesplegable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarraPrincipal
            // 
            this.lblBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lblBarraPrincipal.Name = "lblBarraPrincipal";
            this.lblBarraPrincipal.Size = new System.Drawing.Size(1024, 75);
            this.lblBarraPrincipal.TabIndex = 0;
            this.lblBarraPrincipal.DoubleClick += new System.EventHandler(this.lblBarraPrincipal_DoubleClick);
            this.lblBarraPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDiseño_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbLogo.Image = global::Missushi.Properties.Resources.logoFondoRosaHD;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(75, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblMenu.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(95, 12);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(70, 50);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // pbUbicacion
            // 
            this.pbUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbUbicacion.Image = global::Missushi.Properties.Resources.mapa;
            this.pbUbicacion.Location = new System.Drawing.Point(340, 15);
            this.pbUbicacion.Name = "pbUbicacion";
            this.pbUbicacion.Size = new System.Drawing.Size(45, 45);
            this.pbUbicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUbicacion.TabIndex = 0;
            this.pbUbicacion.TabStop = false;
            this.pbUbicacion.Click += new System.EventHandler(this.pbUbicacion_Click);
            this.pbUbicacion.MouseLeave += new System.EventHandler(this.leave);
            this.pbUbicacion.MouseHover += new System.EventHandler(this.hover);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblIngresar.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngresar.ForeColor = System.Drawing.Color.White;
            this.lblIngresar.Location = new System.Drawing.Point(920, 12);
            this.lblIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(91, 50);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Ingresar";
            this.lblIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIngresar.Click += new System.EventHandler(this.lblIngresar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblRegistro.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(790, 12);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(90, 50);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblUbicacion.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUbicacion.ForeColor = System.Drawing.Color.White;
            this.lblUbicacion.Location = new System.Drawing.Point(240, 12);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(106, 50);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "Ubicación";
            this.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUbicacion.Click += new System.EventHandler(this.lblUbicacion_Click);
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.lblDisponibilidad.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisponibilidad.ForeColor = System.Drawing.Color.White;
            this.lblDisponibilidad.Location = new System.Drawing.Point(425, 15);
            this.lblDisponibilidad.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(146, 50);
            this.lblDisponibilidad.TabIndex = 0;
            this.lblDisponibilidad.Text = "Disponibilidad";
            this.lblDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisponibilidad.Click += new System.EventHandler(this.lblDisponibilidad_Click);
            // 
            // pbDisponibilidad
            // 
            this.pbDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbDisponibilidad.Image = global::Missushi.Properties.Resources.disponi;
            this.pbDisponibilidad.Location = new System.Drawing.Point(565, 15);
            this.pbDisponibilidad.Name = "pbDisponibilidad";
            this.pbDisponibilidad.Size = new System.Drawing.Size(45, 45);
            this.pbDisponibilidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisponibilidad.TabIndex = 0;
            this.pbDisponibilidad.TabStop = false;
            this.pbDisponibilidad.Click += new System.EventHandler(this.pbDisponibilidad_Click);
            this.pbDisponibilidad.MouseLeave += new System.EventHandler(this.leave);
            this.pbDisponibilidad.MouseHover += new System.EventHandler(this.hover);
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbMenu.Image = global::Missushi.Properties.Resources.menu;
            this.pbMenu.Location = new System.Drawing.Point(160, 15);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(45, 45);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            this.pbMenu.MouseLeave += new System.EventHandler(this.leave);
            this.pbMenu.MouseHover += new System.EventHandler(this.hover);
            // 
            // lblBarra1
            // 
            this.lblBarra1.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra1.Location = new System.Drawing.Point(225, 15);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(1, 45);
            this.lblBarra1.TabIndex = 0;
            // 
            // lblBarra2
            // 
            this.lblBarra2.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra2.Location = new System.Drawing.Point(405, 15);
            this.lblBarra2.Name = "lblBarra2";
            this.lblBarra2.Size = new System.Drawing.Size(1, 45);
            this.lblBarra2.TabIndex = 0;
            // 
            // lblBarra3
            // 
            this.lblBarra3.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra3.Location = new System.Drawing.Point(630, 15);
            this.lblBarra3.Name = "lblBarra3";
            this.lblBarra3.Size = new System.Drawing.Size(1, 45);
            this.lblBarra3.TabIndex = 0;
            // 
            // lblBarra4
            // 
            this.lblBarra4.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra4.Location = new System.Drawing.Point(770, 15);
            this.lblBarra4.Name = "lblBarra4";
            this.lblBarra4.Size = new System.Drawing.Size(1, 45);
            this.lblBarra4.TabIndex = 0;
            // 
            // lblBarra5
            // 
            this.lblBarra5.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarra5.Location = new System.Drawing.Point(900, 15);
            this.lblBarra5.Name = "lblBarra5";
            this.lblBarra5.Size = new System.Drawing.Size(1, 45);
            this.lblBarra5.TabIndex = 0;
            // 
            // pbImagenesRestaurante
            // 
            this.pbImagenesRestaurante.Location = new System.Drawing.Point(62, 135);
            this.pbImagenesRestaurante.Name = "pbImagenesRestaurante";
            this.pbImagenesRestaurante.Size = new System.Drawing.Size(900, 380);
            this.pbImagenesRestaurante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenesRestaurante.TabIndex = 0;
            this.pbImagenesRestaurante.TabStop = false;
            this.pbImagenesRestaurante.WaitOnLoad = true;
            // 
            // pbLetrasLogo
            // 
            this.pbLetrasLogo.Image = global::Missushi.Properties.Resources.miss;
            this.pbLetrasLogo.Location = new System.Drawing.Point(402, 75);
            this.pbLetrasLogo.Name = "pbLetrasLogo";
            this.pbLetrasLogo.Size = new System.Drawing.Size(220, 60);
            this.pbLetrasLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLetrasLogo.TabIndex = 0;
            this.pbLetrasLogo.TabStop = false;
            this.pbLetrasLogo.Visible = false;
            // 
            // btnReseñas
            // 
            this.btnReseñas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.btnReseñas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReseñas.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReseñas.ForeColor = System.Drawing.Color.White;
            this.btnReseñas.Location = new System.Drawing.Point(446, 521);
            this.btnReseñas.Name = "btnReseñas";
            this.btnReseñas.Size = new System.Drawing.Size(116, 44);
            this.btnReseñas.TabIndex = 1;
            this.btnReseñas.Text = "Reseñas";
            this.btnReseñas.UseVisualStyleBackColor = false;
            this.btnReseñas.Visible = false;
            this.btnReseñas.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbSalir.Image = global::Missushi.Properties.Resources.salir;
            this.pbSalir.Location = new System.Drawing.Point(940, 15);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(45, 45);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 0;
            this.pbSalir.TabStop = false;
            this.pbSalir.Visible = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(402, 75);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 68);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Visible = false;
            // 
            // lblBarraTitulo
            // 
            this.lblBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(199)))), ((int)(((byte)(183)))));
            this.lblBarraTitulo.Location = new System.Drawing.Point(402, 128);
            this.lblBarraTitulo.Name = "lblBarraTitulo";
            this.lblBarraTitulo.Size = new System.Drawing.Size(95, 7);
            this.lblBarraTitulo.TabIndex = 0;
            this.lblBarraTitulo.Visible = false;
            // 
            // pbMenuDesplegable
            // 
            this.pbMenuDesplegable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbMenuDesplegable.Image = global::Missushi.Properties.Resources.disponi1;
            this.pbMenuDesplegable.Location = new System.Drawing.Point(0, 0);
            this.pbMenuDesplegable.Name = "pbMenuDesplegable";
            this.pbMenuDesplegable.Size = new System.Drawing.Size(75, 75);
            this.pbMenuDesplegable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuDesplegable.TabIndex = 0;
            this.pbMenuDesplegable.TabStop = false;
            this.pbMenuDesplegable.Visible = false;
            this.pbMenuDesplegable.Click += new System.EventHandler(this.pbMenuDesplegable_Click);
            // 
            // FormDiseño
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lblBarraTitulo);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.lblBarra3);
            this.Controls.Add(this.pbUbicacion);
            this.Controls.Add(this.lblBarra4);
            this.Controls.Add(this.lblBarra2);
            this.Controls.Add(this.lblBarra5);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.pbDisponibilidad);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.lblBarra1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnReseñas);
            this.Controls.Add(this.pbImagenesRestaurante);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbLetrasLogo);
            this.Controls.Add(this.pbMenuDesplegable);
            this.Controls.Add(this.lblBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDiseño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiseño";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDiseño_FormClosing);
            this.Load += new System.EventHandler(this.FormDiseño_Load);
            this.DoubleClick += new System.EventHandler(this.FormDiseño_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDiseño_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisponibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuDesplegable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBarraPrincipal;
        private PictureBoxPersonalizado pbLogo;
        private Label lblBarra1;
        private Label lblBarra2;
        private Label lblBarra3;
        private Label lblBarra4;
        private Label lblBarra5;
        private PictureBoxPersonalizado pbSalir;
        private LabelPersonalizado lblMenu;
        private LabelPersonalizado lblIngresar;
        private LabelPersonalizado lblRegistro;
        private LabelPersonalizado lblUbicacion;
        private LabelPersonalizado lblDisponibilidad;
        private PictureBoxPersonalizado pbUbicacion;
        private PictureBoxPersonalizado pbDisponibilidad;
        private PictureBoxPersonalizado pbMenu;
        protected LabelPersonalizado lblTitulo;
        protected Label lblBarraTitulo;
        protected PictureBox pbImagenesRestaurante;
        protected PictureBox pbLetrasLogo;
        private BotonPersonalizado btnReseñas;
        private PictureBoxPersonalizado pbMenuDesplegable;
    }
}