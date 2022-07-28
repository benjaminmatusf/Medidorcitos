<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="MedidorcitoWeb.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="row">
        <div class="col-lg-4 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Agregar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="rutTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe Ingresar el Rut"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ControlToValidate="nombreTxt" CssClass="text-danger" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Ingresar un Nombre"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="emailTxt">Email</label>
                        <asp:TextBox ID="emailTxt" CssClass="form-control" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ControlToValidate="emailTxt" CssClass="text-danger" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe Ingresar el Email"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="contraTxt">Contraseña</label>
                        <asp:TextBox ID="contraTxt" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>    
                         <asp:RequiredFieldValidator ControlToValidate="contraTxt" CssClass="text-danger" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe Ingresar una Contraseña"></asp:RequiredFieldValidator>
                    </div>

                    <asp:Button runat="server" CssClass="btn btn-info" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Agregar" />
                    
                </div>
            </div>
        </div>
    </div>


</asp:Content>
