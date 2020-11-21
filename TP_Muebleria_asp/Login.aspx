<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP_Muebleria_asp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
    <div class="col-12" style="text-align:center">
        <asp:Label ID="aclaracion_lbl" runat="server" Text="Sesion ya iniciada"></asp:Label>
        <br />
        <asp:Button ID="cerrarU_btn" runat="server" Text="Cerrar Sesion" OnClick="cerrarU_btn_Click" />
    </div>
    <div class="col-6" style="text-align:center">
        <asp:Label ID="nombre_lbl" runat="server" Text="Correo electronico"></asp:Label>

    </div>
    <div class="col-6" style="text-align:center">
        <asp:TextBox ID="nombre_txt" runat="server"></asp:TextBox>

    </div>
    <div class="col-6" style="text-align:center">
        <asp:Label ID="contraseña_lbl" runat="server" Text="Contraseña"></asp:Label>

    </div>
    <div class="col-6" style="text-align:center">
        <asp:TextBox ID="contraseña_txt" runat="server"></asp:TextBox>

    </div>
    <div class="col-6" style="text-align:center">
        <asp:Button ID="inicioS_btn" runat="server" Text="Iniciar sesion" OnClick="inicioS_btn_Click" />

    </div>
    <div class="col-6" style="text-align:center">
        <asp:Button ID="crearU_btn" runat="server" Text="Crear Usuario" OnClick="crearU_btn_Click"/>
    </div>

    <div class="col-6" style="text-align:center">
        <asp:Button ID="editar_btn" runat="server" Text="Editar Usuario" OnClick="editar_btn_Click"/>
    </div>


    </div>



</asp:Content>
