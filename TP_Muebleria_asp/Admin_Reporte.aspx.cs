using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Muebleria_asp
{
    public partial class Admin_Reporte : System.Web.UI.Page
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
            

            string consulta = "select p.Nombre_Producto, p.Foto_Producto , p.Descripcion, "+
                                "ISNULL((select SUM(dc.Cantidad_Comprada) from Detalle_Compra as dc " +
                                " where dc.Cod_Producto_DC = p.Cod_Producto_PRO),0) as cantidad, "+
                                " ISNULL((select SUM(dc.Precio_Unitario) from Detalle_Compra as dc " +
                                "where dc.Cod_Producto_DC = p.Cod_Producto_PRO),0) as precio_total "+
                                " from Productos as p ";
            //Obtengo la tabla con todos los usuarios
            GridView1.DataSource = aq.ObtenerDataTable(consulta);
            // La muestro en Grid
            GridView1.DataBind();

        }
    }
}