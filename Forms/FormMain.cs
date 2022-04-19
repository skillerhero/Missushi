using Missushi.Forms;
using Missushi.Funciones;
using MySqlConnector;
using System.Data;
using Missushi.Clases;
using Missushi.Forms.Gerente;

namespace Missushi{
    public partial class FormMain{
        private Globales globales;
        public FormMain(){
            InitializeComponent();
            globales = new Globales();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e){
            if(ConexionBD.connection != null) {
                ConexionBD.connection.Close();
            }
        }
    }
}