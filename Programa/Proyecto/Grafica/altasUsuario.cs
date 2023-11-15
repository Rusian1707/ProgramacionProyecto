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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.mostrarUsuarios(datosUsuarios);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 cuartoForm = new Form4();
            cuartoForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.agregarUsuarios(txtNombre, txtApellido, txtCi, boxUsuario, txtCorreo);
            objetoConexion.agregarTelUsuarios(txtCi, txtTel);
            objetoConexion.mostrarUsuarios(datosUsuarios);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
