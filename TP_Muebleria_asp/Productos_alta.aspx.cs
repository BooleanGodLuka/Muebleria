using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace TP_Muebleria_asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClaseMaestra_SQL acceso = new ClaseMaestra_SQL();
        protected void Page_Load(object sender, EventArgs e)
        {
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string num = txtb_nompro.Text;
            string num2 = txtb_alto.Text;

            string consulta = "insert into Productos(Nombre_Producto, Foto_Producto, Color, Tipo_Madera, Precio_Unitario, Alto, Ancho, Largo, Cod_categoria_Prod)" +
                " values ('" + txtb_nompro.Text + "','" + txtb_Url.Text + "','" + txtb_color.Text + "','" + txtb_tm.Text + "','" + txtb_pu.Text + "','" + txtb_alto.Text + "','" + txtb_ancho.Text + "','" + txtb_largo.Text + "','" + txtb_codcat.Text + "')";

            aclaracion_lbl.Text = consulta;

            try
            {
                acceso.ejecutar_comando(consulta);
                //acceso.aplicarconsultasql(consulta);
                Server.Transfer("Admin_Productos.aspx");
            }
            catch (Exception ex)
            {
            }



        }
    }
}