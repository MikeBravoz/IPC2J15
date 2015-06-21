<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="QuetzalExpress.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuContextual" runat="server">
    Si aun no tienes cuenta has Clic en "Nuevo Usuario"
    <ul id="menuContextual">
        <li><a href="/Clientes/NuevosClientes.aspx">Nuevo Usuario </a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Bienvenido </h2>

</asp:Content>
