<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:20px;">
    <form id="form1" runat="server">
        <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label><br/><br/>
        <asp:Literal ID="Literal" runat="server"></asp:Literal>
        <asp:Button ID="ButtonEmpezar" runat="server" Text="Empezar Examen" OnClick="Empezar" /><br/><br/>
        <asp:Button ID="ButtonSalir" runat="server" Text="Salir" OnClick="Salir" />
    </form>
</body>
</html>
