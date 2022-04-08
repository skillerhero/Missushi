namespace Missushi.Forms.Administrador {
    partial class FormReservacionAdministrador {
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
            this.btnHacerReservacion = new System.Windows.Forms.Button();
            this.dgReservaciones = new System.Windows.Forms.DataGridView();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(50, 248);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(98, 41);
            this.btnHacerReservacion.TabIndex = 0;
            this.btnHacerReservacion.Text = "Hacer reservacion";
            this.btnHacerReservacion.UseVisualStyleBackColor = true;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReservaciones.EnableHeadersVisualStyles = false;
            this.dgReservaciones.GridColor = System.Drawing.Color.DarkBlue;
            this.dgReservaciones.Location = new System.Drawing.Point(38, 46);
            this.dgReservaciones.Name = "dgReservaciones";
            this.dgReservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReservaciones.RowHeadersVisible = false;
            this.dgReservaciones.RowTemplate.Height = 25;
            this.dgReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservaciones.Size = new System.Drawing.Size(665, 150);
            this.dgReservaciones.TabIndex = 1;
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.Location = new System.Drawing.Point(194, 248);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(99, 39);
            this.btnCancelarReservacion.TabIndex = 2;
            this.btnCancelarReservacion.Text = "Cancelar Reservacion";
            this.btnCancelarReservacion.UseVisualStyleBackColor = true;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.btnCancelarReservacion_Click);
            // 
            // FormReservacionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 359);
            this.Controls.Add(this.btnCancelarReservacion);
            this.Controls.Add(this.dgReservaciones);
            this.Controls.Add(this.btnHacerReservacion);
            this.Name = "FormReservacionAdministrador";
            this.Text = "FormReservacionAdministrador";
            this.Load += new System.EventHandler(this.FormReservacionAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHacerReservacion;
        private DataGridView dgReservaciones;
        private Button btnCancelarReservacion;
    }
}