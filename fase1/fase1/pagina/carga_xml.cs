using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace fase1.pagina
{
    public class carga_xml
    {
        public static string[] v;
        public void archivo(string cadena) {

            char[] del = { '<', '>', '/', (char)10,' ' };
            v = cadena.Split(del);


            for (int i=0; i<v.Length;i++) {
                Debug.WriteLine(v[i]);
            }           

        }

    }
}