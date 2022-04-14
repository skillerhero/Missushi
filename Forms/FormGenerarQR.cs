using Missushi.Funciones;
using QRCoder;

namespace Missushi.Forms {
    public partial class FormGenerarQR : Form {
        public FormGenerarQR() {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            QRCodeGenerator qr = new QRCodeGenerator();
            string get = "http://"+ ConexionBD.ipServidor +"/modificarReservacion.php?idReservacion=" + txtUrl.Text;
            QRCodeData data = qr.CreateQrCode(get, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pbQR.Image = code.GetGraphic(5);
            txtLinkGenerado.Text = get;
        }
    }
}
