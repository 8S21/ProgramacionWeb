using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Calificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioAlum"].ToString();
                lblUsuario.Text = "Terminaste tu examen " + usuario;
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx?Mensaje=3");
            }
            string calificacion = Session["calificacion"].ToString();
            lblCalificacion.Text = "Tu calificacion es " + calificacion;
        }

        protected void Aceptar(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            int matricula = Convert.ToInt32( Session["Matricula"].ToString() );
            double calificacion = Convert.ToDouble( Session["calificacion"].ToString() );
            if( con.ResgistrarCalificacion( matricula, calificacion ) )
            {
                Session.Remove( "calificacion" );
                Response.Redirect( "Alumno.aspx" );
            }
        }
    }
}