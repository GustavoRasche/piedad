<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidoresGR2.IngresarLectura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Ingresar Lectura</h1>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />

        <asp:DropDownList ID="ddlMedidor" runat="server" CssClass="form-control" AppendDataBoundItems="true">
            <asp:ListItem Text="-- Seleccione un medidor --" Value=""></asp:ListItem>
        </asp:DropDownList>
        
        <asp:RequiredFieldValidator ID="rfvMedidor" runat="server" ControlToValidate="ddlMedidor" ErrorMessage="Seleccione un medidor" CssClass="text-danger"></asp:RequiredFieldValidator>

        <input type="date" ID="txtFecha" runat="server" class="form-control" />
        <asp:RequiredFieldValidator ID="rfvFecha" runat="server" ControlToValidate="txtFecha" ErrorMessage="Seleccione una fecha" CssClass="text-danger"></asp:RequiredFieldValidator>

        <asp:TextBox ID="txtHora" runat="server" CssClass="form-control" placeholder="Hora"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvHora" runat="server" ControlToValidate="txtHora" ErrorMessage="Ingrese la hora" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revHora" runat="server" ControlToValidate="txtHora" ErrorMessage="Ingrese una hora válida (formato: HH:mm)" CssClass="text-danger" ValidationExpression="^([0-1][0-9]|2[0-3]):([0-5][0-9])$"></asp:RegularExpressionValidator>

        <asp:TextBox ID="txtValorConsumo" runat="server" CssClass="form-control" placeholder="Valor de Consumo"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvValorConsumo" runat="server" ControlToValidate="txtValorConsumo" ErrorMessage="Ingrese el valor de consumo" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rvValorConsumo" runat="server" ControlToValidate="txtValorConsumo" ErrorMessage="Ingrese un valor de consumo válido (entre 0 y 600)" CssClass="text-danger" Type="Double" MinimumValue="0" MaximumValue="600"></asp:RangeValidator>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>