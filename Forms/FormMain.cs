using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Clases;
using Missushi.Forms.Gerente;

namespace Missushi{
    public partial class FormMain : Form{
        public FormMain(){
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
            cargarDataGrid();
        }

        private void cargarDataGrid(){
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
                lblInfo.Text = "Sin conexi�n.";
                lblInfo.Visible = true;
                btnRegistro.Enabled = false;
                btnLogin.Enabled = false;
            }
        }

        private void btnRegistroClick(object sender, EventArgs e){
            FormRegistro formRegistro = new FormRegistro();
            if (formRegistro.ShowDialog() == DialogResult.OK){
                cargarDataGrid();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e){
            if(ConexionBD.connection != null) {
                ConexionBD.connection.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            FormLogin formLogin = new FormLogin();
            if (formLogin.ShowDialog() == DialogResult.OK) {
                this.Hide();
                if (Usuario.type == 'C') {
                    FormMainCliente formMainCliente = new FormMainCliente();
                    formMainCliente.Closed += (s, args) => this.Show();
                    formMainCliente.Show();
                }else if(Usuario.type == 'A') {
                    FormMainAdministrador formMainAdministrador = new FormMainAdministrador();
                    formMainAdministrador.Closed += (s, args) => this.Show();
                    formMainAdministrador.Show();
                }else if (Usuario.type == 'G') {
                    FormMainGerente formMainGerente = new FormMainGerente();
                    formMainGerente.Closed += (s, args) => this.Show();
                    formMainGerente.Show();
                }
            }
            
        }

        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e) {
            cargarDataGrid();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('A')) {
                FormMainAdministrador formMainAdministrador = new FormMainAdministrador();
                formMainAdministrador.Closed += (s, args) => this.Show();
                formMainAdministrador.Show();
            } else {
                MessageBox.Show("No hay administradores registrados.");
            } 
        }

        private void btnLoginCliente_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('C')) {
                FormMainCliente formMainCliente = new FormMainCliente();
                formMainCliente.Closed += (s, args) => this.Show();
                formMainCliente.Show();
            } else {
                MessageBox.Show("No hay clientes registrados.");
            }
        }

        private void btnLoginGerente_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('G')) {
                FormMainGerente formMainGerente = new FormMainGerente();
                formMainGerente.Closed += (s, args) => this.Show();
                formMainGerente.Show();
            } else {
                MessageBox.Show("No hay gerentes registrados.");
            }
        }

        private void btnQR_Click(object sender, EventArgs e) {
            FormGenerarQR formGenerarQR = new FormGenerarQR();
            formGenerarQR.Show();
        }

        private void FormMain_Load(object sender, EventArgs e) {

        }

        private void btnMenu_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
    }
}