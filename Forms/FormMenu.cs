using System.Data;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms{
    public partial class FormMenu : Form {
        public FormMenu() {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e) {
            cargarDataGrid();
        }

        private void cargarDataGrid() {
            try{
                MySqlDataAdapter dataAdapter;
               
                dataAdapter = ConexionBD.consultarTablaAdapter("menu");
               
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgMenu.ReadOnly = true;
                dgMenu.DataSource = ds.Tables[0];
            }
            catch (Exception ex){
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
