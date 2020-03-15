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


    public partial class Sign_int : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                aclaracion_lbl.Visible = false;

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
                    string consulta = "Insert into Usuarios (Nombre,Apellido,DNI,Telefono,EMail,Contraseña) values ('"
                        + nombre_txt.Text + "','" + apellido_txt.Text + "','" + dni_txt.Text + "','" +
                        tel_txt.Text + "','" + mail_txt.Text + "'" +contra_txt.Text + "');";

                    ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
                    clasita.ejecutar_comando(consulta);
                    Usuario us = new Usuario();
                    us.set_apellido(apellido_txt.Text);
                    us.set_contra(contra_txt.Text);
                    us.set_dni(dni_txt.Text);
                    us.set_mail(mail_txt.Text);
                    us.set_nombre(nombre_txt.Text);
                    us.set_tel(tel_txt.Text);
                   
                    Session["usuario"] = us;
                    Server.Transfer("Login.aspx");

                }



            }    

        }
    }
}