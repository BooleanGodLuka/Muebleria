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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Usuario"] == null)
                {
                    aclaracion_lbl.Visible = false;

                }else
                {
                    cerrarU_btn.Visible = false;
                    nombre_lbl.Visible = false;
                    nombre_txt.Visible = false;
                    contraseña_lbl.Visible = false;
                    contraseña_txt.Visible = false;
                }
            }
        }

        protected void cerrarU_btn_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Server.Transfer("Login.aspx");
        }

        protected void crearU_btn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Sign_int.aspx");

        }

        protected bool val_sesion(DataTable dt)
        {
            for (int i =0; i<dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["EMail"].ToString() == nombre_txt.Text)
                {
                    if (dt.Rows[i]["Contraseña"].ToString() == contraseña_txt.Text)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        
        protected void inicioS_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ClaseMaestra_SQL clasita = new ClaseMaestra_SQL();
            Usuario us = new Usuario();
            dt = clasita.ObtenerDataTable("Select * From Usuarios");

            if (val_sesion(dt))
            {
                us.cargar_us_xtabla(dt);
                Session["Usuario"] = us;
                Server.Transfer("Login.aspx");
            }
            else
            {
                aclaracion_lbl.Text = "Datos incorrectos";
                aclaracion_lbl.Visible = true;
            }

        
        }
    }
}