using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Muebleria_asp
{
    public partial class Admin_Facturas : System.Web.UI.Page
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

            string consulta = "select * from Compras";
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

            string idComp = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            string fecha = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;

            string precio_total = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox7")).Text;



            try
            {

                //Aplico el update a la tabla usuarios con los datos obtenidos
                string consulta = "";

                    consulta = "update Compras set Fecha = '" + fecha + "' where Cod_Compra_CO = " + idComp;

                

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