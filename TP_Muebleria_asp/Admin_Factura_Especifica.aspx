<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Admin_Factura_Especifica.aspx.cs" Inherits="TP_Muebleria_asp.Admin_Factura_Especifica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

<br /><br /><br />    <br /><br /><br />

    <div class="container">
        <%--<div class="row">--%>

            <div class="center-block" style="float:left;">

                <asp:GridView ID="GridView1" Style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; margin-left: 222px;" class="table" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" PageSize="5" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="16px" CellPadding="4" ForeColor="#333333" GridLines="None" Height="118px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Compra">
                            <EditItemTemplate>
                                <asp:TextBox ID="compra_txt" runat="server" Text='<%# Bind("Cod_Compra_DC") %>' ReadOnly></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="compra_lbl" runat="server" Text='<%# Bind("Cod_Compra_DC") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Compra">
                            <EditItemTemplate>
                                <asp:TextBox ID="producto_txt" runat="server" Text='<%# Bind("Nombre_Producto") %>' ReadOnly></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="producto_lbl" runat="server" Text='<%# Bind("Nombre_Producto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad vendida">
                            <EditItemTemplate>
                                <asp:TextBox ID="cantidad_txt" runat="server" type="number" Text='<%# Bind("Cantidad_Comprada") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="cantidad_lbl" runat="server" Text='<%# Bind("Cantidad_Comprada") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio Total">
                            <EditItemTemplate>
                                <asp:TextBox ID="precio_txt" runat="server" Text='<%# Bind("Precio_Unitario") %>' ReadOnly></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="precio_lbl" runat="server" Text='<%# Bind("Precio_Unitario") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cod Productos" Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="cod_prod_txt" runat="server" Text='<%# Bind("Cod_Producto_DC") %>' ReadOnly></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="cod_prod_lbl" runat="server" Text='<%# Bind("Cod_Producto_DC") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />

                </asp:GridView>
            </div>
            
        <%--</div>--%>
    </div>






<br /><br /><br />    <br /><br /><br />






</asp:Content>