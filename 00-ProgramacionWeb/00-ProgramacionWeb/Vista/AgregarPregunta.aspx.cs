using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;

namespace _00_ProgramacionWeb.Vista
{
    public partial class AgregarPregunta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioMaes"].ToString();
            }
            catch ( Exception )
            {
                Response.Redirect( "Login.aspx?Mensaje=2" );
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            String pregunta = txtPregunta.Text;
            String respuesta1 = txtRespuesta1.Text;
            String respuesta2 = txtRespuesta2.Text;
            String respuesta3 = txtRespuesta3.Text;
            String respuesta4 = txtRespuesta4.Text;
            int correcta = Convert.ToInt32( RespuestaCorrecta.Text );
            String grupo = Request.Params["g"];
            if( con.RegistrarPregunta( pregunta, respuesta1, respuesta2, respuesta3, respuesta4, correcta, grupo ) )
            {
                Response.Redirect( "MostrarAlumnos.aspx?e=1&g=" + grupo );
            }
            else
            {
                Response.Write( "No se pudo agregar la pregunta" );
            }
        }
    }
}