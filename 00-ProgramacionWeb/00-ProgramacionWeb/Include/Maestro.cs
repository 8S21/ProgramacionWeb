using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _00_ProgramacionWeb.Include
{
    public class Maestro
    {
        private int idMaestro;
        private String nombre;
        private String apellido;
        private String correo;
        private String usuario;
        private String password;

        public Maestro( int idMaestro, String nombre, String apellido, String correo, String usuario, String password )
        {
            this.idMaestro = idMaestro;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.usuario = usuario;
            this.password = password;
        }
        public int IdMaestro
        {
            set
            {
                idMaestro = value;
            }
            get
            {
                return idMaestro;
            }
        }
        public String Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public String Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
        public String Correo
        {
            set
            {
                correo = value;
            }
            get
            {
                return correo;
            }
        }
        public String Usuario
        {
            set
            {
                usuario = value;
            }
            get
            {
                return usuario;
            }
        }
        public String Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
    }
}