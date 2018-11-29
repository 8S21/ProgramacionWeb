<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calificacion.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.Calificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:50px; margin-top:200px;">
    <form id="form1" runat="server">
        <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label><br/>
        <asp:Label ID="lblCalificacion" runat="server" Text="Label"></asp:Label><br/>
        <asp:Button ID="Button" runat="server" Text="Aceptar" OnClick="Aceptar" />
    </form>
</body>
</html>
