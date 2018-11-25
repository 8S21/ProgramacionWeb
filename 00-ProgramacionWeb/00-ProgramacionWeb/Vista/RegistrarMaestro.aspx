<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarMaestro.aspx.cs" Inherits="_00_ProgramacionWeb.Vista.RegistrarMaestro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo Registro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><br>
            <asp:TextBox ID="txtNombre" runat="server" type="text" name="nombre" required="required"></asp:TextBox><br>
            <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label><br>
            <asp:TextBox ID="txtApellido" runat="server" type="text" name="apellido" required="required"></asp:TextBox><br>
            <asp:Label ID="Label3" runat="server" Text="Materia"></asp:Label><br>
            <asp:TextBox ID="txtMateria" runat="server" type="text" name="materia" required="required"></asp:TextBox><br>
            <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label><br>
            <asp:TextBox ID="txtCorreo" runat="server" type="text" name="correo" required="required"></asp:TextBox><br>
            <asp:Label ID="Label5" runat="server" Text="Usuario"></asp:Label><br>
            <asp:TextBox ID="txtUsuario" runat="server" type="text" name="usuario" required="required"></asp:TextBox><br>
            <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label><br>
            <asp:TextBox ID="txtPassword" runat="server" type="password" name="password" required="required"></asp:TextBox><br>
            <asp:Button ID="Button1" runat="server" Text="Crear" type="submit" OnClick="Insertar"/>
        </div>
    </form>
</body>
</html>
