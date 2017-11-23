<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="MenuOrganizador.aspx.cs" Inherits="AplicacionWeb.MenuOrganizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <asp:Button ID="btnListarUsuarios" Text="Listar Usuarios" runat="server" OnClick="btnListarUsuarios_Click"/>
    <asp:Button ID="btnRegistrarEvento" Text="Registrar Evento" runat="server" OnClick="btnRegistrarEvento_Click"/>
    <asp:Button ID="btnEventosDeOrganizador" Text="Eventos de Organizador" runat="server" OnClick="btnEventosDeOrganizador_Click"/>
</asp:Content>
