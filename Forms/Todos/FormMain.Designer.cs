using Missushi.Forms;

namespace Missushi
{
    partial class FormMain : FormDiseño{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfoRestaurante = new Missushi.Forms.LabelPersonalizado();
            this.SuspendLayout();
            // 
            // lblInfoRestaurante
            // 
            this.lblInfoRestaurante.AutoSize = true;
            this.lblInfoRestaurante.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoRestaurante.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoRestaurante.ForeColor = System.Drawing.Color.Black;
            this.lblInfoRestaurante.Location = new System.Drawing.Point(299, 561);
            this.lblInfoRestaurante.Name = "lblInfoRestaurante";
            this.lblInfoRestaurante.Size = new System.Drawing.Size(425, 45);
            this.lblInfoRestaurante.TabIndex = 0;
            this.lblInfoRestaurante.Text = "Correo: jessicaCA@gmail.com      Teléfono: 644-2510241";
            this.lblInfoRestaurante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lblInfoRestaurante);
            this.Name = "FormMain";
            this.Text = "Home";
            this.HandleCreated += new EventHandler(this.mostrarPantallaDeCarga);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Controls.SetChildIndex(this.lblInfoRestaurante, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelPersonalizado lblInfoRestaurante;
    }
}