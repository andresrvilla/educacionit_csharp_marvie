<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h3>Estas son los últimos posteos</h3>
    <asp:ListView runat="server" ID="lstPosteos">
        <LayoutTemplate> <%-- Equivalente a la "MasterPage" --%>
            <div class="card-columns">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </LayoutTemplate>
        <ItemTemplate> <%-- Equivalente a el WebForm con MasterPage. Este se repite por cada elemento --%>
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Titulo") %></h5>
                    <p class="card-text"><%#Eval("Resumen") %></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
