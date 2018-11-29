using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Modelo;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioAlum"].ToString();
                lblUsuario.Text = "Bienvenido " + usuario;
            }
            catch (Exception)
            {
                Response.Redirect( "Login.aspx?Mensaje=3" );
            }
            int matricula = Convert.ToInt32( Session["Matricula"].ToString() );
            Modelos m = new Modelos();
            Literal.Text = m.MostrarDatosAlumno( matricula );
        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove( "UsuarioAlum" );
            Response.Redirect( "Login.aspx" );
        }

        protected void Empezar(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32( Session["Matricula"].ToString() );
            Modelos m = new Modelos();
            string calificacion = m.VerificarCalificacion( matricula );
            if( calificacion.Length == 0 )
            {
                string grupo = m.ObtenerGrupo(matricula);
                int respuestasCorrectas = 0;
                Session["RespuestasCorrectas"] = respuestasCorrectas;
                Response.Redirect("Examen.aspx?g=" + grupo + "&p=0");
            }
            else
            {
                Response.Write( "Ya realizaste tu examen" );
            }
        }
    }
}