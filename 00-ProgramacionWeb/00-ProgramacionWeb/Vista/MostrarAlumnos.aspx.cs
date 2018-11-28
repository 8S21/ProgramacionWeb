using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Modelo;
using _00_ProgramacionWeb.Conexion;
using System.Data;

namespace _00_ProgramacionWeb.Vista
{
    public partial class MostrarAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioMaes"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect( "Login.aspx?Mensaje=2" );
            }
            if ( Request.Params["e"] != null )
            {
                String mensaje = Request.Params["e"];
                if ( mensaje == "1" )
                {
                    Response.Write( "Se registro Exitosamente" );
                }
            }

            Consultas con = new Consultas();
            Modelos m = new Modelos();
            String grupo = Request.Params["g"];
            
            LiteralAlumnos.Text = m.MostrarAlumnosGrupo( grupo );
            LiteralPreguntas.Text = m.MostrarExamenes( grupo );
        }

        protected void AgregarAlumno(object sender, EventArgs e)
        {
            String grupo = Request.Params["g"];
            String carrera = Request.Params["c"];
            Response.Redirect( "RegistrarAlumno?c=" + carrera + "&g=" + grupo );
        }

        protected void Regresar(object sender, EventArgs e)
        {
            Response.Redirect( "Maestro.aspx" );
        }

        protected void AgregarPreguntas(object sender, EventArgs e)
        {
            String grupo = Request.Params["g"];
            Response.Redirect( "AgregarPregunta.aspx?g=" + grupo );
        }
    }
}