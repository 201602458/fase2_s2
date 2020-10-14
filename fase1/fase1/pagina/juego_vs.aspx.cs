using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fase1.pagina
{
    public partial class juego_vs : System.Web.UI.Page
    {
        public static int turnos = 1;
        //fila(1)-columna(A)-color
        public static string[,] pos = new string[8, 8];
        //jugar j = new jugar();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Write("<script>");
            Response.Write("window.open('juego.aspx' ,'_blank')");
            Response.Write("</script>");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>");
            Response.Write("window.open('inicio.aspx' ,'_blank')");
            Response.Write("</script>");

        }


        protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
        {
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 0] = "blanca";
                ImageButton1.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 0] = "negra";
                ImageButton1.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton1.Enabled = false;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 1] = "blanca";
                ImageButton2.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 1] = "negra";
                ImageButton2.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton2.Enabled = false;

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 2] = "blanca";
                ImageButton3.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 2] = "negra";
                ImageButton3.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton3.Enabled = false;

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 3] = "blanca";
                ImageButton4.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 3] = "negra";
                ImageButton4.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton4.Enabled = false;

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 4] = "blanca";
                ImageButton5.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 4] = "negra";
                ImageButton5.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton5.Enabled = false;

        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 5] = "blanca";
                ImageButton7.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 5] = "negra";
                ImageButton7.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton7.Enabled = false;

        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 6] = "blanca";
                ImageButton8.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 6] = "negra";
                ImageButton8.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton8.Enabled = false;

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 7] = "blanca";
                ImageButton6.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 7] = "negra";
                ImageButton6.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton6.Enabled = false;

        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 0] = "blanca";
                ImageButton9.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 0] = "negra";
                ImageButton9.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton9.Enabled = false;

        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 1] = "blanca";
                ImageButton10.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 1] = "negra";
                ImageButton10.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton10.Enabled = false;

        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 2] = "blanca";
                ImageButton11.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 2] = "negra";
                ImageButton11.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton11.Enabled = false;

        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 3] = "blanca";
                ImageButton12.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 3] = "negra";
                ImageButton12.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton12.Enabled = false;

        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 4] = "blanca";
                ImageButton13.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 4] = "negra";
                ImageButton13.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton13.Enabled = false;

        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 5] = "blanca";
                ImageButton14.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 5] = "negra";
                ImageButton14.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton14.Enabled = false;

        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 6] = "blanca";
                ImageButton15.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 6] = "negra";
                ImageButton15.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton15.Enabled = false;

        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 7] = "blanca";
                ImageButton16.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 7] = "negra";
                ImageButton16.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton16.Enabled = false;

        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 0] = "blanca";
                ImageButton17.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 0] = "negra";
                ImageButton17.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton17.Enabled = false;

        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 1] = "blanca";
                ImageButton18.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 1] = "negra";
                ImageButton18.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton18.Enabled = false;

        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 2] = "blanca";
                ImageButton19.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 2] = "negra";
                ImageButton19.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton19.Enabled = false;

        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 3] = "blanca";
                ImageButton20.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 3] = "negra";
                ImageButton20.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton20.Enabled = false;

        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 4] = "blanca";
                ImageButton21.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 4] = "negra";
                ImageButton21.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton21.Enabled = false;

        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 5] = "blanca";
                ImageButton22.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 5] = "negra";
                ImageButton22.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton22.Enabled = false;

        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 6] = "blanca";
                ImageButton23.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 6] = "negra";
                ImageButton23.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton23.Enabled = false;

        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 7] = "blanca";
                ImageButton24.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 7] = "negra";
                ImageButton24.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton24.Enabled = false;

        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 0] = "blanca";
                ImageButton25.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 0] = "negra";
                ImageButton25.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton25.Enabled = false;

        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 1] = "blanca";
                ImageButton26.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 1] = "negra";
                ImageButton26.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton26.Enabled = false;


        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 2] = "blanca";
                ImageButton27.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 2] = "negra";
                ImageButton27.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton27.Enabled = false;

        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {

            pos[3, 3] = "blanca";


        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            pos[3, 4] = "negra";
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 5] = "blanca";
                ImageButton30.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 5] = "negra";
                ImageButton30.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton30.Enabled = false;

        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 6] = "blanca";
                ImageButton31.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 6] = "negra";
                ImageButton31.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton31.Enabled = false;

        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 7] = "blanca";
                ImageButton32.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 7] = "negra";
                ImageButton32.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton32.Enabled = false;

        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 0] = "blanca";
                ImageButton33.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 0] = "negra";
                ImageButton33.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton33.Enabled = false;

        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 1] = "blanca";
                ImageButton34.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 1] = "negra";
                ImageButton34.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton34.Enabled = false;

        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 2] = "blanca";
                ImageButton35.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 2] = "negra";
                ImageButton35.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton35.Enabled = false;

        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            pos[4, 3] = "negra";
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            pos[4, 4] = "blanca";
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 5] = "blanca";
                ImageButton38.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 5] = "negra";
                ImageButton38.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton38.Enabled = false;

        }

        protected void ImageButton39_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 6] = "blanca";
                ImageButton39.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 6] = "negra";
                ImageButton39.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            turnos++;
            ImageButton39.Enabled = false;

        }

        protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 7] = "blanca";
                ImageButton40.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 7] = "negra";
                ImageButton40.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton40.Enabled = false;

        }

        protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 0] = "blanca";
                ImageButton41.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 0] = "negra";
                ImageButton41.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton41.Enabled = false;

        }

        protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 1] = "blanca";
                ImageButton42.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 1] = "negra";
                ImageButton42.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton42.Enabled = false;

        }

        protected void ImageButton43_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 2] = "blanca";
                ImageButton43.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 2] = "negra";
                ImageButton43.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton43.Enabled = false;

        }

        protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 3] = "blanca";
                ImageButton44.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 3] = "negra";
                ImageButton44.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton44.Enabled = false;

        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 4] = "blanca";
                ImageButton45.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 4] = "negra";
                ImageButton45.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton45.Enabled = false;

        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 5] = "blanca";
                ImageButton46.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 5] = "negra";
                ImageButton46.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton46.Enabled = false;

        }

        protected void ImageButton47_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 6] = "blanca";
                ImageButton47.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 6] = "negra";
                ImageButton47.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton47.Enabled = false;

        }

        protected void ImageButton48_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 7] = "blanca";
                ImageButton48.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 7] = "negra";
                ImageButton48.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton48.Enabled = false;

        }

        protected void ImageButton49_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 0] = "blanca";
                ImageButton49.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 0] = "negra";
                ImageButton49.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton49.Enabled = false;

        }

        protected void ImageButton50_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 1] = "blanca";
                ImageButton50.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 1] = "negra";
                ImageButton50.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton50.Enabled = false;

        }

        protected void ImageButton51_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 2] = "blanca";
                ImageButton51.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 2] = "negra";
                ImageButton51.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton51.Enabled = false;

        }

        protected void ImageButton52_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 3] = "blanca";
                ImageButton52.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 3] = "negra";
                ImageButton52.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton52.Enabled = false;

        }

        protected void ImageButton53_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 4] = "blanca";
                ImageButton53.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 4] = "negra";
                ImageButton53.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton53.Enabled = false;

        }

        protected void ImageButton54_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 5] = "blanca";
                ImageButton54.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 5] = "negra";
                ImageButton54.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton54.Enabled = false;

        }

        protected void ImageButton55_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 6] = "blanca";
                ImageButton55.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 6] = "negra";
                ImageButton55.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton55.Enabled = false;

        }

        protected void ImageButton56_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 7] = "blanca";
                ImageButton56.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 7] = "negra";
                ImageButton56.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton56.Enabled = false;

        }

        protected void ImageButton57_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 0] = "blanca";
                ImageButton57.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 0] = "negra";
                ImageButton57.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton57.Enabled = false;

        }

        protected void ImageButton58_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 1] = "blanca";
                ImageButton58.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 1] = "negra";
                ImageButton58.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton58.Enabled = false;

        }

        protected void ImageButton59_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 2] = "blanca";
                ImageButton59.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 2] = "negra";
                ImageButton59.ImageUrl = "~/pagina/imagenes/blanca.png";
            }
            turnos++;
            ImageButton59.Enabled = false;

        }

        protected void ImageButton60_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 3] = "blanca";
                ImageButton60.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 3] = "negra";
                ImageButton60.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton60.Enabled = false;

        }

        protected void ImageButton61_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 4] = "blanca";
                ImageButton61.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 4] = "negra";
                ImageButton61.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton61.Enabled = false;

        }

        protected void ImageButton62_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 5] = "blanca";
                ImageButton62.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 5] = "negra";
                ImageButton62.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton62.Enabled = false;

        }

        protected void ImageButton63_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 6] = "blanca";
                ImageButton63.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 6] = "negra";
                ImageButton63.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton63.Enabled = false;

        }

        protected void ImageButton64_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 7] = "blanca";
                ImageButton64.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 7] = "negra";
                ImageButton64.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            turnos++;
            ImageButton64.Enabled = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                //si hay una archivo.
                string nombreArchivo = Bsubir.Text;
                string ruta = "~/guardado/" + nombreArchivo + ".xml";
                //Bsubir.SaveAs(Server.MapPath(ruta));

                pos[3, 3] = "blanca";
                pos[3, 4] = "negra";
                pos[4, 3] = "negra";
                pos[4, 4] = "blanca";
                crear c = new crear();
                c.generar2(Server.MapPath(ruta));
                Response.Write("<script>window.alert('Guardado correctamente')</script>");




            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('Error al descargar el archivo')</script>");
            }




            //String dubir =Bsubir.SaveAs(Bsubir.FileName));
        }

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
    }
}