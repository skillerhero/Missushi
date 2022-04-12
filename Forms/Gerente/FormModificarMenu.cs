﻿using Missushi.Funciones;
using System.Globalization;

namespace Missushi.Forms.Gerente {
    public partial class FormModificarMenu : Form {
        public FormModificarMenu() {
            InitializeComponent();
            cbTipoMenu.Items.Add("Postre");
            cbTipoMenu.Items.Add("Bebida");
            cbTipoMenu.Items.Add("Principal");
            cbTipoMenu.Items.Add("Complemento");
            cbTipoMenu.Text = cbTipoMenu.Items[0].ToString();
        }

        private void bntAceptarMenu_Click(object sender, EventArgs e) {
            try {
                string nombre = Validacion.ajustarEspacios(txtNombrePlatillo.Text.Trim()), 
                    descripcion = Validacion.ajustarEspacios(txtDescripcionMenu.Text.Trim()), 
                    foto = Validacion.ajustarEspacios(txtFotoMenu.Text.Trim()),
                    tipo = Validacion.ajustarEspacios(cbTipoMenu.Text.Trim());
                


                switch (cbTipoMenu.SelectedIndex){
                    case 0:
                        tipo = "Postre";
                        break;   
                    case 1:
                        tipo = "Bebida";
                        break;
                    case 2:
                        tipo = "Principal";
                        break;
                    case 3:
                        tipo = "Complemento";
                        break;
                }

                if (!Validacion.esAlfabetico(nombre)){
                    MessageBox.Show("El nombre tiene caracteres no válidos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Validacion.esMenor(descripcion, 200)){
                    MessageBox.Show("La descripcion es demasiado larga", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Validacion.IsNumeric(txtPrecioMenu.Text)){
                    MessageBox.Show("El precio contiene caracteres no validos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else  if (ConexionBD.agregarPlatillo(nombre, descripcion, float.Parse(txtPrecioMenu.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat) ,  foto,  tipo))  {
                    MessageBox.Show("Agregado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }else{
                    MessageBox.Show("Ocurrio un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormModificarMenu_Load(object sender, EventArgs e) {

        }
    }
}
