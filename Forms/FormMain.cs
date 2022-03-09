using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;

namespace Missushi
{
    public partial class FormMain : Form
    {
        private MySqlConnection connection;
        public FormMain(){
            InitializeComponent();
            connection = ConexionBD.connection;
            cargarDataGrid();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e){
            lblHelloWorld.Text = "Hola";
            FormRegistro frmRegistro = new FormRegistro();
            if (frmRegistro.ShowDialog() == DialogResult.OK){
                cargarDataGrid();
            }

        }

        private void cargarDataGrid(){
            connection.Open();
            String query = "Select * from usuario;";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgUsuarios.ReadOnly = true;
            dgUsuarios.DataSource = ds.Tables[0];
            connection.Close();
        }
    }
}