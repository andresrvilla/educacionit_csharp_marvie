<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Administracion.Categorias.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <asp:ListView runat="server" ID="lstCategorias">
        <LayoutTemplate>
            <table class="table">
              <thead>
                <tr>
                  <th scope="col">Id</th>
                  <th scope="col">Nombre</th>
                  <th scope="col">Acciones</th>
                </tr>
              </thead>
              <tbody>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
              </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <th scope="row"><%#Eval("Id") %></th>
                <td><%#Eval("Nombre") %></td>
                <td><a class="btn btn-info" href="Editar.aspx?id=<%#Eval("Id") %>">Editar</a></td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
