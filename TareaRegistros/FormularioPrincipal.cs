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

        private void consultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cUsuarios cu = new UI.Consultas.cUsuarios();
            cu.Show();
        }

        private void consultaCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cCategorias cc = new UI.Consultas.cCategorias();
            cc.Show();
        }
    }
}
