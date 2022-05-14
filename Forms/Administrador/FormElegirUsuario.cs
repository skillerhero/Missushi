using Missushi.Clases;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;


namespace Missushi.Forms.Administrador {
    public partial class FormElegirUsuario : Form {
        public FormElegirUsuario() {
            InitializeComponent();
            cargarDataGrid();
        }
        private void cargarDataGrid() {
            try {
                MySqlDataAdapter dataAdapter;
                dataAdapter = ConexionBD.consultarTablaAdapter("usuario");
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgUsuarios.ReadOnly = true;
                dgUsuarios.DataSource = ds.Tables[0];
            } catch (Exception ex) {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgUsuarios.Visible = false;
            }
        }

        private void dgUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dgUsuarios.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgUsuarios.Rows[selectedrowindex];
            var id = selectedRow.Cells["idUsuario"].Value;
            if (id != null) {
                Globales.usuarioSeleccionado.IdUsuario = Convert.ToInt32(id);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
