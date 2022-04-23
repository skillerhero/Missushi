using Missushi.Properties;

namespace Missushi.Forms.Todos {
    public partial class FormPantallaDeCarga : Form {
        private int count = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public FormPantallaDeCarga() {
            InitializeComponent();
            this.lblPorcentaje.Cursor = Cursors.Default;
            this.lblPorcentaje.MouseHover -= lblPorcentaje.hover;
            this.lblPorcentaje.MouseLeave -= lblPorcentaje.leave;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            count += 2;
            if (count == 102) {
                count = 0;
                timer1.Stop();
                player.Stop();
                this.DialogResult = DialogResult.OK;
                return;
            } else {
                progressBar1.Value = count;
                lblPorcentaje.Text = count.ToString() + "%";
            }         
        }

        private void FormPantallaDeCarga_Shown(object sender, EventArgs e) {
            Random random = new Random();
            int num = random.Next(100);
            switch (num%6) {
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
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(dir, "Resources");
            string file = "aplausos.wav";
            player.SoundLocation = Path.Combine(path, file);
            player.Play();
            progressBar1.Maximum = 100;
            progressBar1.Step = 2;
            progressBar1.Value = 0;
            timer1.Start();
        }
    }
}
