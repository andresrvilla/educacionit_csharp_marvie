<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card-columns {
            @include media-breakpoint-only(xs) {
            column-count: 2;
          }
            @include media-breakpoint-only(sm) {
            column-count: 2;
          }
          @include media-breakpoint-only(md) {
            column-count: 2;
          }
          @include media-breakpoint-only(lg) {
            column-count: 2;
          }
          @include media-breakpoint-only(xl) {
            column-count: 2;
          }
        }
    </style>
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
                    <h5 class="card-title">
                        <a href="VerPost.aspx?id=<%#Eval("Id") %>">
                            <%#Eval("Titulo") %>
                        </a>
                    </h5>
                    <p class="card-text"><%#Eval("Resumen") %></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
