<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Cliente_historial.aspx.cs" Inherits="TP_Muebleria_asp.Cliente_historial" %>

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
                        <asp:TemplateField HeaderText="Fecha">
                            <ItemTemplate>
                                <asp:Label ID="fecha_lbl" runat="server" Text='<%# Bind("Fecha") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio de la Compra">
                            <ItemTemplate>
                                $<asp:Label ID="precio_lbl" runat="server" Text='<%# Bind("Precio_Total") %>'></asp:Label>
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
