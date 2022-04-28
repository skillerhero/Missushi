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
    public partial class FormMenuDesplegable : Form {
        public FormMenuDesplegable() {
            InitializeComponent();
            Personalizar();
        }

        private void Personalizar() {
            pnlMenuSub.Visible = false;
        }

        private void ocultar() {
            if (pnlMenuSub.Visible == true)
            {
                pnlMenuSub.Visible = false;
            }
        }

        private void mostrar(Panel subMenu) {
            
            if (pnlMenuSub.Visible == false)
            {
                ocultar();
                pnlMenuSub.Visible = true;
            }
            else
            {
                pnlMenuSub.Visible = false;
            }
        }

        private void btnDesplegar_Click(object sender, EventArgs e) {
            mostrar(pnlMenuSub);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            MessageBox.Show("Agregar platillo");
            
            ocultar();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            MessageBox.Show("Modificar platillo");
            ocultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            MessageBox.Show("Eliminar platillo");
            ocultar();
        }

  

        private void pnlMissushi_Paint(object sender, PaintEventArgs e) {
            if (pnlPrincipal.Width == 240)
            {
                lblMissushi.Width = 50;
                lblMissushi.Height = 74;
                pnlPrincipal.AutoScroll = false;
                AutoScroll = false;
                pnlPrincipal.Width = 90;
                pnlPrincipal.Height = 74;
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnDesplegar.Visible = false;
            }
            else
            {
                pnlPrincipal.Width = 240;
                pnlPrincipal.Height = 585;
                lblMissushi.Width = 225;
                lblMissushi.Height = 74;
                btnDesplegar.Visible = true;
                btnAgregar.Visible = true;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
            }
        }
    }
}