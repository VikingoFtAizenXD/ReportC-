namespace First_Report
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Evalucion = new First_Report.Evalucion();
            this.Datos_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_EvaluacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Evalucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_EvaluacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Datos_UsuarioBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Datos_EvaluacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "First_Report.Repor_Evaluacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(666, 432);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Evalucion
            // 
            this.Evalucion.DataSetName = "Evalucion";
            this.Evalucion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Datos_UsuarioBindingSource
            // 
            this.Datos_UsuarioBindingSource.DataMember = "Datos_Usuario";
            this.Datos_UsuarioBindingSource.DataSource = this.Evalucion;
            // 
            // Datos_EvaluacionBindingSource
            // 
            this.Datos_EvaluacionBindingSource.DataMember = "Datos_Evaluacion";
            this.Datos_EvaluacionBindingSource.DataSource = this.Evalucion;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Evalucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_EvaluacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Datos_UsuarioBindingSource;
        private Evalucion Evalucion;
        private System.Windows.Forms.BindingSource Datos_EvaluacionBindingSource;
    }
}

