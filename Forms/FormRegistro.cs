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

namespace Missushi.Forms
{
    public partial class FormRegistro : Form
    {
        private MySqlConnection connection;

        public FormRegistro()
        {
            InitializeComponent();
            cbTipo.Items.Add("Cliente");
            cbTipo.Items.Add("Administrador");
            cbTipo.Items.Add("Gerente");
            cbTipo.Text = cbTipo.Items[0].ToString();

            connection = ConexionBD.connection;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String nombres = txtNombres.Text, apellidos = txtApellidos.Text, contraseña = txtContraseña.Text, correo = txtCorreo.Text;
            char tipo=' ';
            switch (cbTipo.SelectedIndex) {
                case 0:
                    tipo = 'C';
                    break;
                case 1:
                    tipo = 'A';
                    break;
                case 2:
                    tipo = 'G';
                    break;
            }

            try{
                connection.Open();
                string sql = "INSERT INTO usuario(nombres, apellidos, contrasenia, correo, tipo) VALUES(@0,@1,@2, @3, @4)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@0", MySqlDbType.VarChar, 80).Value = nombres;
                cmd.Parameters.Add("@1", MySqlDbType.VarChar, 80).Value = apellidos;
                cmd.Parameters.Add("@2", MySqlDbType.VarChar, 50).Value = contraseña;
                cmd.Parameters.Add("@3", MySqlDbType.VarChar, 50).Value = correo;
                cmd.Parameters.Add("@4", MySqlDbType.VarChar, 1).Value = tipo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Éxito", "Missushi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Missushi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
