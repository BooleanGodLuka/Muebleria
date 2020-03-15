using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

    public class ClaseMaestra_SQL
    {


        String ruta = "";
        String rutaBDMuebleria = "Data Source=localhost\\sqlexpress;Initial Catalog=Muebleria;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDMuebleria);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(String consultaSql)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    public DataTable ObtenerDataTable(String Sql, string tabla = "tabla")
    {
        DataSet ds = new DataSet();
        ClaseMaestra_SQL datos = new ClaseMaestra_SQL();
        SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
        adp.Fill(ds,tabla);
        return ds.Tables[tabla];
    }

    public DataRow ObtenerFilaEspecifica (string consulta , int fila = 0)
    {
        DataTable dt = ObtenerDataTable(consulta);
        return dt.Rows[fila];
    }

    public void cargaTabla(String NombreTabla, String consulta, ref DataSet ds)
        {
            SqlConnection cn = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(consulta);
            adp.Fill(ds, NombreTabla);
        }

        public DataTable cargar_tabla_xprocedimiento_almacenado (SqlCommand Comando, String consulta)
        {
        DataTable dt = new DataTable();
        SqlConnection Conexion = ObtenerConexion();
        SqlCommand cmd = new SqlCommand();
        cmd = Comando;
        cmd.Connection = Conexion;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = consulta;
        SqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        Conexion.Close();
        return dt;
    }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

        public void ejecutar_comando (string consulta)
    {
        SqlConnection cn = ObtenerConexion();
        SqlCommand cmd = new SqlCommand(consulta, cn);
        SqlDataReader dr;
        try
        {
            dr = cmd.ExecuteReader();
            while (dr.Read()) { };              ///Lo vi en un video para guardar datos, NO SE
                                                /// no hace nada el while, pero por las se deja 

        }
        catch (Exception ex) { }
    }
        public void ObtenerTodosLosObjetosDeTabla(String nombreTabla, string tabla, ref DataSet ds)
        {
            ClaseMaestra_SQL ad = new ClaseMaestra_SQL();
            ad.cargaTabla(nombreTabla, "select * from " + tabla, ref ds);
        }

        public void ObtenerTodosLosObjetosDeTabla_Clausula(String nombreTabla, String clausula, string tabla, string clausula2, ref DataSet ds)
        {
            ClaseMaestra_SQL ad = new ClaseMaestra_SQL();
            ad.cargaTabla(nombreTabla, clausula + " " + tabla + " " + clausula2, ref ds);
        }

        public void aplicarconsultasql(String Sql, string tabla = "tabla")
        {
            DataSet ds = new DataSet();
            SqlConnection cn = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql);
            adp.Fill(ds, tabla);
        }

    }
