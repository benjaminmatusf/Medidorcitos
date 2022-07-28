<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="MedidorcitoWeb.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="row">
        <div class="col-lg-4 mx-auto">

             <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Agregar Medidor</h3>
                </div>
           
                <div class="card-body">
                     <div class="form-group">
                        <label for="numeroSerieTxt">Numero de serie</label>
                        <asp:TextBox ID="numeroSerieTxt" TextMode="Number" min="0" CssClass="form-control" runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="numeroSerieTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe Ingresar el número de serie"></asp:RequiredFieldValidator>
                           <asp:RangeValidator ID="RangeValidator1" ControlToValidate="numeroSerieTxt" CssClass="text-danger" Type="Integer" runat="server" ErrorMessage="Debe ser mayor a 0" MinimumValue="0" MaximumValue="99999"></asp:RangeValidator>
                     </div></br>

                     <div class="form-group">
                        <label for="tipoRbl">Tipo de medidor</label>
                        <asp:RadioButtonList runat="server" ID="tipoRbl">
                            <asp:ListItem Value="Medidor de enchufe" Text="Medidor de enchufe"></asp:ListItem>
                            <asp:ListItem Value="Medidor con monitor" Text="Medidor con monitor"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div></br>

                   
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                            Text="Agregar" CssClass="btn btn-primary " /> 
                    </div>
                </div>
          
          
  </div>
        </div>
    </div>

 

</asp:Content>
