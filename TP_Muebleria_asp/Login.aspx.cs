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
                    editar_btn.Visible = false;
                    cerrarU_btn.Visible = false;
                    contraseña_lbl.Visible = true;
                    contraseña_txt.Visible = true;
                    mail2_lbl.Visible = true;
                    mail2_txt.Visible = true;
                    inicioS_btn.Visible = true;
                    historial_btn.Visible = false;

                }
                else
                {                    
                    mail2_lbl.Visible = false;
                    mail2_txt.Visible = false;
                    inicioS_btn.Visible = false;
                    contraseña_lbl.Visible = false;
                    contraseña_txt.Visible = false;
                    crearU_btn.Visible = false;
                    cerrarU_btn.Visible = true;
                    editar_btn.Visible = true;
                    historial_btn.Visible = true;
                }
            }
        }

        protected void cerrarU_btn_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Server.Transfer("Login.aspx");
        }

        protected void editar_btn_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("Sign_int.aspx");
        }

        protected void historial_btn_click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente_historial.aspx");
        }

        protected void crearU_btn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Sign_int.aspx");

        }

        protected bool val_sesion(DataTable dt)
        {
            for (int i =0; i<dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["EMail"].ToString() == mail2_txt.Text)
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
            string consulta =  "Select * from Usuarios where Email = '" + mail2_txt.Text + "' AND Contraseña = '" + contraseña_txt.Text + "'";
            dt = clasita.ObtenerDataTable(consulta);
            //DataRow dr = clasita.ObtenerFilaEspecifica(consulta);



            if (clasita.ValidarConsulta(consulta))
            {
                us.cargar_us_xtabla(dt);
                Session["Usuario"] = us;
                if (us.get_tipo() == "tu2   ")
                {
                    Server.Transfer("Home_admin.aspx");
                }
                else
                {
                    Server.Transfer("Home_cliente.aspx");
                }
                
            }
            else
            {
                Response.Write("<script>alert('Datos incorrectos')</script>");
                Server.Transfer("Login.aspx");
            }

        
        }
    }
}