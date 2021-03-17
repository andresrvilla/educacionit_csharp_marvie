<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="VerPost.aspx.cs" Inherits="Blog.VerPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h1><asp:Label ID="lblTitulo" runat="server"></asp:Label></h1>
    <asp:Label runat="server" ID="lblContenido"></asp:Label>
    <hr />
    <h3>Comentarios</h3>
    <asp:ListView runat="server" ID="lstComentarios">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
        </LayoutTemplate>
        <ItemTemplate>
            Comentario de: <%#Eval("Autor") %><br />
            <%#Eval("Comentario1") %><br />
        </ItemTemplate>
    </asp:ListView>
    <hr />
    <h3>Agregar nuevo comentario</h3>
    Autor:
    <asp:TextBox runat="server" CssClass="form-control" id="txtAutor"></asp:TextBox>
    Comentario:
    <asp:TextBox runat="server" CssClass="form-control" ID="txtComentario" Rows="5" TextMode="MultiLine"></asp:TextBox>
    <asp:Button runat="server" CssClass="btn btn-primary btn-block" ID="btnGuardarComentario" Text="Guardar" OnClick="btnGuardarComentario_Click" />
</asp:Content>
