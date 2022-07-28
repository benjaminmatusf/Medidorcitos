<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLectura.aspx.cs" Inherits="MedidorcitoWebApp.VerLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
        <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Ver Lectura</h3>
                </div>
                <div class="card-body">

                                   

                    <asp:GridView CssClass="table table-hover table-bordered" AutoGenerateColumns="false"
                        runat="server" ID="grillaLecturas">                        
                        <Columns>
                            <asp:BoundField DataField="MedidorLectura.NumeroSerie" HeaderText="Medidor" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField DataField="Hora" HeaderText="Hora" />
                            <asp:BoundField DataField="Minuto" HeaderText="Minuto" />
                            <asp:BoundField DataField="Consumo" HeaderText="Consumo del medidor" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
