<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Saludador.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .error{
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Ingrese su nombre para que la página lo salude:</b><br />
            <asp:TextBox runat="server" ID="txtNombrePersona"></asp:TextBox><br />
            <asp:Button runat="server" id="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click"/><asp:Button runat="server" ID="btnResetear" OnClick="btnResetear_Click" Text="Resetear" /><br />
            <asp:Label runat="server" ID="lblSaludo"></asp:Label><br runat="server" id="salto" />
            <asp:Label runat="server" ID="lblError" CssClass="error"></asp:Label>
        </div>
    </form>
</body>
</html>
