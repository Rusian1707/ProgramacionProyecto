using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class CConexion
    { 

         static private string cadenaConexion = "SERVER=127.0.0.1;User ID=root;Password='';DATABASE=proyecto";
    public MySqlConnection Conexion = new MySqlConnection(cadenaConexion);

    public MySqlConnection AbrirConexion()
    {

        if (Conexion.State == ConnectionState.Closed)
        {
            Conexion.Open();
        }
        return Conexion;
    }

    public MySqlConnection CerrarConexion()
    {
        if (Conexion.State == ConnectionState.Open)
        {
            Conexion.Close();
        }
        return Conexion;

    }
}
}
