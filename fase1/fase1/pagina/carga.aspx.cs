using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;


namespace fase1.pagina
{
    public partial class carga : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bup_Click(object sender, EventArgs e)
        {

            string leer = "";
            if (Bsubir.HasFile)
            {
                string ext = System.IO.Path.GetExtension(Bsubir.FileName);
                ext = ext.ToLower();

                if (ext == ".xml")
                {                   

                    Bsubir.SaveAs(Server.MapPath("~/pagina/subido/" + Bsubir.FileName));

                    leer = Server.MapPath("~/pagina/subido/" + Bsubir.FileName);
                    
                }
                else
                {
                    //Response.Write("1no");
                }
            }
            else
            {
                //Response.Write("2no");
            }

            try
            {
                XmlTextReader reader = new XmlTextReader(leer);
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            Tvista.Text += ("<" + reader.Name);
                            Tvista.Text += (">");
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            Tvista.Text += (reader.Value);
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            Tvista.Text += ("</" + reader.Name);
                            Tvista.Text += (">");
                            break;
                    }

                    //Tvista.Text += "\r";
                    Button1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('Error al abrir el archivo')</script>");
            }

            

        }//fin bup

        
        /*botones barra*/
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("escribe1??");
            string cosa = Tvista.Text;
            carga_xml c = new carga_xml();
            c.archivo(cosa);
            Response.Redirect("juego.aspx");
        }



        

        /***************/
    }
}