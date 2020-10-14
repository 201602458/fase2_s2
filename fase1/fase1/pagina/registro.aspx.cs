using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using biblioteca;
using System.Data.SqlClient;

namespace fase1.pagina
{
    public partial class registro : System.Web.UI.Page
    {
        conexion con = new conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            paises();           
        }
     
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            confirmar(Tusu.Text);
        }

        //rellenar
        public void paises()
        {
            
            try
            {
               
                //String dato = "";
                String name = "select * from paises";
                SqlCommand cm = new SqlCommand(name, con.getConexion());
                //Response.Write("<script>window.alert('zi')</script>");
                //cm.Parameters.AddWithValue("@nombre");               
                SqlDataReader consu = cm.ExecuteReader();
                while (consu.Read())
                {
                   
                        Tpais.Items.Add(consu["nombre"].ToString());
                        //Response.Write("<script>window.alert('"+consu[i].ToString()+"')</script>");

                    

                }
                //return dato;
                //Response.Write("<script>window.alert('zi')</script>");



            }
            catch (Exception)
            {

                //Response.Write("<script>window.alert('no')</script>");
            }

        }

        public void confirmar(string usu)
        {

            try
            {
                String dato = "";
                String repetido = "select * from usuario where nick = '" + usu + "'";
                SqlCommand cm2 = new SqlCommand(repetido, con.getConexion());
                SqlDataReader consu = cm2.ExecuteReader();
                while (consu.Read())
                {
                    dato = consu["nick"].ToString();

                }

                if (dato != "")
                {
                    Response.Write("<script>window.alert('Usuario Existente')</script>");
                }
                else
                {

                    operacion op = new operacion();
                    string nombre, apellido, usuario, contra, contra2, fecha_nac, correo, pais;
                    nombre = Tnombre.Text;
                    apellido = Tapellido.Text;
                    usuario = Tusu.Text;
                    contra = Tcontra.Text;
                    contra2 = Tcontra2.Text;
                    fecha_nac = TfechaNac.Text;
                    correo = Tcorreo.Text;
                    pais = Tpais.Text;
                    if (contra.Equals(contra2))
                    {
                        if (op.registrar(nombre, apellido, usuario, contra, fecha_nac, correo, pais))
                        {
                            Response.Write("<script>window.alert('Guardado Correctamente')</script>");

                            Response.Redirect("index.aspx");
                        }
                        else
                        {
                            Response.Write("<script>window.alert('Error al Guardar')</script>");
                        }

                    }
                    else { Response.Write("<script>window.alert('Contrasenas no Coinsiden')</script>"); }
                }

            }
            catch (Exception)
            {

            }



        }

    }//fin clase principal
}