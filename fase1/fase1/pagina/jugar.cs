using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fase1.pagina
{
    public class jugar
    {
        //
        public bool logica(int f, int c)
        {
            bool si = true;

            if ((f - 1) < 0 && (c - 1) < 0)
            {//por si esta en primera fila y primer columna
                if (juego.pos[f, c + 1] == "negro" || juego.pos[f, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c] == "negro" || juego.pos[f + 1, c] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c + 1] == "negro" || juego.pos[f + 1, c + 1] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");

                }

            }


            else if ((f + 1) > 7 && (c - 1) < 0)
            {//por si esta en la fila final, columna inicial
                if (juego.pos[f - 1, c] == "negro" || juego.pos[f - 1, c] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c + 1] == "negro" || juego.pos[f - 1, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f, c + 1] == "negro" || juego.pos[f, c + 1] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");
                }
            }
            else if ((f - 1) < 0 && (c + 1) > 7)
            {//por si esta en la fila inicial, columna final
                if (juego.pos[f, c - 1] == "negro" || juego.pos[f, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c - 1] == "negro" || juego.pos[f + 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c] == "negro" || juego.pos[f + 1, c] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");
                }
            }
            else if ((f + 1) > 7 && (c + 1) > 7)
            {//por si esta en la fila final, columna final
                if (juego.pos[f - 1, c - 1] == "negro" || juego.pos[f - 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c] == "negro" || juego.pos[f - 1, c] == "blanca")
                {

                }
                else if (juego.pos[f, c - 1] == "negro" || juego.pos[f, c - 1] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");
                }
            }

            else if ((c + 1) > 7)
            {//columna final
                if (juego.pos[f - 1, c - 1] == "negro" || juego.pos[f - 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c] == "negro" || juego.pos[f - 1, c] == "blanca")
                {

                }
                else if (juego.pos[f, c - 1] == "negro" || juego.pos[f, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c - 1] == "negro" || juego.pos[f + 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c] == "negro" || juego.pos[f + 1, c] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");
                }

            }
            else if ((f - 1) < 0)
            {//por si esta en primera fila
                if (juego.pos[f, c - 1] == "negro" || juego.pos[f, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f, c + 1] == "negro" || juego.pos[f, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c - 1] == "negro" || juego.pos[f + 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c] == "negro" || juego.pos[f + 1, c] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c + 1] == "negro" || juego.pos[f + 1, c + 1] == "blanca")
                {

                }
                else
                {
                    si = false;
                   // "<script>window.alert('Error')</script>;"
                }

            }
            else if ((f + 1) > 7)
            {//por si esta en ultima fila
                if (juego.pos[f - 1, c - 1] == "negro" || juego.pos[f - 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c] == "negro" || juego.pos[f - 1, c] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c + 1] == "negro" || juego.pos[f - 1, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f, c - 1] == "negro" || juego.pos[f, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f, c + 1] == "negro" || juego.pos[f, c + 1] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");
                }

            }
            else if ((c - 1) < 0)
            {//columna inicial
                if (juego.pos[f - 1, c] == "negro" || juego.pos[f - 1, c] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c + 1] == "negro" || juego.pos[f - 1, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f, c + 1] == "negro" || juego.pos[f, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c] == "negro" || juego.pos[f + 1, c] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c + 1] == "negro" || juego.pos[f + 1, c + 1] == "blanca")
                {

                }
                else
                {
                    si = false;
                    //Response.Write("<script>window.alert('Error')</script>");
                }

            }
            else
            {//en medio de cosas

                if (juego.pos[f - 1, c - 1] == "negro" || juego.pos[f - 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c] == "negro" || juego.pos[f - 1, c] == "blanca")
                {

                }
                else if (juego.pos[f - 1, c + 1] == "negro" || juego.pos[f - 1, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f, c - 1] == "negro" || juego.pos[f, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f, c + 1] == "negro" || juego.pos[f, c + 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c - 1] == "negro" || juego.pos[f + 1, c - 1] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c] == "negro" || juego.pos[f + 1, c] == "blanca")
                {

                }
                else if (juego.pos[f + 1, c + 1] == "negro" || juego.pos[f + 1, c + 1] == "blanca")
                {

                }
                /*else
                {
                    si = false;
                    Response.Write("<script>window.alert('Error')</script>");
                }*/
            }
            
            return si;

        }//fin public

        //**
        

        //**
    }
}