namespace Missushi.Forms {
    public partial class FormMainCliente : Form {
        public FormMainCliente() {
            InitializeComponent();
        }

        private void FormMainCliente_Load(object sender, EventArgs e) {
            label1.Text = Clases.Usuario.id.ToString();
            
        }
    }
}
