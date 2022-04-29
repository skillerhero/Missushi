using Missushi.Clases;

namespace Missushi.Forms.Gerente {
    public partial class FormMainGerente : FormDiseño {
        public FormMainGerente() {
            InitializeComponent();
        }

        private void btnModificarInfo_Click(object sender, EventArgs e) {
            FormModificarInfoRestaurante formModificarInfo = new FormModificarInfoRestaurante();
            formModificarInfo.Show();
            Globales.transition();
            Close();
        }

        private void btnModificarZona_Click(object sender, EventArgs e) {
            FormModificarZona formModificarZona = new FormModificarZona();
            formModificarZona.Show();
            Globales.transition();
            Close();
        }

        private void btnAgregarZona_Click(object sender, EventArgs e) {
            FormAgregarZona formAgregarZona = new FormAgregarZona();
            formAgregarZona.Show();
            Globales.transition();
            Close();
        }

        private void btnAgregarPlatillo_Click_1(object sender, EventArgs e) {
            FormAgregarPlatillo formAgregarPlatillo = new FormAgregarPlatillo();
            formAgregarPlatillo.Show();
            Globales.transition();
            Close();
        }

        private void btnModificarPlatillos_Click_1(object sender, EventArgs e) {
            FormModificarPlatillo formModificarPlatillo = new FormModificarPlatillo();
            formModificarPlatillo.Show();
            Globales.transition();
            Close();
        }

        private void btnEliminarP_Click_1(object sender, EventArgs e) {
            FormEliminarPlatillo formEliminarPlatillo = new FormEliminarPlatillo();
            formEliminarPlatillo.Show();
            Globales.transition();
            Close();
        }
    }
}
