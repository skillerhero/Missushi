namespace Missushi.Forms.Todos {
    public partial class FormMenuDesplegable : FormDiseño {
        public FormMenuDesplegable() {
            InitializeComponent();
            inicializar();
            cargarPantallaMainCliente();
        }


        private void inicializar() {
            if (pnlPrincipalMenu.Visible == true)
            {
                pnlPrincipalMenu.Visible = false;
            }
        }
        private void pictureBoxPersonalizado1_Click(object sender, EventArgs e) {
            if(pnlPrincipalMenu.Visible == true)
            {
                pnlPrincipalMenu.Visible = false;
            }
            else
            {
                pnlPrincipalMenu.Visible = true;
            }
        }

    }
}