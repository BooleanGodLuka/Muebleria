using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Muebleria_asp
{
    public partial class Cliente_historial : System.Web.UI.Page
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
            Usuario us = (Usuario)Session["Usuario"];

            string consulta = "select Fecha, Precio_Total from Compras where Cod_Usuario_CO = "+us.get_cod();
            //Obtengo la tabla con todos los usuarios
            GridView1.DataSource = aq.ObtenerDataTable(consulta);
            // La muestro en Grid
            GridView1.DataBind();

        }
    }
}