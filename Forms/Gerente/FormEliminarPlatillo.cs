using System.Data;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms.Gerente {
    public partial class FormEliminarPlatillo : FormDiseño {
        public FormEliminarPlatillo() {
            InitializeComponent();
            cargarDataGridEliminar();
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
                }
                else{
                    MessageBox.Show("Ocurrio un error");
                }
            }
            catch (Exception ex){
                MessageBox.Show("Ocurrió un error");
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgTablaEliminar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
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
