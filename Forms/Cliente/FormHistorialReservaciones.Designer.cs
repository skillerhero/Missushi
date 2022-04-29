namespace Missushi.Forms.Cliente {
    partial class FormHistorialReservaciones {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            this.dgReservaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarReservacion);
            this.panel1.Controls.Add(this.dgReservaciones);
            this.panel1.Location = new System.Drawing.Point(12, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 257);
            this.panel1.TabIndex = 5;
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.Location = new System.Drawing.Point(488, 212);
            this.btnCancelarReservacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(113, 52);
            this.btnCancelarReservacion.TabIndex = 6;
            this.btnCancelarReservacion.Text = "Cancelar Reservacion";
            this.btnCancelarReservacion.UseVisualStyleBackColor = true;
            // 
            // dgReservaciones
            // 
            this.dgReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgReservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgReservaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgReservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReservaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgReservaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReservaciones.ColumnHeadersHeight = 30;
            this.dgReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReservaciones.EnableHeadersVisualStyles = false;
            this.dgReservaciones.GridColor = System.Drawing.Color.DarkBlue;
            this.dgReservaciones.Location = new System.Drawing.Point(16, 4);
            this.dgReservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReservaciones.Name = "dgReservaciones";
            this.dgReservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReservaciones.RowHeadersVisible = false;
            this.dgReservaciones.RowHeadersWidth = 51;
            this.dgReservaciones.RowTemplate.Height = 25;
            this.dgReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservaciones.Size = new System.Drawing.Size(760, 200);
            this.dgReservaciones.TabIndex = 5;
            // 
            // FormHistorialReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormHistorialReservaciones";
            this.Text = "FormHistorialReservaciones";
            this.Controls.SetChildIndex(this.pbImagenesRestaurante, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenesRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnCancelarReservacion;
        private DataGridView dgReservaciones;
    }
}