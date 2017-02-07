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
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        private Categorias LlenarCampos()
        {
            var categoria = new Categorias();
            categoria.Categoria = CategoriatextBox.Text;
            return categoria;
        }

        public void Limpiar()
        {
            CategoriaIdtextBox.Clear();
            CategoriatextBox.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(CategoriatextBox.Text))
            {
                CategoriaerrorProvider.SetError(CategoriatextBox, "Debe escribir la categoria.");
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var categoria = new Categorias();

            categoria = LlenarCampos();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los Campos.");
                return;
            }
            else if (CategoriasBLL.Guardar(categoria))
            {
                MessageBox.Show("Se ha guardado la Categoria.");
                Limpiar();
            }


            // Verificar si el id existë?
            //Modificamos
            //else
            //Insertamos


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var categoria = CategoriasBLL.Buscar(Utilitarios.ToInt(CategoriaIdtextBox.Text));

            if (categoria != null && CategoriasBLL.Eliminar(categoria))
            {
                MessageBox.Show("La categoria ha sido eliminada");

                Limpiar();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CategoriaIdtextBox.Text))
            {
                int id = Convert.ToInt32(CategoriaIdtextBox.Text);
                var categoria = CategoriasBLL.Buscar(id);
                if (categoria != null)
                {
                    CategoriatextBox.Text = categoria.Categoria;
                }
                else
                {
                    MessageBox.Show("La categoria no esta creado");
                }
            }
        }
       
       
       
    }
}
