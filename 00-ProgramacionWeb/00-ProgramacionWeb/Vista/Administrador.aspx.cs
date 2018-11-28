using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;
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
            Consultas con = new Consultas();
            String html = "";
            if( con.MostrarMaestros().Rows.Count > 0 )
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Nombre</td><td>Apellido</td><td>Correo</td><td>Usuario</td><td>Contraseña</td></tr></thead>";
                html += "<tbody>";
                foreach( DataRow dato in con.MostrarMaestros().Rows )
                {
                    html += "<tr>";
                    html += "<td>" + dato["IdMaestro"].ToString() + "</td>";
                    html += "<td>" + dato["Nombre"].ToString() + "</td>";
                    html += "<td>" + dato["Apellido"].ToString() + "</td>";
                    html += "<td>" + dato["Correo"].ToString() + "</td>";
                    html += "<td>" + dato["Usuario"].ToString() + "</td>";
                    html += "<td>" + dato["Password"].ToString() + "</td>";
                    html += "</tr>";
                }
                html += "</tbody>";
                html += "</table></center>";
            }
            else
            {
                html += "<center><table><tr><td>No hay registros</td></tr></table></center>";
            }
            Literal.Text = html;

        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove( "UsuarioAdmi" );
            Response.Redirect( "Login.aspx" );
        }
    }
}