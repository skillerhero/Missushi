namespace Missushi.Forms.Gerente {
    partial class FormEliminarPlatillo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarPlatillo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbAgregarPlatillo = new Missushi.Forms.PictureBoxPersonalizado();
            this.pbEliminarPlatillo = new Missushi.Forms.PictureBoxPersonalizado();
            this.btnAgregarPlatillo = new Missushi.Forms.BotonPersonalizado();
            this.btnEliminarPlatillo = new Missushi.Forms.BotonPersonalizado();
            this.txtIdPlatillo = new Missushi.Forms.TextBoxPersonalizado();
            this.lblIdPlatillo = new System.Windows.Forms.Label();
            this.dgTablaEliminar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAgregarPlatillo
            // 
            this.pbAgregarPlatillo.BackColor = System.Drawing.Color.White;
            this.pbAgregarPlatillo.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregarPlatillo.Image")));
            this.pbAgregarPlatillo.Location = new System.Drawing.Point(337, 436);
            this.pbAgregarPlatillo.Name = "pbAgregarPlatillo";
            this.pbAgregarPlatillo.Size = new System.Drawing.Size(100, 100);
            this.pbAgregarPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregarPlatillo.TabIndex = 0;
            this.pbAgregarPlatillo.TabStop = false;
            // 
            // pbEliminarPlatillo
            // 
            this.pbEliminarPlatillo.BackColor = System.Drawing.Color.White;
            this.pbEliminarPlatillo.Enabled = false;
            this.pbEliminarPlatillo.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarPlatillo.Image")));
            this.pbEliminarPlatillo.Location = new System.Drawing.Point(587, 436);
            this.pbEliminarPlatillo.Name = "pbEliminarPlatillo";
            this.pbEliminarPlatillo.Size = new System.Drawing.Size(100, 100);
            this.pbEliminarPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminarPlatillo.TabIndex = 4;
            this.pbEliminarPlatillo.TabStop = false;
            this.pbEliminarPlatillo.Click += new System.EventHandler(this.btnEliminarPlatillo_Click);
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnAgregarPlatillo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPlatillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlatillo.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPlatillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(337, 542);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(100, 45);
            this.btnAgregarPlatillo.TabIndex = 5;
            this.btnAgregarPlatillo.Text = "Agregar platillo";
            this.btnAgregarPlatillo.UseVisualStyleBackColor = false;
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.agregarPlatillo_Click);
            // 
            // btnEliminarPlatillo
            // 
            this.btnEliminarPlatillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnEliminarPlatillo.Enabled = false;
            this.btnEliminarPlatillo.FlatAppearance.BorderSize = 0;
            this.btnEliminarPlatillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlatillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnEliminarPlatillo.Location = new System.Drawing.Point(587, 542);
            this.btnEliminarPlatillo.Name = "btnEliminarPlatillo";
            this.btnEliminarPlatillo.Size = new System.Drawing.Size(100, 45);
            this.btnEliminarPlatillo.TabIndex = 6;
            this.btnEliminarPlatillo.Text = "Eliminar platillo";
            this.btnEliminarPlatillo.UseVisualStyleBackColor = false;
            this.btnEliminarPlatillo.Click += new System.EventHandler(this.btnEliminarPlatillo_Click);
            // 
            // txtIdPlatillo
            // 
            this.txtIdPlatillo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIdPlatillo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdPlatillo.Location = new System.Drawing.Point(513, 396);
            this.txtIdPlatillo.Multiline = true;
            this.txtIdPlatillo.Name = "txtIdPlatillo";
            this.txtIdPlatillo.Size = new System.Drawing.Size(100, 29);
            this.txtIdPlatillo.TabIndex = 7;
            this.txtIdPlatillo.TextChanged += new System.EventHandler(this.txtIdPlatillo_TextChanged);
            // 
            // lblIdPlatillo
            // 
            this.lblIdPlatillo.AutoSize = true;
            this.lblIdPlatillo.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdPlatillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblIdPlatillo.Location = new System.Drawing.Point(410, 388);
            this.lblIdPlatillo.Name = "lblIdPlatillo";
            this.lblIdPlatillo.Size = new System.Drawing.Size(97, 45);
            this.lblIdPlatillo.TabIndex = 8;
            this.lblIdPlatillo.Text = "Id platillo:";
            // 
            // dgTablaEliminar
            // 
            this.dgTablaEliminar.AllowUserToAddRows = false;
            this.dgTablaEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTablaEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTablaEliminar.BackgroundColor = System.Drawing.Color.White;
            this.dgTablaEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTablaEliminar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaEliminar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTablaEliminar.ColumnHeadersHeight = 30;
            this.dgTablaEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgTablaEliminar.EnableHeadersVisualStyles = false;
            this.dgTablaEliminar.GridColor = System.Drawing.Color.White;
            this.dgTablaEliminar.Location = new System.Drawing.Point(94, 140);
            this.dgTablaEliminar.Name = "dgTablaEliminar";
            this.dgTablaEliminar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaEliminar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTablaEliminar.RowHeadersVisible = false;
            this.dgTablaEliminar.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgTablaEliminar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTablaEliminar.RowTemplate.Height = 29;
            this.dgTablaEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTablaEliminar.Size = new System.Drawing.Size(835, 230);
            this.dgTablaEliminar.TabIndex = 9;
            this.dgTablaEliminar.SelectionChanged += new System.EventHandler(this.dgTablaEliminar_SelectionChanged);
            // 
            // FormEliminarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgTablaEliminar);
            this.Controls.Add(this.lblIdPlatillo);
            this.Controls.Add(this.txtIdPlatillo);
            this.Controls.Add(this.btnEliminarPlatillo);
            this.Controls.Add(this.btnAgregarPlatillo);
            this.Controls.Add(this.pbEliminarPlatillo);
            this.Controls.Add(this.pbAgregarPlatillo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEliminarPlatillo";
            this.Text = "FormEliminarPlatillo";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.pbAgregarPlatillo, 0);
            this.Controls.SetChildIndex(this.pbEliminarPlatillo, 0);
            this.Controls.SetChildIndex(this.btnAgregarPlatillo, 0);
            this.Controls.SetChildIndex(this.btnEliminarPlatillo, 0);
            this.Controls.SetChildIndex(this.txtIdPlatillo, 0);
            this.Controls.SetChildIndex(this.lblIdPlatillo, 0);
            this.Controls.SetChildIndex(this.dgTablaEliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBoxPersonalizado pbAgregarPlatillo;
        private PictureBoxPersonalizado pbEliminarPlatillo;
        private BotonPersonalizado btnAgregarPlatillo;
        private BotonPersonalizado btnEliminarPlatillo;
        private TextBoxPersonalizado txtIdPlatillo;
        private Label lblIdPlatillo;
        private DataGridView dgTablaEliminar;
    }
}