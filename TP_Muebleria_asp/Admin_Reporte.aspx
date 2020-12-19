<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Admin_Reporte.aspx.cs" Inherits="TP_Muebleria_asp.Admin_Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br /><br /><br />    <br /><br /><br />

    <div class="container">
        <%--<div class="row">--%>

            <div class="center-block" style="float:left;">

                <asp:GridView ID="GridView1" Style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; margin-left: 222px;" class="table" runat="server" AutoGenerateColumns="False"  PageSize="5" Width="30px" CellPadding="4" ForeColor="#333333" GridLines="None" Height="118px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre">
                            <ItemTemplate>
                                <asp:Label ID="fecha_lbl" runat="server" Text='<%# Bind("Nombre_Producto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Foto">
                            <ItemTemplate>
                               <asp:Image ID="foto_img" runat="server" Height="56px" ImageUrl='<%# Bind("Foto_Producto") %>' Width="84px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label ID="fecha_lbl" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad vendida">
                            <ItemTemplate>
                                <asp:Label ID="cantidad_lbl" runat="server" Text='<%# Bind("cantidad") %>' value="0"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Dinero recaudado">
                            <ItemTemplate>
                                $<asp:Label ID="dinero_lbl" runat="server" Text='<%# Bind("precio_total") %>' value="0"></asp:Label>
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