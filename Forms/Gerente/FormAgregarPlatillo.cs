using Missushi.Clases;
using Missushi.Funciones;
using System.Globalization;

namespace Missushi.Forms.Gerente {
    public partial class FormAgregarPlatillo : FormDiseño {
        public FormAgregarPlatillo() {
            InitializeComponent();
            cargarBarraUsuario();
            cbTipoMenu.Items.Add("Entradas");
            cbTipoMenu.Items.Add("Rollos");
            cbTipoMenu.Items.Add("Platillos");
            cbTipoMenu.Items.Add("Paquetes");
            cbTipoMenu.Items.Add("Postres");
            cbTipoMenu.Items.Add("Bebidas");
            cbTipoMenu.Text = cbTipoMenu.Items[0].ToString();

            lblTitulo.colorLetra = Globales.verdeFuerteLetra;
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "Agregar Platillo";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
            this.pnlAgregarPlatillo.Location = centrarComponente(pnlAgregarPlatillo);
            lblBarraTitulo.BringToFront();
        }
        private void bntAceptarMenu_Click(object sender, EventArgs e) {
            try {
                string nombre = Validacion.ajustarEspacios(txtNombrePlatillo.Text.Trim()),
                descripcion = Validacion.ajustarEspacios(txtDescripcionMenu.Text.Trim()),
                foto = Validacion.ajustarEspacios(txtFotoMenu.Text.Trim()),
                tipo = Validacion.ajustarEspacios(cbTipoMenu.Text.Trim());
                string x = txtPrecioMenu.Text;
                float precio = float.Parse(txtPrecioMenu.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);


                switch (cbTipoMenu.SelectedIndex)
                {
                    case 0:
                        tipo = "Entradas";
                        break;
                    case 1:
                        tipo = "Rollos";
                        break;
                    case 2:
                        tipo = "Platillos";
                        break;
                    case 3:
                        tipo = "Paquetes";
                        break;
                    case 4:
                        tipo = "Postres";
                        break;
                    case 5:
                        tipo = "Bebidas";
                        break;
                }

                if (!Validacion.esAlfabetico(nombre)) {
                    MessageBox.Show("El nombre tiene caracteres no válidos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                if (!Validacion.esMenor(descripcion, 200)) {
                    MessageBox.Show("La descripcion es demasiado larga", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Validacion.IsNumeric(txtPrecioMenu.Text)) {
                    MessageBox.Show("El precio contiene caracteres no validos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if (ConexionBD.existePlatillo(nombre))
                {
                    MessageBox.Show("El platillo ya existe.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else if (ConexionBD.agregarPlatillo(nombre, descripcion, precio, foto, tipo)) {
                    MessageBox.Show("Agregado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                } else {
                    MessageBox.Show("Ocurrio un error");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
