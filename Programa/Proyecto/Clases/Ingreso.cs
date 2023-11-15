using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Clases
{
    class Ingreso
    {

        public void VerificarUsuario(TextBox ci, ComboBox usuario)
        {
            try
            {
                if (!EsNumero(ci.Text))
                {
                    MessageBox.Show("Por favor, ingrese solo números en el campo de la cédula.");
                    return;
                }

                CConexion objetoConexion = new CConexion();

                string query = "SELECT usuario FROM usuario WHERE ci = @ci";
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.AbrirConexion());
                myCommand.Parameters.AddWithValue("@ci", ci.Text);

                string tipoUsuario = Convert.ToString(myCommand.ExecuteScalar());

                objetoConexion.CerrarConexion();

                if (!string.IsNullOrEmpty(tipoUsuario))
                {
                    MessageBox.Show("Usuario encontrado: " + tipoUsuario);

                    if (tipoUsuario == "camioneros")
                    {
                        Form6 admCamionero = new Form6();
                        admCamionero.Show();
                    }
                    else if (tipoUsuario == "cliente")
                    {
                        Form7 pedCliente = new Form7();
                        pedCliente.Show();
                    }
                    else if (tipoUsuario == "oficinistas")
                    {
                        Form4 admOficinista = new Form4();
                        admOficinista.Show();
                    }
                    else if (tipoUsuario == "personal_almacen")
                    {
                        Form6 admPers = new Form6();
                        admPers.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de usuario no reconocido");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
               
              
            }
        }

        private bool EsNumero(string cadena)
        {
            return cadena.All(char.IsDigit);
        }


    }
}
