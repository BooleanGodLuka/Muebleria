using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Muebleria_asp
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Filtro"] = null;
            Session["Busqueda"] = null;

            if (Session["Usuario"] == null)
            {
                login_lbtn.Text = "Ingresar";
                admin_lbtn.Visible = false;

            }else
            {
                
                Usuario us = (Usuario)Session["Usuario"];
                login_lbtn.Text = us.get_mail();
                if (us.get_tipo() != "tu2")
                {
                    admin_lbtn.Visible = false;
                }
            }

        }

        protected void living_lbtn_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "cat4";   ///aca pongan el codigo de categoria como esta puesto en la BD
                                             /// lo mismo en todos los otros eventos de click (obvio)  
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Response.Redirect("Productos_browser.aspx");
            
        }

        protected void dormitorio_lbtn_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "cat1";
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Response.Redirect("Productos_browser.aspx");
        }

        protected void cocina_lbtn_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "cat2";
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Response.Redirect("Productos_browser.aspx");
        }

        protected void comedor_lbtn_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "cat3";
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Response.Redirect("Productos_browser.aspx");
        }

        protected void baño_lbtn_Click(object sender, EventArgs e)
        {
            ///Esto es para exteriores , shit happens
            Session["Categoria"] = "cat5";
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Response.Redirect("Productos_browser.aspx");
        }

        protected void contacto_lbtn_Click(object sender, EventArgs e)
        {
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Session["Categoria"] = null;
            Response.Redirect("Productos_browser.aspx");
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Session["Categoria"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void carrito_lbtn_Click(object sender, EventArgs e)
        {
            Session["Filtro"] = null;
            Session["Busqueda"] = null;
            Session["Categoria"] = null;
            Response.Redirect("Carrito.aspx");
        }

        protected void buscar_btn_click(object sender, EventArgs e)
        {
            Session["Busqueda"] = null;
            Session["Busqueda"] = buscar_text.Text.ToString();
            Session["Filtro"] = null;
            Session["Categoria"] = null;
            Response.Redirect("Productos_browser.aspx?key=" + "B" + Session["Busqueda"]);
        }

    }
}