<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidorcitoWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

     <div class="card-body">     

      <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Ver Medidores</h3>
                </div>                             

                 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                    <asp:GridView CssClass="table table-hover table-bordered"
                        OnRowCommand="grillaMedidores_RowCommand"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        EmptyDataText="No hay registros para mostrar"
                        runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Numero de serie" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                             <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-danger" runat="server"
                                    CommandName="eliminar" Text="Eliminar"
                                    CommandArgument='<%# Eval("Id") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                   </ContentTemplate>
        </asp:UpdatePanel>

                </div>
            </div>
        </div>

    </div>


</asp:Content>
