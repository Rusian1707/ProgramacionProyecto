using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Clases
{
    class Pedido
    {
        public void mostrarPedidos(DataGridView tablaPedidos)
{
    try
    {
        CConexion objetoConexion = new CConexion();

        tablaPedidos.DataSource = null;
        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT p.id_pedido, p.id_estado, le.latitud, le.longitud FROM pedido p JOIN lugarEnvio le ON p.id_lugarenvio = le.id_lugarEnvio", objetoConexion.AbrirConexion());
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        tablaPedidos.DataSource = dt;
        objetoConexion.CerrarConexion();
    }
    catch (Exception ex)
    {
        MessageBox.Show("No se ha conectado" + ex.ToString());
    }
}


        public void agregarPedido(TextBox idPedido, TextBox idlugarEnvio, ComboBox idEstado, DateTimePicker fechaPedido)
        {
            try
            {
                CConexion objetoConexion = new CConexion();


                if (int.TryParse(idlugarEnvio.Text, out int lugarEnvio))
                {
                    string query = "INSERT INTO pedido (id_pedido, id_lugarenvio, id_estado, fechapedido)" +
                                   "VALUES ('" + idPedido.Text + "'," + lugarEnvio + ",'" + idEstado.Text + "', '" + fechaPedido.Value.ToString("yyyy-MM-dd") + "')";

                    MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.AbrirConexion());
                    myCommand.ExecuteNonQuery();

                    MessageBox.Show("Se ha guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("El valor de id_lugarenvio no es válido. Debe ser un número.");
                }

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha conectado" + ex.ToString());
            }
        }

        public void agregarUbicacionPedido(TextBox idlugarEnvio, TextBox latitud, TextBox longitud)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                double latitudDouble, longitudDouble;

                if (double.TryParse(latitud.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out latitudDouble) &&
                    double.TryParse(longitud.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out longitudDouble))
                {
                    string query = "INSERT INTO lugarEnvio(id_lugarenvio, latitud, longitud)" +
                                   "VALUES ('" + idlugarEnvio.Text + "', " + latitudDouble.ToString(CultureInfo.InvariantCulture) + ", " + longitudDouble.ToString(CultureInfo.InvariantCulture) + ")";

                    MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.AbrirConexion());
                    myCommand.ExecuteNonQuery();

                    MessageBox.Show("Se ha guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("Las coordenadas no son válidas. Asegúrate de ingresar números válidos.");
                }

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha conectado" + ex.ToString());
            }
        }



    }
}
