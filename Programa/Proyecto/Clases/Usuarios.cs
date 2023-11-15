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
    class Usuarios
    {
        public void mostrarUsuarios(DataGridView tablaUsuarios)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                tablaUsuarios.DataSource = null;

                string query = "SELECT u.ci, u.nombre, u.apellido, u.correo, u.usuario, ut.tel " +
                               "FROM usuario u " +
                               "INNER JOIN usuario_tel ut ON u.ci = ut.ci";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.AbrirConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaUsuarios.DataSource = dt;
                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha conectado" + ex.ToString());
            }
        }


        public void agregarUsuarios(TextBox nombre, TextBox apellido, TextBox ci, ComboBox usuario, TextBox correo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "INSERT INTO usuario (ci, nombre, apellido, correo, usuario)" + "values ('" + ci.Text + "','" + nombre.Text + "','" + apellido.Text + "','" + correo.Text + "','" +usuario.Text+"'  )";
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.AbrirConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Se ha guardado exitosamente");
                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha conectado" + ex.ToString());
            }

        }

        internal void modificarUsuarios(TextBox txtNombre, TextBox txtApellido, TextBox txtCi, ComboBox boxUsuario, TextBox txtCorreo, TextBox txtTel)
        {
            throw new NotImplementedException();
        }

        public void agregarTelUsuarios(TextBox ci, TextBox telefono)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "INSERT INTO usuario_tel (ci, tel)" + "values ('" + ci.Text + "','" + telefono.Text + "')";
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.AbrirConexion());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Se ha guardado exitosamente");
                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha conectado" + ex.ToString());
            }

        }

        public void SeleccionarUsuarios(DataGridView tablaUsuario, TextBox ci, TextBox nombre, TextBox apellido, ComboBox usuario, TextBox correo)
        {
            try
            {
                ci.Text = tablaUsuario.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaUsuario.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaUsuario.CurrentRow.Cells[2].Value.ToString();
                correo.Text = tablaUsuario.CurrentRow.Cells[3].Value.ToString();
                usuario.Text = tablaUsuario.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar usuario: " + ex.ToString());
            }
        }

        public void modificarUsuarios(TextBox nombre, TextBox apellido, TextBox ci, ComboBox usuario, TextBox correo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "UPDATE usuario SET nombre=@nombre, apellido=@apellido, correo=@correo, usuario=@usuario WHERE ci=@ci";
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.AbrirConexion());
                myCommand.Parameters.AddWithValue("@nombre", nombre.Text);
                myCommand.Parameters.AddWithValue("@apellido", apellido.Text);
                myCommand.Parameters.AddWithValue("@correo", correo.Text);
                myCommand.Parameters.AddWithValue("@usuario", usuario.Text);
                myCommand.Parameters.AddWithValue("@ci", ci.Text);

                int filasModificadas = myCommand.ExecuteNonQuery();
                objetoConexion.CerrarConexion();

                if (filasModificadas > 0)
                {
                    MessageBox.Show("Se ha modificado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con esa cédula");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.ToString());
            }
        }

        public void eliminarUsuarioYTelefonos(TextBox ci)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string checkUserQuery = "SELECT COUNT(*) FROM usuario WHERE ci = @ci";
                using (MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, objetoConexion.AbrirConexion()))
                {
                    checkUserCommand.Parameters.AddWithValue("@ci", ci.Text);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        MessageBox.Show("La cédula no existe en la base de datos.");
                        return;
                    }
                }

                using (MySqlTransaction transaction = objetoConexion.AbrirConexion().BeginTransaction())
                {
                    try
                    {
                        string deleteTelQuery = "DELETE FROM usuario_tel WHERE ci = @ci";
                        using (MySqlCommand deleteTelCommand = new MySqlCommand(deleteTelQuery, objetoConexion.AbrirConexion(), transaction))
                        {
                            deleteTelCommand.Parameters.AddWithValue("@ci", ci.Text);
                            deleteTelCommand.ExecuteNonQuery();
                        }

                        string deleteUserQuery = "DELETE FROM usuario WHERE ci = @ci";
                        using (MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, objetoConexion.AbrirConexion(), transaction))
                        {
                            deleteUserCommand.Parameters.AddWithValue("@ci", ci.Text);
                            deleteUserCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Se ha eliminado el usuario y sus teléfonos exitosamente");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al eliminar usuario y teléfonos: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }





    }
}

