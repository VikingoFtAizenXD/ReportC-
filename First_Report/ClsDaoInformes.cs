using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace First_Report
{
  public   class ClsDaoInformes
    {
      public static SqlDataAdapter Informes_Usuario()
      {
          SqlDataAdapter dta = null;
          SqlConnection ConexionBD = CONEXION.CONECTAR();
          try
          {
              ConexionBD.Open();
              SqlCommand cmd = new SqlCommand("SELECT Nombre,Telefono,Edad FROM Tbl_Usuario WHERE Usuario = 'Didier_Arias'", ConexionBD);
              dta = new SqlDataAdapter(cmd);
          }
          catch(Exception Ex)
          {
              MessageBox.Show(Ex.Message);
          }
          finally
          {
              ConexionBD.Close();
          }
          return dta;
      }
      public static SqlDataAdapter Informes_Evaluacion()
      {
          SqlDataAdapter dta = null;
          SqlConnection ConexionBD = CONEXION.CONECTAR();
          try
          {
              ConexionBD.Open();
              SqlCommand cmd = new SqlCommand("SELECT Pregunta,Respuesta,Descripcion,Curso FROM Tbl_Evaluacion WHERE Usuario = 'Didier_Arias'", ConexionBD);
              dta = new SqlDataAdapter(cmd);
          }
          catch(Exception Ex)
          {
              MessageBox.Show(Ex.Message);
          }
          finally
          {
              ConexionBD.Close();
          }
          return dta;
      }
    }
}
