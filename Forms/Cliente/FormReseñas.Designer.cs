namespace Missushi.Forms.Cliente
{
    partial class FormReseñas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResenia
            // 
            this.btnResenia.Location = new System.Drawing.Point(323, 263);
            this.btnResenia.Name = "btnResenia";
            this.btnResenia.Size = new System.Drawing.Size(148, 59);
            this.btnResenia.TabIndex = 0;
            this.btnResenia.Text = "Enviar Reseña";
            this.btnResenia.UseVisualStyleBackColor = true;
            this.btnResenia.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReseñas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResenia);
            this.Name = "FormReseñas";
            this.Text = "FormReseñas";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnResenia;
    }
}