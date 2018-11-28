using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;
using _00_ProgramacionWeb.Include;

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
        public Boolean LoginAdministrador( String usuario, String password )
        {
            try
            {
                conexion.Open();
                String consulta = "select * from administrador where Usuario = @usuario and Password = @password";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                com.Parameters.AddWithValue( "@usuario", usuario );
                com.Parameters.AddWithValue( "@password", password );
                int count = Convert.ToInt32( com.ExecuteScalar() );
                if ( count == 0 )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch ( MySqlException )
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Boolean LoginMaestro( String usuario, String password )
        {
            try
            {
                conexion.Open();
                String consulta = "select * from maestro where Usuario = @usuario and Password = @password";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                com.Parameters.AddWithValue( "@usuario", usuario );
                com.Parameters.AddWithValue( "@password", password );
                int count = Convert.ToInt32( com.ExecuteScalar() );
                if ( count == 0 )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch ( MySqlException )
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Boolean LoginAlumno( String nombre, int matricula )
        {
            try
            {
                conexion.Open();
                String consulta = "select * from alumno where Nombre = @nombre and matricula = @matricula";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                com.Parameters.AddWithValue( "@nombre", nombre );
                com.Parameters.AddWithValue( "@matricula", matricula );
                int count = Convert.ToInt32( com.ExecuteScalar() );
                if ( count == 0 )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch ( MySqlException )
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Boolean RegistrarMaestro( String nombre, String apellido, String correo, String usuario, String password )
        {
            try
            {
                conexion.Open();
                String consulta = "insert into maestro (Nombre, Apellido, Correo, Usuario, Password) values (@nombre,@apellido,@correo,@usuario,@password)";
                MySqlCommand com = new MySqlCommand(consulta, conexion);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@apellido", apellido);
                com.Parameters.AddWithValue("@correo", correo);
                com.Parameters.AddWithValue("@usuario", usuario);
                com.Parameters.AddWithValue("@password", password);
                int resultado = com.ExecuteNonQuery();
                if (resultado == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Boolean RegistrarGrupo( String carrera, String grupo )
        {
            try
            {
                conexion.Open();
                String consulta = "insert into grupo( Carrera, Grupo ) values ( @carrera, @grupo )";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                com.Parameters.AddWithValue( "@carrera", carrera );
                com.Parameters.AddWithValue( "@grupo", grupo );
                int resultado = com.ExecuteNonQuery();
                if( resultado == 0 )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch( MySqlException )
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Boolean RegistrarAlumno( int matricula, String nombre, String apellido, String carrera, String grupo )
        {
            try
            {
                conexion.Open();
                String consulta = "insert into alumno( Matricula, Nombre, Apellido, Carrera, Grupo) values ( @matricula, @nombre, @apellido, @carrera, @grupo )";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                com.Parameters.AddWithValue( "@matricula", matricula );
                com.Parameters.AddWithValue( "@nombre", nombre );
                com.Parameters.AddWithValue( "@apellido", apellido );
                com.Parameters.AddWithValue( "@carrera", carrera );
                com.Parameters.AddWithValue( "@grupo", grupo );
                int resultado = com.ExecuteNonQuery();
                if( resultado == 0 )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch( MySqlException )
            {
                return true;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable MostrarMaestros()
        {
            DataTable dt;
            try
            {
                conexion.Open();
                String consulta = "select * from maestro";
                MySqlCommand com = new MySqlCommand(consulta, conexion);                
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (MySqlException)
            {
                dt = new DataTable();
                return dt;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable MostrarGrupos()
        {
            DataTable dt = new DataTable();
            try
            {
                conexion.Open();
                String consulta = "select * from grupo";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                MySqlDataAdapter adapter = new MySqlDataAdapter( com );                
                adapter.Fill( dt );
                return dt;
            }
            catch( MySqlException )
            {                
                return dt;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable MostrarAlumnosGrupo( String grupo )
        {
            DataTable dt = new DataTable();
            try
            {
                conexion.Open();
                String consulta = "select * from alumno where Grupo = @grupo";
                MySqlCommand com = new MySqlCommand( consulta, conexion );
                com.Parameters.AddWithValue( "@grupo", grupo );
                MySqlDataAdapter adapter = new MySqlDataAdapter( com );
                adapter.Fill( dt );
                return dt;
            }
            catch( MySqlException )
            {
                return dt;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}