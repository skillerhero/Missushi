using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms.Cliente {
    public partial class FormElegirZona : Form {
        public FormElegirZona() {
            InitializeComponent();
        }

        private void FormElegirZona_Load(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.LoadAsync("https://static6.depositphotos.com/1167801/651/i/950/depositphotos_6517777-stock-photo-rainbow-of-colorful-boxes.jpg");
        }
    }
}
