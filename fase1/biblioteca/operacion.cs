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
    public class operacion
    {
        conexion con = new conexion();
        public bool registrar(string nombre, string apellido, string usu, string contra, string fecha_nac, string email, string pais)
        {
            //confirmar(usu);
            try {
                
                string sql = "INSERT INTO usuario VALUES('" + nombre + "','" + apellido + "','" + usu + "','" + contra + "','" + fecha_nac + "', '" + email + "'," + "(select id from paises where nombre = '"+pais+"'))";               
                SqlCommand cm = new SqlCommand(sql, con.getConexion());
                int n = cm.ExecuteNonQuery();                

                return n > 0;

            }
            catch (Exception)
            {

                return false;
            }


        }

        //****



        //conexion con = new conexion();

        public String ingresar(String nombre, String contra)
        {
           // String que = "1";
            try {
                String dato = "";
                String name = "select * from usuario where nick = '" + nombre + "' AND contra ='" + contra + "'";
                SqlCommand cm = new SqlCommand(name, con.getConexion());
                //cm.Parameters.AddWithValue("@nick", nombre);
                SqlDataReader consu = cm.ExecuteReader();
                if (consu.Read()) {
                    dato = consu["idUsu"].ToString();
                    id_usu(dato);

                }
                return dato;
            }
            catch (Exception)
            {

                return "no";
            }          

        }

        public string id_usu(string us) {
            string id_usu = us;


            return id_usu;
        }



        public bool crear_juego(string fecha, string usuario, string rival, int estado, int tipo) {

            try {
                string sql = "INSERT INTO partida VALUES('"+fecha+"',(select idUsu from usuario where nick ='"+usuario+"' ),'"+rival+"',"+estado+","+tipo+")";
                SqlCommand cm = new SqlCommand(sql, con.getConexion());
                int n = cm.ExecuteNonQuery();
                return n > 0;


            }
            catch (Exception) {
                return false;

            }
                
        }

        
    }//fin clase principal
   
}
