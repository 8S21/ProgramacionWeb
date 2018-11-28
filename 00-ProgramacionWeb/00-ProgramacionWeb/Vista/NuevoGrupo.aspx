<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoGrupo.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.NuevoGrupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:20px">
    <form id="form1" runat="server">
        Nuevo Grupo<br/><br/>
        Carrera:<br/>
        <asp:TextBox ID="txtCarrera" runat="server" required="required"></asp:TextBox><br/><br/>
        Grupo:<br/>
        <asp:TextBox ID="txtGrupo" runat="server" required="required"></asp:TextBox><br/><br/>
        <asp:Button ID="ButtonCrear" runat="server" Text="Crear" OnClick="CrearGrupo" />
    </form>
</body>
</html>
