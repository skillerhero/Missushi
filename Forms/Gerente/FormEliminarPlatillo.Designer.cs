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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTablaEliminar = new System.Windows.Forms.DataGridView();
            this.btnEliminarPlatillo = new System.Windows.Forms.Button();
            this.txtIdPlatillo = new System.Windows.Forms.TextBox();
            this.lblPlatilloEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTablaEliminar
            // 
            this.dgTablaEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTablaEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTablaEliminar.BackgroundColor = System.Drawing.Color.White;
            this.dgTablaEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTablaEliminar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaEliminar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTablaEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgTablaEliminar.EnableHeadersVisualStyles = false;
            this.dgTablaEliminar.GridColor = System.Drawing.Color.White;
            this.dgTablaEliminar.Location = new System.Drawing.Point(95, 140);
            this.dgTablaEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTablaEliminar.Name = "dgTablaEliminar";
            this.dgTablaEliminar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaEliminar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTablaEliminar.RowHeadersVisible = false;
            this.dgTablaEliminar.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgTablaEliminar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTablaEliminar.RowTemplate.Height = 29;
            this.dgTablaEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTablaEliminar.Size = new System.Drawing.Size(833, 232);
            this.dgTablaEliminar.TabIndex = 0;
            this.dgTablaEliminar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablaEliminar_CellContentDoubleClick);
            // 
            // btnEliminarPlatillo
            // 
            this.btnEliminarPlatillo.Location = new System.Drawing.Point(361, 436);
            this.btnEliminarPlatillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPlatillo.Name = "btnEliminarPlatillo";
            this.btnEliminarPlatillo.Size = new System.Drawing.Size(135, 22);
            this.btnEliminarPlatillo.TabIndex = 1;
            this.btnEliminarPlatillo.Text = "Eliminar platillo";
            this.btnEliminarPlatillo.UseVisualStyleBackColor = true;
            this.btnEliminarPlatillo.Click += new System.EventHandler(this.btnEliminarPlatillo_Click);
            // 
            // txtIdPlatillo
            // 
            this.txtIdPlatillo.Location = new System.Drawing.Point(426, 389);
            this.txtIdPlatillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPlatillo.Name = "txtIdPlatillo";
            this.txtIdPlatillo.Size = new System.Drawing.Size(158, 27);
            this.txtIdPlatillo.TabIndex = 2;
            // 
            // lblPlatilloEliminar
            // 
            this.lblPlatilloEliminar.AutoSize = true;
            this.lblPlatilloEliminar.Location = new System.Drawing.Point(347, 397);
            this.lblPlatilloEliminar.Name = "lblPlatilloEliminar";
            this.lblPlatilloEliminar.Size = new System.Drawing.Size(73, 20);
            this.lblPlatilloEliminar.TabIndex = 3;
            this.lblPlatilloEliminar.Text = "Id platillo";
            // 
            // FormEliminarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lblPlatilloEliminar);
            this.Controls.Add(this.txtIdPlatillo);
            this.Controls.Add(this.btnEliminarPlatillo);
            this.Controls.Add(this.dgTablaEliminar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEliminarPlatillo";
            this.Text = "FormEliminarPlatillo";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.dgTablaEliminar, 0);
            this.Controls.SetChildIndex(this.btnEliminarPlatillo, 0);
            this.Controls.SetChildIndex(this.txtIdPlatillo, 0);
            this.Controls.SetChildIndex(this.lblPlatilloEliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgTablaEliminar;
        private Button btnEliminarPlatillo;
        private TextBox txtIdPlatillo;
        private Label lblPlatilloEliminar;
    }
}