<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="EventosOrganizador.aspx.cs" Inherits="AplicacionWeb.EventosOrganizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" Text="<- Volver al Menú" Onclick="btnVolver_Click"/>
    <br />
    <br />
    <asp:GridView ID="TablaEventosPorOrganizador" runat="server">

    </asp:GridView>
</asp:Content>
