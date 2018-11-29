using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _00_ProgramacionWeb.Include
{
    public class Preguntas
    {
        public string pregunta { set; get; }
        public string respuesta1 { set; get; }
        public string respuesta2 { set; get; }
        public string respuesta3 { set; get; }
        public string respuesta4 { set; get; }
        public int correcta { set; get; }
        public Preguntas()
        {

        }
        public Preguntas( string preg, string resp1, string resp2, string resp3, string resp4, int corr )
        {
            pregunta = preg;
            respuesta1 = resp1;
            respuesta2 = resp2;
            respuesta3 = resp3;
            respuesta4 = resp4;
            correcta = corr;
        }        
    }
}