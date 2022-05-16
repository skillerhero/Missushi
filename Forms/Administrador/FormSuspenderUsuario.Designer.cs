using Missushi.Clases;

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
            this.lblSuspenderU = new System.Windows.Forms.Label();
            this.btnCambios = new Missushi.Forms.BotonPersonalizado();
            this.txtCorreoSuspender = new Missushi.Forms.TextBoxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTablaUsuarios
            // 
            this.dgTablaUsuarios.AllowUserToAddRows = false;
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
            this.dgTablaUsuarios.Location = new System.Drawing.Point(147, 158);
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
            this.dgTablaUsuarios.Size = new System.Drawing.Size(730, 280);
            this.dgTablaUsuarios.TabIndex = 0;
            this.dgTablaUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablaUsuarios_CellDoubleClick);
            // 
            // lblSuspenderU
            // 
            this.lblSuspenderU.AutoSize = true;
            this.lblSuspenderU.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSuspenderU.Location = new System.Drawing.Point(364, 465);
            this.lblSuspenderU.Name = "lblSuspenderU";
            this.lblSuspenderU.Size = new System.Drawing.Size(135, 39);
            this.lblSuspenderU.TabIndex = 3;
            this.lblSuspenderU.Text = "Correo de usuario:";
            // 
            // btnCambios
            // 
            this.btnCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnCambios.FlatAppearance.BorderSize = 0;
            this.btnCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnCambios.Location = new System.Drawing.Point(420, 528);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(185, 29);
            this.btnCambios.TabIndex = 4;
            this.btnCambios.Text = "Suspender Usuario";
            this.btnCambios.UseVisualStyleBackColor = false;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            this.btnCambios.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // txtCorreoSuspender
            // 
            this.txtCorreoSuspender.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCorreoSuspender.Location = new System.Drawing.Point(505, 473);
            this.txtCorreoSuspender.Multiline = true;
            this.txtCorreoSuspender.Name = "txtCorreoSuspender";
            this.txtCorreoSuspender.Size = new System.Drawing.Size(155, 23);
            this.txtCorreoSuspender.TabIndex = 5;
            // 
            // FormSuspenderUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.txtCorreoSuspender);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.lblSuspenderU);
            this.Controls.Add(this.dgTablaUsuarios);
            this.Name = "FormSuspenderUsuario";
            this.Text = "Missushi - Suspender usuario";
            this.Controls.SetChildIndex(this.dgTablaUsuarios, 0);
            this.Controls.SetChildIndex(this.lblSuspenderU, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.btnCambios, 0);
            this.Controls.SetChildIndex(this.txtCorreoSuspender, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgTablaUsuarios;
        private Label lblSuspenderU;
        private BotonPersonalizado btnCambios;
        private TextBoxPersonalizado txtCorreoSuspender;
    }
}