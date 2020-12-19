using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Muebleria_asp
{


    public partial class Sign_int : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["Usuario"] == null)
                {
                    editar_btn.Visible = false;
                }
                else
                {
                    crear_btn.Visible = false;
                }
                
                aclaracion_lbl.Visible = false;

            }
        }

        protected void validar_numero (object sender, EventArgs e)
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

        protected bool val_rellenado ()
        {
            if (nombre_txt.Text != null)
            {
                if (apellido_txt.Text != null)
                {
                    if (dni_txt.Text != null)
                    {
                        if (tel_txt.Text != null)
                        {
                            if (mail_txt.Text != null)
                            {
                                if (contra_txt.Text != null)
                                {
                                    return true;
                                }
                                
                            }
                        }
                    }
                }
            }
            return false;
        }

        protected bool val_existencia()
        {
            DataTable dt = new DataTable();
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            dt = clasita.ObtenerDataTable("Select * from Usuarios");

            for (int i =0; i<dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["EMail"].ToString() == mail_txt.Text)
                {
                    return false;
                }
            }
            return true;

        }


        protected void crear_btn_Click(object sender, EventArgs e)
        {
            if (!val_rellenado())
            {
                aclaracion_lbl.Text = "Datos insuficientes";
                aclaracion_lbl.Visible = true;
            }
            else
            {
                if (!val_existencia())
                {
                    aclaracion_lbl.Text = "E-Mail ya en uso";
                    aclaracion_lbl.Visible = true;
                }
                else
                {
                    /*string consulta = "Insert into Usuarios (Nombre,Apellido,DNI,Telefono,EMail,Contraseña) values ('"
                        + nombre_txt.Text + "','" + apellido_txt.Text + "','" + dni_txt.Text + "','" +
                        tel_txt.Text + "','" + mail_txt.Text + "'" +contra_txt.Text + "');";
                    */
                    ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
                    string consulta = "Insert into Usuarios(Nombre, Apellido, DNI, Telefono, EMail, Contraseña, Ctipo_Usuario_US) values('"
                            + nombre_txt.Text + "','" + apellido_txt.Text + "','" + dni_txt.Text + "','" +
                            tel_txt.Text + "','" + mail_txt.Text + "','" + contra_txt.Text + "', " +
                            "(select Ctipo_Usuario_TU as Ctipo_Usuario_US from Tipo_Usuarios where Tipo_Usuario = 'Cliente'));";
                    try
                    {
                        //clasita.ejecutar_comando(consulta);
                        clasita.aplicarconsultasql(consulta);
                    }catch(Exception gg)
                    {

                    }
                    DataRow cod = clasita.ObtenerFilaEspecifica("Select MAX(Cod_Usuario_US) as codigo From Usuarios");
                    Usuario us = new Usuario();
                    us.set_apellido(apellido_txt.Text);
                    us.set_contra(contra_txt.Text);
                    us.set_dni(dni_txt.Text);
                    us.set_mail(mail_txt.Text);
                    us.set_nombre(nombre_txt.Text);
                    us.set_tel(tel_txt.Text);
                    us.set_cod(cod["codigo"].ToString());
                   
                    Session["usuario"] = us;
                    Response.Write("<script>alert('Usuario creado, bienvenido !')</script>");
                    Server.Transfer("Login.aspx");

                }



            }    

        }

        protected void editar_btn_Click(object sender, EventArgs e)
        {
            if (!val_rellenado())
            {
                aclaracion_lbl.Text = "Datos insuficientes";
                aclaracion_lbl.Visible = true;
            }
            else
            {
                
                  
                    ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
                    
                    Usuario us = new Usuario();
                    us.set_apellido(apellido_txt.Text);
                    us.set_contra(contra_txt.Text);
                    us.set_dni(dni_txt.Text);
                    us.set_mail(mail_txt.Text);
                    us.set_nombre(nombre_txt.Text);
                    us.set_tel(tel_txt.Text);
                try { 
                    string consulta = "update usuarios set EMail = '" + us.get_mail() + "', Apellido='"+us.get_apellido()+"', " +
                    " Nombre='"+us.get_nombre()+"', Contraseña='"+us.get_contra()+"', DNI='"+us.get_dni()+"', " +
                    "Telefono= '"+us.get_tel()+"' where COD_Usuario_US = " + us.get_cod() ;
                    clasita.ejecutar_comando(consulta);
                }
                catch (Exception gg)
                {
                    aclaracion_lbl.Text = "Error de BD";
                    aclaracion_lbl.Visible = true;
                }

                    Session["usuario"] = us;
                    Server.Transfer("Home_cliente.aspx");

                


            }

        }
    }
}