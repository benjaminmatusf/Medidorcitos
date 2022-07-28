<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="MedidorcitoWeb.VerUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <div class="row">

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                    <div class="col-lg-6 mx-auto">

                            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Ver Usuarios</h3>
                </div>    

                <asp:GridView 
                    CssClass="table table-hover table-bordered"
                    ID="grillaUsuario"
                    AutoGenerateColumns="false"
                    ShowHeaderWhenEmpty="true"
                    EmptyDataText="No hay registros para mostrar"
                    runat="server"
                    OnRowCommand="grillaUsuario_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="Rut" DataField="Rut" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Email" DataField="Email" />
                        <asp:BoundField HeaderText="Contraseña" DataField="Contraseña" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-danger" runat="server"
                                    CommandName="eliminar" Text="Eliminar"
                                    CommandArgument='<%# Eval("Id") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
             </div>
            </div>
            </ContentTemplate>
        </asp:UpdatePanel>

    </div>

</asp:Content>
