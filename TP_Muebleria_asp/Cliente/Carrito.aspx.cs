using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            if (Session["Usuario"] == null)
            {
                Response.Write("<script>alert('Por favor, inicie sesion')</script>");
            }


            Usuario us = (Usuario)Session["Usuario"];
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            //string tot;//= 0;
            //float temp = 0;
            //for (int i = 0; i < carrito_grdv.Rows.Count; i++)
            //{
            //    tot = carrito_grdv.Rows[i].Cells[3].Text;
            //    temp += float.Parse(tot);
            //    //tot += float.Parse(carrito_grdv.Rows[i].Cells[2].Text);
            //}

            string codigoUsuario = us.get_cod();
            DateTime dia = DateTime.Now;


            //string total = temp.ToString();
            string consulta = "insert into compras (Cod_Usuario_CO,Fecha,Precio_Total) select '" + codigoUsuario + "'" +
                ",'" + dia + "','"+ 0 +"'";
            clasita.ejecutar_comando(consulta);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            consulta = "Select MAX(Cod_Compra_CO) From Compras";
            dt = clasita.ObtenerDataTable(consulta);

            for (int fila = 0; fila < carrito_grdv.Rows.Count ; fila++)
            {

                
                    string cod_Prodcuto = carrito_grdv.Rows[fila].Cells[1].Text;
                    string cantidadComprada = carrito_grdv.Rows[fila].Cells[4].Text;
                    //string precioUnitario = carrito_grdv.Rows[fila].Cells[3].Text;


                string cod_Compra = dt.Rows[0][0].ToString();
                

                consulta = "Insert into Detalle_Compra(Cod_Compra_DC,Cod_Producto_DC,Cantidad_Comprada)" +
                            "select " + cod_Compra + ",'" + cod_Prodcuto + "'," + cantidadComprada;

                clasita.ejecutar_comando(consulta);             //aca la consulta manda cualquiera, por eso no se carga


            }//MAX(Cod_Factura_F)

            Session["Carrito"] = null;
            Response.Write("<script>alert('Compra realizada!')</script>");
            Server.Transfer("/Cliente/Home_cliente.aspx");

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