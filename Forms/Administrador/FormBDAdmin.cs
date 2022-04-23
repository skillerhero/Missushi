
using System.Data;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms.Administrador {
    public partial class FormBDAdmin : Form {
        public FormBDAdmin() {
            InitializeComponent();
        }

        private void FormBDAdmin_Load(object sender, EventArgs e) {
            var tablas = new[] {
                 "usuario",
                 "reservacion",
                  "zona",
                 "restaurante",
                 "menu",
                 "resenia",
                 "historial"
            };
            cbTablas.DisplayMember = "Text";
            cbTablas.DataSource = tablas;
        }
        private void cargarDataGrid() {
            try {
                MySqlDataAdapter dataAdapter;
                if (cbTablas.SelectedItem != null) {
                    dataAdapter = ConexionBD.consultarTablaAdapter(cbTablas.SelectedItem.ToString());
                } else {
                    dataAdapter = ConexionBD.consultarTablaAdapter("usuario");
                }
                ConexionBD.consultarTablaAdapter(cbTablas.SelectedText);
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

        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e) {
            cargarDataGrid();
        }
    }
}
