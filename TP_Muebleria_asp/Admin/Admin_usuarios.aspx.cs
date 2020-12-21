using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP_Muebleria_asp
{
    public partial class Admin_usuarios : System.Web.UI.Page
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
                aclaracion_lbl.Text = "Los nombres y apellidos no pueden contener numeros";
                aclaracion_lbl.Visible = true;
            }

        }


        void cargargrid()
        {
            //Obtengo la tabla con todos los usuarios
            GridView1.DataSource = aq.ObtenerDataTable(" select Cod_Usuario_US,	Tipo_Usuario ,Nombre,Apellido,DNI,Contraseña,Telefono,EMail,Estado from Usuarios Inner Join Tipo_Usuarios on Ctipo_Usuario_TU = Ctipo_Usuario_US ");
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


            //DropDownList DdlCantidad = GridView1.Rows[e.RowIndex].FindControl("DropDownEstado") as DropDownList;
            //ListItem i;
            //i = new ListItem("Nuevo leon", "1");
            //DdlCantidad.Items.Add(i);
                    //DdlCantidad.Items.Add("true");
                    //DdlCantidad.Items.Add("False");



            //Obtengo todos los valores de los texbox de edicion
            string IdUser = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_idUs")).Text;
            string tipouser = ((DropDownList)GridView1.Rows[e.RowIndex].FindControl("DropDownTipoUser")).SelectedValue.ToString();
            string nombre = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_nombre")).Text;
            string apellido = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_apellido")).Text;
            string dni = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_dni")).Text;
            string Pass = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_pass")).Text;
            string telefono = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_tel")).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_email")).Text; 
            string Estado = ((DropDownList)GridView1.Rows[e.RowIndex].FindControl("DropDownEstado")).SelectedValue.ToString();
            //string Estado = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_estado")).Text;

            string tipoUsuario;

            if (tipouser == "Cliente")
            {
                tipoUsuario = "tu1";
            }
            else tipoUsuario = "tu2";



            int estadobit;
            if (Estado == "True")
            {
                estadobit = 1;
            }
            else estadobit = 0;
            try
            {
               
                //Aplico el update a la tabla usuarios con los datos obtenidos
                aq.aplicarconsultasql("update Usuarios set Estado = '" + estadobit + "' ,Nombre = '" + nombre
                    + "' ,Apellido = '" + apellido + "' ,DNI = '" + dni + "' ,EMail = '" + email
                    + "' ,Contraseña = '" + Pass + "' ,Telefono = '" + telefono 
                    + "' ,Ctipo_Usuario_US = '" + tipoUsuario + "' where Cod_Usuario_US = " + IdUser);

            }
            catch (Exception)
            {
                
            }
            // le digo que intente editar una fila que no existe para que no me modifique campos
            GridView1.EditIndex = -1;
            //recargo tabla
            cargargrid();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}