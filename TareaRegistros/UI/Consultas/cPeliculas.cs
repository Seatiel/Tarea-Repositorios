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

        private void LlenarFiltro()
        {
            FiltrarcomboBox.Items.Insert(0, "ID");
            FiltrarcomboBox.Items.Insert(1, "Descripcion");          
            FiltrarcomboBox.Items.Insert(2, "Todo");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "ID";
        }

        private void BuscarSeleccion()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
                PeliculasdataGridView.DataSource = PeliculasBLL.GetListId(Utilitarios.ToInt(FiltrartextBox.Text));

            if (FiltrarcomboBox.SelectedIndex == 1)
                PeliculasdataGridView.DataSource = PeliculasBLL.GetListDescripcion(FiltrartextBox.Text);

            if (FiltrarcomboBox.SelectedIndex == 2)
                PeliculasdataGridView.DataSource = PeliculasBLL.GetList();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                BuscarSeleccion();
            }            
        }

        private bool Validar()
        {
            if (FiltrarcomboBox.Text != "Todo")
            {
                if (string.IsNullOrEmpty(FiltrartextBox.Text))
                {
                    BuscarerrorProvider.SetError(FiltrartextBox, "Ingresar el campo que desea filtar");
                    return false;
                }

                if (FiltrarcomboBox.SelectedIndex == 1 && PeliculasBLL.GetListDescripcion(FiltrartextBox.Text).Count == 0)
                {
                    MessageBox.Show("No hay registros que coincidan con este campo de filtro.");
                    return false;

                }
                if (FiltrarcomboBox.SelectedIndex == 0 && PeliculasBLL.GetListId(Utilitarios.ToInt(FiltrartextBox.Text)).Count == 0)
                {
                    MessageBox.Show("No hay registros que coincidan con este campo de filtro");
                    return false;
                }
            }
            BuscarerrorProvider.Clear();
            return true;
        }

        private void cPeliculas_Load(object sender, EventArgs e)
        {
            LlenarFiltro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DesdedateTimePicker.Value.Date < HastadateTimePicker.Value.Date)
            {
                PeliculasdataGridView.DataSource = 
                    PeliculasBLL.GetListFecha(
                        DesdedateTimePicker.Value.Date,
                    HastadateTimePicker.Value.Date);
            }
        }
    }
}
