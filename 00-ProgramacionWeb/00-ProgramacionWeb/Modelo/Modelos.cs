﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using _00_ProgramacionWeb.Conexion;
using _00_ProgramacionWeb.Include;
using System.Data;

namespace _00_ProgramacionWeb.Modelo
{
    public class Modelos
    {
        public Modelos() { }
        public string MostrarExamenes( string grupo )
        {
            Consultas con = new Consultas();
            string html = "";
            if( con.MostrarPreguntas( grupo ).Rows.Count > 0 )
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Pregunta</td><td>Respuesta1</td><td>Respuesta2</td><td>Respuesta3</td><td>Respuesta4</td><td>Respuesta Correcta</td></tr></thead>";
                html += "<tbody>";
                foreach( DataRow dato in con.MostrarPreguntas( grupo ).Rows )
                {
                    html += "<tr>";
                    html += "<td>" + dato["IdPregunta"].ToString() + "</td>";
                    html += "<td>" + dato["Pregunta"].ToString() + "</td>";
                    html += "<td>" + dato["Respuesta1"].ToString() + "</td>";
                    html += "<td>" + dato["Respuesta2"].ToString() + "</td>";
                    html += "<td>" + dato["Respuesta3"].ToString() + "</td>";
                    html += "<td>" + dato["Respuesta4"].ToString() + "</td>";
                    html += "<td>" + dato["RespuestaCorrecta"].ToString() + "</td>";
                    html += "</tr>";
                }
                html += "</tbody>";
                html += "</table></center>";
            }
            else
            {
                html += "<center><table><tr><td>No hay preguntas para este grupo</td></tr></table></center>";
            }
            return html;
        }
        public string MostrarAlumnosGrupo( string grupo )
        {
            Consultas con = new Consultas();
            String html = "";
            if ( con.MostrarAlumnosGrupo(grupo).Rows.Count > 0 )
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Matricula</td><td>Nombre</td><td>Apellido</td><td>Carrera</td><td>Grupo</td><td>Calificación</td></tr></thead>";
                html += "<tbody>";
                foreach ( DataRow dato in con.MostrarAlumnosGrupo(grupo).Rows )
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
            return html;
        }
        public string MostrarGrupos()
        {
            Consultas con = new Consultas();
            String html = "";
            if (con.MostrarGrupos().Rows.Count > 0)
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Carrera</td><td>Grupo</td><td>Acciones</td></tr></thead>";
                html += "<tbody>";
                foreach (DataRow dato in con.MostrarGrupos().Rows)
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
            return html;
        }
        public string MostrarMaestros()
        {
            Consultas con = new Consultas();
            String html = "";
            if (con.MostrarMaestros().Rows.Count > 0)
            {
                html = "<center><table border='1'><thead><tr><td>ID</td><td>Nombre</td><td>Apellido</td><td>Correo</td><td>Usuario</td><td>Contraseña</td></tr></thead>";
                html += "<tbody>";
                foreach (DataRow dato in con.MostrarMaestros().Rows)
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
            return html;
        }
        public string MostrarDatosAlumno( int matricula )
        {
            Consultas con = new Consultas();
            string html = "";
            if( con.MostarDatosAlumno( matricula ).Rows.Count > 0 )
            {
                html = "<center><table border='1'><thead><tr><td>Matricula</td><td>Nombre</td><td>Apellido</td><td>Carrera</td><td>Grupo</td><td>Calificación</td></tr></thead>";
                html += "<tbody>";
                foreach( DataRow dato in con.MostarDatosAlumno( matricula ).Rows )
                {
                    html += "<tr>";
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
            return html;
        }
        public string ObtenerGrupo( int matricula )
        {
            Consultas con = new Consultas();
            string grupo = "";
            foreach( DataRow dato in con.MostarDatosAlumno( matricula ).Rows )
            {
                grupo = dato["Grupo"].ToString();
            }
            return grupo;
        }
        public string VerificarCalificacion( int matricula )
        {
            Consultas con = new Consultas();
            string calificacion = "";
            foreach( DataRow dato in con.MostarDatosAlumno( matricula ).Rows )
            {
                calificacion = dato["Calificacion"].ToString();
            }
            return calificacion;
        }
        public ArrayList MostrarPreguntas( string grupo )
        {
            ArrayList preguntas = new ArrayList();
            Consultas con = new Consultas();
            if( con.MostrarPreguntas( grupo ).Rows.Count > 0 )
            {
                foreach( DataRow dato in con.MostrarPreguntas( grupo ).Rows )
                {
                    string pregunta = dato["Pregunta"].ToString();
                    string respuesta1 = dato["Respuesta1"].ToString();
                    string respuesta2 = dato["Respuesta2"].ToString();
                    string respuesta3 = dato["Respuesta3"].ToString();
                    string respuesta4 = dato["Respuesta4"].ToString();
                    int correcta = Convert.ToInt32( dato["RespuestaCorrecta"].ToString() );
                    preguntas.Add( new Preguntas( pregunta, respuesta1, respuesta2, respuesta3, respuesta4, correcta ) );
                }
            }
            return preguntas;
        }
    }
}