using Missushi.Clases;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;

namespace Missushi.Forms.Cliente {
    public partial class FormHistorialReservaciones : FormDiseño {
        public FormHistorialReservaciones() {
            InitializeComponent();
            cargarDataGrid();
            centrarComponente(dgReservaciones);
        }
        private void cargarDataGrid() {
            try {
                MySqlDataAdapter dataAdapter;
                dataAdapter = ConexionBD.consultarReservacionAdapter(Globales.usuarioActual.IdUsuario);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgReservaciones.ReadOnly = true;
                dgReservaciones.DataSource = ds.Tables[0];
                dgReservaciones.Columns["idReservacion"].Visible = false;
                dgReservaciones.Columns["fechaHoraInicio"].HeaderText = "Inicio";
                dgReservaciones.Columns["fechaHoraFin"].HeaderText = "Fin";
                dgReservaciones.Columns["cantidadPersonas"].HeaderText = "No. Personas";
                dgReservaciones.Columns["idZona"].HeaderText = "Zona";
                dgReservaciones.Columns["estado"].HeaderText = "Estado";
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgReservaciones.Visible = false;
            }
        }
        private void btnCancelarReservacion_Click(object sender, EventArgs e) {
            try {
                int selectedrowindex = dgReservaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgReservaciones.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["idReservacion"].Value);
                if (id > 0) {
                    ConexionBD.cancelarReservacion(id);
                    MessageBox.Show("Cancelación hecha con éxito.");
                }
                cargarDataGrid();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgReservaciones_SelectionChanged(object sender, EventArgs e) {
            if(dgReservaciones.SelectedCells.Count > 0) {
                int selectedrowindex = dgReservaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgReservaciones.Rows[selectedrowindex];
                if (selectedRow.Cells["estado"].Value.Equals("En espera")) {
                    btnCancelarReservacion.Enabled = true;
                } else {
                    btnCancelarReservacion.Enabled = false;
                }
            }

        }

        private void dgReservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
