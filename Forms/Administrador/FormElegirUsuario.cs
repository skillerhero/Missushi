using Missushi.Funciones;
using MySqlConnector;
using System.Data;


namespace Missushi.Forms.Administrador {
    public partial class FormElegirUsuario : Form {
        public FormElegirUsuario() {
            InitializeComponent();
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
    }
}
