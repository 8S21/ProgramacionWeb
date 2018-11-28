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
    public partial class Maestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioMaes"].ToString();
                lblMaestro.Text = "Bienvenido " + usuario;
            }
            catch (Exception)
            {
                Response.Redirect( "Login.aspx?Mensaje=2" );
            }
            if (Request.Params["e"] != null)
            {
                String mensaje = Request.Params["e"];
                if (mensaje == "1")
                {
                    Response.Write( "Se registro Exitosamente" );
                }
            }
            Consultas con = new Consultas();
            String html = "";
            if ( con.MostrarGrupos().Rows.Count > 0 )
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Carrera</td><td>Grupo</td><td>Acciones</td></tr></thead>";
                html += "<tbody>";
                foreach ( DataRow dato in con.MostrarGrupos().Rows )
                {
                    html += "<tr>";
                    html += "<td>" + dato["IdGrupo"].ToString() + "</td>";
                    html += "<td>" + dato["Carrera"].ToString() + "</td>";
                    html += "<td>" + dato["Grupo"].ToString() + "</td>";
                    html += "<td><a href='MostrarAlumnos.aspx?c=" + dato["Carrera"].ToString() + "&g=" + dato["Grupo"].ToString() + "'>Mostar Alumnos</a></td>";
                    html += "</tr>";
                }
                html += "</tbody>";
                html += "</table><center>";
            }
            else
            {
                html += "<center><table><tr><td>No hay grupos</td></tr></table></center>";
            }
            Literal.Text = html;
        }

        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove( "UsuarioMaes" );
            Response.Redirect( "Login.aspx" );
        }

        protected void CrearGrupo(object sender, EventArgs e)
        {
            Response.Redirect( "NuevoGrupo.aspx" );
        }        
    }
}