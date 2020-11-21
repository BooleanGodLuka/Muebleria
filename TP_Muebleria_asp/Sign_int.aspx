<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Sign_int.aspx.cs" Inherits="TP_Muebleria_asp.Sign_int" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
        <font size="7">
            Por favor rellene los campos especificados
            <br />
        </font>
    </div>
    <div class ="row">
    <div class ="col-6" style="text-align:center">
    Nombre:    
    </div>
    <div class ="col-6" style="text-align:center">
    <asp:TextBox ID="nombre_txt" runat="server"></asp:TextBox>
    </div>
    <div class ="col-6" style="text-align:center">
    Apellido:    
    </div>
    <div class ="col-6" style="text-align:center">
    <asp:TextBox ID="apellido_txt" runat="server"></asp:TextBox>
    </div>
    <div class ="col-6" style="text-align:center">
    DNI:    
    </div>
    <div class ="col-6" style="text-align:center">
    <asp:TextBox ID="dni_txt" runat="server"></asp:TextBox>
    </div>
    <div class ="col-6" style="text-align:center">
    Telefono:    
    </div>
    <div class ="col-6" style="text-align:center">
        <asp:TextBox ID="tel_txt" runat="server"></asp:TextBox>
    </div>
    <div class ="col-6" style="text-align:center">
    E-Mail:    
    </div>
    <div class ="col-6" style="text-align:center">
        <asp:TextBox ID="mail_txt" runat="server"></asp:TextBox>   
    </div>
    <div class ="col-6" style="text-align:center">
    Contraseña:    
    </div>
    <div class ="col-6" style="text-align:center">
        <asp:TextBox type="password" ID="contra_txt" runat="server"></asp:TextBox>   
    </div>
    <div class ="col-12" style="text-align:center">
        <asp:Button ID="crear_btn" runat="server" Text="Crear Usuario" OnClick="crear_btn_Click" />
        <br />
    </div>
    <div class ="col-12" style="text-align:center">
        <asp:Button ID="editar_btn" runat="server" Text="Editar Usuario" OnClick="editar_btn_Click" />
        <br />
    </div>
    <div class ="col-12" style="text-align:center">
        <asp:Label ID="aclaracion_lbl" runat="server"></asp:Label>
    </div>
     </div>
    
</asp:Content>
