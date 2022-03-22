using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missushi.Forms.Cliente {
    public partial class FormReservacionCliente : Form {
        public FormReservacionCliente() {
            InitializeComponent();
        }

        private void btnHacerReservacion_Click(object sender, EventArgs e) {

        }

        private void FormReservacionCliente_Load(object sender, EventArgs e) {
            var horarios = new[] {
                 new { Text = "08:00-11:00", Value = 0 },
                 new { Text = "14:00-17:00", Value = 1 },
                 new { Text = "17:00-20:00", Value = 2 },
                 new { Text = "20:00-23:00", Value = 3 }
            };
            cbHoraInicio.DisplayMember = "Text";
            cbHoraInicio.ValueMember = "Value";
            cbHoraInicio.DataSource = horarios;
        }

        private void btnElegirZona_Click(object sender, EventArgs e) {
            FormElegirZona formElegirZona = new FormElegirZona();
            formElegirZona.ShowDialog();
        }
    }
}
