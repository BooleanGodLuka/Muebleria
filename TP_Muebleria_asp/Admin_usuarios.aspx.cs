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

            }
        }


        void cargargrid()
        {
            //Obtengo la tabla con todos los usuarios
            GridView1.DataSource = aq.ObtenerDataTable("select Cod_Usuario_US,	Ctipo_Usuario_US,Nombre,Apellido,DNI,Contraseña,Telefono,EMail,Estado from Usuarios");
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

            //Obtengo todos los valores de los texbox de edicion
            string IdUser = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_idUs")).Text;
            string tipouser = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_tipoUs")).Text;
            string nombre = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_nombre")).Text;
            string apellido = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_apellido")).Text;
            string dni = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_dni")).Text;
            string Pass = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_pass")).Text;
            string telefono = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_tel")).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_email")).Text; 
            string Estado = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_estado")).Text;

            try
            {
               
                //Aplico el update a la tabla usuarios con los datos obtenidos
                aq.aplicarconsultasql("update Usuarios set Estado = '" + Estado + "' ,Nombre = '" + nombre
                    + "' ,Apellido = '" + apellido + "' ,DNI = '" + dni + "' ,EMail = '" + email
                    + "' ,Contraseña = '" + Pass + "' ,Telefono = '" + telefono 
                    + "' ,Ctipo_Usuario_US = '" + tipouser + "' where Cod_Usuario_US = " + IdUser);

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