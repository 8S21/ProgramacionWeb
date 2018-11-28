<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPregunta.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.AgregarPregunta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:20px">
    <form id="form1" runat="server">
        Nueva Pregunta<br/><br/>
        Pregunta:<br/>
        <asp:TextBox ID="txtPregunta" runat="server" Width="450px" Height="50px"></asp:TextBox><br/><br/>
        Respuesta 1:<br/>
        <asp:TextBox ID="txtRespuesta1" runat="server" Width="450px" Height="50px"></asp:TextBox><br/><br/>
        Respuesta 2:<br/>
        <asp:TextBox ID="txtRespuesta2" runat="server" Width="450px" Height="50px"></asp:TextBox><br/><br/>
        Respuesta 3:<br/>
        <asp:TextBox ID="txtRespuesta3" runat="server" Width="450px" Height="50px"></asp:TextBox><br/><br/>
        Respuesta 4:<br/>
        <asp:TextBox ID="txtRespuesta4" runat="server" Width="450px" Height="50px"></asp:TextBox><br/><br/>
        Respuesta Correta:<br/>
        <asp:DropDownList ID="RespuestaCorrecta" runat="server">
            <asp:ListItem Value="1">Respuesta 1</asp:ListItem>
            <asp:ListItem Value="2">Respuesta 2</asp:ListItem>
            <asp:ListItem Value="3">Respuesta 3</asp:ListItem>
            <asp:ListItem Value="4">Respuesta 4</asp:ListItem>
        </asp:DropDownList><br/><br/>
        <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" OnClick="Agregar" />
    </form>
</body>
</html>
