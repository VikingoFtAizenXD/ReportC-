using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace First_Report
{
   public class CONEXION
    {
       public static SqlConnection CONECTAR()
       {
           SqlConnection ConexionBD = new SqlConnection("SERVER=.;DATABASE=Example; integrated security = true");
           return ConexionBD;
       }
    }
}
