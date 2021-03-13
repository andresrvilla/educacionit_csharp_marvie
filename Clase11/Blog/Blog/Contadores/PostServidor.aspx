<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="PostServidor.aspx.cs" Inherits="Blog.Contadores.PostServidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h3>Post con variables de sesion</h3>
    Cantidad de veces clickeada: <asp:Label runat="server" ID="lblContador">0</asp:Label><br />
    <asp:Button runat="server" ID="btnContar" CssClass="btn btn-primary" Text="Incrementar" OnClick="btnContar_Click" />
</asp:Content>
