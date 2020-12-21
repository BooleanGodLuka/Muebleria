using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP_Muebleria_asp
{
    public class Usuario
    {
        string cod_us;
        string contra_us;
        string tipo_us;
        string nombre_us;
        string apellido_us;
        string dni_us;
        string tel_us;
        string mail_us;
        bool estado_us;

        public string get_cod() { return cod_us; }
        public string get_contra() { return contra_us; }
        public string get_tipo() { return tipo_us; }
        public string get_nombre () { return nombre_us; }
        public string get_apellido() { return apellido_us; }
        public string get_dni() { return dni_us; }
        public string get_tel() { return tel_us; }
        public string get_mail() { return mail_us; }

        public bool get_estado() { return estado_us; }
        public void set_cod (string p) { cod_us = p; }
        public void set_contra(string p) { contra_us = p; }
        public void set_tipo(string p) { tipo_us = p; }
        public void set_nombre(string p) { nombre_us = p; }
        public void set_apellido(string p) { apellido_us = p; }
        public void set_dni(string p) { dni_us = p; }
        public void set_tel(string p) { tel_us = p; }
        public void set_mail(string p) { mail_us = p; }
        public void set_estado(bool p) { estado_us = p; }

        public void cargar_us_xtabla (DataTable dt, int fila =0)
        {
            cod_us = dt.Rows[fila]["Cod_Usuario_US"].ToString();
            contra_us = dt.Rows[fila]["Contraseña"].ToString();
            tipo_us = dt.Rows[fila]["Ctipo_Usuario_US"].ToString();
            nombre_us = dt.Rows[fila]["Nombre"].ToString();
            apellido_us = dt.Rows[fila]["Apellido"].ToString();
            dni_us = dt.Rows[fila]["DNI"].ToString();
            tel_us = dt.Rows[fila]["Telefono"].ToString();
            mail_us = dt.Rows[fila]["EMail"].ToString();
           estado_us = Convert.ToBoolean(dt.Rows[fila]["Estado"]);

        }

    }
}