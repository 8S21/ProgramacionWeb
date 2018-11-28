<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarAlumnos.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.MostrarAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:20px">
    <form id="form1" runat="server">
        Alumnos del Grupo:<br/>
        <asp:Literal ID="LiteralAlumnos" runat="server"></asp:Literal>
        <asp:Button ID="ButtonRegistrarAlumno" runat="server" Text="Registrar Alumno" OnClick="AgregarAlumno" /><br/><br/>
        Preguntas del Examen para este grupo
        <asp:Literal ID="LiteralPreguntas" runat="server"></asp:Literal>
        <asp:Button ID="ButtonAgregarPreguntas" runat="server" Text="Agregar Preguntas al Examen" OnClick="AgregarPreguntas" /><br/><br/>
        <asp:Button ID="ButtonInicio" runat="server" Text="Regresar" OnClick="Regresar" />
    </form>
</body>
</html>
