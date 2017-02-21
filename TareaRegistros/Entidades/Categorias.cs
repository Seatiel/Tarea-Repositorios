using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaRegistros.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public virtual  List<Peliculas> Peliculas { get; set; }

        public Categorias()
        {
            this.Peliculas = new List<Entidades.Peliculas>();
        }
        public Categorias(string categoria)
        {
            this.Categoria = categoria;
        }

        public Categorias(int categoriaId, string categoria)
        {
            this.CategoriaId = categoriaId;
            this.Categoria = categoria;
        }
    }
}
