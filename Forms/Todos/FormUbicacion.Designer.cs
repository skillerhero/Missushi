﻿namespace Missushi.Forms.Todos {
    partial class FormUbicacion : FormDiseño {
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
            this.pbFotoMaps = new Missushi.Forms.PictureBoxPersonalizado();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotoMaps
            // 
            this.pbFotoMaps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFotoMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(120)))), ((int)(((byte)(79)))));
            this.pbFotoMaps.Location = new System.Drawing.Point(160, 100);
            this.pbFotoMaps.Name = "pbFotoMaps";
            this.pbFotoMaps.Size = new System.Drawing.Size(700, 400);
            this.pbFotoMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoMaps.TabIndex = 0;
            this.pbFotoMaps.TabStop = false;
            this.pbFotoMaps.WaitOnLoad = true;
            this.pbFotoMaps.Click += new System.EventHandler(this.pbFotoMaps_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(240, 518);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(240, 553);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // FormUbicacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.pbFotoMaps);
            this.Name = "FormUbicacion";
            this.Text = "Missushi - Ubicación";
            this.Controls.SetChildIndex(this.pbFotoMaps, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoMaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxPersonalizado pbFotoMaps;
        private Label lblDireccion;
        private Label lblDescripcion;
    }
}