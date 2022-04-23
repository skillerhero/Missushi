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

namespace Missushi.Forms.Gerente {
    public partial class FormEliminarPlatillo : Form {
        public FormEliminarPlatillo() {
            InitializeComponent();
            cargarDataGridEliminar();
        }

        private void cargarDataGridEliminar() {
            try
            {
                MySqlDataAdapter dataAdapter;

                dataAdapter = ConexionBD.consultarTablaMenu();
                ConexionBD.consultarTablaMenu();
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgTablaEliminar.ReadOnly = true;
                dgTablaEliminar.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgTablaEliminar.Visible = false;

            }
        }


        private void btnEliminarPlatillo_Click(object sender, EventArgs e) {
            string nombre = Validacion.ajustarEspacios(txtPlatilloEliminar.Text.Trim());
            try
            {
                if (ConexionBD.eliminarPlatillo(nombre))
                {
                    MessageBox.Show("Eliminado con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgTablaEliminar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dgTablaEliminar.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgTablaEliminar.Rows[selectedrowindex];
            var nombre = selectedRow.Cells["nombre"].Value;
            txtPlatilloEliminar.Text = nombre.ToString();
        }



       
    }
}
