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
using Missushi.Clases;
using QRCoder;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

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
            string coment = "hola";
            int idUsuario = 1;
 
            int cantidadEstrellas = 1;
            DateTime fecha = new DateTime(2011, 6, 10);

            
            if (ConexionBD.agregarResenia(fecha,cantidadEstrellas,idUsuario,coment))
            {
                MessageBox.Show("Enviada con éxito,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No");
            }
           

             MessageBox.Show("Gracias por su reseña");
            this.DialogResult = DialogResult.OK;
        }

        private void FormReseñas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
