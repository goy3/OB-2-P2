<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="EventosEntreDosFechas.aspx.cs" Inherits="AplicacionWeb.EventosEntreDosFechas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Button id="btnVolver" Text="<- Volver al Menú" runat="server" OnClick="btnVolver_Click"/>
    
    <asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:Label ID="lblFechaInicial" runat="server" Text="Fecha Inicial:"></asp:Label>
        <asp:Calendar ID="CalendarioFechaInicial" runat="server"></asp:Calendar>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
        <asp:Label ID="lblFechaFinal" runat="server" Text="Fecha Final"></asp:Label>
        <asp:Calendar ID="CalendarioFechaFinal" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="btnMostrarEventos" Text="Mostrar Eventos" runat="server" OnClick="btnMostrarEventos_Click"/>

        
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
        <br />
        <asp:GridView ID="TablaMostrarEventosEntreDosFechas" runat="server"></asp:GridView>
    </asp:Panel>
</asp:Content>
