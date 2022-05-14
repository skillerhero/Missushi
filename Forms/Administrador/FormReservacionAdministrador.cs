using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Forms.Cliente;
using Missushi.Clases;

namespace Missushi.Forms.Administrador {
    public partial class FormReservacionAdministrador : FormDiseño {
        public FormReservacionAdministrador() {
            InitializeComponent();
            cargarBarraUsuario();
        }

        private void FormReservacionAdministrador_Load(object sender, EventArgs e) {
            lblTitulo.colorLetra = Globales.verdeFuerteLetra;
            lblTitulo.Visible = true;
            lblTitulo.desactivarLabel();
            lblTitulo.Text = "RESERVACIONES";
            lblBarraTitulo.Visible = true;
            lblBarraTitulo.Width = lblTitulo.Width;
            lblBarraTitulo.BringToFront();
            centrarComponente(lblTitulo);
            centrarComponente(lblBarraTitulo);
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
            FormHacerReservacion formHacerReservacionAdministrador = new FormHacerReservacion();
            formHacerReservacionAdministrador.Show();
            Globales.transition();
            Close();
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

        private void dgReservaciones_SelectionChanged(object sender, EventArgs e) {
            if (dgReservaciones.SelectedCells.Count > 0) {
                int selectedrowindex = dgReservaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgReservaciones.Rows[selectedrowindex];
                if (selectedRow.Cells["estado"].Value.Equals("En espera")) {
                    btnCancelarReservacion.Enabled = true;
                } else {
                    btnCancelarReservacion.Enabled = false;
                }
            }
        }
    }
}
