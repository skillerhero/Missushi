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
            try {
                FormModificarInfo formModificarInfo = new FormModificarInfo();
                formModificarInfo.ShowDialog();
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }

        }
    }
}
