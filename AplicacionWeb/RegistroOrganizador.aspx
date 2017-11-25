<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="RegistroOrganizador.aspx.cs" Inherits="AplicacionWeb.RegistroOrganizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
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
    <asp:Panel runat="server">
        <asp:Label ID="lblNombre" runat="server">Nombre: </asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
    </asp:Panel>
    <asp:Panel runat="server">
        <asp:Label ID="lblTelefono" runat="server">Telefono: </asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtTelefono" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"   runat="server" ForeColor="Tomato" ControlToValidate="txtTelefono" ErrorMessage="Debe ser un número" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
    </asp:Panel>
    <asp:Panel runat="server">
        <asp:Label ID="lblDireccion" runat="server">Direccion: </asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtDireccion" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
    </asp:Panel>
    <asp:Panel ID="panel3" runat="server">
        <asp:Button ID="btnRegistrar" Text="Registrar" runat="server" OnClick="btnRegistrar_Click" />
    </asp:Panel>

</asp:Content>
