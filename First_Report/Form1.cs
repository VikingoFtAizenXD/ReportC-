using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace First_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter datosUsuario = new SqlDataAdapter();
            SqlDataAdapter datosEvaluacion = new SqlDataAdapter();
            datosUsuario = ClsDaoInformes.Informes_Usuario();
            datosEvaluacion = ClsDaoInformes.Informes_Evaluacion();
            datosUsuario.Fill(Evalucion.Datos_Usuario);
            datosEvaluacion.Fill(Evalucion.Datos_Evaluacion);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}
