using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LIB_DATOS
{
    public class ClsExpo_DAL
    {
        public static string IntegralExpo_APM(string booking)
        {
         
          SqlConnection cn = new SqlConnection(Conexion.Impo);
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText= "SELECT ORD_CODIGO FROM neptunia1.terminal.dbo.SSI_ORDEN WHERE ord_numdocumento =RIGHT('" + booking + "',6)	AND YEAR(ORD_FECHAREG)=YEAR(GETDATE()) AND ord_flagEstado IS NULL" ;
           cmd.Connection = cn;
          
           string integral="";
           try
           { cn.Open();
                integral = cmd.ExecuteScalar().ToString();
              cn.Close();
           }
           catch (Exception ex)
           {

               Console.WriteLine(ex.Message);
           }
           return integral;
           
         
        }

        public static string IntegralImpo_APM(string blMaster)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            string integral ="";
            try
            {
                 cn = new SqlConnection(Conexion.Impo);
                 cmd = new SqlCommand();
                cmd.CommandText = "SELECT ORD_CODIGO from ssi_orden where  ORD_BL = '" + blMaster + "' AND YEAR(ORD_FECHAREG)=YEAR(GETDATE()) AND ord_flagEstado IS NULL";
                cmd.Connection = cn;
                cn.Open();
                 integral = cmd.ExecuteScalar().ToString();
                 
            }
            catch (Exception ex)
            {
                integral = "" ;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
              
           
            
            return integral;
        }

        public static DataTable Linea_Cliente(string CodIntegral)
        {
            SqlConnection cn = new SqlConnection(Conexion.Impo);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select c.NOMBRE,ORD_LINEA,(select desarm10 from dqarmado10 where codarm10 = ord_linea)'LINEA', desnav08,B.codnav08,numvia11 from ssi_orden A INNER JOIN DDCABMAN11 B ON B.NAVVIA11 = A.ORD_NAVVIA INNER JOIN AACLIENTESAA C ON C.CONTRIBUY = A.ORD_CLIENTE INNER JOIN DQNAVIER08 D ON D.CODNAV08=B.CODNAV08 where ord_codigo='"+CodIntegral+"'";
            cmd.Connection = cn;
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader()  ;
            DataTable dt = new DataTable();
            ;
            dt.Load(rd);
            cn.Close();
            return dt;
            }
    }
}
