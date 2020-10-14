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
    
    public partial class historial : System.Web.UI.Page
    {
        conexion con = new conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Lusu.Text = index.usuario;
            generar();
        }

        protected void LBjuego_Click(object sender, EventArgs e)
        {
            Response.Write("<script>");
            Response.Write("window.open('inicio_juego.aspx' ,'_blank')");
            Response.Write("</script>");
        }

        protected void LBcarga_Click(object sender, EventArgs e)
        {
            Response.Redirect("carga.aspx");
        }

        protected void LBinicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("inicio.aspx");
        }

        protected void LBdesc_Click(object sender, EventArgs e)
        {
            Response.Redirect("historial.aspx");
        }

        public void generar() {
            Response.Write("<div id=\"Dtabla\">");
            Response.Write("<table border=\"1\">");
            Response.Write("<tr>");

            Response.Write("<td>");
            Response.Write("Id Partida");
            Response.Write("</td>");

            Response.Write("<td>");
            Response.Write("Fecha Creacion");
            Response.Write("</td>");

            Response.Write("<td>");
            Response.Write("Creador");
            Response.Write("</td>");

            Response.Write("<td>");
            Response.Write("Rival");
            Response.Write("</td>");

            Response.Write("<td>");
            Response.Write("Estado de la Partida");
            Response.Write("</td>");

            Response.Write("<td>");
            Response.Write("Tipo de Partida");
            Response.Write("</td>");

            Response.Write("</tr>");
            // String que = "1";
            try
            {
                string dato = "";
                string name = "select idPart, fechaCreacion, U.nick, rival, E.estado, T.tipo from partida, usuario U, estado_partida E, tipo_partida T where FK_idCrea = (select idUsu from usuario where nick = '"+ Lusu.Text + "') and FK_idEst = E.idEP and FK_idTipo = T.idTP";
                SqlCommand cm = new SqlCommand(name, con.getConexion());
                //cm.Parameters.AddWithValue("@nick", nombre);
                SqlDataReader consu = cm.ExecuteReader();
                //*************
                
                //*************
                while (consu.Read())
                {
                    //LH.Text = consu["idPart"].ToString();

                    

                    if (consu["nick"].ToString()==Lusu.Text) {
                        Response.Write("<tr>");
                        //

                        Response.Write("<td>");
                        Response.Write(consu["idPart"].ToString());
                        Response.Write("</td>");

                        Response.Write("<td>");
                        Response.Write(consu["fechaCreacion"].ToString());
                        Response.Write("</td>");

                        Response.Write("<td>");
                        Response.Write(consu["nick"].ToString());
                        Response.Write("</td>");

                        Response.Write("<td>");
                        Response.Write(consu["rival"].ToString());
                        Response.Write("</td>");

                        Response.Write("<td>");
                        Response.Write(consu["estado"].ToString());
                        Response.Write("</td>");

                        Response.Write("<td>");
                        Response.Write(consu["tipo"].ToString());
                        Response.Write("</td>");

                        Response.Write("</tr>");
                    }
                    
                    
                    //
                    //LH.Items.Add(consu["nombre"].ToString());

                }
                
            }
            catch (Exception)
            {

                
            }
            Response.Write("</table>");
            Response.Write("</div>");

        }
    }
}