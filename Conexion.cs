using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoBolera
{
    static class Conexion
    {

        public static DataSet getQuery(string cmd)
        {
            DataSet ds = null;
            try
            {
                MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=bolera;Uid=root;pwd=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conexion);

                DataSet dsAux = new DataSet();
                adapter.Fill(dsAux);
                ds = dsAux;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema:\n" + e.Message);
            }

            return ds;
        }

    }
}
