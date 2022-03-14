using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Missushi.Clases;
using Missushi.Funciones;
namespace Missushi.Forms.Gerente {
    public partial class FormModificarInfo : Form {
        public FormModificarInfo() {
            InitializeComponent();
        }

        private void FormModificarInfo_Load(object sender, EventArgs e) {
            Restaurante restaurante = ConexionBD.consultarRestaurante();
            txtNombre.Text= restaurante.getNombre();
            txtDescripcion.Text = restaurante.getDescription();
            txtLatitud.Text = restaurante.getLatitud();
            txtLongitud.Text = restaurante.getLongitud();
            txtFotoPrincipal.Text = restaurante.getFotoPrincipal();
            txtIdGerente.Text = restaurante.getIdGerente().ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string latitud = txtLatitud.Text;
            string longitud = txtLongitud.Text;
            string fotoPrincipal = txtFotoPrincipal.Text;
            int idGerente = Convert.ToInt32(txtIdGerente.Text);
            ConexionBD.modificarRestaurante(nombre, descripcion, latitud, longitud, fotoPrincipal, idGerente);
        }
    }
}

