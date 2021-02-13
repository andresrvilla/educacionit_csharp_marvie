<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundo.Default" %>

<!DOCTYPE html>
<!-- Markup -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hola Edmundo!!!</h1>
            <p>Esto es una página de ASP.NET WebForms</p>
            <% Response.Write("Hola mundo desde codigo c#"); %><br />
            <% Response.Write(DateTime.Now); %><br />
            <asp:Label runat="server" ID="lblHolaMundo"></asp:Label>
        </div>
    </form>
</body>
</html>
