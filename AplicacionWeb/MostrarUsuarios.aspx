<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="MostrarUsuarios.aspx.cs" Inherits="AplicacionWeb.MostrarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

        <br />
        <br />
    <asp:Panel ID="PanelAdministrador" runat="server">
        <asp:Button ID="btnVolver" runat="server" Text="<- Volver al Menú" OnClick="btnVolver_Click"/>
    </asp:Panel>
        
        <asp:Panel runat="server">
        <br />
            <asp:GridView ID="TablaMostrarUsuarios" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="contrasenia" HeaderText="Contraseña" />
                <asp:BoundField  DataField="tipo" HeaderText="Tipo"/>
            </Columns>
        </asp:GridView>
        </asp:Panel>
</asp:Content>
