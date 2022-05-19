using System.Data;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms.Gerente {
    public partial class FormModificarMenu : FormDiseño {
        public FormModificarMenu() {
            InitializeComponent();
            cargarBarraUsuario();
            cargarDataGridEliminar();
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "Modificar Menú";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblTitulo.Location = centrarComponente(lblTitulo);
            lblBarraTitulo.Location = centrarComponente(lblBarraTitulo);
        }

        private void cargarDataGridEliminar() {
            try{
                MySqlDataAdapter dataAdapter;
                dataAdapter = ConexionBD.consultarTablaAdapter("menu");
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgTablaEliminar.ReadOnly = true;
                dgTablaEliminar.DataSource = ds.Tables[0];
                dgTablaEliminar.Columns["descripcion"].HeaderText = "Descripcion";
                dgTablaEliminar.Columns["idPlatillo"].HeaderText = "ID Platillo";
                dgTablaEliminar.Columns["nombre"].HeaderText = "Nombre";
                dgTablaEliminar.Columns["precio"].HeaderText = "Precio";
                dgTablaEliminar.Columns["foto"].HeaderText = "Foto";
                dgTablaEliminar.Columns["tipo"].HeaderText = "Tipo";
                foreach (DataGridViewColumn col in dgTablaEliminar.Columns) {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex){
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgTablaEliminar.Visible = false;

            }
        }


        private void btnEliminarPlatillo_Click(object sender, EventArgs e) {
            try{
                int idPlatillo = Convert.ToInt32(txtIdPlatillo.Text);
                if (ConexionBD.eliminarPlatillo(idPlatillo)){
                    MessageBox.Show("Eliminado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridEliminar();
                }else{
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
            catch (Exception ex){
                MessageBox.Show("Ocurrió un error");
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtIdPlatillo_TextChanged(object sender, EventArgs e) {
            if (Validacion.IsNumeric(txtIdPlatillo.Text)) {
                btnEliminarPlatillo.Enabled = true;
                pbEliminarPlatillo.Enabled = true;
                pbEliminarPlatillo.Cursor = Cursors.Hand;
            } else {
                btnEliminarPlatillo.Enabled = false;
                pbEliminarPlatillo.Enabled = false;
                pbEliminarPlatillo.Cursor = Cursors.Default;
            }
        }

        private void dgTablaEliminar_SelectionChanged(object sender, EventArgs e) {
            if (dgTablaEliminar.SelectedCells.Count > 0) {
                int selectedrowindex = dgTablaEliminar.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgTablaEliminar.Rows[selectedrowindex];
                var idPlatillo = selectedRow.Cells["idPlatillo"].Value;
                var nombre = selectedRow.Cells["nombre"].Value;
                var descripcion = selectedRow.Cells["descripcion"].Value;
                var precio = selectedRow.Cells["precio"].Value;
                var foto = selectedRow.Cells["foto"].Value;

                txtIdPlatillo.Text = idPlatillo.ToString();
            } 
        }
    }
}
