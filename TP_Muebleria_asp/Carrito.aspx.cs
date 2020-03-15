using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace TP_Muebleria_asp
{
    public partial class Carrito : System.Web.UI.Page
    {
        string fila;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Carrito"] == null)
                {
                    carrito_grdv.Visible = false;
                   
                    compra_btn.Visible = false;
                    aclaracion_lbl.Text = "El carrito se encuentra vacio";
                }
                else
                {
                       
                    DataTable dt = (DataTable)Session["Carrito"];

                    carrito_grdv.DataSource = dt;
                    carrito_grdv.DataBind();
                    
                    aclaracion_lbl.Text = "De desear eliminar un producto del Carro";

                }



            }
        }

       


        protected void compra_btn_Click(object sender, EventArgs e)
        {
            Usuario us = (Usuario)Session["Usuario"];
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            string tot;//= 0;
            float temp = 0;
            for (int i=0; i<carrito_grdv.Rows.Count; i++)
            {
                tot = carrito_grdv.Rows[i].Cells[3].Text;
                temp += float.Parse(tot);
                //tot += float.Parse(carrito_grdv.Rows[i].Cells[2].Text);
            }

            string total = temp.ToString();
            string consulta = "insert into facturas (Cod_Usuario_F,Fecha_Venta,Cod_TipoP_F,Precio_Total) select '" + us.get_cod() + "'" +
                ",'" + DateTime.Now + "','"+ total+"'";
            clasita.ejecutar_comando(consulta);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            for (int j = 0; j < carrito_grdv.Rows.Count; j++)
            {
                consulta = "Select MAX(Cod_Factura_F) From Facturas";
                dt = clasita.ObtenerDataTable(consulta);
                consulta = "Select Cod_Marca_PXM From ProductosxMarcas where Cod_Producto_PXM = '" + carrito_grdv.Rows[j].Cells[1].Text + "'";
                dt2 = clasita.ObtenerDataTable(consulta);

                consulta = "Insert into Detalle_Factura(Cod_Factura_DF,Cod_Producto_DF,Cod_Marca_DF,Cantidad_Vendida,Precio_Unitario)" +
                            "select " + dt.Rows[0][0].ToString() + ",'" + carrito_grdv.Rows[j].Cells[0] +
                            "','" +dt2.Rows[0][0].ToString() + "'" + carrito_grdv.Rows[j].Cells[2] + "'";
                clasita.ejecutar_comando(consulta);


            }//MAX(Cod_Factura_F)

            

        }

        protected void carrito_grdv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //creo una tabla temporal para borrar el item
            DataTable tablaTemp = new DataTable();
            // la cargo con la session actual
            tablaTemp = (DataTable)this.Session["Carrito"];
            //borro la row que seleccione
            tablaTemp.Rows[e.RowIndex].Delete();

            //recargo tabla
            carrito_grdv.DataSource = (DataTable)Session["Carrito"];
            carrito_grdv.DataBind();
        }
    }
}