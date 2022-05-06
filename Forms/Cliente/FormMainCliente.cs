using Missushi.Clases;
using Missushi.Forms.Cliente;
using Missushi.Forms.Todos;

namespace Missushi.Forms {
    public partial class FormMainCliente : FormDiseño {
        public FormMainCliente() {
            InitializeComponent();
            cargarPantallaMainCliente();
        }

        private void hacerReseñaToolStripMenuItem_Click(object sender, EventArgs e) {
            Cliente.FormReseña formReseña = new Cliente.FormReseña();
            Globales.transition();
            formReseña.Show();
        }
    }
}
