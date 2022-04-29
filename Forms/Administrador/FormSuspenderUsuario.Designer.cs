namespace Missushi.Forms.Administrador {
    partial class FormSuspenderUsuario {
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
            this.dgTablaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCambios = new System.Windows.Forms.Button();
            this.txtCorreoSuspender = new System.Windows.Forms.TextBox();
            this.lblSuspenderU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTablaUsuarios
            // 
            this.dgTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaUsuarios.Location = new System.Drawing.Point(12, 128);
            this.dgTablaUsuarios.Name = "dgTablaUsuarios";
            this.dgTablaUsuarios.RowHeadersVisible = false;
            this.dgTablaUsuarios.RowHeadersWidth = 51;
            this.dgTablaUsuarios.RowTemplate.Height = 29;
            this.dgTablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTablaUsuarios.Size = new System.Drawing.Size(965, 274);
            this.dgTablaUsuarios.TabIndex = 0;
            this.dgTablaUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablaUsuarios_CellDoubleClick);
            // 
            // btnCambios
            // 
            this.btnCambios.Location = new System.Drawing.Point(443, 439);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(94, 29);
            this.btnCambios.TabIndex = 1;
            this.btnCambios.Text = "Aceptar";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // txtCorreoSuspender
            // 
            this.txtCorreoSuspender.Location = new System.Drawing.Point(447, 415);
            this.txtCorreoSuspender.Name = "txtCorreoSuspender";
            this.txtCorreoSuspender.Size = new System.Drawing.Size(125, 23);
            this.txtCorreoSuspender.TabIndex = 2;
            // 
            // lblSuspenderU
            // 
            this.lblSuspenderU.AutoSize = true;
            this.lblSuspenderU.Location = new System.Drawing.Point(340, 415);
            this.lblSuspenderU.Name = "lblSuspenderU";
            this.lblSuspenderU.Size = new System.Drawing.Size(101, 15);
            this.lblSuspenderU.TabIndex = 3;
            this.lblSuspenderU.Text = "Correo de usuario";
            // 
            // FormSuspenderUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 557);
            this.Controls.Add(this.lblSuspenderU);
            this.Controls.Add(this.txtCorreoSuspender);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.dgTablaUsuarios);
            this.Name = "FormSuspenderUsuario";
            this.Text = "FormSuspenderUsuario";
            this.Controls.SetChildIndex(this.pbImagenesRestaurante, 0);
            this.Controls.SetChildIndex(this.dgTablaUsuarios, 0);
            this.Controls.SetChildIndex(this.btnCambios, 0);
            this.Controls.SetChildIndex(this.txtCorreoSuspender, 0);
            this.Controls.SetChildIndex(this.lblSuspenderU, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgTablaUsuarios;
        private Button btnCambios;
        private TextBox txtCorreoSuspender;
        private Label lblSuspenderU;
    }
}