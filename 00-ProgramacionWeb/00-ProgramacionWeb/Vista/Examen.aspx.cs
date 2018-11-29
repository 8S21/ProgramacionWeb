using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Modelo;
using System.Data;
using System.Collections;
using _00_ProgramacionWeb.Include;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Examen : System.Web.UI.Page
    {
        int contador = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioAlum"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx?Mensaje=3");
            }
            Modelos m = new Modelos();
            string grupo = Request.Params["g"];
            ArrayList preguntas = m.MostrarPreguntas( grupo );
            Preguntas pre;
            string pregunta = "";
            string respuesta1 = "";
            string respuesta2 = "";
            string respuesta3 = "";
            string respuesta4 = "";

            int numero = Convert.ToInt32(Request.Params["p"]);
            numero += contador;
            int restriccion = preguntas.Count;
            if ( numero < restriccion )
            {
                for (int i = 0; i <= numero; i++)
                {
                    if (i == numero)
                    {
                        pre = (Preguntas)preguntas[i];
                        pregunta = pre.pregunta;
                        respuesta1 = pre.respuesta1;
                        respuesta2 = pre.respuesta2;
                        respuesta3 = pre.respuesta3;
                        respuesta4 = pre.respuesta4;
                    }
                }
                lblPregunta.Text = pregunta;
                RadioButton1.Text = respuesta1;
                RadioButton2.Text = respuesta2;
                RadioButton3.Text = respuesta3;
                RadioButton4.Text = respuesta4;
            }
            else
            {
                int respuestasCorrectas = Convert.ToInt32( Session["RespuestasCorrectas"].ToString() );
                double calificacion = ( Convert.ToDouble( respuestasCorrectas ) * 10.00) / Convert.ToDouble(restriccion);
                Session["calificacion"] = calificacion;
                Response.Redirect( "Calificacion.aspx" );
            }
            
        }

        protected void Click(object sender, EventArgs e)
        {
            if( RadioButton1.Checked == true )
            {
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;
            }
            else if( RadioButton2.Checked == true )
            {
                RadioButton1.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;
            }
            else if( RadioButton3.Checked == true )
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton4.Checked = false;
            }
            else if( RadioButton4.Checked == true )
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
            }
        }

        protected void Siguiente(object sender, EventArgs e)
        {
            Modelos m = new Modelos();
            string grupo = Request.Params["g"];
            int numero = Convert.ToInt32(Request.Params["p"]);
            int respuestasCorrectas = Convert.ToInt32( Session["RespuestasCorrectas"].ToString() );
            ArrayList preguntas = m.MostrarPreguntas(grupo);
            Preguntas pre;
            int respuestaCorrecta = 0;
            for (int i = 0; i <= numero; i++)
            {
                if (numero == i)
                {
                    pre = (Preguntas)preguntas[i];
                    respuestaCorrecta = pre.correcta;
                }
            }
            if (RadioButton1.Checked == true)
            {
                if (1 == respuestaCorrecta)
                {
                    respuestasCorrectas += 1;
                }
            }
            else if (RadioButton2.Checked == true)
            {
                if (2 == respuestaCorrecta)
                {
                    respuestasCorrectas += 1;
                }
            }
            else if (RadioButton3.Checked == true)
            {
                if (3 == respuestaCorrecta)
                {
                    respuestasCorrectas += 1;
                }
            }
            else if (RadioButton4.Checked == true)
            {
                if (4 == respuestaCorrecta)
                {
                    respuestasCorrectas += 1;
                }
            }
            Session["RespuestasCorrectas"] = respuestasCorrectas;
            numero += contador + 1;
            Response.Redirect( "Examen.aspx?g=" + grupo +"&p=" + numero );
        }
    }
}