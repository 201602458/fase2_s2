using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace biblioteca
{
    public class conexion
    {
        public SqlConnection getConexion() {
            try {
                
                string cadena = @"Data Source=CALDERON-PC;Initial Catalog=fase1;Integrated Security=True";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
