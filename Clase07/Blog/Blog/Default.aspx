<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-md-2 col-3">
            Aca iria el menu
        </div>
        <div class="col-md-7 col-9">
            <h3>Estas son los últimos posteos</h3>
        </div>
        <div class="col-md-3">
            Publicidades
        </div>
    </div>
    <div class="row">
        <div class="col-6 offset-3">
            Acerca de mi sitio...
        </div>
    </div>
    
</asp:Content>
