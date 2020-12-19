<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Productos_alta.aspx.cs" Inherits="TP_Muebleria_asp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:label runat="server" text="Carga de Producto"></asp:label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre de Producto"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_nompro" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_Descripcion" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="FotoProducto" runat="server" Text="Foto De Producto"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Color"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_color" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Tipo de Madera"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_tm" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Precio Unitario"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_pu" runat="server" type="number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Seleccione Categoria"></asp:Label> 
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server"> </asp:DropDownList>  
        

        <%--<asp:Label ID="Label7" runat="server" Text="Categoria del mueble"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_codcat" runat="server" ></asp:TextBox>--%>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Alto"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_alto" runat="server" type="number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label9" runat="server" Text="Largo"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_largo" runat="server" type="number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label10" runat="server" Text="Ancho"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_ancho" runat="server" type="number"></asp:TextBox>
    
        <br>
        <br>

        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Dar alta a Producto Nuevo</asp:LinkButton>
        <br />
        <asp:Label ID="aclaracion_lbl" style="font-size:20px" runat="server" ></asp:Label>

    </p>

</asp:Content>
