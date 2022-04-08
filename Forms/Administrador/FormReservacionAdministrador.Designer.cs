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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservacionAdministrador));
            this.btnHacerReservacion = new System.Windows.Forms.Button();
            this.dgReservaciones = new System.Windows.Forms.DataGridView();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.Location = new System.Drawing.Point(202, 331);
            this.btnHacerReservacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(112, 55);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgReservaciones.ColumnHeadersHeight = 30;
            this.dgReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgReservaciones.EnableHeadersVisualStyles = false;
            this.dgReservaciones.GridColor = System.Drawing.Color.DarkBlue;
            this.dgReservaciones.Location = new System.Drawing.Point(43, 61);
            this.dgReservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReservaciones.Name = "dgReservaciones";
            this.dgReservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReservaciones.RowHeadersVisible = false;
            this.dgReservaciones.RowHeadersWidth = 51;
            this.dgReservaciones.RowTemplate.Height = 25;
            this.dgReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservaciones.Size = new System.Drawing.Size(760, 200);
            this.dgReservaciones.TabIndex = 1;
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.Location = new System.Drawing.Point(515, 334);
            this.btnCancelarReservacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(113, 52);
            this.btnCancelarReservacion.TabIndex = 2;
            this.btnCancelarReservacion.Text = "Cancelar Reservacion";
            this.btnCancelarReservacion.UseVisualStyleBackColor = true;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.btnCancelarReservacion_Click);
            // 
            // FormReservacionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(840, 479);
            this.Controls.Add(this.btnCancelarReservacion);
            this.Controls.Add(this.dgReservaciones);
            this.Controls.Add(this.btnHacerReservacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReservacionAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de reservación";
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