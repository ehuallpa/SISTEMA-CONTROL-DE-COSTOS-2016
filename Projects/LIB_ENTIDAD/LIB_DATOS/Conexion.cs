using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace LIB_DATOS
{
    class Conexion
    {
        public static string Impo
        {
            get
            {
                return
        ConfigurationManager.ConnectionStrings["Impo"].
        ConnectionString;
            }
        }


    }
}
