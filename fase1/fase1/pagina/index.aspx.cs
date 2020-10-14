using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using biblioteca;
using System.IO;
using System.Diagnostics;

namespace fase1
{
    public partial class index : System.Web.UI.Page
    {
        public static string usuario;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            operacion op = new operacion();
            
            if (op.ingresar(Tusu.Text, Tcontra.Text) != "") {
                usuario = Tusu.Text;             
                Response.Redirect("inicio.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('Usuario y/o Cintraseña Erronea')</script>");




            }

        }
    }
}