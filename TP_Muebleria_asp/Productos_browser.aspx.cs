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





    public partial class Formulario_web3 : System.Web.UI.Page
    {
        public string usuario;

        private int cant_productos;
        static  ClaseMaestra_SQL clasita;
        private string[] url_imgs;
        private DataSet tabla_productos;
        private List<ImageButton> botones_productos;


        //protected void cargar_cant_productos()       ///saco la cantidad de productos a haber en la pagina
        //{
        //    clasita = new ClaseMaestra_SQL();
        //    SqlConnection con = clasita.ObtenerConexion();
        //    DataSet dt = new DataSet();
        //    DataTable tabla = new DataTable();


        //    string consulta = "Select COUNT (Cod_Categoria) FROM CatxPro AS Cantidad_Prod WHERE Cod_Categoria = " + (string)Session["Categoria"];



        //    clasita.cargaTabla("CatxPro", consulta, ref dt);

           
            
        //       cant_productos = Convert.ToInt16(dt.Tables[0].Rows[0][0]);
            

        //    con.Close();
        //}


        //protected void cargar_tabla_prod ()        ///Se cargan las direcciones de las imagenes de los productos
        //{
        //    clasita = new ClaseMaestra_SQL();
        //    SqlConnection con = clasita.ObtenerConexion();
            
        //    DataTable tabla = new DataTable();

        //                                ///VER SI ESTE INNERJOIN ESTA BIEN POR AMOR A LA PATRIA
        //    string consulta = "Select * FROM Productos INNER JOIN CatxPro ON Producto.CodProducto_p = CatxPro.CodProducto_cxp WHERE CatxPro.CodCategoria_cxp = " + (string)Session["Categoria"];



        //    clasita.cargaTabla("Productos", consulta, ref tabla_productos);



        //    con.Close();
        //}

        protected void Page_Load(object sender, EventArgs e)
        {






            //botones_productos = new List<ImageButton>();        ///esto seria para manejar los imagebutton de los productos
            //                                                    ///
            //if (!IsPostBack)
            //{
            //    cargar_cant_productos();                        ///dedusco la cantidad de productos de la pagina
            //    //url_imgs = new string[cant_productos];          
            //    cargar_tabla_prod();                            ///cargo la tabla con todos los productos de la pagina para que a
            //                                                    ///la hora que clickeen en alguno se le manda el DataRow respectivo
            //                                                    ///Ese DataRow se saca con la posicion que la saco del nombre del boton 
            //                                                    ///haciendo tabla_productos.Tables[0].Row[boton.ID.Replace("Producto","")]
            //                                                    ///u otra forma de sacar la palabra "Producto" del ID

            //    productos_lstv.DataSource = tabla_productos.Tables[0];
            //    productos_lstv.DataBind();



            //    //for (int i = 0; i < cant_productos; i++)
            //    //{
            //    //    ImageButton boton = new ImageButton();    ///aca se cargarian la cantidad de imagebuttons que la pagina necesita
            //    //    boton.ID = "Producto " + i.ToString();
            //    //    boton.Height = 300;
            //    //    boton.Width = 500;
            //    //    boton.ImageUrl = tabla_productos.Tables[0].Rows[i][12].ToString();    /// 12 por que supongo que era la columna de la url, no me fije :B
            //    //    botones_productos.Add(boton);
            //    //}

            //}
        }

        protected void Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void buscar_btn_click(object sender, EventArgs e)
        {
            
            Session["Filtro"] = buscar_text.Text.ToString();
            Response.Redirect("Productos_browser.aspx?key=" + Session["Filtro"]);
        }

    }
}