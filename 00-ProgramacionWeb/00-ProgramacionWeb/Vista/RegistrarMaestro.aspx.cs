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
    public partial class RegistrarMaestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insertar(object sender, EventArgs e)
        {            
            Consultas con = new Consultas();
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String materia = txtMateria.Text;
            String correo = txtCorreo.Text;
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            if (con.RegistrarMaestro(nombre, apellido, materia, correo, usuario, password))
            {
                Response.Write("Exito");
            }
            else
            { }

                Response.Write( "Error" );
            }
        }
    }
}