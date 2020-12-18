<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Producto_especifico.aspx.cs" Inherits="TP_Muebleria_asp.Formulario_web2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
  margin: 4px 2px;
  cursor: pointer;
 
}
    </style>

    <br />
    <br />

    <div class="row">
        <div class="col-6">
            <asp:Image ID="Prod_img" runat="server" />
            <%--<img class="d-block w-100" src="https://www.perozzi.com.ar/6790-large_default/placard.jpg" alt="Third slide" style="height: 500px; width: 500px">--%>
        </div>
        <div class="col-4" style="text-align: center">
            <font size="9">
            <asp:Label ID="nombreprod_lbl" runat="server" Text="Nombre producto"></asp:Label>
            </font>
            <br />
            <%--<font size="5">
                Precio
                <asp:label id="precio_lbl" runat="server" text="precio $"></asp:label> $
                Ancho
                <asp:Label ID="ancho_lbl" runat="server" Text="cm"></asp:Label> cm
                Alto
                <asp:Label ID="alto_lbl" runat="server" Text="Label"></asp:Label> cm 
            </font>
            <br />
            <font size="3">
                Color
                <asp:Label ID="color_lbl" runat="server" Text="cm"></asp:Label>
                </font>
            <br />
            <font size="3">
                Tipo de Madera
                <asp:Label ID="tipoM_lbl" runat="server" Text="natural"></asp:Label>
                </font>--%>

  <table class="table table-bordered">
  <thead>
    <tr>
      
      
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">Precio</th>
      <td> $ <asp:Label ID="precio_lbl" runat="server" Text="precio $"></asp:Label> </td>

    </tr>
    <tr>
      <th scope="row">Ancho</th>
        <td> <asp:Label ID="ancho_lbl" runat="server" Text="cm"></asp:Label> cm  </td>
    </tr>
    <tr>
      <th scope="row">Alto</th>
        <td>  <asp:Label ID="alto_lbl" runat="server" Text="Label"></asp:Label> cm </td>
    </tr>
     <tr>
      <th scope="row">Color</th>
        <td> <asp:Label ID="color_lbl" runat="server" Text="cm"></asp:Label> </td>
    </tr>
       <tr>
      <th scope="row">Tipo de Madera</th>
        <td>   <asp:Label ID="tipoM_lbl" runat="server" Text="natural"></asp:Label> </td>
    </tr>
       <tr>
      <th scope="row">Cantidad</th>
        <td>  <asp:TextBox ID="Cantidad_txt" runat="server" type="number"></asp:TextBox> </td>
    </tr>
  </tbody>
</table>




            <br />
            <br />
            <br />
            <br />
            <div style="margin-right:70%">
            
                
                <%--<asp:DropDownList ID="cantidad_ddl" runat="server" ></asp:DropDownList>--%>


               <%-- <asp:TextBox ID="Cantidad_txt" runat="server" type="number"></asp:TextBox>--%>
                    


                <asp:LinkButton ID="LinkButton1" runat="server" class="button" OnClick="LinkButton1_Click">Agregar a carro</asp:LinkButton>
                <!--<asp:Button ID="carro" runat="server" Text="Button" />-->
            <%--<button class="button">Comprar</button>--%>
            
        </div>
        <div class="col-2"></div>
        

    </div>
</asp:Content>
