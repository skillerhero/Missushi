using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Missushi.Clases;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms.Gerente {
    public partial class FormModificarPlatillo : Form {
        public FormModificarPlatillo() {
            InitializeComponent();
            cargarDataGrid();
            cbTipoModi.Items.Add("Entradas");
            cbTipoModi.Items.Add("Rollos");
            cbTipoModi.Items.Add("Platillos");
            cbTipoModi.Items.Add("Paquetes");
            cbTipoModi.Items.Add("Postres");
            cbTipoModi.Items.Add("Bebidas");
            cbTipoModi.Text = cbTipoModi.Items[0].ToString();
        }

        private void cargarDataGrid() {
            try
            {
                MySqlDataAdapter dataAdapter;

                dataAdapter = ConexionBD.consultarTablaMenu();
                ConexionBD.consultarTablaMenu();
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgPlatillosModi.ReadOnly = true;
                dgPlatillosModi.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgPlatillosModi.Visible = false;

            }
        }

        private void btnModificarPlatillo_Click(object sender, EventArgs e) {
            try { 
                string nombre = Validacion.ajustarEspacios(txtNombreModi.Text.Trim()),
                   descripcion = Validacion.ajustarEspacios(txtDescripcionModi.Text.Trim()),
                   foto = Validacion.ajustarEspacios(txtImagenMod.Text.Trim()),
                   tipo = Validacion.ajustarEspacios(cbTipoModi.Text.Trim());
                string x = txtPrecioModi.Text;
                float precio = float.Parse(txtPrecioModi.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);


                switch (cbTipoModi.SelectedIndex)
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

                if (!Validacion.esAlfabetico(nombre))
                {
                    MessageBox.Show("El nombre tiene caracteres no válidos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Validacion.esMenor(descripcion, 200))
                {
                    MessageBox.Show("La descripcion es demasiado larga", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Validacion.IsNumeric(txtPrecioModi.Text))
                {
                    MessageBox.Show("El precio contiene caracteres no validos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (ConexionBD.modificarPlatillo(nombre, descripcion, precio, foto, tipo))
                {
                    MessageBox.Show("Modificado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            } 
            catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgPlatillosModi_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dgPlatillosModi.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgPlatillosModi.Rows[selectedrowindex];
            var nombre = selectedRow.Cells["nombre"].Value;
            txtNombreModi.Text = nombre.ToString();
        }

       
    }
}
