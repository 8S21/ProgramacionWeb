using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace _00_ProgramacionWeb.Conexion
{
    public class Consultas
    {
        MySqlConnection conexion;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        DataTable tabla = new DataTable();
        String cadena = "server=localhost;user id=root;persistsecurityinfo=True;database=programacion_web; password=";

        public Consultas()
        {
            conexion = new MySqlConnection(cadena);
        }        
        public Boolean Login( String usuario, String password )
        {
            Boolean estado = true;
            try
            {
                conexion.Open();
            }
            catch( MySqlException e )
            {

            }
            finally
            {

            }
            return estado;
        }
    }
}