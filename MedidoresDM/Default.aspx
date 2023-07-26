<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresGR2.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Ingresar Medidor</h1>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />

        <asp:TextBox ID="txtnumeroSerie" runat="server" CssClass="form-control" placeholder="Número de Serie"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvnumeroSerie" runat="server" ControlToValidate="txtnumeroSerie" ErrorMessage="Ingrese el número de serie" CssClass="text-danger"></asp:RequiredFieldValidator>

        <asp:TextBox ID="txttipo" runat="server" CssClass="form-control" placeholder="Tipo"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtipo" runat="server" ControlToValidate="txttipo" ErrorMessage="Ingrese el tipo" CssClass="text-danger"></asp:RequiredFieldValidator>



        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>