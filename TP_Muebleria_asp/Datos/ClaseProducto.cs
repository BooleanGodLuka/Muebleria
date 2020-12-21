using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP_Muebleria_asp
{
    public class ClaseProducto
    {
        string cod_prod;
        string nombre;
        string img_url;
        string color;
        string t_madera;
        double precio_unitario;
        double alto;
        double ancho;
        double largo;

        public void set_tmadera (string madera) { t_madera = madera; }
        public void set_cod(string cod) { cod_prod = cod; }
        public void set_nomb(string n) { nombre = n; }
        public void set_img(string url) { img_url = url; }
        public void set_color(string col) { color = col; }
        public void set_precio(double precio) { precio_unitario = precio; }
        public void set_alto(double alt) { alto = alt; }
        public void set_ancho(double anch) { ancho = anch; }
        public void set_largo (double lar) { largo = lar; }
        public string get_cod () { return cod_prod; }
        public string get_nombre () { return nombre; }
        public string get_img() { return img_url; }
        public string get_t_madera() { return t_madera; }
        public string get_color () { return color; }
        public double get_precio () { return precio_unitario; }
        public double get_alto () { return alto; }
        public double get_ancho () { return ancho; }
        public double get_largo () { return largo; }




        public void cargar_obj_xTabla(DataTable dt, int fila=0)
        {
            cod_prod = dt.Rows[fila]["Cod_Producto_PRO"].ToString();
            nombre = dt.Rows[fila]["Nombre_Producto"].ToString();
            img_url = dt.Rows[fila]["Foto_Producto"].ToString();
            color = dt.Rows[fila]["Color"].ToString();
            precio_unitario = Convert.ToDouble(dt.Rows[fila]["Precio_Unitario"]);
            alto = Convert.ToDouble(dt.Rows[fila]["Alto"]);
            ancho = Convert.ToDouble(dt.Rows[fila]["Ancho"]);
            largo = Convert.ToDouble(dt.Rows[fila]["Largo"]);
            t_madera = dt.Rows[fila]["Tipo_Madera"].ToString();
        }
    }
}