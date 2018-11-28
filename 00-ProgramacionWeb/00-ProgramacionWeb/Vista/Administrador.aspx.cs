using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Modelo;
using System.Data;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioAdmi"].ToString();
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
            Modelos m = new Modelos();
            Literal.Text =m.MostrarMaestros();

        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove( "UsuarioAdmi" );
            Response.Redirect( "Login.aspx" );
        }
    }
}