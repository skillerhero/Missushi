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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTablaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCambios = new System.Windows.Forms.Button();
            this.txtCorreoSuspender = new System.Windows.Forms.TextBox();
            this.lblSuspenderU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTablaUsuarios
            // 
            this.dgTablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTablaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgTablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTablaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTablaUsuarios.ColumnHeadersHeight = 30;
            this.dgTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgTablaUsuarios.EnableHeadersVisualStyles = false;
            this.dgTablaUsuarios.GridColor = System.Drawing.Color.White;
            this.dgTablaUsuarios.Location = new System.Drawing.Point(33, 128);
            this.dgTablaUsuarios.Name = "dgTablaUsuarios";
            this.dgTablaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTablaUsuarios.RowHeadersVisible = false;
            this.dgTablaUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgTablaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTablaUsuarios.RowTemplate.Height = 29;
            this.dgTablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTablaUsuarios.Size = new System.Drawing.Size(952, 274);
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
            this.txtCorreoSuspender.Size = new System.Drawing.Size(125, 27);
            this.txtCorreoSuspender.TabIndex = 2;
            // 
            // lblSuspenderU
            // 
            this.lblSuspenderU.AutoSize = true;
            this.lblSuspenderU.Location = new System.Drawing.Point(340, 415);
            this.lblSuspenderU.Name = "lblSuspenderU";
            this.lblSuspenderU.Size = new System.Drawing.Size(127, 20);
            this.lblSuspenderU.TabIndex = 3;
            this.lblSuspenderU.Text = "Correo de usuario";
            // 
            // FormSuspenderUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lblSuspenderU);
            this.Controls.Add(this.txtCorreoSuspender);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.dgTablaUsuarios);
            this.Name = "FormSuspenderUsuario";
            this.Text = "FormSuspenderUsuario";
            this.Controls.SetChildIndex(this.dgTablaUsuarios, 0);
            this.Controls.SetChildIndex(this.btnCambios, 0);
            this.Controls.SetChildIndex(this.txtCorreoSuspender, 0);
            this.Controls.SetChildIndex(this.lblSuspenderU, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
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