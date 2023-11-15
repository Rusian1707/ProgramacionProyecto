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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Clases.Almacen objetoConexion = new Clases.Almacen();
            objetoConexion.mostrarAlmacenes(datosAlmacenes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas cerar sesion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Form1 primerform = new Form1();
                primerform.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Clases.Almacen objetoConexion = new Clases.Almacen();
            objetoConexion.mostrarAlmacenes(datosAlmacenes);
        }
    }
}
