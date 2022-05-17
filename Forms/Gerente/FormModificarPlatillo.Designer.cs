namespace Missushi.Forms.Gerente {
    partial class FormModificarPlatillo {
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
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new Missushi.Forms.TextBoxPersonalizado();
            this.txtFoto = new Missushi.Forms.TextBoxPersonalizado();
            this.txtPrecio = new Missushi.Forms.TextBoxPersonalizado();
            this.txtDescripcion = new Missushi.Forms.TextBoxPersonalizado();
            this.cbTipo = new Missushi.Forms.ComboBoxPersonalizado();
            this.btnModificarPlatillo = new Missushi.Forms.BotonPersonalizado();
            this.dgPlatillosModi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblFoto.Location = new System.Drawing.Point(575, 460);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(52, 45);
            this.lblFoto.TabIndex = 13;
            this.lblFoto.Text = "Foto";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblTipo.Location = new System.Drawing.Point(175, 400);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(54, 45);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblNombre.Location = new System.Drawing.Point(175, 460);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 45);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblPrecio.Location = new System.Drawing.Point(575, 400);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 45);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.lblDescripcion.Location = new System.Drawing.Point(175, 520);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(107, 45);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(297, 468);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 30);
            this.txtNombre.TabIndex = 18;
            // 
            // txtFoto
            // 
            this.txtFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtFoto.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFoto.Location = new System.Drawing.Point(648, 468);
            this.txtFoto.Multiline = true;
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(200, 30);
            this.txtFoto.TabIndex = 19;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(648, 408);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 30);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(297, 528);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 30);
            this.txtDescripcion.TabIndex = 21;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(196)))));
            this.cbTipo.DisplayMember = "Text";
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(297, 408);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(200, 28);
            this.cbTipo.TabIndex = 22;
            this.cbTipo.ValueMember = "Value";
            // 
            // btnModificarPlatillo
            // 
            this.btnModificarPlatillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.btnModificarPlatillo.FlatAppearance.BorderSize = 0;
            this.btnModificarPlatillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPlatillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(44)))));
            this.btnModificarPlatillo.Location = new System.Drawing.Point(575, 525);
            this.btnModificarPlatillo.Name = "btnModificarPlatillo";
            this.btnModificarPlatillo.Size = new System.Drawing.Size(273, 34);
            this.btnModificarPlatillo.TabIndex = 23;
            this.btnModificarPlatillo.Text = "Modificar";
            this.btnModificarPlatillo.UseVisualStyleBackColor = false;
            this.btnModificarPlatillo.Click += new System.EventHandler(this.btnModificarPlatillo_Click);
            this.btnModificarPlatillo.Paint += new System.Windows.Forms.PaintEventHandler(this.cortarEsquinas);
            // 
            // dgPlatillosModi
            // 
            this.dgPlatillosModi.AllowUserToAddRows = false;
            this.dgPlatillosModi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPlatillosModi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPlatillosModi.BackgroundColor = System.Drawing.Color.White;
            this.dgPlatillosModi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPlatillosModi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlatillosModi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPlatillosModi.ColumnHeadersHeight = 30;
            this.dgPlatillosModi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPlatillosModi.EnableHeadersVisualStyles = false;
            this.dgPlatillosModi.GridColor = System.Drawing.Color.White;
            this.dgPlatillosModi.Location = new System.Drawing.Point(62, 142);
            this.dgPlatillosModi.Name = "dgPlatillosModi";
            this.dgPlatillosModi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlatillosModi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPlatillosModi.RowHeadersVisible = false;
            this.dgPlatillosModi.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPlatillosModi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPlatillosModi.RowTemplate.Height = 29;
            this.dgPlatillosModi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlatillosModi.Size = new System.Drawing.Size(900, 230);
            this.dgPlatillosModi.TabIndex = 24;
            this.dgPlatillosModi.SelectionChanged += new System.EventHandler(this.dgPlatillosModi_SelectionChanged);
            // 
            // FormModificarPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgPlatillosModi);
            this.Controls.Add(this.btnModificarPlatillo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFoto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificarPlatillo";
            this.Text = "Missushi - Modificar platillo";
            this.Controls.SetChildIndex(this.pbLetrasLogo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBarraTitulo, 0);
            this.Controls.SetChildIndex(this.lblFoto, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtFoto, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cbTipo, 0);
            this.Controls.SetChildIndex(this.btnModificarPlatillo, 0);
            this.Controls.SetChildIndex(this.dgPlatillosModi, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrasLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlatillosModi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblFoto;
        private Label lblTipo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblDescripcion;
        private TextBoxPersonalizado txtNombre;
        private TextBoxPersonalizado txtFoto;
        private TextBoxPersonalizado txtPrecio;
        private TextBoxPersonalizado txtDescripcion;
        private ComboBoxPersonalizado cbTipo;
        private BotonPersonalizado btnModificarPlatillo;
        private DataGridView dgPlatillosModi;
    }
}