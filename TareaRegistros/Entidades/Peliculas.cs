﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaRegistros.Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Estrenos { get; set; }
        public string Descripcion { get; set; }        
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }

        public virtual List<Categorias> Categorias { get; set; }
        public virtual List<PeliculasComentarios> Comentarios { get; set; }

        public Peliculas()
        {
            this.Categorias = new List<Entidades.Categorias>();
            this.Comentarios = new List<Entidades.PeliculasComentarios>();
        }

        public Peliculas(int peliculaId, string estrenos, string descripcion, DateTime fecha, int categoriaId)
        {
            this.PeliculaId = peliculaId;
            this.Estrenos = estrenos;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.CategoriaId = categoriaId;

            this.Categorias = new List<Entidades.Categorias>();
            this.Comentarios = new List<PeliculasComentarios>();
        }
    }
}
