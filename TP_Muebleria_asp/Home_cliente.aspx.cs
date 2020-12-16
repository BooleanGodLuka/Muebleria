using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace TP_Muebleria_asp
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        private ClaseMaestra_SQL clasita;

        protected void cargar_cod_prod(ref string[] cod_prods)
        {
            
            clasita = new ClaseMaestra_SQL();
            SqlConnection con = clasita.ObtenerConexion();
            DataSet dt = new DataSet();
            DataTable tabla = new DataTable();
             

            string consulta = "Select top 3 Cod_Producto_DF, Max(Detalle_Factura.Cantidad_Vendida * Detalle_Factura.Precio_Unitario)AS Total From Detalle_Factura group by Cod_Producto_DF order by Total desc";

            

            clasita.cargaTabla("DetalleVenta", consulta, ref dt);

            for(int i = 1; i <= 3; i++) { 
            cod_prods[i] = dt.Tables[0].Rows[i][0].ToString();
            }

            con.Close();

        }
        
        protected void cargar_dest_url(ref string[] dest_url , string[] cod_prod)
        {
            clasita = new ClaseMaestra_SQL();
            SqlConnection con = clasita.ObtenerConexion();
            DataSet dt = new DataSet();
            DataTable tabla = new DataTable();


            string consulta = "Select Fotos_Producto From Productos where Cod_Producto_PRO = " + cod_prod[0] + " OR Cod_Producto_PRO= " + cod_prod[1] + " OR Cod_Producto_PRO= " + cod_prod[2];



            clasita.cargaTabla("Productos", consulta, ref dt);

            for (int i = 0; i < 3; i++)
            {
                dest_url[i] = dt.Tables[0].Rows[i][0].ToString();
            }

            con.Close();



        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
            string [] destacado_url = new string[3];
            string [] cod_prods = new string[3];

            if (!IsPostBack)
            {
                /// Funciones para cargar los productos destacados
                //cargar_cod_prod(ref cod_prods);
                //cargar_dest_url(ref destacado_url, cod_prods);

                /// Esto hasta que tengamos base de datos
                destacado_url[0] = "https://www.perozzi.com.ar/6790-large_default/placard.jpg";
                destacado_url[1] = "https://hendel-r7d8odghj1.stackpathdns.com/media/catalog/product/cache/0c3e9ac8430b5a3e77d1544ae1698a10/3/1/31997_1.jpg";
                destacado_url[2] = "https://http2.mlstatic.com/mesas-comedor-mesa-lustrada-guayubira-marmol-negro-cosmic-D_NQ_NP_989663-MLA26004806223_092017-O.jpg";
                


                Destacado1_img.ImageUrl = destacado_url[0];
                Destacado2_img.ImageUrl = destacado_url[1];
                Destacado3_img.ImageUrl = destacado_url[2];
            }

        }

        

        
    }
}