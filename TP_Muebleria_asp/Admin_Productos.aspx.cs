using System;
using System.Collections.Generic;
using System.Data;
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
                aclaracion_lbl.Visible = false;
            

            }
        }


        protected void validar_numero(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.TextBox texto = (System.Web.UI.WebControls.TextBox)sender;
            string palabra = texto.Text;
            if (palabra.Any(char.IsDigit))
            {
                texto.Text = "";
                aclaracion_lbl.Text = "Hay Numeros en campos especificos de letras";
                aclaracion_lbl.Visible = true;
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
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            DataTable dt = new DataTable();
            string consultita = "";
            consultita = "Select DISTINCT Tipo_Madera from Productos where Cod_categoria_Prod  = '" + Session["Categoria"].ToString() + "'";
           




            string url = ((FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1")).FileName;

            if (((FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1")).HasFile)
                ((FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1")).SaveAs(Server.MapPath("/fotos/" + url));
            url = "/fotos/" + url;

                       
            string idProd = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            string idCate = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;


            //string idCate=((DropDownList)GridView1.Rows[e.RowIndex].FindControl("DropDownList1")).Text;

            string nombre = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4")).Text;
            string color = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox5")).Text;
            string tipoM = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox6")).Text;
            string precio = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox7")).Text;
            precio = precio.Replace(",", ".");
            string alto = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox8")).Text;
            string ancho = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox9")).Text;
            string largo = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox10")).Text;
            string Estado = ((DropDownList)GridView1.Rows[e.RowIndex].FindControl("DropDownEstado")).SelectedValue.ToString();
            //string estado = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox11")).Text;




            int estadobit;
            if (Estado == "True")
            {
                estadobit = 1;
            }
            else estadobit = 0;

            try
            {

                //Aplico el update a la tabla usuarios con los datos obtenidos
                string consulta = "";
                if (url == "/fotos/")
                {
                    consulta = "update Productos set Estado = '" + estadobit + "' ,Nombre_Producto = '" + nombre 
                    + "' ,Color = '" + color + "' ,Tipo_Madera = '" + tipoM
                    + "' ,Precio_Unitario = " + precio + " ,Alto = '" + alto
                     + "' ,Ancho = '" + ancho + "' ,Largo = '" + largo
                     + "' where Cod_Producto_PRO = '" + idProd + "'";

                }
                else
                {
                    consulta = "update Productos set Estado = '" + estadobit + "' ,Foto_Producto = '" + url
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