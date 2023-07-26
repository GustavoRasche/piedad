<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="MedidoresGR2.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="contrasenaTxt">Contraseña</label>
                        <asp:TextBox ID="contrasenaTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="correTxt">Correo Electronico</label>
                        <asp:TextBox ID="correoTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                  
                    <asp:Button ID="ingresaBtn" runat="server" CssClass="btn btn-primary"  Text="Ingresar" OnClick="ingresaBtn_Click" />
                
                   

                </div>
            </div>

        </div>
    </div>
</asp:Content>
