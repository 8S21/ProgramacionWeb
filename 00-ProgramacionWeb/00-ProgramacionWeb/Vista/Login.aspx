<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <label>Usuario</label><br>
            <asp:TextBox ID="txtUsuario" runat="server" type="text" name="usuario" required="required"></asp:TextBox><br>
            <label>Contraseña</label><br>
            <asp:TextBox ID="txtPassword" runat="server" type="password" name="password" required="required"></asp:TextBox><br>
            <asp:Button ID="Button1" runat="server" Text="Entrar" type="submit"></asp:Button>
        </div>
    </form>
</body>
</html>
