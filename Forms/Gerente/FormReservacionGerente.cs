using Missushi.Clases;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;

namespace Missushi.Forms.Gerente {
    public partial class FormReservacionGerente : FormDiseño {
        public FormReservacionGerente() {
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid() {
            try {
                MySqlDataAdapter dataAdapter;
                dataAdapter = ConexionBD.consultarReservacionDiaAdapter(dpDia.Value);
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
                dgReservaciones.Columns["idUsuario"].HeaderText = "ID usuario";
            } catch (Exception ex) {
                ConexionBD.manejarErrores(ex);
                dgReservaciones.Visible = false;
            }
        }

        private void dpDia_ValueChanged(object sender, EventArgs e) {
            cargarDataGrid();
        }
    }
}
