<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="RegistroAdministrador.aspx.cs" Inherits="AplicacionWeb.RegistroAdministrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <br />
    <br />
    
    <asp:Button ID="btnVolver" runat="server" Text="<- Volver al Menú" OnClick="btnVolver_Click"/>
    <asp:Panel ID="panel1" runat="server">
        <br />
        <asp:Label ID="lblEmail" runat="server">Email: </asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:Label ID="lblMensajeEmail" runat="server"></asp:Label>
        <br />
        <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
    </asp:Panel>
    <asp:Panel ID="panel2" runat="server">
        <asp:Label ID="lblContrasenia" runat="server">Contraseña: </asp:Label>
        <asp:TextBox ID="txtContrasenia" runat="server"></asp:TextBox>
        <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtContrasenia" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
        <asp:Label ID="lblMensajeContrasenia" runat="server"></asp:Label>
    </asp:Panel>
    
    <asp:Panel ID="panel3" runat="server">
        <asp:Button ID="btnRegistrar" Text="Registrar" runat="server" OnClick="btnRegistrar_Click" />
    </asp:Panel>
        
        
    

     <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        
        
    

</asp:Content>