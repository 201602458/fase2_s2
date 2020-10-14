using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using biblioteca;

namespace fase1.pagina
{
    public partial class inicio_juego : System.Web.UI.Page
    {
        operacion op = new operacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Lusu.Text = index.usuario;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //individual
            string fecha;
            DateTime f = DateTime.Today;
            fecha = f.ToString("dd-MM-yyyy");

            if (op.crear_juego(fecha, Lusu.Text, null, 5, 1))
            {
                Response.Write("<script>window.alert('Creado correctamente')</script>");
                Response.Redirect("juego.aspx");

            }
            else
            {
                Response.Write("<script>window.alert('Error al crear partida')</script>");
            }
            Response.Redirect("juego_vs.aspx");


        }

        protected void Bplay_Click(object sender, EventArgs e)
        {
            //versus
            string fecha;
            DateTime f = DateTime.Today;
            fecha = f.ToString("dd-MM-yyyy");

            if (op.crear_juego(fecha, Lusu.Text, Tj2.Text, 5, 2))
            {
                Response.Write("<script>window.alert('Creado correctamente')</script>");
                Response.Redirect("juego.aspx");

            }
            else
            {
                Response.Write("<script>window.alert('Error al crear partida')</script>");
            }

            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            L1.Visible = true;
            L2.Visible = true;
            L3.Visible = true;
            Tj1.Visible = true;
            Tj2.Visible = true;
            Bplay.Visible = true;
           
        }
    }
}