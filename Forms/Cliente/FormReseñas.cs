


using System;
using Missushi.Funciones;
using Missushi.Clases;



namespace Missushi.Forms.Cliente
{
    public partial class FormReseñas : Form
    {
        public FormReseñas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormResenia = new FormReseñas();
            string coment = (string)comentario.Text;
            int idUsuario = Globales.usuarioActual.IdUsuario;
            int cantidadEstrellas = (int)N_Estrellas.Value;
            // DateTime fecha = new DateTime(2011, 6, 10);
            DateTime Now = DateTime.Now;
         

            if (ConexionBD.agregarResenia(Now,cantidadEstrellas,idUsuario,coment))
            {
                MessageBox.Show("Gracias por su reseña", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vuelva a intentar");
            }
           
        }

        private void FormReseñas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
