using Missushi.Funciones;
namespace Missushi.Forms.Gerente {
    public partial class FormAgregarZona : Form {
        public FormAgregarZona() {
            InitializeComponent();
        }

        private void btnAgregarZona_Click(object sender, EventArgs e) {
            try {
                if (ConexionBD.agregarZona(Convert.ToInt32(udCupo.Value), txtFoto.Text)) { 
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Zona agregada con éxito");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.No;
            }
        }

        private void FormAgregarZona_Load(object sender, EventArgs e) {

        }
    }
}
