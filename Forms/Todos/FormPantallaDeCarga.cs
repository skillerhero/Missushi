using Missushi.Properties;
using System.Diagnostics;

namespace Missushi.Forms.Todos {
    public partial class FormPantallaDeCarga : Form {
        private int count = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FormPantallaDeCarga() {
            InitializeComponent();
            this.lblPorcentaje.Cursor = Cursors.Default;
            this.lblPorcentaje.desactivarLabel();
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            count += 1;
            if (count >= 100) {
                count = 0;
                timer1.Stop();
                player.Stop();
                DialogResult = DialogResult.OK;
                return;
            } else {
                progressBar1.Value = count;
                lblPorcentaje.Text = count.ToString() + "%";
            }         
        }

        public void setDuracionTimer(int segundos) {
            segundos = segundos * 10;
            timer1.Interval = segundos;
        }

        private void FormPantallaDeCarga_Shown(object sender, EventArgs e) {
            cargarGif();
            cargarAudio();

        }

        private void cargarGif() {
            Random random = new Random();
            int num = random.Next(100);
            switch (num % 6) {
                case 0:
                    pbGif.Image = Resources.sushi_1;
                    break;
                case 1:
                    pbGif.Image = Resources.sushi_2;
                    break;
                case 2:
                    pbGif.Image = Resources.sushi_3;
                    break;
                case 3:
                    pbGif.Image = Resources.sushi_4;
                    break;
                case 4:
                    pbGif.Image = Resources.sushi_5;
                    break;
                case 5:
                    pbGif.Image = Resources.sushi_6;
                    break;
            }
        }

        private void cargarAudio() {
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(dir, "Resources");
            string file = "aplausos.wav";
            player.SoundLocation = Path.Combine(path, file);
            player.Play();
        }
    }
}
