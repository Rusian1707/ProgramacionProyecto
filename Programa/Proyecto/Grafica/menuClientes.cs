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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Clases.Pedido objetoConexion = new Clases.Pedido();
            objetoConexion.mostrarPedidos(datosPedidos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas cerar sesion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Form1 primerform = new Form1();
                primerform.Show();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void datosPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Pedido objetoConexion = new Clases.Pedido();

            objetoConexion.agregarPedido(txtPedido, txtLugarEnvio, boxEstado, dtHora);
            objetoConexion.mostrarPedidos(datosPedidos);
            objetoConexion.agregarUbicacionPedido(txtLugarEnvio, txtLatitud, txtLongitud);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
