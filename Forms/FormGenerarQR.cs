using QRCoder;

namespace Missushi.Forms {
    public partial class FormGenerarQR : Form {
        public FormGenerarQR() {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            QRCodeGenerator qr = new QRCodeGenerator();
            string get = "http://18.117.132.41/modificarReservacion.php?idReservacion=";
            QRCodeData data = qr.CreateQrCode(get+txtUrl.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pbQR.Image = code.GetGraphic(5);
        }
    }
}
