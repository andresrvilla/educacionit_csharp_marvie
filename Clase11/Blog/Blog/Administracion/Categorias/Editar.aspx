<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Blog.Administracion.Categorias.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <asp:Panel runat="server" ID="pnlError" Visible="false">
        <div class="alert alert-danger" role="alert">
          Ha ocurrido un error al cargar la categoría.
          <asp:Button runat="server" ID="btnAccion" CssClass="btn btn-danger" Text="Volver al Listado" OnClick="btnAccion_Click"/>
        </div>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlFormulario" Visible="false">
        <div class="row">
            <div class="col">
                Nombre: 
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:TextBox CssClass="form-control" runat="server" id="txtNombre"></asp:TextBox><br />
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 offset-md-2">
                <asp:Button CssClass="btn btn-block btn-primary" runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
            <div class="col-md-4">
                <a href="Default.aspx" class="btn btn-block btn-warning">Cancelar</a>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
