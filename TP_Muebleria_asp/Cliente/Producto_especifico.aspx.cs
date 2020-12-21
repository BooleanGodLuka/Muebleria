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
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        private ClaseProducto prod = new ClaseProducto();


        protected void cargar_producto()
        {
            string cod_prod = Request.QueryString["cod"].ToString();
            //string cod_prod = "2";
            //SqlConnection cn = new SqlConnection();
            DataTable dt = new DataTable();
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            //cn = clasita.ObtenerConexion();
            dt = clasita.ObtenerDataTable("Select * From Productos where Cod_Producto_PRO = '" + cod_prod + "'");
            
            prod.cargar_obj_xTabla(dt);
            //cn.Close();
        }

        //protected void cargar_drop_cantidad ()
        //{
        //    int max = obtener_stock();

        //    for (int i = 0; i<max; i++)
        //    {
        //        cantidad_ddl.Items.Insert(i, (i+1).ToString());

        //    }
            
          



        //}


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_producto();
                //Prod_img.ImageUrl = "https://www.perozzi.com.ar/6790-large_default/placard.jpg";
                Prod_img.ImageUrl = prod.get_img();
                Prod_img.Width = 500;
                Prod_img.Height = 500;
                nombreprod_lbl.Text = prod.get_nombre();
                precio_lbl.Text = prod.get_precio().ToString();
                alto_lbl.Text = prod.get_alto().ToString();
                ancho_lbl.Text = prod.get_ancho().ToString();
                color_lbl.Text = prod.get_color();
                tipoM_lbl.Text = prod.get_t_madera();
                //cargar_drop_cantidad();



            }

        }

       

        public int obtener_stock()
        {
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            DataTable dt = new DataTable();
            dt = clasita.ObtenerDataTable("Select Stock from Productos where Cod_Producto_PRO = '" + prod.get_cod() + "'");
            return Convert.ToInt32(dt.Rows[0]["Stock"]);
        }

       
             

       

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            DataTable aux = (DataTable)Session["Carrito"];
            cargar_producto();

            if (Session["Usuario"] == null)
            {
                Response.Write("<script>alert('Por favor, inicie sesion')</script>");
            }

            //DataRow precio = aux.NewRow();
            //precio = clasita.ObtenerFilaEspecifica("Select Precio_Unitario as Precio from Productos where Cod_Producto_PRO = '"+ prod.get_cod() + "'" );

            //float preciof = precio.Field<float>("Precio");

            float preciototal = float.Parse(precio_lbl.Text) * float.Parse(Cantidad_txt.Text);




            if (aux != null)
            {

                //aux.Rows.Add(clasita.ObtenerFilaEspecifica("Select Cod_Producto_PRO as Codigo, Nombre_Producto as Nombre, "));
                //aux.Rows[0]["Codigo"].
                string consulta = "Select Cod_Producto_PRO as Codigo, " +
                    "Nombre_Producto as Nombre, " + preciototal + " as Precio, " + Cantidad_txt.Text + " as Cantidad From Productos " +
                    "where Cod_Producto_PRO = '" + prod.get_cod() + "'";

                DataRow row = aux.NewRow();
                row = clasita.ObtenerFilaEspecifica(consulta);
                //aux.Rows.Add(row);
                aux.ImportRow(row);


                ///agregar columna a la tabla con nuevo producto
                ///una vez que le den al comprar en el form del carrito limpiar dataset session[carrito]
                Session["Carrito"] = aux;
                Server.Transfer("/Cliente/Carrito.aspx");
            }
            else
            {




                ///Si no hay carrito, se crea uno para asignarle los datos 

                DataTable aux2 = new DataTable();
                aux2 = clasita.ObtenerDataTable("Select Cod_Producto_PRO as Codigo, Nombre_Producto" +
                    " as Nombre,  "+ preciototal + " as Precio," + Cantidad_txt.Text +" as Cantidad From Productos where Cod_Producto_PRO = '" +
                    prod.get_cod() + "'");
                //DataRow row = aux2.NewRow();
                //row = clasita.ObtenerFilaEspecifica("Select Cod_Producto_PRO as Codigo, " +
                //    "Nombre_Producto as Nombre,  Precio_Unitario as Precio From Productos " +
                //    "where Cod_Producto_PRO = '" + prod.get_cod() + "'");
                //aux2.ImportRow(row);

                //aux2.Columns.Add("Codigo");
                //aux2.Columns.Add("Nombre");
                //aux2.Columns.Add("Cantidad");
                //aux2.Columns.Add("Precio");

                //DataRow row = aux2.NewRow();
                ///// se le agrega la primera fila con el objeto cargado y la cantidad establecida por el usuario
                //aux2.Rows.Add(prod.get_cod(), prod.get_nombre(), Convert.ToInt32(cantidad_ddl.SelectedItem.Text), (prod.get_precio() * Convert.ToInt32(cantidad_ddl.SelectedItem.Text)));
                //row["Codigo"] = prod.get_cod();
                //row["Nombre"] = prod.get_nombre();
                //row["Cantidad"] = cantidad_ddl.SelectedValue.ToString();
                //row["Precio"] = Convert.ToInt32(cantidad_ddl.SelectedValue.ToString()) * prod.get_precio();
                //aux2.Rows.Add(row);




                Session["Carrito"] = aux2;
                Server.Transfer("/Cliente/Carrito.aspx");


            }
        }
    }
}