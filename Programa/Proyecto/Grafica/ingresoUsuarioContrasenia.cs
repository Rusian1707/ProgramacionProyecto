using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        private string cargo;
        public Form2(String rol)

            
        {
            cargo = rol;

            InitializeComponent();
          






        }
        
        

  
        

    
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clases.Ingreso objetoConexion = new Clases.Ingreso();
            objetoConexion.VerificarUsuario(txtNombre, null);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 primerForm = new Form1();
            primerForm.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
