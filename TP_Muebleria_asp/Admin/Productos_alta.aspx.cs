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
        ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string consulta = "";

            consulta = " Select Distinct Nombre_Categoria from Categorias ";

            dt = clasita.ObtenerDataTable(consulta);

            DropDownList1.Items.Add("Categorias");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Categorias = dt.Rows[i].ItemArray[0].ToString();
                DropDownList1.Items.Add(Categorias);

            }

        }

        protected bool val_rellenado ()
        {
            if (txtb_alto.Text != "")
            {
                if (txtb_ancho.Text != "")
                {
                    if (txtb_color.Text != "")
                    {
                        if(txtb_Descripcion.Text != "")
                        {
                            if (txtb_largo.Text != "")
                            {
                                if(txtb_nompro.Text != "")
                                {
                                    if(txtb_pu.Text != "")
                                    {
                                        if(txtb_tm.Text != "")
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

            if (!val_rellenado())
            {
                aclaracion_lbl.Text = "Datos insuficientes";
                aclaracion_lbl.Visible = true;
            }
            else
            {
                ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();



                string consulta = "SELECT MAX (CAST (SUBSTRING(Cod_Producto_PRO, 2, 3)AS int))  AS CodProducto From Productos;";
                DataRow dr = clasita.ObtenerFilaEspecifica(consulta);

                string Nombre = txtb_nompro.Text;
                string Descripcion = txtb_Descripcion.Text;
                string Url = FileUpload1.FileName;
                string Color = txtb_color.Text;
                string TipoMadera = txtb_tm.Text;
                float Precio = float.Parse(txtb_pu.Text);
                string Categoria = DropDownList1.Text;
                float alto = float.Parse(txtb_alto.Text);
                float largo = float.Parse(txtb_largo.Text);
                float ancho = float.Parse(txtb_ancho.Text);

                if (FileUpload1.HasFile)
                    FileUpload1.SaveAs(Server.MapPath("/fotos/" + Url));
                Url = "/fotos/" + Url;

                string consultita = "Select Cod_Categoria_CAT from Categorias where  Nombre_Categoria='" + Categoria + "'";
                DataRow Dar = clasita.ObtenerFilaEspecifica(consultita);

                int codigo = int.Parse(dr["CodProducto"].ToString()) + 1;

                consulta = "insert into Productos (Cod_Producto_PRO, Nombre_Producto,Descripcion,Foto_Producto,Color,Tipo_Madera,Precio_Unitario,Alto,Ancho,Largo,Estado,Cod_categoria_Prod)" +
                            " values ('a" + codigo + "','" + Nombre + "','" + Descripcion + "','" + Url + "','" + Color + "','" + TipoMadera + "','" + Precio + "','" + alto + "','" + ancho + "','" + largo + "','" + 1 + "','" + Dar["Cod_Categoria_CAT"].ToString() + "')";

                //aclaracion_lbl.Text = consulta;

                try
                {
                    clasita.ejecutar_comando(consulta);
                    //acceso.aplicarconsultasql(consulta);
                    Server.Transfer("/Admin/Admin_Productos.aspx");
                }
                catch (Exception ex)
                {

                }
            }

            



        }
    }
}