using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;

namespace Missushi
{
    public partial class FormMain : Form
    {
        public FormMain(){
            InitializeComponent();
            cargarDataGrid();
        }


        private void cargarDataGrid(){
            try{
                ConexionBD.connection.Open();
                String query = "Select * from usuario;";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, ConexionBD.connection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgUsuarios.ReadOnly = true;
                dgUsuarios.DataSource = ds.Tables[0];
                ConexionBD.connection.Close();
            }
            catch (Exception e){
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgUsuarios.Visible = false;
                lblInfo.Text = "Sin conexión.";
                lblInfo.Visible = true;
                btnRegistro.Enabled = false;
            }
        }

        private void btnRegistroClick(object sender, EventArgs e){
            FormRegistro formRegistro = new FormRegistro();
            if (formRegistro.ShowDialog() == DialogResult.OK){
                cargarDataGrid();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e){
            ConexionBD.connection.Close();
        }
    }
}