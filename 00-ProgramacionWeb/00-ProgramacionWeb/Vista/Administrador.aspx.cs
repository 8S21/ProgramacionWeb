using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["Usuario"].ToString();
                lblUsuario.Text = "Bienvenido " + usuario;
            }
            catch( Exception )
            {
                Response.Redirect( "Login.aspx?Mensaje=1" );                
            }
            if( Request.Params["e"] != null )
            {
                String mensaje = Request.Params["e"];
                if( mensaje == "1" )
                {
                    Response.Write( "Se registro Exitosamente" );
                }
            }
        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove( "Usuario" );
            Response.Redirect( "Login.aspx" );
        }
    }
}