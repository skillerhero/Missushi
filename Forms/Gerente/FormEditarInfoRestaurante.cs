using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms.Gerente {
    public partial class FormEditarInfoRestaurante : Form {
        public FormEditarInfoRestaurante() {
            InitializeComponent();
        }

        private void btnInfoRestaurante_Click(object sender, EventArgs e) {
            FormModificarInfo formModificarInfo = new FormModificarInfo();
            formModificarInfo.Show();
        }
    }
}
