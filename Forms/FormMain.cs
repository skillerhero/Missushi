using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Clases;
using Missushi.Forms.Gerente;

namespace Missushi
{
    public partial class FormMain : Form
    {
        public FormMain(){
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid(){
            try {
                MySqlDataAdapter dataAdapter = ConexionBD.consultarUsuariosAdapter();
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
    }
}