using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove( "UsuarioAlum" );
            Response.Redirect( "Login.aspx" );
        }

        protected void Empezar(object sender, EventArgs e)
        {
            Response.Redirect( "Examen.aspx" );
        }
    }
}