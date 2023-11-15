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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.mostrarUsuarios(datosUsuarios);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 cuartoForm = new Form4();
            cuartoForm.Show();
        }

        private void datosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.mostrarUsuarios(datosUsuarios);

        }

        private void datosUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.SeleccionarUsuarios(datosUsuarios, txtCi, txtNombre, txtApellido, boxUsuario, txtCorreo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Usuarios objetoConexion = new Clases.Usuarios();
            objetoConexion.modificarUsuarios(txtNombre, txtApellido, txtCi, boxUsuario, txtCorreo);
            objetoConexion.mostrarUsuarios(datosUsuarios);

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
