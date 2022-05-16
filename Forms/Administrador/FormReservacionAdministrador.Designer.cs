using Missushi.Clases;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservacionAdministrador));
            this.pbHacerReservacion = new System.Windows.Forms.PictureBox();
            this.pbCancelarReservacion = new System.Windows.Forms.PictureBox();
            this.btnHacerReservacion = new Missushi.Forms.BotonPersonalizado();
            this.btnCancelarReservacion = new Missushi.Forms.BotonPersonalizado();
            this.dgReservaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHacerReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelarReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHacerReservacion
            // 
            this.pbHacerReservacion.Image = global::Missushi.Properties.Resources.reservar1;
            this.pbHacerReservacion.Location = new System.Drawing.Point(340, 436);
            this.pbHacerReservacion.Name = "pbHacerReservacion";
            this.pbHacerReservacion.Size = new System.Drawing.Size(106, 100);
            this.pbHacerReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHacerReservacion.TabIndex = 3;
            this.pbHacerReservacion.TabStop = false;
            // 
            // pbCancelarReservacion
            // 
            this.pbCancelarReservacion.Image = global::Missushi.Properties.Resources.cancelar;
            this.pbCancelarReservacion.Location = new System.Drawing.Point(630, 443);
            this.pbCancelarReservacion.Name = "pbCancelarReservacion";
            this.pbCancelarReservacion.Size = new System.Drawing.Size(108, 93);
            this.pbCancelarReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelarReservacion.TabIndex = 4;
            this.pbCancelarReservacion.TabStop = false;
            // 
            // btnHacerReservacion
            // 
            this.btnHacerReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnHacerReservacion.FlatAppearance.BorderSize = 0;
            this.btnHacerReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerReservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnHacerReservacion.Location = new System.Drawing.Point(340, 542);
            this.btnHacerReservacion.Name = "btnHacerReservacion";
            this.btnHacerReservacion.Size = new System.Drawing.Size(106, 45);
            this.btnHacerReservacion.TabIndex = 5;
            this.btnHacerReservacion.Text = "Hacer Reservación";
            this.btnHacerReservacion.UseVisualStyleBackColor = false;
            this.btnHacerReservacion.Click += new System.EventHandler(this.btnHacerReservacion_Click);
            this.btnHacerReservacion.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnCancelarReservacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnCancelarReservacion.Location = new System.Drawing.Point(632, 542);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(106, 45);
            this.btnCancelarReservacion.TabIndex = 6;
            this.btnCancelarReservacion.Text = "Cancelar Reservación";
            this.btnCancelarReservacion.UseVisualStyleBackColor = false;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.btnCancelarReservacion_Click);
            this.btnCancelarReservacion.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // dgReservaciones
            // 
            this.dgReservaciones.AllowUserToAddRows = false;
            this.dgReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgReservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgReservaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgReservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReservaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReservaciones.ColumnHeadersHeight = 30;
            this.dgReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReservaciones.EnableHeadersVisualStyles = false;
            this.dgReservaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.dgReservaciones.Location = new System.Drawing.Point(62, 173);
            this.dgReservaciones.Name = "dgReservaciones";
            this.dgReservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgReservaciones.RowHeadersVisible = false;
            this.dgReservaciones.RowHeadersWidth = 51;
            this.dgReservaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgReservaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgReservaciones.RowTemplate.Height = 29;
            this.dgReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservaciones.Size = new System.Drawing.Size(897, 257);
            this.dgReservaciones.TabIndex = 8;
            this.dgReservaciones.SelectionChanged += new System.EventHandler(this.dgReservaciones_SelectionChanged);
            // 
            // FormReservacionAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgReservaciones);
            this.Controls.Add(this.btnCancelarReservacion);
            this.Controls.Add(this.btnHacerReservacion);
            this.Controls.Add(this.pbCancelarReservacion);
            this.Controls.Add(this.pbHacerReservacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReservacionAdministrador";
            this.Text = "Modificacion de reservación";
            this.Load += new System.EventHandler(this.FormReservacionAdministrador_Load);
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.pbHacerReservacion, 0);
            this.Controls.SetChildIndex(this.pbCancelarReservacion, 0);
            this.Controls.SetChildIndex(this.btnHacerReservacion, 0);
            this.Controls.SetChildIndex(this.btnCancelarReservacion, 0);
            this.Controls.SetChildIndex(this.dgReservaciones, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHacerReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelarReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pbHacerReservacion;
        private PictureBox pbCancelarReservacion;
        private BotonPersonalizado btnHacerReservacion;
        private BotonPersonalizado btnCancelarReservacion;
        private DataGridView dgReservaciones;
    }
}