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
            this.dgTablaEliminar = new System.Windows.Forms.DataGridView();
            this.btnEliminarPlatillo = new System.Windows.Forms.Button();
            this.txtPlatilloEliminar = new System.Windows.Forms.TextBox();
            this.lblPlatilloEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTablaEliminar
            // 
            this.dgTablaEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaEliminar.Location = new System.Drawing.Point(10, 16);
            this.dgTablaEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTablaEliminar.Name = "dgTablaEliminar";
            this.dgTablaEliminar.RowHeadersWidth = 51;
            this.dgTablaEliminar.RowTemplate.Height = 29;
            this.dgTablaEliminar.Size = new System.Drawing.Size(566, 181);
            this.dgTablaEliminar.TabIndex = 0;
            this.dgTablaEliminar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablaEliminar_CellContentDoubleClick);
            // 
            // btnEliminarPlatillo
            // 
            this.btnEliminarPlatillo.Location = new System.Drawing.Point(224, 290);
            this.btnEliminarPlatillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPlatillo.Name = "btnEliminarPlatillo";
            this.btnEliminarPlatillo.Size = new System.Drawing.Size(135, 22);
            this.btnEliminarPlatillo.TabIndex = 1;
            this.btnEliminarPlatillo.Text = "Eliminar platillo";
            this.btnEliminarPlatillo.UseVisualStyleBackColor = true;
            this.btnEliminarPlatillo.Click += new System.EventHandler(this.btnEliminarPlatillo_Click);
            // 
            // txtPlatilloEliminar
            // 
            this.txtPlatilloEliminar.Location = new System.Drawing.Point(289, 243);
            this.txtPlatilloEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlatilloEliminar.Name = "txtPlatilloEliminar";
            this.txtPlatilloEliminar.Size = new System.Drawing.Size(158, 23);
            this.txtPlatilloEliminar.TabIndex = 2;
            // 
            // lblPlatilloEliminar
            // 
            this.lblPlatilloEliminar.AutoSize = true;
            this.lblPlatilloEliminar.Location = new System.Drawing.Point(166, 246);
            this.lblPlatilloEliminar.Name = "lblPlatilloEliminar";
            this.lblPlatilloEliminar.Size = new System.Drawing.Size(90, 15);
            this.lblPlatilloEliminar.TabIndex = 3;
            this.lblPlatilloEliminar.Text = "Nombre platillo";
            // 
            // FormEliminarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 344);
            this.Controls.Add(this.lblPlatilloEliminar);
            this.Controls.Add(this.txtPlatilloEliminar);
            this.Controls.Add(this.btnEliminarPlatillo);
            this.Controls.Add(this.dgTablaEliminar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEliminarPlatillo";
            this.Text = "FormEliminarPlatillo";
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgTablaEliminar;
        private Button btnEliminarPlatillo;
        private TextBox txtPlatilloEliminar;
        private Label lblPlatilloEliminar;
    }
}