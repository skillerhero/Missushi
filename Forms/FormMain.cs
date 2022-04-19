using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Clases;
using Missushi.Forms.Gerente;

namespace Missushi{
    public partial class FormMain : Form{
        private Globales globales;
        public FormMain(){
            InitializeComponent();
            globales = new Globales();
        }
        private void FormMain_Load(object sender, EventArgs e) {
            pbLogo.ImageLocation = "https://i.ibb.co/ZH7DBFs/logo-Sin-Fondo.png";
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
                lblInfo.Text = "Sin conexión.";
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }

        private void qRToolStripMenuItem_Click(object sender, EventArgs e) {
            FormDiseño formDiseño = new FormDiseño();
            formDiseño.Show();
        }

        private void entrarComoGerenteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('G')) {
                FormMainGerente formMainGerente = new FormMainGerente();
                formMainGerente.Closed += (s, args) => this.Show();
                formMainGerente.Show();
                this.Hide();
            } else {
                MessageBox.Show("No hay gerentes registrados.");
            }
        }

        private void entrarComoClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('C')) {
                FormMainCliente formMainCliente = new FormMainCliente();
                formMainCliente.Closed += (s, args) => this.Show();
                formMainCliente.Show();
                this.Hide();
            } else {
                MessageBox.Show("No hay clientes registrados.");
            }
        }

        private void entrarComoAdminToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ConexionBD.consultarPrimerUsuario('A')) {
                FormMainAdministrador formMainAdministrador = new FormMainAdministrador();
                formMainAdministrador.Closed += (s, args) => this.Show();
                formMainAdministrador.Show();
                this.Hide();
            } else {
                MessageBox.Show("No hay administradores registrados.");
            }
        }

        private void verBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e) {
            dgUsuarios.Visible = true;
            cbTablas.Visible = true;
            btnLogin.Visible = false;
            btnRegistro.Visible = false;
            pbLogo.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            cargarDataGrid();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e) {
            dgUsuarios.Visible = false;
            cbTablas.Visible = false;
            btnLogin.Visible = true;
            btnRegistro.Visible = true;
            pbLogo.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}