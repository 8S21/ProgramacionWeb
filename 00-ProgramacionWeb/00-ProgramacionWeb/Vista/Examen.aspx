<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examen.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.Examen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center; font-size:20px; margin-top:200px;">
    <form id="form1" runat="server">

        1.-<asp:Label ID="lblPregunta" runat="server" Text="Label"></asp:Label><br/><br/>
        A).-<asp:RadioButton ID="RadioButton1" runat="server" GroupName="RadioGrup" style="margin-right:50px"/>
        B).-<asp:RadioButton ID="RadioButton2" runat="server" GroupName="RadioGrup" style="margin-right:50px"/>
        C).-<asp:RadioButton ID="RadioButton3" runat="server" GroupName="RadioGrup" style="margin-right:50px" OnCheckedChanged="Click"/>
        D).-<asp:RadioButton ID="RadioButton4" runat="server" GroupName="RadioGrup" style="margin-right:50px"/><br/><br/>
        <asp:Button ID="ButtonSiguiente" runat="server" Text="Siguiente" OnClick="Siguiente" />

    </form>
</body>
</html>
