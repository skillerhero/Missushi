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

        private void btnModificarMenu_Click(object sender, EventArgs e) {
            FormModificarMenu formModificarMenu = new FormModificarMenu();
            formModificarMenu.ShowDialog();
        }
    }
}
