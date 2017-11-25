<%@ Page Title="Login" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AplicacionWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
</asp:Login>

    <asp:Panel ID="Panel2" runat="server">
    <asp:label ID="lblMensaje" runat="server"></asp:label>
    </asp:Panel>
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <asp:Button id="btnRegistrarOrganizador" Text="Registrar Organizador" runat="server" OnClick="btnRegistrarOrganizador_Click"/>
    </asp:Panel>
<p>
</p>
</asp:Content>
