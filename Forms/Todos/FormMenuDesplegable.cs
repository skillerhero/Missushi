using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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