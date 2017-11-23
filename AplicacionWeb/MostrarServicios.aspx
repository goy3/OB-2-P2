<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="MostrarServicios.aspx.cs" Inherits="AplicacionWeb.MostrarServicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    
    <asp:Button ID="btnVolver" runat="server" Text="<- Volver al Menú" OnClick="btnVolver_Click"/>
    
    <asp:Panel ID="panelServicios" runat="server">
        <br />    
        <asp:GridView ID="TablaMostrarServicios" runat="server">
            
        </asp:GridView>
    </asp:Panel>

</asp:Content>
