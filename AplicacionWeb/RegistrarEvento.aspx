<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="RegistrarEvento.aspx.cs" Inherits="AplicacionWeb.RegistrarEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Button ID="btnVolver" runat="server" Text="<- Volver al Menú" OnClick="btnVolver_Click"/>
    <br />
    <br />
    <asp:Panel ID="PanelCalendario" runat="server">
        <asp:Label ID="lblFecha" runat="server">Ingrese la fecha:</asp:Label>
        <asp:Calendar ID="CalendarioFecha" runat="server"></asp:Calendar>
    </asp:Panel>
    <br />
    <asp:Panel ID="PanelTurno" runat="server">
        <asp:Label ID="lblTurno" runat="server">Seleccione un turno:</asp:Label>
        <br />
        <asp:Label ID="lblManana" runat="server">Mañana</asp:Label>
        <asp:RadioButton ID="rbManana" GroupName="Turno" runat="server" OnCheckedChanged="rbManana_CheckedChanged"/>
        <br />
        <asp:Label ID="lblTarde" runat="server">Tarde</asp:Label>
        <asp:RadioButton ID="rbTarde" GroupName="Turno" runat="server" OnCheckedChanged="rbTarde_CheckedChanged"/>
        <br />
        <asp:Label ID="lblNoche" runat="server">Noche</asp:Label>
        <asp:RadioButton ID="rbNoche" GroupName="Turno" runat="server" OnCheckedChanged="rbNoche_CheckedChanged"/>
    </asp:Panel>
    <br />
    <asp:Panel ID="PanelDescripcion" runat="server">
        <asp:Label ID="lblDescripcion" runat="server">Ingrese una descripción: </asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNombre" runat="server">Nombre: </asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </asp:Panel>
    <br />
    <asp:Panel ID="PanelTipo" runat="server">
        <asp:Label ID="lblTipo" runat="server">Seleccione el tipo de evento: </asp:Label>
        <br />
        <asp:Label ID="lblComun" runat="server">Común</asp:Label>
        <asp:RadioButton ID="rbComun" GroupName="Tipo" runat="server" OnCheckedChanged="rbComun_CheckedChanged"/>
        <br />
        <asp:Label ID="lblPremium" runat="server">Premium</asp:Label>
        <asp:RadioButton ID="rbPremium" GroupName="Tipo" runat="server" OnCheckedChanged="rbPremium_CheckedChanged"/>
    </asp:Panel>
    <%--<asp:Panel ID="PanelFoto" runat="server">
        <asp:Label ID="lblFoto" runat="server">Foto: </asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server"/>
        <asp:Button ID="Foto" runat="server" OnClick="Foto_Click"/>
    </asp:Panel>--%>
</asp:Content>
