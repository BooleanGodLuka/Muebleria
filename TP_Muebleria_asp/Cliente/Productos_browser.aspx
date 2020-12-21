<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Productos_browser.aspx.cs" Inherits="TP_Muebleria_asp.Formulario_web3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

<style>
 
   
</style>

    
    <br />
    <br />





    <div class="topnav">
        <div class="search-container">
            <form action="/action_page.php">
      
      <asp:TextBox ID="buscar_text" runat="server" placeholder="Buscar..." style="display:inline-block"></asp:TextBox>
      <asp:DropDownList ID="tmadera_drpd" runat="server"></asp:DropDownList>
      <asp:LinkButton ID="buscar_btn" runat="server" Onclick="buscar_btn_click" style="display:inline-block ; width: 25px ; height: auto" ><i class="fa fa-search" style="text-align:center"></i></asp:LinkButton>

    </form>
  </div>
        </div>
        
    
  

    
    <% 

        ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
        //System.Data.SqlClient.SqlConnection cn = clasita.ObtenerConexion();

        System.Data.DataTable ts = new System.Data.DataTable();
        string consulta;

        if (Convert.ToString(Request.QueryString["key"]) == null) {
            
                consulta = "Select * from Productos where Cod_categoria_Prod = '" + Session["Categoria"].ToString() + "'";
            


        }
        else
        {
            string busqueda = "";
            if (Convert.ToString(Request.QueryString["key"]).Substring(0,1) == "B") {

                busqueda = Convert.ToString(Request.QueryString["key"]).Substring(1);
                consulta = "Select * from Productos where Nombre_Producto like '%" + busqueda + "%'";
            }else
            {
                busqueda = Convert.ToString(Request.QueryString["key"]).Substring(1);
                consulta = "Select * from Productos where Cod_categoria_Prod = '" + Session["Categoria"].ToString() + "'"+
                busqueda;
            }

            %>
            <script>console.log("<%=busqueda %>")</script>
            <script>console.log("<%=consulta %>")</script>  
   <%
        }

        %>
        
     

        <%
        //System.Data.SqlClient.SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(consulta, cn);
        //adp.Fill(ts);

        ts = clasita.ObtenerDataTable(consulta);

        //ts=clasita.ObtenerDataTable(consulta,"Productos");
        //clasita.ObtenerTabla("select c_articulo,detallear,precio,url from Articulos order by c_articulo desc");
        int j = 0;
        string link;
        string img;



        %>
   

        <div class="row"> 



        <%for ( j = 0;  j <ts.Rows.Count; j++)
        {
            link = "<a href= \"" + @"Producto_especifico.aspx" + "?cod=" + ts.Rows[j]["Cod_Producto_PRO"].ToString() + "\">" +ts.Rows[j]["Nombre_Producto"] +"</a>" ;
            img = "<img class=\"d-block w-100\" src=\"" + ts.Rows[j]["Foto_Producto"] + "\" style=\"height:300px; width:500px\">";
            %>

           <div class="col-4" style="text-align:center">
            
               <%=link %>
               <br />
               <%=img %>

                                                                                                                                                                                                                                                                    

            </div>

 <% } %>
            </div>






                            <%-- Porqueria experimental , no descomentar --%>
<%--    <div class="row">
           


        <asp:ListView ID="productos_lstv" runat="server"></asp:ListView>


<%--        <div class="col-3" style="text-align:center">
               <asp:LinkButton ID="producto1" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="producto2" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="producto3" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="producto4" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
        <div class="col-3" style="text-align:center">
               <asp:LinkButton ID="LinkButton1" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="LinkButton2" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="LinkButton3" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>
            <div class="col-3" style="text-align:center">
                <asp:LinkButton ID="LinkButton4" runat="server">NOMBRE PRODUCTO</asp:LinkButton>
               <br />
               <img class="d-block w-100" src="https://www.tifon.es/1150-large_default/pack-4-sillas-comedor-leiza-2.jpg" alt="First slide" style="height:300px; width:500px">
            </div>--%>
   


<%--<script>
function openNav() {
  document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
}
</script>
   --%>


</asp:Content>
