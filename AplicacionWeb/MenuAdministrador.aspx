<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="MenuAdministrador.aspx.cs" Inherits="AplicacionWeb.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <asp:Button ID="btnRegistrarAdmin" runat="server" Text="Registrar Administrador" Onclick="btnRegistrarAdmin_Click" />
    <asp:Button ID="btnListarUsuarios" Text="Listar Usuarios" runat="server" OnClick="btnListarUsuarios_Click" />
    <asp:Button ID="btnListarServicios" Text="Listar Servicios" runat="server" OnClick="btnListarServicios_Click" />
    <asp:Button ID="btnEventosEntreFechas" Text="Eventos entre fechas" runat="server" OnClick="btnEventosEntreFechas_Click"/>
    <asp:Button ID="btnEventosQueNoUtilizanServico" Text="Eventos que no utilizan un servicio determinado" runat="server" OnClick="btnEventosQueNoUtilizanServico_Click"/>

</asp:Content>
