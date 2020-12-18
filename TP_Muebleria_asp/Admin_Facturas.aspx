<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Admin_Facturas.aspx.cs" Inherits="TP_Muebleria_asp.Admin_Facturas" %>

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
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Cod_Compra_CO") %>' ReadOnly></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Cod_Compra_CO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ver mas">
                            <EditItemTemplate>
                                <asp:Button ID="ver_mas_btn_e" OnClick="ver_mas_btn_click" runat="server" Text="Ver mas" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Button ID="ver_mas_btn_v" OnClick="ver_mas_btn_click" runat="server" Text="Ver mas" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Fecha") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Fecha") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Usuario">
                            <EditItemTemplate>
                                <asp:TextBox ID="nombre_txt" runat="server" Text='<%# Bind("Nombre") %>' ReadOnly></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="nombre_lbl" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio Total">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Precio_Total") %>' ReadOnly></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                $<asp:Label ID="Label7" runat="server" Text='<%# Bind("Precio_Total") %>'></asp:Label>
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