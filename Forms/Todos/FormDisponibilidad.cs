using Missushi.Clases;

namespace Missushi.Forms.Todos {
    public partial class FormDisponibilidad : FormDiseño {
        public FormDisponibilidad() {
            InitializeComponent();
        }

        private void FormDisponibilidad_Load(object sender, EventArgs e) {
            pbMapaZonas.ImageLocation = Globales.restaurante.FotoMapaZonas;

        }
    }
}
