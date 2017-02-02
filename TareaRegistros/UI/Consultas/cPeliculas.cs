using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaRegistros.BLL;
using TareaRegistros.DAL;

namespace TareaRegistros.UI.Consultas
{
    public partial class cPeliculas : Form
    {
        public cPeliculas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            PeliculasdataGridView.DataSource = PeliculasBLL.GetList();
        }

        private void Filtarbutton_Click(object sender, EventArgs e)
        {
            var db = new RegistrosDb();

            if (DesdedateTimePicker.Value.Date < HastadateTimePicker.Value.Date)
            {
                PeliculasdataGridView.DataSource = PeliculasBLL.GetListFecha(DesdedateTimePicker.Value.Date, HastadateTimePicker.Value.Date);
            }
        }
    }
}
