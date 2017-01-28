using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TareaRegistros
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rUsuarios ru = new UI.Registros.rUsuarios();
            ru.Show();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rPeliculas rp = new UI.Registros.rPeliculas();
            rp.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rCategorias rc = new UI.Registros.rCategorias();
            rc.Show();
        }
    }
}
