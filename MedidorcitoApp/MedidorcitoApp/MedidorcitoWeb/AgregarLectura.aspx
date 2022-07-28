<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="MedidorcitoWeb.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
      <div class="row">
        <div class="col-lg-4 mx-auto">

            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3 style="font-family:Verdana;">Agregar Lectura</h3>
                </div>
                <div class="card-body">

                     <div class="form-group">
                        <label for="medidorDdl">Seleccionar medidor por número de serie</label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-control">
                        </asp:DropDownList>
                     </div> </br>
                  
                  

                     <div class="form-group">
                        <label for="fechaCld">Seleccionar fecha de lectura</label>
                        <asp:Calendar runat="server" ID="fechaCld">
                        </asp:Calendar>
                     </div></br>
                    
               <div class="row">
                   <label>Indicar hora de lectura</label>
                   <div class="col">
                      <div class="form-group">
                        <label for="horaTxt">Hora</label>
                        <asp:TextBox ID="horaTxt" TextMode="Number" min="0" max="23" CssClass="form-control" runat="server" placeholder="0 ~ 23" ></asp:TextBox>
                           <asp:RequiredFieldValidator ControlToValidate="horaTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe Ingresar la Hora"></asp:RequiredFieldValidator>
                           <asp:RangeValidator ID="RangeValidator1" ControlToValidate="horaTxt" CssClass="text-danger" Type="Integer" runat="server" ErrorMessage="Hora inválida" MinimumValue="0" MaximumValue="23"></asp:RangeValidator>
                      </div>
                 </div>

                   

                   <div class="col">
                     <div class="form-group">
                        <label for="minutoTxt">Minuto</label>
                        <asp:TextBox ID="minutoTxt" TextMode="Number" min="0" max="59" CssClass="form-control" runat="server" placeholder="0 ~ 59" ></asp:TextBox>
                          <asp:RequiredFieldValidator ControlToValidate="minutoTxt" CssClass="text-danger" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Ingresar el Minuto"></asp:RequiredFieldValidator>
                          <asp:RangeValidator ID="RangeValidator2" ControlToValidate="minutoTxt" CssClass="text-danger" Type="Integer" runat="server" ErrorMessage="Minuto inválido" MinimumValue="0" MaximumValue="59"></asp:RangeValidator>
                     </div></br>
                    </div>                    
                 </div>        

                     <div class="form-group">
                        <label for="consumoTxt">Consumo del medidor</label>
                        <asp:TextBox ID="consumoTxt" TextMode="Number" min="0" max="600" CssClass="form-control" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator ControlToValidate="consumoTxt" CssClass="text-danger" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe Ingresar el Consumo"></asp:RequiredFieldValidator>
                          <asp:RangeValidator ID="RangeValidator3" ControlToValidate="consumoTxt" CssClass="text-danger" Type="Integer" runat="server" ErrorMessage="El consumo no puede ser mayor que 600" MinimumValue="0" MaximumValue="600"></asp:RangeValidator>
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
