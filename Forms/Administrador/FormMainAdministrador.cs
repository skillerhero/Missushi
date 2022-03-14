using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms {
    public partial class FormMainAdministrador : Form {
        public FormMainAdministrador() {
            InitializeComponent();
        }

        private void FormMainAdministrador_Load(object sender, EventArgs e) {
            label1.Text = Clases.Usuario.id.ToString();
        }
    }
}
