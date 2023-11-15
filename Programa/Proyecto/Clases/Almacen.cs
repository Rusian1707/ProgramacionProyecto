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
    class Almacen
    {
        public void mostrarAlmacenes(DataGridView tablaAlmacen)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                tablaAlmacen.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from almacen", objetoConexion.AbrirConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlmacen.DataSource = dt;
                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha conectado" + ex.ToString());
            }
        }
    }
}
