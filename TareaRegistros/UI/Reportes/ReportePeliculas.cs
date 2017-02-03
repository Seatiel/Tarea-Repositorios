using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaRegistros.BLL;
using TareaRegistros.Entidades;

namespace TareaRegistros.UI.Reportes
{
    public partial class ReportePeliculas : Form
    {
        public ReportePeliculas()
        {
            InitializeComponent();
        }

        private void ReportePeliculas_Load(object sender, EventArgs e)
        {
            this.PeliculasreportViewer.RefreshReport();
            PeliculasreportViewer.Reset();
            PeliculasreportViewer.ProcessingMode = ProcessingMode.Local;
            PeliculasreportViewer.LocalReport.ReportPath = @"C:\Users\Seatiel\Desktop\Programacion Aplicada 1\Proyectos 2017\TareaRegistros\TareaRegistros\UI\Reportes\PeliculasReport.rdlc";
            ReportDataSource source = new ReportDataSource("PeliculasDataSet", PeliculasBLL.GetList());
            PeliculasreportViewer.LocalReport.DataSources.Add(source);
            this.PeliculasreportViewer.RefreshReport();
        }
    }
}
