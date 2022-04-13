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
            
           // ConexionBD.agregarResenia(estrellas, coment);

            

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
