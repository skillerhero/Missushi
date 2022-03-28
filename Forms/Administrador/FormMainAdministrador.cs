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
