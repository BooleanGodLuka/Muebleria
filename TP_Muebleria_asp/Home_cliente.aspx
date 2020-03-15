<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Home_cliente.aspx.cs" Inherits="TP_Muebleria_asp.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="row">
            <div class="col-md-12" style="width:100px; background-color:bisque; color:black; text-align:center;"><h3>PRODUCTOS DESTACADOS</h3></div>
            <div class="col-md-12">
                <!--style="width:70% ; height:1% ; margin-left:auto ; margin-right:auto"-->
            <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active" style="align-content:center" >
                        <%--<img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:500px;">--%>
                        <asp:Image ID="Destacado1_img" runat="server" alt="First Slide" style="height:500px" class="d-block w-100"/>
                    </div>
                    <div class="carousel-item" >
                        <%--<img class="d-block w-100" src="https://http2.mlstatic.com/mesas-comedor-mesa-lustrada-guayubira-marmol-negro-cosmic-D_NQ_NP_989663-MLA26004806223_092017-O.jpg" alt="Second slide" style="height:500px;">--%>
                        <asp:Image ID="Destacado2_img" runat="server" alt="Second Slide" style="height:500px" class="d-block w-100"/>
                    </div>
                    <div class="carousel-item">
                        <%--<img class="d-block w-100" src="https://www.perozzi.com.ar/6790-large_default/placard.jpg" alt="Third slide" style="height:500px;">--%>
                        <asp:Image ID="Destacado3_img" runat="server" alt="Third Slide" style="height:500px" class="d-block w-100"/>
                    </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
           </div>


            <%--Esto nunca sucedio señores--%>



             <%--<div class="col-md-12" style="width:100px; background-color:bisque; color:black; text-align:center;"><h3>OFERTAS</h3></div>
            <div class="col-3" style="text-align:center">
               <asp:LinkButton ID="producto1" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:400px; width:600px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="producto2" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:400px; width:600px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="producto3" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:400px; width:600px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="producto4" runat="server" OnClick="producto4_Click">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:400px; width:600px">
            </div>--%>
        </div>
    

    

</asp:Content>
