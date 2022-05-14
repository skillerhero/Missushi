using System.Data;
using System.Globalization;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms.Gerente {
    public partial class FormModificarPlatillo : FormDiseño {
        public FormModificarPlatillo() {
            InitializeComponent();
            cargarBarraUsuario();
            cargarDataGrid();
            cbTipo.Items.Add("Entradas");
            cbTipo.Items.Add("Rollos");
            cbTipo.Items.Add("Platillos");
            cbTipo.Items.Add("Paquetes");
            cbTipo.Items.Add("Postres");
            cbTipo.Items.Add("Bebidas");
            cbTipo.Text = cbTipo.Items[0].ToString();
        }

        private void cargarDataGrid() {
            try
            {
                MySqlDataAdapter dataAdapter;

                dataAdapter = ConexionBD.consultarTablaAdapter("menu");
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgPlatillosModi.ReadOnly = true;
                dgPlatillosModi.DataSource = ds.Tables[0];
                dgPlatillosModi.Columns["idPlatillo"].HeaderText = "ID Platillo";
                dgPlatillosModi.Columns["nombre"].HeaderText = "Nombre";
                dgPlatillosModi.Columns["descripcion"].HeaderText = "Descripción";
                dgPlatillosModi.Columns["precio"].HeaderText = "Precio";
                dgPlatillosModi.Columns["foto"].HeaderText = "Foto";
                dgPlatillosModi.Columns["tipo"].HeaderText = "Tipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgPlatillosModi.Visible = false;

            }
        }

        private void btnModificarPlatillo_Click(object sender, EventArgs e) {
            try {
                int selectedrowindex = dgPlatillosModi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgPlatillosModi.Rows[selectedrowindex];
                var idPlatillo = selectedRow.Cells["idPlatillo"].Value;
                string nombre = Validacion.ajustarEspacios(txtNombre.Text.Trim()),
                   descripcion = Validacion.ajustarEspacios(txtDescripcion.Text.Trim()),
                   foto = Validacion.ajustarEspacios(txtFoto.Text.Trim()),
                   tipo = Validacion.ajustarEspacios(cbTipo.Text.Trim());
                string x = txtPrecio.Text;
                float precio = float.Parse(txtPrecio.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);


                switch (cbTipo.SelectedIndex)
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

                if (!Validacion.esAlfabetico(nombre)){
                    MessageBox.Show("El nombre tiene caracteres no válidos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacion.esMenor(descripcion, 200)) {
                    MessageBox.Show("La descripcion es demasiado larga", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validacion.IsNumeric(txtPrecio.Text)){
                    MessageBox.Show("El precio contiene caracteres no validos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (ConexionBD.modificarPlatillo(Convert.ToInt32(idPlatillo), nombre, descripcion, precio, foto, tipo)){
                    MessageBox.Show("Modificado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGrid();
                }
                else{
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
            var idPlatillo = selectedRow.Cells["idPlatillo"].Value;
            var nombre = selectedRow.Cells["nombre"].Value;
            var descripcion = selectedRow.Cells["descripcion"].Value;
            var precio = selectedRow.Cells["precio"].Value;
            var foto = selectedRow.Cells["foto"].Value;
            var tipo = selectedRow.Cells["tipo"].Value;
            txtNombre.Text = nombre.ToString();
            txtDescripcion.Text = descripcion.ToString();
            txtPrecio.Text = precio.ToString();
            txtFoto.Text = foto.ToString();
            cbTipo.SelectedIndex = cbTipo.FindStringExact(tipo.ToString());
        }

       
    }
}
