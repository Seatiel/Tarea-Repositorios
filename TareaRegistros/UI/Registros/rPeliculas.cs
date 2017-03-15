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
using TareaRegistros.Entidades;

namespace TareaRegistros.UI.Registros
{
    public partial class rPeliculas : Form
    {
        Entidades.Peliculas pelicula;
        public rPeliculas()
        {
            InitializeComponent();
            Limpiar();
        }

        private void rPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            CategoriascomboBox.DataSource = CategoriasBLL.GetList();
            CategoriascomboBox.DisplayMember = "Categoria";
            CategoriascomboBox.ValueMember = "CategoriaId";

            UsuariocomboBox.DataSource = UsuariosBLL.GetList();
            UsuariocomboBox.DisplayMember = "NombreUsuario";
            UsuariocomboBox.ValueMember = "UsuarioId";

        }

        private Peliculas LlenarCampos()
        {
            string categorias = CategoriascomboBox.SelectedValue.ToString();

            pelicula.Estrenos = EstrenostextBox.Text;
            pelicula.Descripcion = DescripciontextBox.Text;
            pelicula.Fecha = FechadateTimePicker.Value;
            pelicula.CategoriaId = Utilitarios.ToInt(categorias);
            return pelicula;
        }
        private void LLenarGrid(Peliculas pelicula, bool soloCategorias)
        {
            //todo: optimizar este metodo ......
            if (soloCategorias)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pelicula.Categorias;
            }
            else
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = pelicula.Comentarios;
            }

        }

        public void Limpiar()
        {
            pelicula = new Peliculas();

            PeliculasIdtextBox.Clear();
            EstrenostextBox.Clear();
            DescripciontextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(EstrenostextBox.Text)) || (string.IsNullOrEmpty(DescripciontextBox.Text)))
            {
                EstrenoserrorProvider.SetError(EstrenostextBox, "Debe de ingresar el Estreno.");
                DescripcionerrorProvider.SetError(DescripciontextBox, "Debe de ingresar la Descripcion.");
                retorno = false;
            }
            return retorno;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            pelicula = LlenarCampos();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (PeliculasBLL.Guardar(pelicula))
            {
                MessageBox.Show("La pelicula se ha Guardado.");
            }
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = PeliculasBLL.Buscar(Utilitarios.ToInt(PeliculasIdtextBox.Text));
            if (pelicula != null)
            {
                if (PeliculasBLL.Eliminar(pelicula))
                    MessageBox.Show("La pelicula ha sido eliminada");
            }
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PeliculasIdtextBox.Text))
            {
                var pelicula = PeliculasBLL.Buscar(Utilitarios.ToInt(PeliculasIdtextBox.Text));
                if (pelicula != null)
                {
                    EstrenostextBox.Text = pelicula.Estrenos;
                    DescripciontextBox.Text = pelicula.Descripcion;
                    FechadateTimePicker.Value = pelicula.Fecha;
                    CategoriascomboBox.SelectedValue = pelicula.CategoriaId;

                    LLenarGrid(pelicula, true);
                    LLenarGrid(pelicula, false);

                }
                else
                {
                    MessageBox.Show("La pelicula no esta creada");
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            Categorias categoria = new Categorias();

            //BLL.CategoriasBLL.Buscar((int)CategoriascomboBox.SelectedValue)

            categoria = (Categorias)CategoriascomboBox.SelectedItem;

            pelicula.Categorias.Add(categoria);

            LLenarGrid(pelicula, true);
        }

        private void AgregarComentariosbutton_Click(object sender, EventArgs e)
        {
            PeliculasComentarios review = new PeliculasComentarios();

            review.Usuario = (Usuarios)UsuariocomboBox.SelectedItem;
            review.Comentario = ComentariotextBox.Text;

            pelicula.Comentarios.Add(review);

            LLenarGrid(pelicula, false);
        }
    }
}
