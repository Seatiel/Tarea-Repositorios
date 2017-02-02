using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaRegistros.BLL;

namespace TareaRegistros.UI.Consultas
{
    public partial class cCategorias : Form
    {
        public cCategorias()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            CategoriasdataGridView.DataSource = CategoriasBLL.GetList();
        }
    }
}
