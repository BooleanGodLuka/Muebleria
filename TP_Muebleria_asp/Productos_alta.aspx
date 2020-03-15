<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Productos_alta.aspx.cs" Inherits="TP_Muebleria_asp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:label runat="server" text="Carga de Producto"></asp:label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre de Prdocuto"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_nompro" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Url Foto de Producto"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_Url" runat="server"></asp:TextBox>
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
        &nbsp;<asp:TextBox ID="txtb_pu" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Codigo de Categoria"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_codcat" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Alto"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_alto" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label9" runat="server" Text="Largo"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_largo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label10" runat="server" Text="Ancho"></asp:Label>
        &nbsp;<asp:TextBox ID="txtb_ancho" runat="server"></asp:TextBox>
    </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Crear</asp:LinkButton>
        <br />
        <asp:Label ID="aclaracion_lbl" runat="server" ></asp:Label>
    </p>

</asp:Content>
