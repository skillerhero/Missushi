namespace Missushi.Forms.Todos {
    public partial class FormPantallaDeCarga : Form {
        private int count = 0;
        public FormPantallaDeCarga() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            count += 2;
            if (count == 102) {
                count = 0;
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                return;
            } else {
                progressBar1.Value = count;
                lblPorcentaje.Text = count.ToString() + "%";
            }         
        }

        private void FormPantallaDeCarga_Shown(object sender, EventArgs e) {
            progressBar1.Maximum = 100;
            progressBar1.Step = 2;
            progressBar1.Value = 0;
            timer1.Start();
        }
    }
}
