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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas cerrar sesion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Form1 primerform = new Form1();
                primerform.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 crearUsuario = new Form3();
            crearUsuario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 elUsuario = new Form8();
            elUsuario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 selUsuario = new Form9();
            selUsuario.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
