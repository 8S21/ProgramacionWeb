<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examen.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.Examen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:20px; margin-top:200px;">
    <form id="form1" runat="server">

        1.-<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br/><br/>
        1.-<asp:RadioButton ID="RadioButton1" runat="server" style="margin-right:50px"/>
        2.-<asp:RadioButton ID="RadioButton2" runat="server" style="margin-right:50px"/>
        3.-<asp:RadioButton ID="RadioButton3" runat="server" style="margin-right:50px"/>
        4.-<asp:RadioButton ID="RadioButton4" runat="server" style="margin-right:50px"/><br/><br/>
        <asp:Button ID="ButtonSiguiente" runat="server" Text="Siguiente" />

    </form>
</body>
</html>
