<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="Carrito.aspx.cs" Inherits="TP_Muebleria_asp.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />

   <style>
    .button {
  background-color:#000000;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin-left:auto; 
  margin-right:auto;
  cursor: pointer;
 
}
    </style>

        
        <br />
        
        <div class="col-12" >
            <asp:GridView ID="carrito_grdv" style="margin-left:auto; margin-right:auto;" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="carrito_grdv_RowDeleting">
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
        <div class="col-12" >
            <asp:Button ID="compra_btn"  runat="server" Text="Comprar" OnClick="compra_btn_Click" />

        </div>

    Macaco come sopa du macaco
    <br />
    <br />
    <br />

       

</asp:Content>
