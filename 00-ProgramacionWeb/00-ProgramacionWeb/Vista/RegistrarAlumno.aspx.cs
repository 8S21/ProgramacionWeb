using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;

namespace _00_ProgramacionWeb.Vista
{
    public partial class RegistrarAlumno : System.Web.UI.Page
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
            if( Request.Params["c"] == null || Request.Params["g"] == null )
            {
                Response.Redirect( "Maestros.aspx" );
            }
            txtCarrera.Text = Request.Params["c"];
            txtGrupo.Text = Request.Params["g"];
        }

        protected void AgregarAlumno(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            int matricula = Convert.ToInt32( txtMatricula.Text );
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String carrera = txtCarrera.Text;
            String grupo = txtGrupo.Text;
            if( con.RegistrarAlumno( matricula, nombre, apellido, carrera, grupo ) )
            {
                Response.Redirect( "MostrarAlumnos.aspx?e=1&c=" + Request.Params["c"] + "&g=" + Request.Params["g"] );
            }
            else
            {
                Response.Write( "-no se pudo realizar la operación" );
            }
        }
    }
}