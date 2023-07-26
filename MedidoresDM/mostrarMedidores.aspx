<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidores.aspx.cs" Inherits="MedidoresGR2.MostrarMedidores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Mostrar Medidores</h1>
        <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged">
            <asp:ListItem Text="Todos" Value=""></asp:ListItem>

        </asp:DropDownList>

        <asp:GridView ID="gridMedidores" runat="server" CssClass="table table-striped table-bordered">
            <Columns>
                <asp:BoundField DataField="numeroSerie" HeaderText="Número de Serie" />
                <asp:BoundField DataField="tipo" HeaderText="Tipo" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>