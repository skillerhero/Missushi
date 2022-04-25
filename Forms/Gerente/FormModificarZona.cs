using Missushi.Clases;
using Missushi.Funciones;

namespace Missushi.Forms.Gerente {
    public partial class FormModificarZona : Form {
        public FormModificarZona() {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e){
            try{
                int idZona = Globales.zonaSeleccionada.IdZona;
                int cupo = Decimal.ToInt32(nudCupo.Value);
                string foto = txtFotoZona.Text;

                ConexionBD.modificarZona(idZona, cupo, foto);
                MessageBox.Show("Modificado con éxito");

                this.DialogResult = DialogResult.OK;  
                
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnElegirZona_Click(object sender, EventArgs e){
            FormElegirZona formElegirZona = new FormElegirZona();
            if (formElegirZona.ShowDialog() == DialogResult.OK){
                this.btnElegirZona.Text = "Zona " + Globales.zonaSeleccionada.IdZona;
                nudCupo.Value = Globales.zonaSeleccionada.Cupo;
                txtFotoZona.Text = Globales.zonaSeleccionada.Foto;
            }
        }
    }
}
