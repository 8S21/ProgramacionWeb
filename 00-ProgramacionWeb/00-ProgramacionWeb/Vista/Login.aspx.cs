using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;
using MySql.Data.MySqlClient;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Request.Params["Mensaje"] != null )
            {
                String mensaje = Request.Params["Mensaje"];
                if( mensaje == "1" )
                {
                    Response.Write( "Inicia Sesión como Administrador" );
                }
                else if( mensaje == "2" )
                {
                    Response.Write( "Inicia Sesión como Maestro" );
                }
                else if( mensaje == "3" )
                {
                    Response.Write( "Inicia Sesión como alumno" );
                }
            }
        }

        protected void Entrar(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            int matricula = Convert.ToInt32( txtPassword.Text );
            if( con.LoginAdministrador( usuario, password ) )
            {
                Session["UsuarioAdmi"] = usuario;
                Response.Redirect( "Administrador.aspx" );
            }
            else if( con.LoginMaestro( usuario, password ) )
            {
                Session["UsuarioMaes"] = usuario;
                Response.Redirect( "Maestro.aspx" );
            }
            else if( con.LoginAlumno( usuario, matricula ) )
            {
                Session["UsuarioAlum"] = usuario;
                Response.Redirect( "Alumno.aspx" );
            }
            else
            {

                Response.Write( "<center>Error<br/>No coincide su usuario y contraseña<br/>Intente de nuevo<center><br/>" );
            }
        }
    }
}