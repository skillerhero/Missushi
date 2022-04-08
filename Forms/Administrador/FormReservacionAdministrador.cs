using Missushi.Funciones;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms.Administrador {
    public partial class FormReservacionAdministrador : Form {
        public FormReservacionAdministrador() {
            InitializeComponent();
        }

        private void FormReservacionAdministrador_Load(object sender, EventArgs e) {
            cargarDataGrid();
        }

        private void cargarDataGrid() {
            try {
                MySqlDataAdapter dataAdapter;
                dataAdapter = ConexionBD.consultarTablaAdapter("reservacion");
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgReservaciones.ReadOnly = true;
                dgReservaciones.DataSource = ds.Tables[0];
            } catch (Exception ex) {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgReservaciones.Visible = false;
            }
        }

        private void btnHacerReservacion_Click(object sender, EventArgs e) {
            FormHacerReservacionAdministrador formHacerReservacionAdministrador = new FormHacerReservacionAdministrador();
            if(formHacerReservacionAdministrador.ShowDialog() == DialogResult.OK) {
                cargarDataGrid();
            }
        }

        private void btnCancelarReservacion_Click(object sender, EventArgs e) {
            try {
                int selectedrowindex = dgReservaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgReservaciones.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["idReservacion"].Value);
                if(id > 0) {
                    ConexionBD.cancelarReservacion(id);
                    MessageBox.Show("Cancelación hecha con éxito.");
                    cargarDataGrid();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
