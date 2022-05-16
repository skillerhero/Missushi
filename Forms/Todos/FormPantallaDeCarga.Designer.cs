namespace Missushi.Forms.Todos {
    partial class FormPantallaDeCarga {
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
            this.components = new System.ComponentModel.Container();
            this.pbGif = new Missushi.Forms.PictureBoxPersonalizado();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new Missushi.Forms.LabelPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGif
            // 
            this.pbGif.BackColor = System.Drawing.Color.White;
            this.pbGif.Location = new System.Drawing.Point(100, 5);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(150, 150);
            this.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGif.TabIndex = 0;
            this.pbGif.TabStop = false;
            this.pbGif.Cursor = Cursors.Default;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 30);
            this.progressBar1.TabIndex = 1;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Location = new System.Drawing.Point(147, 198);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(56, 54);
            this.lblPorcentaje.TabIndex = 0;
            this.lblPorcentaje.Text = "0%";
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPantallaDeCarga
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.ControlBox = false;
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPantallaDeCarga";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando";
            this.Shown += new System.EventHandler(this.FormPantallaDeCarga_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxPersonalizado pbGif;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private LabelPersonalizado lblPorcentaje;
    }
}