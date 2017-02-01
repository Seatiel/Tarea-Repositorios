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

namespace TareaRegistros.UI.Registros
{
    public partial class rPeliculas : Form
    {
        public rPeliculas()
        {
            InitializeComponent();
        }

        public void LlenarCombo()
        {
            var lista = CategoriasBLL.GetList();
            if (lista.Count <= 0)
            {
                var categoria = new Categorias("Accion");
                var categoria1 = new Categorias("Terror");
                var categoria2 = new Categorias("Comedia");

                CategoriasBLL.Guardar(categoria);
                CategoriasBLL.Guardar(categoria1);
                CategoriasBLL.Guardar(categoria2);
            }
            CategoriascomboBox.DataSource = lista;
            CategoriascomboBox.ValueMember = "CategoriaId";
            CategoriascomboBox.DisplayMember = "Categoria";
        }

        private Peliculas LlenarCampos()
        {
            var peliculas = new Peliculas();
            peliculas.Estrenos = EstrenostextBox.Text;
            peliculas.Descripcion = DescripciontextBox.Text;
            peliculas.Categorias = CategoriascomboBox.Text;
            peliculas.Fecha = FechadateTimePicker.Value;
            return peliculas;
        }

        public void Limpiar()
        {
            PeliculasIdtextBox.Clear();
            EstrenostextBox.Clear();
            DescripciontextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;
            CategoriascomboBox.SelectedIndex = 0;            
        }

        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

        public bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(EstrenostextBox.Text))
            {
                EstrenoserrorProvider.SetError(EstrenostextBox, "Debe de ingresar el Estreno.");
                if (string.IsNullOrEmpty(DescripciontextBox.Text))
                {
                    DescripcionerrorProvider.SetError(DescripciontextBox, "Debe de ingresar una Descripcion.");
                }
                retorno = false;
            }
            return retorno;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = new Peliculas();
            pelicula = LlenarCampos();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if(PeliculasBLL.Guardar(pelicula))
            {
                MessageBox.Show("La pelicula se ha Guardado.");
            }
            Limpiar();
        }

        private void rPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = PeliculasBLL.Buscar(ToInt(PeliculasIdtextBox.Text));
            if (pelicula != null)
            {
                if (PeliculasBLL.Eliminar(pelicula))
                    MessageBox.Show("La pelicula ha sido eliminada");
            }
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PeliculasIdtextBox.Text);
            var pelicula = PeliculasBLL.Buscar(id);
            if (pelicula != null)
            {
                EstrenostextBox.Text = pelicula.Estrenos;
                DescripciontextBox.Text = pelicula.Descripcion;
                //FechadateTimePicker.MaxDate = pelicula.Fecha;             
            }
            else
            {
                MessageBox.Show("La pelicula no esta creada");
            }
        }
    }
}
