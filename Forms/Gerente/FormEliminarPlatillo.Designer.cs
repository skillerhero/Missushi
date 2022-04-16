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
            this.dgTablaEliminar.Location = new System.Drawing.Point(12, 21);
            this.dgTablaEliminar.Name = "dgTablaEliminar";
            this.dgTablaEliminar.RowHeadersWidth = 51;
            this.dgTablaEliminar.RowTemplate.Height = 29;
            this.dgTablaEliminar.Size = new System.Drawing.Size(647, 241);
            this.dgTablaEliminar.TabIndex = 0;
            this.dgTablaEliminar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablaEliminar_CellContentDoubleClick);
            // 
            // btnEliminarPlatillo
            // 
            this.btnEliminarPlatillo.Location = new System.Drawing.Point(256, 386);
            this.btnEliminarPlatillo.Name = "btnEliminarPlatillo";
            this.btnEliminarPlatillo.Size = new System.Drawing.Size(154, 29);
            this.btnEliminarPlatillo.TabIndex = 1;
            this.btnEliminarPlatillo.Text = "Eliminar platillo";
            this.btnEliminarPlatillo.UseVisualStyleBackColor = true;
            this.btnEliminarPlatillo.Click += new System.EventHandler(this.btnEliminarPlatillo_Click);
            // 
            // txtPlatilloEliminar
            // 
            this.txtPlatilloEliminar.Location = new System.Drawing.Point(330, 324);
            this.txtPlatilloEliminar.Name = "txtPlatilloEliminar";
            this.txtPlatilloEliminar.Size = new System.Drawing.Size(180, 27);
            this.txtPlatilloEliminar.TabIndex = 2;
            // 
            // lblPlatilloEliminar
            // 
            this.lblPlatilloEliminar.AutoSize = true;
            this.lblPlatilloEliminar.Location = new System.Drawing.Point(190, 328);
            this.lblPlatilloEliminar.Name = "lblPlatilloEliminar";
            this.lblPlatilloEliminar.Size = new System.Drawing.Size(115, 20);
            this.lblPlatilloEliminar.TabIndex = 3;
            this.lblPlatilloEliminar.Text = "Nombre platillo";
            // 
            // FormEliminarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 459);
            this.Controls.Add(this.lblPlatilloEliminar);
            this.Controls.Add(this.txtPlatilloEliminar);
            this.Controls.Add(this.btnEliminarPlatillo);
            this.Controls.Add(this.dgTablaEliminar);
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