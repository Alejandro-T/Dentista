using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OracleClient;
namespace base_de_datos
{
    class conexion
    {
        public static OracleConnection conectar()
        {
            /*SqlConnection cn = new SqlConnection
                ("SERVER=LAPTOP-06K7LBH5\\SQLEXPRESS;DATABASE=Consultorio;integrated security=true");
            cn.Open();*/

            OracleConnection cn = new OracleConnection("DATA SOURCE = CONSULTORIO; PASSWORD=patito; USER ID = conex");
            return cn;
        }
    }
}
