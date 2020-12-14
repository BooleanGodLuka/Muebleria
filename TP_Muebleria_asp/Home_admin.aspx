<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Home_admin.aspx.cs" Inherits="TP_Muebleria_asp.Home_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br />

    
    <div class="container" style="margin-top:30px;">
        <div class="row">
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Administrar Usuarios</h5>
                        <p class="card-text">Alta, baja y modificacion de todos los usuarios del sistema</p>
                        <a href="<%Response.Write("Admin_usuarios.aspx"); %>" class="btn btn-primary">Administrar</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Administrar Productos</h5>
                        <p class="card-text ">Alta, baja y modificacion de Productos</p>
                        <a href="<%Response.Write("Admin_Productos.aspx"); %>" class="btn btn-primary">Administrar</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Administrar Compras</h5>
                        <p class="card-text ">Alta, baja y modificacion de Productos</p>
                        <a href="<%Response.Write("Admin_Facturas.aspx"); %>" class="btn btn-primary">Administrar</a>
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
