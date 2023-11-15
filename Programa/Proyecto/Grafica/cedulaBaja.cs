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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.mostrarUsuarios(datosUsuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 cuartoForm = new Form4();
            cuartoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.mostrarUsuarios(datosUsuarios);
            objetoConexion.eliminarUsuarioYTelefonos(txtCi);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
