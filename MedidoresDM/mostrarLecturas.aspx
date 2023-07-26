<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="MedidoresGR2.MostrarLecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Mostrar Lecturas</h1>
        

         <asp:GridView ID="grillaLectura" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" CssClass="table table-hover table-bordered" runat="server" EmptyDataText="No hay Registros" runat="server">
            <Columns>
                
                <asp:BoundField HeaderText="Fecha" DataField="fecha" />
                <asp:BoundField HeaderText="Hora Lectura" DataField="hora" />
                <asp:BoundField HeaderText="Consumo" DataField="valorConsumo" />
                <asp:BoundField HeaderText="Numero Serie Medidor" DataField="numeroSerie" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>