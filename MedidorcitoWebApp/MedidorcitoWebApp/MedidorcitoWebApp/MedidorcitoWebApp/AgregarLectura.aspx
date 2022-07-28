<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="MedidorcitoWebApp.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <div class="row">
        <div class="col-lg-4 mx-auto">

            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-white bg-danger"></asp:Label>
            </div>

            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">

                     <div class="form-group">
                        <label for="medidorDdl">Seleccionar medidor por número de serie</label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-control">
                        </asp:DropDownList>
                         <asp:RequiredFieldValidator id="RequiredFieldValidator4"
                    ControlToValidate="medidorDdl"
                    Display="Static"
                    ErrorMessage="*Seleccionar un medidor de la lista*"
                    runat="server"/>

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
                        <asp:TextBox ID="horaTxt" TextMode="Number"  CssClass="form-control" runat="server" placeholder="0 ~ 23" ></asp:TextBox>
                            <asp:RequiredFieldValidator id="RequiredFieldValidator1"
                    ControlToValidate="horaTxt"
                    Display="Static"
                    ErrorMessage="*Ingrese una hora de lectura*"
                    runat="server"/> </br>
                          <asp:RangeValidator id="Range1"
           ControlToValidate="horaTxt"
           MinimumValue="0"
           MaximumValue="23"
           Type="Integer"
           EnableClientScript="false"
           Text="*HORA INVÁLIDA*"
           runat="server"/>
                      </div>
                   </div>
                   </br>
                  


                   <div class="col">
                     <div class="form-group">
                        <label for="minutoTxt">Minuto</label>
                        <asp:TextBox ID="minutoTxt" TextMode="Number" CssClass="form-control" runat="server" placeholder="0 ~ 59" ></asp:TextBox>
                          <asp:RequiredFieldValidator id="RequiredFieldValidator2"
                    ControlToValidate="minutoTxt"
                    Display="Static"
                    ErrorMessage="*Ingrese un minuto de lectura*"
                    runat="server"/> </br>
                         <asp:RangeValidator id="RangeValidator1"
           ControlToValidate="minutoTxt"
           MinimumValue="0"
           MaximumValue="59"
           Type="Integer"
           EnableClientScript="false"
           Text="*MINUTO INVÁLIDO*"
           runat="server"/>
                     </div></br>
                    </div>
                 </div>        </br>

                   

                     <div class="form-group">
                        <label for="consumoTxt">Consumo del medidor</label>
                        <asp:TextBox ID="consumoTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator id="RequiredFieldValidator3"
                    ControlToValidate="consumoTxt"
                    Display="Static"
                    ErrorMessage="*Ingrese un consumo de lectura*"
                    runat="server"/>
                         </br>
                         <asp:RangeValidator id="RangeValidator2"
           ControlToValidate="consumoTxt"
           MinimumValue="0"
           MaximumValue="600"
           Type="Integer"
           EnableClientScript="false"
           Text="*INGRESE UN VALOR ENTRE 0 Y 600*"
           runat="server"/>

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
