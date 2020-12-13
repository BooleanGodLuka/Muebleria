using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Muebleria_asp
{
    public partial class Admin_Productos : System.Web.UI.Page
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

            string consulta = "select Cod_Producto_PRO,Cod_categoria_Prod,Foto_Producto, Nombre_Producto,Color,Tipo_Madera,Precio_Unitario,Alto,Ancho,Largo,Estado from Productos";
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

            string url = ((FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1")).FileName;

            if (((FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1")).HasFile)
                ((FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1")).SaveAs(Server.MapPath("/fotos/" + url));
            url = "/fotos/" + url;

                       
            string idProd = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            string idCate = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;

            string nombre = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4")).Text;
            string color = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox5")).Text;
            string tipoM = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox6")).Text;
            string precio = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox7")).Text;
            precio = precio.Replace(",", ".");
            string alto = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox8")).Text;
            string ancho = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox9")).Text;
            string largo = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox10")).Text;
            string estado = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox11")).Text;




            try
            {

                //Aplico el update a la tabla usuarios con los datos obtenidos
                string consulta = "";
                if (url == "/fotos/")
                {
                    consulta = "update Productos set Estado = '" + estado + "' ,Nombre_Producto = '" + nombre 
                    + "' ,Color = '" + color + "' ,Tipo_Madera = '" + tipoM
                    + "' ,Precio_Unitario = " + precio + " ,Alto = '" + alto
                     + "' ,Ancho = '" + ancho + "' ,Largo = '" + largo
                     + "' where Cod_Producto_PRO = '" + idProd + "'";

                }
                else
                {
                    consulta = "update Productos set Estado = '" + estado + "' ,Foto_Producto = '" + url
                    + "' ,Nombre_Producto = '" + nombre + "' ,Color = '" + color + "' ,Tipo_Madera = '" + tipoM
                    + "' ,Precio_Unitario = " + precio + " ,Alto = '" + alto
                     + "' ,Ancho = '" + ancho + "' ,Largo = '" + largo
                     + "' where Cod_Producto_PRO = '" + idProd + "'";

                }

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