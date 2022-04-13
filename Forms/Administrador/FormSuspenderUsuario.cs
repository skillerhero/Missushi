using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Missushi.Funciones;
using MySqlConnector;

namespace Missushi.Forms.Administrador {
    public partial class FormSuspenderUsuario : Form {
        public FormSuspenderUsuario() {
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid() {
            try
            {
                MySqlDataAdapter dataAdapter;
               
                dataAdapter = ConexionBD.consultarTablaAdapter("usuario");
                
                ConexionBD.consultarTablaAdapter("usuario");
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgTablaUsuarios.ReadOnly = true;
                dgTablaUsuarios.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgTablaUsuarios.Visible = false;
                
            }
        }

        private void btnCambios_Click(object sender, EventArgs e) {
            string correoSuspendido = Validacion.ajustarEspacios(txtCorreoSuspender.Text.Trim());

            try  {
                if (ConexionBD.existeCorreo(correoSuspendido)){
                    if (ConexionBD.VerificarEstado(correoSuspendido)){
                        MessageBox.Show("El usuario está suspendido actualmente");
                        this.DialogResult = DialogResult.Abort;
                    }
                    else {
                        ConexionBD.SuspenderUsuario(correoSuspendido);
                        MessageBox.Show("Usuario suspendido con exito");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show("Hubo ERROR con la actualización de la base de datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgTablaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dgTablaUsuarios.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgTablaUsuarios.Rows[selectedrowindex];
            var correo = selectedRow.Cells["correo"].Value;
            txtCorreoSuspender.Text = correo.ToString();
        }
    }
}
