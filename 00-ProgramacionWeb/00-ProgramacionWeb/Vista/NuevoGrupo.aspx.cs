using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _00_ProgramacionWeb.Conexion;

namespace _00_ProgramacionWeb.Vista
{
    public partial class NuevoGrupo : System.Web.UI.Page
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
        }

        protected void CrearGrupo(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            String carrera = txtCarrera.Text;
            String grupo = txtGrupo.Text;
            if( con.RegistrarGrupo( carrera, grupo ) )
            {
                Response.Redirect( "Maestro.aspx?e=1" );
            }
            else
            {
                Response.Write( "No se pudo completar la operación" );
            }
        }
    }
}