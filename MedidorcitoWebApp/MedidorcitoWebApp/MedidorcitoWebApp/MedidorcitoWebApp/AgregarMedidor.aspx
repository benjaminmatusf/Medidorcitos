<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="MedidorcitoWebApp.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

       <div class="row">
        <div class="col-lg-4 mx-auto">

            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-white bg-danger"></asp:Label>
            </div>

            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                     <div class="form-group">
                        <label for="numeroSerieTxt">Numero de serie</label>
                        <asp:TextBox ID="numeroSerieTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator id="RequiredFieldValidator2"
                    ControlToValidate="numeroSerieTxt"
                    Display="Static"
                    ErrorMessage="*Ingrese un número de serie para el medidor*"
                    runat="server"/> 
                        
                     </div> <asp:RangeValidator id="Range1"
           ControlToValidate="numeroSerieTxt"
           MinimumValue="1"
           MaximumValue="999999"
           Type="Integer"
           EnableClientScript="false"
           Text="*NUMERO DE SERIE DEBE SER MAYOR A 0*"
           runat="server"/>
                    </br>
                    </br>

                    

                     <div class="form-group">
                        <label for="tipoRbl">Tipo de medidor</label>
                        <asp:RadioButtonList runat="server" ID="tipoRbl">
                            <asp:ListItem Value="1" Text="Medidor de enchufe"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Medidor con monitor"></asp:ListItem>
                        </asp:RadioButtonList>
                         <asp:RequiredFieldValidator id="RequiredFieldValidator1"
                    ControlToValidate="tipoRbl"
                    Display="Static"
                    ErrorMessage="*Ingrese un tipo de medidor*"
                    runat="server"/> 
                    </div>

                 
       
                   
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                            Text="Agregar" CssClass="btn btn-primary " /> 
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
