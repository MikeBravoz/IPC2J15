<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QuetzalExpress.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuContextual" runat="server">
    Si aun no tienes cuenta has Clic en "Nuevo Usuario"
    <ul id="menuContextual">
        <li><a href="/Clientes/NuevosClientes.aspx">Nuevo Usuario </a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
</asp:Content>
