using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace fase1.pagina
{
    public class crear
    {

        //juego var = new juego();
        
        public void generar(string ruta) {

            XmlWriter xmlWriter = XmlWriter.Create(ruta);

            int x = 0;
            int  y=0;
            //string letra = "";

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("tablero");

            //fila(1)-columna(A)-color
            //juego.pos[i, j]="";

            for (int i =0; i<=7; i++) {

                for (int j = 0; j <= 7; j++) {

                    if (juego.pos[i,j]==null) {

                        
                    }
                    else {
                        xmlWriter.WriteStartElement("ficha");

                        xmlWriter.WriteStartElement("color");
                        xmlWriter.WriteString(juego.pos[i, j]);
                        xmlWriter.WriteEndElement();
                                                
                        xmlWriter.WriteStartElement("columna");
                        xmlWriter.WriteString(letra(j));
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("fila");
                        xmlWriter.WriteString((i+1).ToString());
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        x = i;
                        y = j;
                        
                    }

                    

                }

            }

            if (juego.pos[x,y].Equals("negra")) {

                xmlWriter.WriteStartElement("siguienteTiro");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString("blanca");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

            }
            else {
                xmlWriter.WriteStartElement("siguienteTiro");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString("negra");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }

           
            
           



            xmlWriter.WriteEndElement();


            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

        }//

        public void generar2(string ruta)
        {

            XmlWriter xmlWriter = XmlWriter.Create(ruta);

            int x = 0;
            int y = 0;
            //string letra = "";

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("tablero");

            //fila(1)-columna(A)-color
            //juego.pos[i, j]="";

            for (int i = 0; i <= 7; i++)
            {

                for (int j = 0; j <= 7; j++)
                {

                    if (juego_vs.pos[i, j] == null)
                    {


                    }
                    else
                    {
                        xmlWriter.WriteStartElement("ficha");

                        xmlWriter.WriteStartElement("color");
                        xmlWriter.WriteString(juego_vs.pos[i, j]);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("columna");
                        xmlWriter.WriteString(letra(j));
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("fila");
                        xmlWriter.WriteString((i + 1).ToString());
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        x = i;
                        y = j;

                    }



                }

            }

            if (juego_vs.pos[x, y].Equals("negra"))
            {

                xmlWriter.WriteStartElement("siguienteTiro");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString("blanca");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

            }
            else
            {
                xmlWriter.WriteStartElement("siguienteTiro");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString("negra");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }







            xmlWriter.WriteEndElement();


            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

        }//

        public string letra(int n)
        {
            string l = "A";
            if (n == 0)
            {
                l = "A";

            }else if (n == 1)
            {
                l = "B";

            }
            else if (n == 2)
            {
                l = "C";

            }
            else if (n == 3)
            {
                l = "D";

            }
            else if (n == 4)
            {
                l = "E";

            }
            else if (n == 5)
            {
                l = "F";

            }
            else if (n == 6)
            {
                l = "G";

            }
            else if (n == 7)
            {
                l = "H";

            }


            return l;
        }//

    }
   

}