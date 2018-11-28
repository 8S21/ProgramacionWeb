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
                Response.Redirect("Login.aspx?Mensaje=2");
            }
            if (Request.Params["e"] != null)
            {
                String mensaje = Request.Params["e"];
                if (mensaje == "1")
                {
                    Response.Write("Se registro Exitosamente");
                }
            }

            Consultas con = new Consultas();
            String grupo = Request.Params["g"];
            String html = "";
            if ( con.MostrarAlumnosGrupo( grupo ).Rows.Count > 0 )
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Matricula</td><td>Nombre</td><td>Apellido</td><td>Carrera</td><td>Grupo</td><td>Calificación</td></tr></thead>";
                html += "<tbody>";
                foreach( DataRow dato in con.MostrarAlumnosGrupo( grupo ).Rows )
                {
                    html += "<tr>";
                    html += "<td>" + dato["IdAlumno"].ToString() + "</td>";
                    html += "<td>" + dato["Matricula"].ToString() + "</td>";
                    html += "<td>" + dato["Nombre"].ToString() + "</td>";
                    html += "<td>" + dato["Apellido"].ToString() + "</td>";
                    html += "<td>" + dato["Carrera"].ToString() + "</td>";
                    html += "<td>" + dato["Grupo"].ToString() + "</td>";
                    html += "<td>" + dato["Calificacion"].ToString() + "</td>";
                    html += "</tr>";
                }
                html += "</tbody>";
                html += "</table></center>";
            }
            else
            {
                html += "<center><table><tr><td>No hay alumnos en este grupo</td></tr></table></center>";
            }
            Literal.Text = html;
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
    }
}