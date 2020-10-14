using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fase1.pagina
{
    public partial class juego : System.Web.UI.Page
    {
        public static int turnos = 1;
        public static int c = 1;
        public static string Tf, Tcolum, Tcolor, cadena;
        //fila(1)-columna(A)-color
        public static string[,] pos = new string[8,8];
        public static string[,] temp = new string[8, 8];
        jugar j = new jugar();
     

        protected void Page_Load(object sender, EventArgs e)
        {
            una();
            
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


        //***********
        protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
        {
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 0] = "blanco";
                ImageButton1.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 0] = "negro";
                ImageButton1.ImageUrl = "~/pagina/imagenes/negra.png";

            }

            if (j.logica(0, 0))
            {
                verificar(0,0);
                turnos++;

            }
            else
            {
                ImageButton1.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 1] = "blanco";
                ImageButton2.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 1] = "negro";
                ImageButton2.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 1))
            {
                verificar(0,1);
                turnos++;

            }
            else
            {
                ImageButton2.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 2] = "blanco";
                ImageButton3.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 2] = "negro";
                ImageButton3.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 2))
            {
                verificar(0,2);
                turnos++;

            }
            else
            {
                ImageButton3.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 3] = "blanco";
                ImageButton4.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 3] = "negro";
                ImageButton4.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 3))
            {
                verificar(0,3);
                turnos++;

            }
            else
            {
                ImageButton4.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 4] = "blanco";
                ImageButton5.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 4] = "negro";
                ImageButton5.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 4))
            {
                verificar(0, 4);
                turnos++;

            }
            else
            {
                ImageButton5.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 5] = "blanco";
                ImageButton7.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 5] = "negro";
                ImageButton7.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 5))
            {
                verificar(0, 5);
                turnos++;

            }
            else
            {
                ImageButton7.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 6] = "blanco";
                ImageButton8.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 6] = "negro";
                ImageButton8.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 6))
            {
                verificar(0, 6);
                turnos++;

            }
            else
            {
                ImageButton8.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[0, 7] = "blanco";
                ImageButton6.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[0, 7] = "negro";
                ImageButton6.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(0, 7))
            {
                verificar(0, 7);
                turnos++;

            }
            else
            {
                ImageButton6.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 0] = "blanco";
                ImageButton9.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 0] = "negro";
                ImageButton9.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 0))
            {
                verificar(1, 0);
                turnos++;

            }
            else
            {
                ImageButton9.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 1] = "blanco";
                ImageButton10.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 1] = "negro";
                ImageButton10.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 1))
            {
                verificar(1, 1);
                turnos++;

            }
            else
            {
                ImageButton10.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 2] = "blanco";
                ImageButton11.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 2] = "negro";
                ImageButton11.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 2))
            {
                verificar(1, 2);
                turnos++;

            }
            else
            {
                ImageButton11.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 3] = "blanco";
                ImageButton12.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 3] = "negro";
                ImageButton12.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 3))
            {
                verificar(1, 3);
                turnos++;

            }
            else
            {
                ImageButton12.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 4] = "blanco";
                ImageButton13.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 4] = "negro";
                ImageButton13.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 4))
            {
                verificar(1, 4);
                turnos++;

            }
            else
            {
                ImageButton13.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 5] = "blanco";
                ImageButton14.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 5] = "negro";
                ImageButton14.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 5))
            {
                verificar(1, 5);
                turnos++;

            }
            else
            {
                ImageButton14.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 6] = "blanco";
                ImageButton15.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 6] = "negro";
                ImageButton15.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 6))
            {
                verificar(1, 6);
                turnos++;

            }
            else
            {
                ImageButton15.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[1, 7] = "blanco";
                ImageButton16.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[1, 7] = "negro";
                ImageButton16.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(1, 7))
            {
                verificar(1, 7);
                turnos++;

            }
            else
            {
                ImageButton16.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 0] = "blanco";
                ImageButton17.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 0] = "negro";
                ImageButton17.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 0))
            {
                verificar(2, 0);
                turnos++;

            }
            else
            {
                ImageButton17.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 1] = "blanco";
                ImageButton18.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 1] = "negro";
                ImageButton18.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 1))
            {
                verificar(2, 1);
                turnos++;

            }
            else
            {
                ImageButton18.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 2] = "blanco";
                ImageButton19.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 2] = "negro";
                ImageButton19.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 2))
            {
                verificar(2, 2);
                turnos++;

            }
            else
            {
                ImageButton19.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 3] = "blanco";
                ImageButton20.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 3] = "negro";
                ImageButton20.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 3))
            {
                verificar(2, 3);
                turnos++;

            }
            else
            {
                ImageButton20.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 4] = "blanco";
                ImageButton21.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 4] = "negro";
                ImageButton21.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 4))
            {
                verificar(2, 4);
                turnos++;

            }
            else
            {
                ImageButton21.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 5] = "blanco";
                ImageButton22.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 5] = "negro";
                ImageButton22.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 5))
            {
                verificar(2, 5);
                turnos++;

            }
            else
            {
                ImageButton22.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 6] = "blanco";
                ImageButton23.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 6] = "negro";
                ImageButton23.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 6))
            {
                verificar(2,6);
                turnos++;

            }
            else
            {
                ImageButton23.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[2, 7] = "blanco";
                ImageButton24.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[2, 7] = "negro";
                ImageButton24.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(2, 7))
            {
                verificar(2, 7);
                turnos++;

            }
            else
            {
                ImageButton24.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[3, 0] = "blanco";
                ImageButton25.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[3, 0] = "negro";
                ImageButton25.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(3, 0))
            {
                verificar(3, 0);
                turnos++;

            }
            else
            {
                ImageButton25.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[3, 1] = "blanco";
                ImageButton26.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[3, 1] = "negro";
                ImageButton26.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(3, 1))
            {
                verificar(3, 1);
                turnos++;

            }
            else
            {
                ImageButton26.ImageUrl = "~/pagina/imagenes/fondo.png";
            }


        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[3, 2] = "blanco";
                ImageButton27.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[3, 2] = "negro";
                ImageButton27.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(3, 2))
            {
                verificar(3, 2);
                turnos++;

            }
            else
            {
                ImageButton27.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {

            pos[3, 3] = "blanco";


        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            pos[3, 4] = "negro";
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[3, 5] = "blanco";
                ImageButton30.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[3, 5] = "negro";
                ImageButton30.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(3, 5))
            {
                verificar(3, 5);
                turnos++;

            }
            else
            {
                ImageButton30.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[3, 6] = "blanco";
                ImageButton31.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[3, 6] = "negro";
                ImageButton31.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(3, 6))
            {
                verificar(3, 6);
                turnos++;

            }
            else
            {
                ImageButton31.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[3, 7] = "blanco";
                ImageButton32.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[3, 7] = "negro";
                ImageButton32.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(3, 7))
            {
                verificar(3, 7);
                turnos++;

            }
            else
            {
                ImageButton32.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 0] = "blanco";
                ImageButton33.ImageUrl = "~/pagina/imagenes/blanca.png";


            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 0] = "negro";
                ImageButton33.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(4, 0))
            {
                verificar(4, 0);
                turnos++;

            }
            else
            {
                ImageButton33.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 1] = "blanco";
                ImageButton34.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 1] = "negro";
                ImageButton34.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(4, 1))
            {
                verificar(4, 1);
                turnos++;

            }
            else
            {
                ImageButton34.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 2] = "blanco";
                ImageButton35.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 2] = "negro";
                ImageButton35.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(4, 2))
            {
                verificar(4, 2);
                turnos++;

            }
            else
            {
                ImageButton35.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            pos[4, 3] = "negro";
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            pos[4, 4] = "blanco";
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 5] = "blanco";
                ImageButton38.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 5] = "negro";
                ImageButton38.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(4, 5))
            {
                verificar(4, 5);
                turnos++;

            }
            else
            {
                ImageButton38.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton39_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 6] = "blanco";
                ImageButton39.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 6] = "negro";
                ImageButton39.ImageUrl = "~/pagina/imagenes/negra.png";

            }
            if (j.logica(4, 6))
            {
                verificar(4, 6);
                turnos++;

            }
            else
            {
                ImageButton39.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[4, 7] = "blanco";
                ImageButton40.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[4, 7] = "negro";
                ImageButton40.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(4, 7))
            {
                verificar(4, 7);
                turnos++;

            }
            else
            {
                ImageButton40.ImageUrl = "~/pagina/imagenes/fondo.png";
            }
        }

        protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 0] = "blanco";
                ImageButton41.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 0] = "negro";
                ImageButton41.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 0))
            {
                verificar(5, 0);
                turnos++;

            }
            else
            {
                ImageButton41.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 1] = "blanco";
                ImageButton42.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 1] = "negro";
                ImageButton42.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 1))
            {
                verificar(5, 1);
                turnos++;

            }
            else
            {
                ImageButton42.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton43_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 2] = "blanco";
                ImageButton43.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 2] = "negro";
                ImageButton43.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 2))
            {
                verificar(5, 2);
                turnos++;

            }
            else
            {
                ImageButton43.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 3] = "blanco";
                ImageButton44.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 3] = "negro";
                ImageButton44.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 3))
            {
                verificar(5, 3);
                turnos++;

            }
            else
            {
                ImageButton44.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 4] = "blanco";
                ImageButton45.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 4] = "negro";
                ImageButton45.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 4))
            {
                verificar(5, 4);
                turnos++;               

            }
            else
            {
                ImageButton45.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 5] = "blanco";
                ImageButton46.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 5] = "negro";
                ImageButton46.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 5))
            {
                verificar(5, 5);
                turnos++;

            }
            else
            {
                ImageButton46.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton47_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 6] = "blanco";
                ImageButton47.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 6] = "negro";
                ImageButton47.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 6))
            {
                verificar(5, 6);
                turnos++;

            }
            else
            {
                ImageButton47.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton48_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[5, 7] = "blanco";
                ImageButton48.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[5, 7] = "negro";
                ImageButton48.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(5, 7))
            {
                verificar(5, 7);
                turnos++;

            }
            else
            {
                ImageButton48.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton49_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 0] = "blanco";
                ImageButton49.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 0] = "negro";
                ImageButton49.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 0))
            {
                verificar(6, 0);
                turnos++;

            }
            else
            {
                ImageButton49.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton50_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 1] = "blanco";
                ImageButton50.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 1] = "negro";
                ImageButton50.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 1))
            {
                verificar(6, 1);
                turnos++;

            }
            else
            {
                ImageButton50.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton51_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 2] = "blanco";
                ImageButton51.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 2] = "negro";
                ImageButton51.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 2))
            {
                verificar(6, 2);
                turnos++;

            }
            else
            {
                ImageButton51.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton52_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 3] = "blanco";
                ImageButton52.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 3] = "negro";
                ImageButton52.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 3))
            {
                verificar(6, 3);
                turnos++;

            }
            else
            {
                ImageButton52.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton53_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 4] = "blanco";
                ImageButton53.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 4] = "negro";
                ImageButton53.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 4))
            {
                verificar(6, 4);
                turnos++;

            }
            else
            {
                ImageButton53.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton54_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 5] = "blanco";
                ImageButton54.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 5] = "negro";
                ImageButton54.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 5))
            {
                verificar(6, 5);
                turnos++;

            }
            else
            {
                ImageButton54.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton55_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 6] = "blanco";
                ImageButton55.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[6, 6] = "negro";
                ImageButton55.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 6))
            {
                verificar(6, 6);
                turnos++;

            }
            else
            {
                ImageButton55.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton56_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 7] = "blanco";
                ImageButton56.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Negro";
                pos[6, 7] = "negro";
                ImageButton56.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(6, 7))
            {
                verificar(6, 7);
                turnos++;

            }
            else
            {
                ImageButton56.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton57_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 0] = "blanco";
                ImageButton57.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 0] = "negro";
                ImageButton57.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 0))
            {
                verificar(7, 0);
                turnos++;

            }
            else
            {
                ImageButton57.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton58_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 1] = "blanco";
                ImageButton58.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 1] = "negro";
                ImageButton58.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 1))
            {
                verificar(7, 1);
                turnos++;

            }
            else
            {
                ImageButton58.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton59_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 2] = "blanco";
                ImageButton59.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 2] = "negro";
                ImageButton59.ImageUrl = "~/pagina/imagenes/blanca.png";
            }
            if (j.logica(7, 2))
            {
                verificar(7, 2);
                turnos++;

            }
            else
            {
                ImageButton59.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton60_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 3] = "blanco";
                ImageButton60.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 3] = "negro";
                ImageButton60.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 3))
            {
                verificar(7, 3);
                turnos++;

            }
            else
            {
                ImageButton60.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton61_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 4] = "blanco";
                ImageButton61.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 4] = "negro";
                ImageButton61.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 4))
            {
                verificar(7, 4);
                turnos++;

            }
            else
            {
                ImageButton61.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton62_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 5] = "blanco";
                ImageButton62.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 5] = "negro";
                ImageButton62.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 5))
            {
                verificar(7, 5);
                turnos++;

            }
            else
            {
                ImageButton62.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton63_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 6] = "blanco";
                ImageButton63.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 6] = "negro";
                ImageButton63.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 6))
            {
                verificar(7, 6);
                turnos++;

            }
            else
            {
                ImageButton63.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }

        protected void ImageButton64_Click(object sender, ImageClickEventArgs e)
        {

            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Negro";
                pos[7, 7] = "blanco";
                ImageButton64.ImageUrl = "~/pagina/imagenes/blanca.png";

            }
            else
            {
                Label1.Text = "Turno de: Blanco";
                pos[7, 7] = "negro";
                ImageButton64.ImageUrl = "~/pagina/imagenes/negra.png";
            }
            if (j.logica(7, 7))
            {
                verificar(7, 7);
                turnos++;

            }
            else
            {
                ImageButton64.ImageUrl = "~/pagina/imagenes/fondo.png";
            }

        }


        //***********

        protected void Button1_Click(object sender, EventArgs e)
        {

            try {
                //si hay una archivo.
                string nombreArchivo = Bsubir.Text;
                string ruta = "~/guardado/" + nombreArchivo + ".xml";
                
                crear c = new crear();
                c.generar(Server.MapPath(ruta));
                Response.Write("<script>window.alert('Guardado correctamente')</script>");

                
            }
            catch (Exception ex) {
                Response.Write("<script>window.alert('Error al descargar el archivo')</script>");
            }

            
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
        /***************/

        public void verificar(int f, int c) {

            //arriba
            for (int fi=f-1;fi>=0;fi--) {
                
                if (pos[fi, c] == pos[f, c])
                {                   
                    //print();
                   // Array.Clear(temp,0,64);
                    break;                  
                }
                else if (pos[fi, c] == null)
                {
                    //eliminar
                   // Array.Clear(temp, 0, 64);
                    break;
                }
                else {
                    
                    temp[(fi), c] = pos[f, c];
                    pos[fi, c] = pos[f, c];
                        //guardado                   

                }
                
            }//fin for
            print();
            Array.Clear(temp, 0, 64);
            //abajo
            for (int fi = f + 1; fi <8; fi++)
            {

                if (pos[fi, c] == pos[f, c])
                {
                   // print();
                    //Array.Clear(temp, 0, 64);
                    break;
                }
                else if (pos[fi, c] == null)
                {
                    //eliminar
                   // Array.Clear(temp, 0, 64);
                    break;
                }
                else
                {

                    temp[(fi), c] = pos[f, c];
                    pos[(fi), c] = pos[f, c];
                    //guardado                   

                }

            }
            print();
            Array.Clear(temp, 0, 64);
            //izquierda
            for (int ci=c-1;ci>=0;ci--)
            {

                if (pos[f, ci] == pos[f, c])
                {
                    //print();
                    
                    break;
                }
                else if (pos[f, ci] == null)
                {
                    //eliminar
                   // Array.Clear(temp, 0, 64);
                    break;
                }
                else
                {

                    temp[f,ci] = pos[f, c];
                    pos[f, ci] = pos[f, c];
                    //guardado                   

                }

            }
            print();
            Array.Clear(temp, 0, 64);
            //derecha
            for (int ci=c+1;ci<8;ci++)
            {

                if (pos[f,ci] == pos[f, c])
                {
                   // print();
                    //Array.Clear(temp, 0, 64);
                    break;
                }
                else if (pos[f,ci] == null)
                {
                    //eliminar
                   // Array.Clear(temp, 0, 64);
                    break;
                }
                else
                {

                    temp[f,ci] = pos[f, c];
                    pos[f, ci] = pos[f, c];
                    //guardado                   

                }

            }
            print();
            Array.Clear(temp, 0, 64);
            //arriba izquierda
            int i = 1;
            int j = 1;
            while((i<8)||(j<8))
            {
                
                
                if (pos[f-i, c-j] == pos[f, c])
                {
                    // print();
                    break;
                }
                else if (pos[f - i, c - j] == null)
                {
                    //eliminar
                    break;
                }
                else
                {
                    temp[f - i, c - j] = pos[f, c];
                    pos[ f - i, c - j] = pos[f, c];
                    //guardado                   

                }
                i++;
                j++;

            }
            print();
            Array.Clear(temp, 0, 64);
            //abajo izquierda
            i = 1;
            j = 1;
            while ((i < 8) || (j < 8))
            {


                if (pos[f + i, c - j] == pos[f, c])
                {
                    // print();
                    break;
                }
                else if (pos[f + i, c - j] == null)
                {
                    //eliminar
                    break;
                }
                else
                {
                    temp[f + i, c - j] = pos[f, c];
                    pos[f + i, c - j] = pos[f, c];
                    //guardado                   

                }
                i++;
                j++;

            }
            print();
            Array.Clear(temp, 0, 64);

            //arriba derecha
            i = 1;
            j = 1;
            while ((i < 8) || (j < 8))
            {


                if (pos[f - i, c + j] == pos[f, c])
                {
                    // print();
                    break;
                }
                else if (pos[f - i, c + j] == null)
                {
                    //eliminar
                    break;
                }
                else
                {
                    temp[f - i, c + j] = pos[f, c];
                    pos[f - i, c + j] = pos[f, c];
                    //guardado                   

                }
                i++;
                j++;

            }
            print();
            Array.Clear(temp, 0, 64);

            //abajo derecha
            i = 1;
            j = 1;
            while ((i < 8) || (j < 8))
            {


                if (pos[f + i, c + j] == pos[f, c])
                {
                    // print();
                    break;
                }
                else if (pos[f + i, c + j] == null)
                {
                    //eliminar
                    break;
                }
                else
                {
                    temp[f + i, c + j] = pos[f, c];
                    pos[f + i, c + j] = pos[f, c];
                    //guardado                   

                }
                i++;
                j++;

            }
            print();
            Array.Clear(temp, 0, 64);






        }

        public void print()
        {
            
                for (int i=0;i<=64;i++) {
                if (temp[0, 0] == "negro")
                {
                    ImageButton1.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 0] == "blanco")
                {
                    ImageButton1.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 1] == "negro")
                {
                    ImageButton2.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 1] == "blanco")
                {
                    ImageButton2.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 2] == "negro")
                {
                    ImageButton3.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 2] == "blanco")
                {
                    ImageButton3.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 3] == "negro")
                {
                    ImageButton4.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 3] == "blanco")
                {
                    ImageButton4.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 4] == "negro")
                {
                    ImageButton5.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 4] == "blanco")
                {
                    ImageButton5.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 7] == "negro")
                {
                    ImageButton6.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 7] == "blanco")
                {
                    ImageButton6.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 5] == "negro")
                {
                    ImageButton7.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 5] == "blanco")
                {
                    ImageButton7.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[0, 6] == "negro")
                {
                    ImageButton8.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[0, 6] == "blanco")
                {
                    ImageButton8.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 0] == "negro")
                {
                    ImageButton9.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 0] == "blanco")
                {
                    ImageButton9.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 1] == "negro")
                {
                    ImageButton10.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 1] == "blanco")
                {
                    ImageButton10.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 2] == "negro")
                {
                    ImageButton11.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 2] == "blanco")
                {
                    ImageButton11.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 3] == "negro")
                {
                    ImageButton12.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 3] == "blanco")
                {
                    ImageButton12.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 4] == "negro")
                {
                    ImageButton13.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 4] == "blanco")
                {
                    ImageButton13.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 5] == "negro")
                {
                    ImageButton14.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 5] == "blanco")
                {
                    ImageButton14.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 6] == "negro")
                {
                    ImageButton15.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 6] == "blanco")
                {
                    ImageButton15.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[1, 7] == "negro")
                {
                    ImageButton16.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[1, 7] == "blanco")
                {
                    ImageButton16.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//
                 if (temp[2, 0] == "negro")
                {
                    ImageButton17.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 0] == "blanco")
                {
                    ImageButton17.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 1] == "negro")
                {
                    ImageButton18.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 1] == "blanco")
                {
                    ImageButton18.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 2] == "negro")
                {
                    ImageButton19.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 2] == "blanco")
                {
                    ImageButton19.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 3] == "negro")
                {
                    ImageButton20.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 3] == "blanco")
                {
                    ImageButton20.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 4] == "negro")
                {
                    ImageButton21.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 4] == "blanco")
                {
                    ImageButton21.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 5] == "negro")
                {
                    ImageButton22.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 5] == "blanco")
                {
                    ImageButton22.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 6] == "negro")
                {
                    ImageButton23.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 6] == "blanco")
                {
                    ImageButton23.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[2, 7] == "negro")
                {
                    ImageButton24.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[2, 7] == "blanco")
                {
                    ImageButton24.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//
                 if (temp[3, 0] == "negro")
                {
                    ImageButton25.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 0] == "blanco")
                {
                    ImageButton25.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 1] == "negro")
                {
                    ImageButton26.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 1] == "blanco")
                {
                    ImageButton26.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 2] == "negro")
                {
                    ImageButton27.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 2] == "blanco")
                {
                    ImageButton27.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 3] == "negro")
                {
                    ImageButton28.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 3] == "blanco")
                {
                    ImageButton28.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 4] == "negro")
                {
                    ImageButton29.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 4] == "blanco")
                {
                    ImageButton29.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 5] == "negro")
                {
                    ImageButton30.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 5] == "blanco")
                {
                    ImageButton30.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 6] == "negro")
                {
                    ImageButton31.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 6] == "blanco")
                {
                    ImageButton31.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[3, 7] == "negro")
                {
                    ImageButton32.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[3, 7] == "blanco")
                {
                    ImageButton32.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//
                 if (temp[4, 0] == "negro")
                {
                    ImageButton33.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 0] == "blanco")
                {
                    ImageButton33.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 1] == "negro")
                {
                    ImageButton34.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 1] == "blanco")
                {
                    ImageButton34.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 2] == "negro")
                {
                    ImageButton35.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 2] == "blanco")
                {
                    ImageButton35.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 3] == "negro")
                {
                    ImageButton36.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 3] == "blanco")
                {
                    ImageButton36.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 4] == "negro")
                {
                    ImageButton37.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 4] == "blanco")
                {
                    ImageButton37.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 5] == "negro")
                {
                    ImageButton38.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 5] == "blanco")
                {
                    ImageButton38.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 6] == "negro")
                {
                    ImageButton39.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 6] == "blanco")
                {
                    ImageButton39.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[4, 7] == "negro")
                {
                    ImageButton40.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[4, 7] == "blanco")
                {
                    ImageButton40.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//
                 if (temp[5, 0] == "negro")
                {
                    ImageButton41.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 0] == "blanco")
                {
                    ImageButton41.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 1] == "negro")
                {
                    ImageButton42.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 1] == "blanco")
                {
                    ImageButton42.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 2] == "negro")
                {
                    ImageButton43.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 2] == "blanco")
                {
                    ImageButton43.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 3] == "negro")
                {
                    ImageButton44.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 3] == "blanco")
                {
                    ImageButton44.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 4] == "negro")
                {
                    ImageButton45.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 4] == "blanco")
                {
                    ImageButton45.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 5] == "negro")
                {
                    ImageButton46.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 5] == "blanco")
                {
                    ImageButton46.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 6] == "negro")
                {
                    ImageButton47.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 6] == "blanco")
                {
                    ImageButton47.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[5, 7] == "negro")
                {
                    ImageButton48.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[5, 7] == "blanco")
                {
                    ImageButton48.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//
                 if (temp[6, 0] == "negro")
                {
                    ImageButton49.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 0] == "blanco")
                {
                    ImageButton49.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 1] == "negro")
                {
                    ImageButton50.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 1] == "blanco")
                {
                    ImageButton50.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 2] == "negro")
                {
                    ImageButton51.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 2] == "blanco")
                {
                    ImageButton51.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 3] == "negro")
                {
                    ImageButton52.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 3] == "blanco")
                {
                    ImageButton52.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 4] == "negro")
                {
                    ImageButton53.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 4] == "blanco")
                {
                    ImageButton53.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 5] == "negro")
                {
                    ImageButton54.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 5] == "blanco")
                {
                    ImageButton54.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 6] == "negro")
                {
                    ImageButton55.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 6] == "blanco")
                {
                    ImageButton55.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[6, 7] == "negro")
                {
                    ImageButton56.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[6, 7] == "blanco")
                {
                    ImageButton56.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//
                 if (temp[7, 0] == "negro")
                {
                    ImageButton57.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 0] == "blanco")
                {
                    ImageButton57.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 1] == "negro")
                {
                    ImageButton58.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 1] == "blanco")
                {
                    ImageButton58.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 2] == "negro")
                {
                    ImageButton59.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 2] == "blanco")
                {
                    ImageButton59.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 3] == "negro")
                {
                    ImageButton60.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 3] == "blanco")
                {
                    ImageButton60.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 4] == "negro")
                {
                    ImageButton61.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 4] == "blanco")
                {
                    ImageButton61.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 5] == "negro")
                {
                    ImageButton62.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 5] == "blanco")
                {
                    ImageButton62.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 6] == "negro")
                {
                    ImageButton63.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 6] == "blanco")
                {
                    ImageButton63.ImageUrl = "~/pagina/imagenes/blanca.png";
                }
                 if (temp[7, 7] == "negro")
                {
                    ImageButton64.ImageUrl = "~/pagina/imagenes/negra.png";
                }
                 if (temp[7, 7] == "blanco")
                {
                    ImageButton64.ImageUrl = "~/pagina/imagenes/blanca.png";
                }//




            }


        }

        public void una() {
            if (c == 1)
            {
                pos[3, 3] = "blanco";
                pos[3, 4] = "negro";
                pos[4, 3] = "negro";
                pos[4, 4] = "blanco";
            }
            else { }
            c++;
           
        }

    }//***************  
}
