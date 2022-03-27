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
    public partial class FormMainGerente : Form {
        public FormMainGerente() {
            InitializeComponent();
        }

        private void btnModificarInfo_Click(object sender, EventArgs e) {
            FormModificarInfo formModificarInfo = new FormModificarInfo();
            formModificarInfo.ShowDialog();
        }

        private void btnModificarZona_Click(object sender, EventArgs e) {
            FormModificarZona formModificarZona = new FormModificarZona();
            formModificarZona.ShowDialog();
        }

        private void btnAgregarZona_Click(object sender, EventArgs e) {
            FormAgregarZona formAgregarZona = new FormAgregarZona();
            formAgregarZona.ShowDialog();
        }
    }
}
