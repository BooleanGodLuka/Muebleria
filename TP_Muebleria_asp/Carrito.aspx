<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TP_Muebleria_asp.Carrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <br />
        <div class="row">
        <div class="col-12" style="text-align:center">
            <asp:GridView ID="carrito_grdv" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="carrito_grdv_RowDeleting">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar"></asp:LinkButton>
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
            <br />
            

        </div>
        <div class="col-12" style="text-align:center">
            <asp:Label ID="aclaracion_lbl" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-4" style="text-align:center">

        </div>
        <div class="col-4" style="text-align:center">

        </div>
        <div class="col-4" style="text-align:center">
            <asp:Button ID="compra_btn"  runat="server" Text="Comprar" OnClick="compra_btn_Click" />

        </div>
        </div>
        
    </form>
</body>
</html>
