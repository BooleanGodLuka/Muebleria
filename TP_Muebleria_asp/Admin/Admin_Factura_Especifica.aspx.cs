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
    public partial class Admin_Factura_Especifica : System.Web.UI.Page
    {
        ClaseMaestra_SQL aq = new ClaseMaestra_SQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargargrid();

            }
        }


        void cargargrid()
        {
            string codigo = Convert.ToString(Request.QueryString["key"]);

            string consulta = "Select dc.*, P.Nombre_Producto " +
                "from Detalle_Compra as dc, Productos as p where dc.Cod_Compra_DC = " + codigo + 
                "and dc.Cod_Producto_DC = p.Cod_Producto_PRO";
            //Obtengo la tabla con todos los usuarios
            GridView1.DataSource = aq.ObtenerDataTable(consulta);
            // La muestro en Grid
            GridView1.DataBind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // le digo que intente editar una fila que no existe para que no me modifique campos
            GridView1.EditIndex = -1;
            //recargo tabla
            cargargrid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Hago que sepa cual es la fila que va a editar
            GridView1.EditIndex = e.NewEditIndex;
            cargargrid();//recargo tabla
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string idcomp = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("compra_txt")).Text;
            string producto = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("producto_txt")).Text;
            string cantidad = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("cantidad_txt")).Text;
            string id_producto = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("cod_prod_txt")).Text;


            string precio = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("precio_txt")).Text;

            


            try
            {

                //Aplico el update a la tabla usuarios con los datos obtenidos
                string consulta = "";

                consulta = "  update Detalle_Compra set Cantidad_Comprada =" + cantidad + " where Cod_Compra_DC = " + idcomp + " and  Cod_Producto_DC = '" + id_producto + "'";



                aq.aplicarconsultasql(consulta);

            }
            catch (Exception)
            {

            }
            // le digo que intente editar una fila que no existe para que no me modifique campos
            GridView1.EditIndex = -1;
            //recargo tabla
            cargargrid();

        }



    }
}