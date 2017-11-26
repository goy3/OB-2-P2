<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="EventosQueNoUtilizanUnServicio.aspx.cs" Inherits="AplicacionWeb.EventosQueNoUtilizanUnServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Button id="btnVolver" Text="<- Volver al Menú" runat="server" OnClick="btnVolver_Click"/>
    <asp:Panel ID="Panel1" runat="server">
        <br />
        <asp:GridView ID="TablaServicios" runat="server" AutoGenerateColumns="false" OnRowCommand="TablaServicios_RowCommand">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion"/>
                <asp:BoundField DataField="PrecioPorPersona" HeaderText="Precio por persona"/>
                <asp:ButtonField ButtonType="Button" Text="Ver eventos sin éste servicio" CommandName="Ver"/>
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <br />
        <asp:GridView id="TablaEventosSinUnServicio" runat="server">

        </asp:GridView>
    </asp:Panel>
</asp:Content>
