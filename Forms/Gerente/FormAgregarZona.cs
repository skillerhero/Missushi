using Missushi.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
