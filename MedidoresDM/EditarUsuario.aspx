<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="MedidoresGR2.EditarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <h3>Editar Usuario</h3>
        <asp:Label ID="lblMensaje" runat="server" CssClass="text-success"></asp:Label>
        <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
        <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" placeholder="Rut" Enabled="false"></asp:TextBox>
        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar Cambios" CssClass="btn btn-primary mt-3" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>
