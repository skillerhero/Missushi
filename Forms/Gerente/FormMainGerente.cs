namespace Missushi.Forms.Gerente {
    public partial class FormMainGerente : Form {
        public FormMainGerente() {
            InitializeComponent();
        }

        private void btnModificarInfo_Click(object sender, EventArgs e) {
            FormModificarInfoRestaurante formModificarInfo = new FormModificarInfoRestaurante();
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

        private void btnAgregarPlatillo_Click_1(object sender, EventArgs e) {
            FormAgregarPlatillo formAgregarPlatillo = new FormAgregarPlatillo();
            formAgregarPlatillo.ShowDialog();
        }

        private void btnModificarPlatillos_Click_1(object sender, EventArgs e) {
            FormModificarPlatillo formModificarPlatillo = new FormModificarPlatillo();
            formModificarPlatillo.ShowDialog();
        }

        private void btnEliminarP_Click_1(object sender, EventArgs e) {
            FormEliminarPlatillo formEliminarPlatillo = new FormEliminarPlatillo();
            formEliminarPlatillo.ShowDialog();
        }
    }
}
