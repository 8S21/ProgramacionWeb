using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _00_ProgramacionWeb.Vista
{
    public partial class Examen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["UsuarioAlum"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx?Mensaje=3");
            }
        }

    }
}